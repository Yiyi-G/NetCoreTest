using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet;
using Tgnet.Linq;

namespace Tgnet.FootChat.Push
{
    public interface IUserNotifyTypeProvider
    {
        Dictionary<NotifyTypes, long[]> GetNotifyTypes(long sender, long[] uids, long sessionId, string sessionType);
    }
    class UserNotifyTypeProvider : IUserNotifyTypeProvider
    {
        private readonly Tgnet.FootChat.Data.IRelationRepository _RelationRepository;
        private readonly Tgnet.FootChat.User.IUserSettingManager _UserSettingManager;

        public UserNotifyTypeProvider(
            Tgnet.FootChat.Data.IRelationRepository relationRepository, Tgnet.FootChat.User.IUserSettingManager userSettingManager)
        {
            _RelationRepository = relationRepository;
            _UserSettingManager = userSettingManager;
        }
        public Dictionary<NotifyTypes, long[]> GetNotifyTypes(long sender, long[] uids, long sessionId, string sessionType)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(sessionType, "sessionType");
            sessionType = sessionType.Trim();
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();

            if (uids.Length == 0)
                return new Dictionary<NotifyTypes, long[]>();
            var isSingle = true;

            if (sessionType.Equals(ActionType.SINGLE_MESSAGE.Action))
            {
                ExceptionHelper.ThrowIfNotId(sender, "sender");
                var exclude = _RelationRepository.Entities.Where(r => r.sender == sender && uids.Contains(r.receiver) && r.isNotNotiry).Select(r => r.receiver).ToArray();
                if (exclude.Length > 0)
                {
                    uids = uids.Except(exclude).ToArray();
                }
            }
            return new UserNotifySettingCollection(uids, _UserSettingManager.GetUserSettings(uids), isSingle)
                .UserNotifySettings
                .GroupBy(p => p.notifyType)
                .Select(p => new { NotifyType = p.Key, uids = p.Select(ps => ps.uid).ToArray() })
                .ToDictionary(p => p.NotifyType, p => p.uids);
        }
        public class UserNotifySettingCollection
        {
            private readonly long[] _Uids;
            private readonly IQueryable<Tgnet.FootChat.Data.UserSetting> _Settings;
            private readonly bool _Single;
            public UserNotifySettingCollection(long[] uids, IQueryable<Tgnet.FootChat.Data.UserSetting> settings, bool isSingle)
            {
                _Uids = uids;
                _Settings = settings;
                _Single = isSingle;
            }
            public UserNotifySetting[] UserNotifySettings
            {
                get
                {
                    var uids = (_Uids ?? Enumerable.Empty<long>()).Distinct().ToArray();
                    if (uids.Length == 0)
                    {
                        return Enumerable.Empty<UserNotifySetting>().ToArray();
                    }
                    var setting = _Settings.ToArray();
                    return _Uids.Select(id => new UserNotifySetting(id, setting.FirstOrDefault(s => s.uid == id), _Single)).ToArray();
                }
            }
        }

        public class UserNotifySetting
        {
            private long _Uid;
            private NotifyTypes _Type;
            public long uid
            {
                get
                {
                    return _Uid;
                }
            }

            public NotifyTypes notifyType
            {
                get
                {
                    return _Type;
                }
            }
            public UserNotifySetting() { }
            public UserNotifySetting(long uid, Tgnet.FootChat.Data.UserSetting setting, bool isSingle)
            {
                _Uid = uid;
                if (setting == null)
                {
                    setting = new FootChat.Data.UserSetting { isOpenNightQuiet = true, isOpenShake = true, isOpenVoice = true, isPushNotify = true };
                }
                if (setting.isOpenNightQuiet && (DateTime.Now.Hour > 22 || DateTime.Now.Hour < 8))
                {
                    _Type = NotifyTypes.Mute;
                }
                if (setting.isOpenVoice && setting.isOpenShake)
                {
                    _Type = NotifyTypes.SoundAndVibration;
                }
                else if (setting.isOpenVoice && !setting.isOpenShake)
                {
                    _Type = NotifyTypes.Sound;
                }
                else if (!setting.isOpenVoice && setting.isOpenShake)
                {
                    _Type = NotifyTypes.Vibration;
                }
                else
                {
                    _Type = NotifyTypes.Mute;
                }
            }
        }
    }
}
