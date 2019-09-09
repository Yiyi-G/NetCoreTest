using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.FCRMAPI;
using Tgnet.FootChat.Mobile;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.UserService;
using Tgnet.OAuth2.Common.Client;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.User
{
    public interface IUserManager
    {
        /// <summary>
        /// 验证码登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="code"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        AccessTokenResult VerificationCodeLogin(string username, string code, string ip);
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <param name="password"></param>
        /// <param name="ip"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        AccessTokenResult Register(string mobile, string code, string password, string ip, string from);
        /// <summary>
        /// 足聊后台添加用户
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <param name="password"></param>
        /// <param name="ip"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        long AddUserByFootChatAdmin(string mobile, string password, string ip, string from);
        /// <summary>
        /// 刷新token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        AccessTokenResult RefreshToken(string refreshToken, string ip);
        /// <summary>
        /// 判断该手机是否注册了足聊
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        bool CheckUserIsExist(string mobile);
        /// <summary>
        /// 通过uid获取用户
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        IQueryable<Data.FootUser> GetUsers(long[] uids);
        /// <summary>
        /// 通过手机号获取用户
        /// </summary>
        /// <param name="mobiles"></param>
        /// <returns></returns>
        IQueryable<FootUser> GetUsers(string[] mobiles);
        Dictionary<long, FootUser> GetUsersByUids(long[] uids);
        IQueryable<FootUser> SearchFootUser(SearchUserArgs args);
        long GetUserIdByUserName(string name);
        void ResetPassword(string usernaem, string oldPassword, string newPassword, string code, ValidateType codeType, string ip);
        /// <summary>
        /// 获取权限判断后的用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="uids"></param>
        /// <param name="addressFriends"></param>
        /// <returns></returns>
        ISimpleUserInfo[] GetUserInfos(IServiceStateService user, long[] uids, Dictionary<long, AddressBookFriend> addressFriends);

        Data.FootUser GetRandomUnverifiedFootUser();
        Data.FootUser GetFirstUnverifiedFootUser();
        int GetUnverifiedFootUserNum();
        /// <summary>
        /// 获取天工网的用户信息（通过手机号）
        /// </summary>
        /// <param name="mobiles"></param>
        /// <returns></returns>
        Tgnet.FootChat.UserService.UserSimpleInfo[] GetTgUserInfoByMobiles(IEnumerable<string> mobiles);
        /// <summary>
        /// 获取天工网的用户信息（通过uid）
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        Tgnet.FootChat.UserService.UserSimpleInfo[] GetTgUserInfos(IEnumerable<long> uids);
        IQueryable<Data.FootUser> GetEnableUser();
        StatisticalItem[] TodayUserStatisticalItem(DateTime? time);
        StatisticalItem[] ThisWeekUserStatisticalItem();
        StatisticalItem[] ThisMonthUserStatisticalItem();
        StatisticalItem[] ThisYearUserStatisticalItem();
        RangeStatistics RangeTimeUserStatisticalItem(DateTime? startTime, DateTime? endTime);
        FootUserStatistics GetFootUserStatistics(DateTime date);
        /// <summary>
        /// 获取用户过期时间
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        Dictionary<long, DateTime> GetUserExipired(long[] uids);
        int GetViewFootPrintCount(DateTime date);
        int GetTotalViewUserCount(DateTime date);
        /// <summary>
        /// 获取天工网用户业务地区（导入数据时用）
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        Dictionary<long, string[]> GetTgUserBusinessAreas(long[] uids);
        /// <summary>
        /// 获取天工网用户产品
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        Tgnet.FootChat.UserService.ProductEntity[] GetTgUserProducts(long uid);
        /// <summary>
        /// 获取足聊用户业务地区
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        string[] GetFootUserBusinessAreaNo(long[] uids);
        Dictionary<long, string[]> GetFootUserBusinessAreaNoDict(long[] uids);
        Dictionary<long, string> GetFootUserMobileDict(long[] uids);
        /// <summary>
        /// 获取权限判断后的足迹用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="fuidDic"></param>
        /// <param name="addressFriends"></param>
        /// <param name="dockFids"></param>
        /// <returns></returns>
        IFootPrintSimpleUserInfo[] GetFootPrintUserInfos(IServiceStateService user, Dictionary<long, long> fuidDic, Dictionary<long, AddressBookFriend> addressFriends, long[] dockFids);
        /// <summary>
        /// 获取用户名称
        /// </summary>
        /// <param name="uids"></param>
        /// <param name="addressFriends"></param>
        /// <returns></returns>
        Dictionary<long, string> GetUserNames(long[] uids, Dictionary<long, AddressBookFriend> addressFriends);

        IQueryable<FootUser> Entities();
        Dictionary<long, string[]> GetUserProducs(long[] uids);
    }
    public class UserManager : IUserManager
    {
        private readonly IFootChatUserRepository _UserRepository;
        private readonly ServiceAgent _OAuth2Service;
        private readonly IChannelProviderService<IUserManagerService> _UserManagerServiceChannelProvider;
        private readonly IChannelProviderService<IUserInfoService> _UserInfoServiceChannelProvider;
        private readonly IMobileManager _MobileManager;
        private readonly IStaticResourceManager _StaticResourceManager;
        private readonly IUserServiceStateRepository _UserServiceStateRepository;
        private readonly IRepository<Data.UserViewFootPrintRecord> _UserViewFootPrintRecordRepository;
        private readonly IRepository<Data.UserBusinessArea> _UserBusinessAreaRepository;
        private readonly IRepository<Data.ImportUserRecord> _ImportUserRecordRepository;
        private readonly IPushManager _PushManager;
        private readonly IRepository<Data.UserProduct> _UserProductRepository;

        public UserManager(IFootChatUserRepository userRepository,
            ServiceAgent oAuth2Service,
            IChannelProviderService<IUserManagerService> userManagerServiceChannelProvider,
            IChannelProviderService<IUserInfoService> userInfoServiceChannelProvider,
            IMobileManager mobileManager,
            IStaticResourceManager staticResourceManager,
            IUserServiceStateRepository userServiceStateRepository,
            IRepository<Data.UserViewFootPrintRecord> userViewFootPrintRecordRepository,
            IRepository<Data.UserBusinessArea> userBusinessAreaRepository,
            IPushManager pushManager,
            Tgnet.Data.IRepository<Data.ImportUserRecord> importUserRecordRepository,
            IRepository<Data.UserProduct> userProductRepository
            )
        {
            _UserRepository = userRepository;
            _OAuth2Service = oAuth2Service;
            _MobileManager = mobileManager;
            _UserInfoServiceChannelProvider = userInfoServiceChannelProvider;
            _UserManagerServiceChannelProvider = userManagerServiceChannelProvider;
            _StaticResourceManager = staticResourceManager;
            _UserServiceStateRepository = userServiceStateRepository;
            _UserViewFootPrintRecordRepository = userViewFootPrintRecordRepository;
            _UserBusinessAreaRepository = userBusinessAreaRepository;
            _PushManager = pushManager;
            _ImportUserRecordRepository = importUserRecordRepository;
            _UserProductRepository = userProductRepository;
        }

        public AccessTokenResult VerificationCodeLogin(string username, string code, string ip)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(username, "username", "用户名不能为空");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(code, "code", "验证码不能为空");

            var token = _OAuth2Service.GetAccessTokenByVerificationCode(Tgnet.Api.OAuth2Context.Current.ClientId, Tgnet.Api.OAuth2Context.Current.ClientSecret,
                username, code, String.Empty, String.Empty, ip);
            switch (token.error)
            {
                case ErrorResponseType.none:
                    var result = token.GetResult();
                    return result;
                case ErrorResponseType.username_non_existent:
                    throw new ExceptionWithErrorCode(ErrorCode.未找到该用户, token.error_description);
                case ErrorResponseType.invalid_verification_code:
                    throw new ExceptionWithErrorCode(ErrorCode.无效验证码);
                case ErrorResponseType.verification_code_expired:
                    throw new ExceptionWithErrorCode(ErrorCode.验证码已过期);
                case ErrorResponseType.invalid_grant:
                    throw new ExceptionWithErrorCode(ErrorCode.输入的数据格式错误, token.error_description);
                default:
                    if (token.error.ToString() == "username_locked")
                        throw new ExceptionWithErrorCode(ErrorCode.没有操作权限, "该账号已禁用");
                    throw new AuthorizationException("State:" + token.error.ToString() + ",Msg:" + token.error_description);
            }
        }

        
        public AccessTokenResult Register(string mobile, string code, string password, string ip, string from)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(from, "from", "注册来源不能为空");
            ExceptionHelper.ThrowIfTrue(!StringRule.VerifyPassword(password), "password", "密码格式错误");
            _MobileManager.Verify(code, mobile, ValidateType.登陆);
            var areaNo = "0001";
            var area = _StaticResourceManager.GetIPArea(ip);
            if (area != null)
                areaNo = area.area_no;
            long uid;
            using (var service = _UserManagerServiceChannelProvider.NewChannelProvider())
            {
                uid = service.Channel.GetUidIfNonexistentRegister(new OAuth2ClientIdentity(), mobile, true, password, ip, from);
            }
            ExceptionHelper.ThrowIfTrue(uid <= 0, "uid", "创建用户失败");
            var securityPsw = string.Empty;
            using (var provider = _UserManagerServiceChannelProvider.NewChannelProvider())
            {
                var id = Tgnet.Security.NumberConfuse.Confuse(uid);
                securityPsw = provider.Channel.GetPassword(new OAuth2ClientIdentity(), id);
            }
            if (!_UserRepository.Entities.Any(p => p.uid == uid))
            {
                _UserRepository.Add(new FootUser()
                {
                    mobile = mobile,
                    uid = uid,
                    password = securityPsw,
                    areaNo = areaNo,
                    isInner = false,
                    isLocked = false,
                    loginCount = 1,
                    lastLogin = DateTime.Now,


                    created = DateTime.Now,
                    verifyImage = String.Empty,
                    verifyStatus = VerifyStatus.None,
                    cover = "",
                });
                _UserRepository.SaveChanges();
                //推送到图数据库
                var taskFactory = new TaskFactory();
                taskFactory.StartNew(() =>
                {
                    _PushManager.AddUser(uid, mobile, false);
                });
            }
            return VerificationCodeLogin(mobile, code, ip);
        }

        public long AddUserByFootChatAdmin(string mobile, string password, string ip, string from)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(from, "from", "注册来源不能为空");
            ExceptionHelper.ThrowIfTrue(!StringRule.VerifyPassword(password), "password", "密码格式错误");
            var areaNo = "0001";
            var area = _StaticResourceManager.GetIPArea(ip);
            if (area != null)
                areaNo = area.area_no;
            long uid;
            using (var service = _UserManagerServiceChannelProvider.NewChannelProvider())
            {
                uid = service.Channel.GetUidIfNonexistentRegister(new OAuth2ClientIdentity(), mobile, true, password, ip, from);
            }
            ExceptionHelper.ThrowIfTrue(uid <= 0, "uid", "创建用户失败");
            var securityPsw = string.Empty;
            using (var provider = _UserManagerServiceChannelProvider.NewChannelProvider())
            {
                var id = Tgnet.Security.NumberConfuse.Confuse(uid);
                securityPsw = provider.Channel.GetPassword(new OAuth2ClientIdentity(), id);
            }
            if (!_UserRepository.Entities.Any(p => p.uid == uid))
            {
                _UserRepository.Add(new FootUser()
                {
                    mobile = mobile,
                    uid = uid,
                    password = securityPsw,
                    areaNo = areaNo,
                    isInner = false,
                    isLocked = false,
                    loginCount = 1,
                    lastLogin = DateTime.Now,
                    created = DateTime.Now,
                    verifyImage = String.Empty,
                    verifyStatus = VerifyStatus.None,
                    cover = "",
                });
                _UserRepository.SaveChanges();
                //推送到图数据库
                var taskFactory = new TaskFactory();
                taskFactory.StartNew(() =>
                {
                    _PushManager.AddUser(uid, mobile, false);
                });
            }
            else
            {
                throw new ExceptionWithErrorCode(ErrorCode.对应条目已存在, "该用户已经存在");
            }
            return uid;
        }

        public AccessTokenResult Login(string username, string password, string ip)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(username, "username", "用户名不能为空");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(password, "password", "密码不能为空");

            var token = _OAuth2Service.GetAccessTokenByPassword(Tgnet.Api.OAuth2Context.Current.ClientId, Tgnet.Api.OAuth2Context.Current.ClientSecret,
                username, password, String.Empty, String.Empty, ip);

            switch (token.error)
            {
                case ErrorResponseType.none:
                    var result = token.GetResult();
                    return result;
                case ErrorResponseType.invalid_grant:
                case ErrorResponseType.username_non_existent:
                    throw new ExceptionWithErrorCode(ErrorCode.帐号或密码不正确, token.error_description);
                case ErrorResponseType.username_locked:
                    throw new ExceptionWithErrorCode(ErrorCode.没有操作权限, "账号有异常，请联系客服");
                default:
                    if (token.error.ToString() == "username_locked")
                        throw new ExceptionWithErrorCode(ErrorCode.没有操作权限, "该账号已禁用");
                    throw new AuthorizationException("State:" + token.error.ToString() + ",Msg:" + token.error_description);
            }
        }
        public void ResetPassword(string usernaem, string oldPassword, string newPassword, string code, ValidateType codeType, string ip)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(usernaem, "username");
            ExceptionHelper.ThrowIfTrue(!StringRule.VerifyPassword(newPassword), "password", "密码长度必须介于6到20位之间");
            ExceptionHelper.ThrowIfTrue(string.IsNullOrWhiteSpace(oldPassword) && String.IsNullOrWhiteSpace(code), "旧密码和验证码不能同时为空");
            if (!String.IsNullOrWhiteSpace(code))
                _MobileManager.Verify(code, usernaem, codeType);
            var result = _OAuth2Service.ResetPassword(OAuth2Context.Current.ClientId, OAuth2Context.Current.ClientSecret, usernaem, oldPassword, newPassword, ip, null);
            switch (result.error)
            {
                case ErrorResponseType.none:
                    break;
                case ErrorResponseType.invalid_grant:
                case ErrorResponseType.invalid_request:
                    throw new ExceptionWithErrorCode(ErrorCode.帐号或密码不正确, result.error_description);
                case ErrorResponseType.username_non_existent:
                    throw new ExceptionWithErrorCode(ErrorCode.未找到该用户, result.error_description);
                case ErrorResponseType.server_error:
                    throw new ExceptionWithErrorCode(ErrorCode.服务器错误, result.error_description);
                default:
                    throw new AuthorizationException("State:" + result.error.ToString() + ",Msg:" + result.error_description);
            }
        }
        public bool CheckUserIsExist(string mobile)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, nameof(mobile));
            return _UserRepository.Entities.FirstOrDefault(p => p.mobile == mobile) != null;
        }



        public IQueryable<FootUser> GetUsers(long[] uids)
        {
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            if (uids.Length == 0)
                return Enumerable.Empty<Data.FootUser>().AsQueryable();
            return _UserRepository.Entities.Where(u => uids.Contains(u.uid));
        }
        public IQueryable<FootUser> GetUsers(string[] mobiles)
        {
            mobiles = (mobiles ?? Enumerable.Empty<string>()).Where(m => !String.IsNullOrWhiteSpace(m)).Distinct().ToArray();
            if (mobiles.Length == 0)
                return Enumerable.Empty<Data.FootUser>().AsQueryable();
            return _UserRepository.Entities.Where(u => mobiles.Contains(u.mobile));
        }
        public ISimpleUserInfo[] GetUserInfos(IServiceStateService user, long[] uids, Dictionary<long, AddressBookFriend> addressFriends)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (uids.Length == 0) return new SimpleUserInfo[0];
            IUserDisplayStrategy strategy;
            if (user != null)
            {
                strategy = new UserDisplayStrategy(user, addressFriends);
            }
            else
                strategy = new UserPreviewStrategy();
            var users = _UserRepository.GetUserInfo(uids);
            return GetDisplaySimpleUserInfo(users, strategy).ToArray();
        }

        public IFootPrintSimpleUserInfo[] GetFootPrintUserInfos(IServiceStateService user, Dictionary<long, long> fuidDic, Dictionary<long, AddressBookFriend> addressFriends, long[] dockFids)
        {
            ExceptionHelper.ThrowIfNull(fuidDic, nameof(fuidDic));
            var uids = fuidDic.Select(p => p.Value).Where(p => p > 0).Distinct().ToArray();
            dockFids = (dockFids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (uids.Length == 0) return new FootPrintSimpleUserInfo[0];
            IFootPrintUserDisplayStrategy strategy;
            if (user != null)
            {
                strategy = new FootPrintUserDisplayStrategy(user, addressFriends, dockFids);
            }
            else
                strategy = new FootPrintUserPreviewStrategy();
            var users = _UserRepository.GetUserInfo(uids);
            return GetDisplayFootPrintUserInfo(users, fuidDic, strategy).ToArray();
        }
        public Tgnet.FootChat.UserService.UserSimpleInfo[] GetTgUserInfoByMobiles(IEnumerable<string> mobiles)
        {
            if (mobiles == null) return new Tgnet.FootChat.UserService.UserSimpleInfo[0];
            mobiles = mobiles.Where(m => StringRule.VerifyMobile(m)).ToArray();
            if (mobiles.Count() == 0) return new Tgnet.FootChat.UserService.UserSimpleInfo[0];
            using (var provider = _UserInfoServiceChannelProvider.NewChannelProvider())
            {
                return provider.Channel.GetUsersSimpleInfoByMobiles(new OAuth2ClientIdentity(), mobiles.ToArray());
            }
        }
        public Tgnet.FootChat.UserService.UserSimpleInfo[] GetTgUserInfos(IEnumerable<long> uids)
        {
            if (uids == null) return new Tgnet.FootChat.UserService.UserSimpleInfo[0];
            uids = uids.Where(id => id > 0).ToArray();
            if (uids.Count() == 0) return new Tgnet.FootChat.UserService.UserSimpleInfo[0];
            using (var provider = _UserInfoServiceChannelProvider.NewChannelProvider())
            {
                return provider.Channel.GetUsersSimpleInfo(new OAuth2ClientIdentity(), uids.ToArray());
            }
        }

        private IEnumerable<IFootPrintSimpleUserInfo> GetDisplayFootPrintUserInfo(Models.SqlQueryModel.UserInfo[] users, Dictionary<long, long> fuidDic, IFootPrintUserDisplayStrategy strategy)
        {
            var kind = strategy.GetUserDisplayKind();
            var footUserInfos = new List<FootPrintSimpleUserInfo>();
            foreach (var fuidPair in fuidDic)
            {
                var fid = fuidPair.Key;
                var uid = fuidPair.Value;
                var userinfo = users.FirstOrDefault(p => p.uid == uid);
                if (userinfo != null)
                {
                    var footUserInfo = new FootPrintSimpleUserInfo();
                    footUserInfo.Fid = fid;
                    footUserInfo.Uid = uid;
                    footUserInfo.Kind = kind;
                    footUserInfo.IsSelf = strategy.CheckIsSelfInfo(uid);
                    footUserInfo.ForceShowName = strategy.GetIsForceShowName(uid, fid);
                    footUserInfo.ForceShowMobile = strategy.GetIsForceShowMobile(uid, fid);
                    footUserInfo.ForceHideMobile = strategy.GetIsForceHideMobile(uid, fid);
                    footUserInfo.Corver = userinfo.cover;
                    footUserInfo.Company = userinfo.company;
                    footUserInfo.Job = userinfo.job;
                    footUserInfo.Mobile = userinfo.mobile;
                    footUserInfo.UserName = strategy.GetUserName(uid, userinfo.name, userinfo.verifyStatus == VerifyStatus.Pass);
                    footUserInfo.Sex = userinfo.sex;
                    footUserInfo.VerifyState = VerifyStateConvert(userinfo);
                    footUserInfos.Add(footUserInfo);
                }
            }
            return footUserInfos.ToArray();
        }

        private IEnumerable<ISimpleUserInfo> GetDisplaySimpleUserInfo(Models.SqlQueryModel.UserInfo[] users, IUserDisplayStrategy strategy)
        {
            var kind = strategy.GetUserDisplayKind();
            foreach (var user in users)
            {
                var simpleUser = new SimpleUserInfo()
                {
                    Uid = user.uid,
                    Mobile = user.mobile,
                    UserName = strategy.GetUserName(user.uid, user.name, user.verifyStatus == VerifyStatus.Pass),
                    Sex = user.sex,
                    Kind = kind,
                    Job = user.job,
                    Corver = user.cover,
                    Company = user.company,
                    IsSelf = strategy.CheckIsSelfInfo(user.uid),
                    VerifyState = VerifyStateConvert(user),
                    ForceShowMobile = strategy.GetIsForceShowMobile(user.uid),
                    ForceShowName = strategy.GetIsForceShowName(user.uid),
                };
                yield return simpleUser;
            }
        }

        private VerifyState VerifyStateConvert(Models.SqlQueryModel.UserInfo user)
        {
            var state = VerifyState.None;
            if (user != null)
            {
                switch (user.verifyStatus)
                {
                    case VerifyStatus.None:
                        if (user.submiVerifytDate.HasValue && user.isNeedVerify)
                            state = VerifyState.Verifying;
                        break;
                    case VerifyStatus.Pass:
                        state = VerifyState.Pass;
                        break;
                    case VerifyStatus.Unpass:
                        state = VerifyState.Unpass;
                        break;
                }
            }
            return state;
        }
        public AccessTokenResult RefreshToken(string refreshToken, string ip)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(refreshToken, "refreshToken");
            var result = _OAuth2Service.RefreshToken(OAuth2Context.Current.ClientId, refreshToken, ip);

            switch (result.error)
            {
                case ErrorResponseType.none:
                    var token = result.GetResult();
                    return token;
                case ErrorResponseType.invalid_request:
                case ErrorResponseType.invalid_scope:
                    throw new ExceptionWithErrorCode(ErrorCode.输入的数据格式错误, result.error_description);
                case ErrorResponseType.access_denied:
                case ErrorResponseType.unauthorized_client:
                case ErrorResponseType.invalid_client:
                    throw new ExceptionWithErrorCode(ErrorCode.没有操作权限, result.error_description);
                case ErrorResponseType.invalid_grant:
                    throw new ExceptionWithErrorCode(ErrorCode.刷新令牌已失效, result.error_description);
                case ErrorResponseType.unsupported_response_type:
                case ErrorResponseType.unsupported_grant_type:
                    throw new ExceptionWithErrorCode(ErrorCode.非法的操作, result.error_description);
                case ErrorResponseType.username_non_existent:
                    throw new ExceptionWithErrorCode(ErrorCode.未找到该用户, result.error_description);
                default:
                    if (result.error.ToString() == "username_locked")
                        throw new ExceptionWithErrorCode(ErrorCode.没有操作权限, "该账号已禁用");
                    throw new AuthorizationException("State:" + result.error.ToString() + ",Msg:" + result.error_description);
            }
        }

        public Dictionary<long, FootUser> GetUsersByUids(long[] uids)
        {
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            var result = new Dictionary<long, FootUser>();
            if (uids.Length <= 0) return result;
            var source = _UserRepository.Entities.AsNoTracking().Where(u => uids.Contains(u.uid));
            result = source.GroupBy(p => p.uid).ToDictionary(p => p.Key, p => p.FirstOrDefault());
            return result;
        }

        public long GetUserIdByUserName(string name)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(name, nameof(name));
            var user = _UserRepository.Entities.AsNoTracking().Where(p => p.name == name).FirstOrDefault();
            var uid = user != null ? user.uid : 0;
            return uid;
        }


        public IQueryable<FootUser> SearchFootUser(SearchUserArgs args)
        {
            args.VerifySearchUserArgs();//搜索条件数据验证
            var source = _UserRepository.Entities.AsNoTracking().Where(p => p.isInner == args.isInner.Value);//足聊用户信息源
            if (args.uid.HasValue)//用户id搜索条件
            {
                source = source.Where(p => p.uid == args.uid.Value);
            }
            if (!string.IsNullOrWhiteSpace(args.mobile))//用户电话号码搜索条件
            {
                //source = source.Where(p => p.mobile == args.mobile);
                source = source.Where(p => p.mobile.StartsWith(args.mobile.Trim()));
            }
            if (!string.IsNullOrWhiteSpace(args.startTime))//注册时间范围的开始时间
            {
                var minTime = args.startTime.To<DateTime>();
                source = source.Where(p => p.created >= minTime.Date);
            }
            if (!string.IsNullOrWhiteSpace(args.endTime))//注册时间范围的结束时间
            {
                var maxTime = args.endTime.To<DateTime>().Date.AddDays(1);
                source = source.Where(p => p.created < maxTime);
            }
            if (!string.IsNullOrWhiteSpace(args.userName))//用户名搜索条件
            {
                //source = source.Where(p => p.name == args.userName);
                source = source.Where(p => p.name.StartsWith(args.userName.Trim()));
            }
            return source;
        }

        public Data.FootUser GetRandomUnverifiedFootUser()
        {
            var result = new Data.FootUser();
            var source = _UserRepository.Entities.AsNoTracking().Where(p => p.isInner == false && p.verifyStatus == VerifyStatus.None && p.submiVerifytDate.HasValue);
            if (source.Any())
            {
                var uids = source.Select(p => p.uid).ToArray();
                var Seed = Guid.NewGuid().GetHashCode();
                var random = new Random(Seed);
                int index = random.Next(0, uids.Length); //生成随机下标
                var uid = uids[index];
                result = source.FirstOrDefault(p => p.uid == uid);
            }
            else
            {
                result = null;
            }
            return result;
        }

        public Data.FootUser GetFirstUnverifiedFootUser()
        {
            var minTime = "1900-01-01".To<DateTime>();
            //先判断有没有超时未完成的审核进行解锁（超过半个小时没有操作的）
            _UserRepository.Update(p => p.isVerifiedLocked && System.Data.Entity.DbFunctions.DiffMinutes(p.verifiedlockDate, DateTime.Now) > 30, p => new FootUser { isVerifiedLocked = false, verifiedlockDate = minTime });

            //再拿出第一条未审核未锁定的
            var source = _UserRepository.Entities.AsNoTracking().Where(p => p.isInner == false && p.verifyStatus != VerifyStatus.Unpass && p.isNeedVerify
              && p.submiVerifytDate.HasValue && p.isVerifiedLocked == false).OrderBy(p => p.created).FirstOrDefault();

            if (source != null)
            {
                //锁定
                _UserRepository.Update(p => p.uid == source.uid, p => new FootUser { isVerifiedLocked = true, verifiedlockDate = DateTime.Now });
            }
            return source;
        }

        public int GetUnverifiedFootUserNum()
        {
            return _UserRepository.Entities.AsNoTracking().Where(p => p.isInner == false && p.verifyStatus == VerifyStatus.None && p.submiVerifytDate.HasValue).Count();
        }

        public IQueryable<FootUser> GetEnableUser()
        {
            return _UserRepository.Entities.AsNoTracking().Where(p => p.isLocked == false);
        }

        public StatisticalItem[] TodayUserStatisticalItem(DateTime? time)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var perHourRegisterNum = _UserRepository.GetTodayPerHourRegisterNum(time);//今天24小时注册用户数                     
            var perHourVerifiedNum = _UserRepository.GetTodayPerHourVerifiedNum(time);//今天24小时认证用户数
            var perHourPaidUserNum = _UserServiceStateRepository.GetTodayPerHourPaidUserNum(time);//今天24小时付费用户数
            var result = GetUserStatisticalItem(perHourRegisterNum, perHourVerifiedNum, perHourPaidUserNum);
            return result;
        }

        public StatisticalItem[] ThisWeekUserStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisWeekRegisterNum = _UserRepository.GetThisWeekRegisterNum();
            var thisWeekVerifiedUserNum = _UserRepository.GetThisWeekVerifiedUserNum();
            var thisWeekPaidUserNum = _UserServiceStateRepository.GetThisWeekPaidUserNum();
            var result = GetUserStatisticalItem(thisWeekRegisterNum, thisWeekVerifiedUserNum, thisWeekPaidUserNum);
            return result;
        }

        public StatisticalItem[] ThisMonthUserStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisMontRegisterNum = _UserRepository.GetThisMontRegisterNum();
            var thisMonthVerifiedUserNum = _UserRepository.GetThisMonthVerifiedUserNum();
            var thisMontPaidUserNum = _UserServiceStateRepository.GetThisMontPaidUserNum();
            var result = GetUserStatisticalItem(thisMontRegisterNum, thisMonthVerifiedUserNum, thisMontPaidUserNum);
            return result;
        }

        public StatisticalItem[] ThisYearUserStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisYearRegisterNu = _UserRepository.GetThisYearRegisterNum();
            var thisYearVerifiedUserNum = _UserRepository.GetThisYearVerifiedUserNum();
            var thisYearPaidUserNum = _UserServiceStateRepository.GetThisYearPaidUserNum();
            var result = GetUserStatisticalItem(thisYearRegisterNu, thisYearVerifiedUserNum, thisYearPaidUserNum);
            return result;
        }

        private StatisticalItem[] GetRangeTimeUserStatisticalItem(DateTime startTime, DateTime endTime)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var rangeTimeRegisterNum = _UserRepository.GetRangeTimeRegisterNum(startTime, endTime);
            var rangeTimeVerifiedUserNum = _UserRepository.GetRangeTimeVerifiedUserNum(startTime, endTime);
            var rangeTimePaidUserNum = _UserServiceStateRepository.GetRangeTimePaidUserNum(startTime, endTime);
            var result = GetUserStatisticalItem(rangeTimeRegisterNum, rangeTimeVerifiedUserNum, rangeTimePaidUserNum);
            return result;
        }

        public RangeStatistics RangeTimeUserStatisticalItem(DateTime? startTime, DateTime? endTime)
        {
            var result = new RangeStatistics();
            if (startTime.HasValue && endTime.HasValue)
            {
                var minTime = startTime.Value;
                var maxTime = endTime.Value;
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "时间范围", "开始日期不能大于结束日期");
                var ts = maxTime - minTime;
                ExceptionHelper.ThrowIfTrue(ts.Days > 31, "时间范围", "时间区间不得超过31天");
                if (minTime.Date == maxTime.Date)
                {
                    //用24小时的
                    var date = minTime.Date;
                    result.item = TodayUserStatisticalItem(date);
                    result.type = "24hour";
                }
                else
                {
                    //循环跨度遍历时间
                    //用天
                    result.item = GetRangeTimeUserStatisticalItem(minTime, maxTime);
                    result.type = "range";
                }
            }
            if (startTime.HasValue && !endTime.HasValue)
            {
                var date = startTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayUserStatisticalItem(date);
                result.type = "24hour";
            }
            if (!startTime.HasValue && endTime.HasValue)
            {
                var date = endTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayUserStatisticalItem(date);
                result.type = "24hour";
            }
            return result;
        }

        private StatisticalItem[] GetUserStatisticalItem(Dictionary<int, int> registerNumDict, Dictionary<int, int> verifiedNumDict, Dictionary<int, int> paidUserNumDict)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var registerItem = new StatisticalItem { Name = "注册用户", NumDict = registerNumDict };
            var verifiedItem = new StatisticalItem { Name = "认证用户", NumDict = verifiedNumDict };
            var paidItem = new StatisticalItem { Name = "付费用户", NumDict = paidUserNumDict };
            item.Add(registerItem);
            item.Add(verifiedItem);
            item.Add(paidItem);
            return item.ToArray();
        }

        public FootUserStatistics GetFootUserStatistics(DateTime date)
        {
            return _UserRepository.GetFootUserStatistics(date);
        }

        public int GetViewFootPrintCount(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            return _UserViewFootPrintRecordRepository.Entities.AsNoTracking().Where(p => p.updated < endTime).Select(p => p.count).DefaultIfEmpty().Sum();
        }

        public int GetTotalViewUserCount(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            return _UserViewFootPrintRecordRepository.Entities.AsNoTracking().Where(p => p.updated < endTime).Select(p => p.uid).Distinct().Count();
        }

        public Dictionary<long, DateTime> GetUserExipired(long[] uids)
        {
            return _UserServiceStateRepository.GetUserExipired(uids);
        }

        public Dictionary<long, string[]> GetTgUserBusinessAreas(long[] uids)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (!uids.Any()) return new Dictionary<long, string[]>();
            using (var provider = _UserInfoServiceChannelProvider.NewChannelProvider())
            {
                return provider.Channel.GetUserBusinessAreas(new OAuth2ClientIdentity(), uids);
            }
        }

        public Tgnet.FootChat.UserService.ProductEntity[] GetTgUserProducts(long uid)
        {
            using (var provider = _UserManagerServiceChannelProvider.NewChannelProvider())
            {
                return provider.Channel.GetNewProducts(new OAuth2ClientIdentity(), uid);
            }
        }

        public string[] GetFootUserBusinessAreaNo(long[] uids)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (!uids.Any()) return new string[0];
            var result = _UserBusinessAreaRepository.Entities.AsNoTracking().Where(p => uids.Contains(p.uid)).Select(p => p.areaNo).Distinct().ToArray();
            return result;
        }

        public Dictionary<long, string[]> GetFootUserBusinessAreaNoDict(long[] uids)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (!uids.Any()) return new Dictionary<long, string[]>();
            var result = _UserBusinessAreaRepository.Entities.AsNoTracking().Where(p => uids.Contains(p.uid))
                .GroupBy(p => p.uid).ToDictionary(p => p.Key, p => p.Select(d => d.areaNo).ToArray());
            return result;
        }

        public Dictionary<long, string> GetFootUserMobileDict(long[] uids)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (!uids.Any()) return new Dictionary<long, string>();
            var result = _UserRepository.Entities.AsNoTracking().Where(p => uids.Contains(p.uid)).GroupBy(p => p.uid).ToDictionary(p => p.Key, p => p.FirstOrDefault().mobile);
            return result;
        }

        public Dictionary<long, string> GetUserNames(long[] uids, Dictionary<long, AddressBookFriend> addressFriends)
        {
            addressFriends = addressFriends ?? new Dictionary<long, AddressBookFriend>();
            var users = _UserRepository.GetUserInfo(uids);
            var userNames = new Dictionary<long, string>();

            foreach (var user in users)
            {
                var uid = user.uid;
                var name = user.name;
                //未认证用优先选择通讯录名称
                if (user.verifyStatus != VerifyStatus.Pass && addressFriends.ContainsKey(uid))
                {
                    var addressFriend = addressFriends[uid];
                    if (addressFriend != null && !string.IsNullOrWhiteSpace(addressFriend.Name))
                        name = addressFriend.Name;
                }
                userNames.Add(uid, name);
            }
            return userNames;
        }
        public IQueryable<FootUser> Entities()
        {
            return _UserRepository.Entities.AsNoTracking();
        }

        public Dictionary<long, string[]> GetUserProducs(long[] uids)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (!uids.Any()) return new Dictionary<long, string[]>();
            var source = from up in _UserProductRepository.Entities
                         where uids.Contains(up.uid)
                         select new
                         {
                             up.uid,
                             up.name
                         };
            return source.ToArray().GroupBy(p => p.uid).ToDictionary(p => p.Key, p => p.Select(n => n.name).ToArray());
        }
    }

    public class SearchUserArgs
    {
        public void VerifySearchUserArgs()
        {
            if (!string.IsNullOrWhiteSpace(startTime) && !string.IsNullOrWhiteSpace(endTime))
            {
                var minTime = startTime.To<DateTime>();
                var maxTime = endTime.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "时间范围", "开始日期不能大于结束日期");
                var ts = minTime - maxTime;
                ExceptionHelper.ThrowIfTrue(ts.Days > 365, "时间范围", "时间区间不得超过1年");
            }
        }

        public SearchUserArgs()
        {
            isInner = false;
        }

        public long? uid { get; set; }
        public string mobile { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string userName { get; set; }
        public bool? isInner { get; set; }
    }
}
