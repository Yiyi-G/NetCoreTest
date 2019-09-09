using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.User
{
    public interface IUserSettingManager
    {
        IUserSettingService GetUserSettingService(IUserService user);
        IQueryable<UserSetting> GetUserSettings(params long[] uids);
    }
    class UserSettingManager : IUserSettingManager
    {
        private readonly IUserSettingRepository _UserSettingRepository;
        public UserSettingManager(IUserSettingRepository userSettingRepository)
        {
            _UserSettingRepository = userSettingRepository;
        }

        public IQueryable<UserSetting> GetUserSettings(params long[] uids)
        {
            return _UserSettingRepository.Entities.Where(p => uids.Contains(p.uid));
        }

        public IUserSettingService GetUserSettingService(IUserService user)
        {
            return new UserSettingService(_UserSettingRepository, user);
        }
    }
    public interface IUserSettingService
    {
        long Uid { get; }
        bool IsOpenVoice { get; }
        bool IsOpenShake { get; }
        bool IsOpenNightQuiet { get; }
        bool IsPushNotify { get; }
        DateTime SettingTime { get; }
        void UpdateUserSetting(bool? isOpenVoice, bool? isOpenShake, bool? isOpenNightQuiet, bool? isPushNotify, bool? isOpenAddressBook);
    }
    class UserSettingService : IUserSettingService
    {
        private readonly IUserSettingRepository _UserSettingRepository;
        private readonly IUserService _UserService;
        private readonly Lazy<UserSetting> _LazyUserSetting;

        #region 
        public long Uid
        {
            get
            {
                return _UserService.Uid;

            }
        }

        public bool IsOpenVoice
        {
            get
            {
                if (_LazyUserSetting != null && _LazyUserSetting.Value != null) return _LazyUserSetting.Value.isOpenVoice;
                return true;
            }
        }
        

        public bool IsOpenShake
        {
            get
            {
                if (_LazyUserSetting != null && _LazyUserSetting.Value != null) return _LazyUserSetting.Value.isOpenShake;
                return true;
            }
        }
        public bool IsOpenNightQuiet
        {
            get
            {
                if (_LazyUserSetting != null && _LazyUserSetting.Value != null) return _LazyUserSetting.Value.isOpenNightQuiet;
                return true;
            }
        }

        public bool IsPushNotify
        {
            get
            {
                if (_LazyUserSetting != null && _LazyUserSetting.Value != null) return _LazyUserSetting.Value.isPushNotify;
                return true;
            }
        }

        public DateTime SettingTime
        {
            get
            {
                if (_LazyUserSetting != null && _LazyUserSetting.Value != null) return _LazyUserSetting.Value.settingTime;
                return DateTime.Now;
            }
        }
        #endregion

        public UserSettingService(IUserSettingRepository userSettingRepository, IUserService userService)
        {
            ExceptionHelper.ThrowIfTrue(userService == null, "userService", "用户uid不能为空");
            ExceptionHelper.ThrowIfNotId(userService.Uid, "uid", "用户uid不能为空");
            _UserSettingRepository = userSettingRepository;
            _UserService = userService;
            _LazyUserSetting = new Lazy<UserSetting>(() =>
            {
                return _UserSettingRepository.Entities.Where(p => p.uid == _UserService.Uid).FirstOrDefault();
            });

        }

        public void UpdateUserSetting(bool? isOpenVoice, bool? isOpenShake, bool? isOpenNightQuiet, bool? isPushNotify, bool? isOpenAddressBook)
        {
            if (_LazyUserSetting == null || _LazyUserSetting.Value == null)
                CreateUserSetting(isOpenVoice, isOpenShake, isOpenNightQuiet, isPushNotify);
            else
            {
                if (isOpenVoice != null)
                    _LazyUserSetting.Value.isOpenVoice = isOpenVoice.Value;
                if (isOpenShake != null)
                    _LazyUserSetting.Value.isOpenShake = isOpenShake.Value;
                if (isOpenNightQuiet != null)
                    _LazyUserSetting.Value.isOpenNightQuiet = isOpenNightQuiet.Value;
                if (isPushNotify != null)
                    _LazyUserSetting.Value.isPushNotify = isPushNotify.Value;
                _UserSettingRepository.SaveChanges();
            }
        }

        private UserSetting CreateUserSetting(bool? isOpenVoice, bool? isOpenShake, bool? isOpenNightQuiet, bool? isPushNotify)
        {
            UserSetting userSetting = new UserSetting()
            {
                uid = _UserService.Uid,
                isOpenVoice = isOpenVoice ?? true,
                isOpenShake = isOpenShake ?? true,
                isOpenNightQuiet = isOpenNightQuiet ?? true,
                isPushNotify = isPushNotify ?? true,
                settingTime = DateTime.Now
            };
            _UserSettingRepository.Add(userSetting);
            _UserSettingRepository.SaveChanges();
            return userSetting;
        }
    }
}
