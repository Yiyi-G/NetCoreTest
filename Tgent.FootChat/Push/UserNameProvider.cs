using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Mobile;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Push
{
    public interface IUserNameProviderFactory
    {
        IUserNameProvider CreateProvider(long uid);
    }

    class UserNameProviderFactory : IUserNameProviderFactory
    {
        private readonly IUserManager _UserManager;
        private readonly Tgnet.FootChat.Data.IRelationRepository _RelationRepository;
        private readonly Tgnet.FootChat.User.IUserSettingManager _UserSettingManager;
        private readonly IUserServiceFactory _UserServiceFactory;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;

        public UserNameProviderFactory(
            IUserManager userManager,
            Tgnet.FootChat.Data.IRelationRepository relationRepository,
            Tgnet.FootChat.User.IUserSettingManager userSettingManager,
            IUserServiceFactory userServiceFactory,
            IAddressBookMobileRepository addressBookMobileRepository
            )
        {
            _UserManager = userManager;
            _RelationRepository = relationRepository;
            _UserSettingManager = userSettingManager;
            _UserServiceFactory = userServiceFactory;
            _AddressBookMobileRepository = addressBookMobileRepository;
        }

        public IUserNameProvider CreateProvider(long uid)
        {
            return new UserNameProvider(uid, _UserManager, _RelationRepository, _UserSettingManager,_UserServiceFactory,_AddressBookMobileRepository);
        }
    }

    public enum NameKind
    {
        Name = 0,
        Nick = 1,
    }

    public class UserName
    {
        public string Name { get; private set; }
        public NameKind Kind { get; private set; }

        public UserName(string name, NameKind kind)
        {
            Name = name;
            Kind = kind;
        }
    }

    public interface IUserNameProvider
    {
        /// <summary>
        /// 自己的名称
        /// </summary>
        /// <returns></returns>
        string Nick(long receiver);
        /// <summary>
        /// 对于参数用户id的昵称
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        Dictionary<long, UserName> NickForUsers(IEnumerable<long> uids);
        Dictionary<long, UserName> UserNicks(IEnumerable<long> uids);
        long[] GetNotifyUsers(long[] uids, long sessionId, string sessionType);
    }

    class UserNameProvider : IUserNameProvider
    {
        private readonly IUserManager _UserManager;
        private readonly Tgnet.FootChat.Data.IRelationRepository _RelationRepository;
        private readonly Tgnet.FootChat.User.IUserSettingManager _UserSettingManager;
        private readonly IUserServiceFactory _UserServiceFactory;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly long _Uid;

        public UserNameProvider(long uid,
            IUserManager userManager,
            Tgnet.FootChat.Data.IRelationRepository relationRepository,
            Tgnet.FootChat.User.IUserSettingManager userSettingManager,
            IUserServiceFactory userServiceFactory,
            IAddressBookMobileRepository addressBookMobileRepository)
        {
            _Uid = uid;
            _UserManager = userManager;
            _RelationRepository = relationRepository;
            _UserSettingManager = userSettingManager;
            _UserServiceFactory = userServiceFactory;
            _AddressBookMobileRepository = addressBookMobileRepository;

        }

        public string Nick(long receiver)
        {
            return _UserManager.GetUsers(new[] { _Uid }).Select(i => i.name).FirstOrDefault();
        }

        public Dictionary<long, UserName> NickForUsers(IEnumerable<long> uids)
        {
            var result = new Dictionary<long, UserName>();
            if (uids == null) return result;
            var ids = uids.Where(id => id > 0).Distinct().ToArray();
            if (ids.Length == 0) return result;
            var names = new Dictionary<long, string>();
            if (_Uid > 0)
            {
                var user = _UserServiceFactory.GetService(_Uid);
                var userService = user.GetUserSeriviceState();
                var myInfoInOtherAddressBook =GetMyInfoFromOrtherAddressBook(user,ids);
                names = GetMyNameToUser(user,ids, myInfoInOtherAddressBook);
            }
            foreach (var item in ids)
            {
                result.Add(item, new UserName(names.ContainsKey(item) ? names[item] : String.Empty, NameKind.Name));
            }
            return result;
        }
        /// <summary>
        /// 返回用户通讯录里对应我的信息
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        private Dictionary<long, FootChat.Models.AddressBookFriend> GetMyInfoFromOrtherAddressBook(IUserService user, long[] uids)
        {
            uids = uids ?? Enumerable.Empty<long>().Where(id => id > 0).Distinct().ToArray();
            if (uids.Length == 0)
                return new Dictionary<long, FootChat.Models.AddressBookFriend>();
            var myMobile = user.Mobile;
            var myInfos = _AddressBookMobileRepository.Entities.Where(p => p.mobile == myMobile && uids.Contains(p.uid))
                .GroupBy(p => p.uid)
                .ToDictionary(p => p.Key, p => p.Select(m => new FootChat.Models.AddressBookFriend
                {
                    Name = m.name,
                    Mobile = m.mobile
                }).FirstOrDefault());
            return myInfos;
        }
        private Dictionary<long, string> GetMyNameToUser(IUserService user, long[] uids, Dictionary<long, AddressBookFriend> addressFriends)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (uids.Length == 0) return new Dictionary<long, string>();
            var strategy = new MyDisplayStrategy(user.GetUserSeriviceState(), addressFriends);
            return GetDisplayMyNameToUser(user, uids, strategy);
        }
        private Dictionary<long, string> GetDisplayMyNameToUser(IUserService user, long[] uids, IUserDisplayStrategy strategy)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (uids.Length == 0) return new Dictionary<long, string>();
            var kind = strategy.GetUserDisplayKind();
            var result = new Dictionary<long, string>();
            var simpleUser = new Model.SimpleUserInfo()
            {
                Sex = user.Sex,
                Kind = kind,
            };
            foreach (var uid in uids)
            {
                simpleUser.UserName = strategy.GetUserName(uid, null, false);
                simpleUser.ForceShowMobile = strategy.GetIsForceShowMobile(uid);
                simpleUser.ForceShowName = strategy.GetIsForceShowName(uid);
                result.Add(uid, simpleUser.UserName);
            }
            return result;
        }

        public long[] GetNotifyUsers(long[] uids, long sessionId, string sessionType)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(sessionType, "sessionType");
            sessionType = sessionType.Trim();
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            if (uids.Length == 0)
                return uids;
            if (sessionType.Equals(ActionType.SINGLE_MESSAGE.Action))
                return _RelationRepository.Entities.Where(r => r.receiver == _Uid && uids.Contains(r.sender) && !r.isNotNotiry).Select(r => r.sender).ToArray();
            return uids;
        }
        
        public Dictionary<long, UserName> UserNicks(IEnumerable<long> uids)
        {
            var result = new Dictionary<long, UserName>();
            if (uids == null) return result;
            var ids = uids.Where(id => id > 0).Distinct().ToArray();
            if (ids.Length == 0) return result;
            var infos = _UserManager.GetUsers(ids);
            var nicks = _RelationRepository.Entities.Where(r => r.sender == _Uid && !String.IsNullOrEmpty(r.remark) && uids.Contains(r.receiver)).ToDictionary(r => r.receiver, r => r.remark) ?? new Dictionary<long, string>();
            foreach (var item in infos)
            {
                result.Add(item.uid, new UserName(nicks.ContainsKey(item.uid) ? nicks[item.uid] : item.name, NameKind.Name));
            }
            return result;
        }
    }
}
