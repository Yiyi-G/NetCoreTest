using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.FCRMAPI;
using Tgnet.FootChat.FCRMAPI.Models;
using Tgnet.FootChat.File;
using Tgnet.FootChat.FootPrint;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.Models.SqlQueryModel;
using Tgnet.FootChat.Push;
using Tgnet.FootChat.Trade;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.User
{
    public interface IUserServiceFactory
    {
        IUserService GetService(long uid);
    }
    public class UserServiceFactory : IUserServiceFactory
    {
        private readonly IFootChatUserRepository _UserRepository;
        private readonly IUserServiceStateRepository _UserServiceStateRepository;
        private readonly IRepository<UserBusinessArea> _UserBusinessAreaRepository;
        private readonly IRepository<UserProduct> _UserProductRepository;
        private readonly IRepository<UserBrand> _UserBrandRepository;
        private readonly IChannelProviderService<Tgnet.FootChat.UserService.IUserManagerService> _UserManagerServiceChannelProvider;
        private readonly IRepository<Data.UserLoginRecord> _UserLoginRecordRepository;
        private readonly IFileManager _FileManager;
        private readonly IUserFavoriteRepository _UserFavoriteRepository;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IRelationRepository _RelationRepository;
        private readonly IRepository<Data.Trade> _TradeRepository;
        private readonly IRepository<Data.UserServiceStateUpdateRecord> _UserServiceStateUpdateRecordRepository;
        private readonly ICallRecordRepository _CallRecordRepository;
        private readonly IRepository<Data.UserViewFootPrintRecord> _UserViewFootPrintRecordRepository;
        private readonly IMessageService _MessageService;
        private readonly IRepository<Data.UserComplain> _UserComplainRepository;
        private readonly FCRMAPI.IPushManager _FCRMAPIPushManager;
        private readonly ISearchManager _SearchManager;
        private readonly IChannelProviderService<VerifyService.IVerifyService> _VerifyServiceProvider;
        private readonly IDockedRecordRepository _DockedRecordRepository;
        public UserServiceFactory(
            IFootChatUserRepository userRepository,
            IUserServiceStateRepository userServiceStateRepository,
            IRepository<UserBusinessArea> userBusinessAreaRepository,
             IRepository<UserProduct> userProductRepository,
            IRepository<UserBrand> userBrandRepository,
            IChannelProviderService<Tgnet.FootChat.UserService.IUserManagerService> userManagerServiceChannelProvider,
            IRepository<Data.UserLoginRecord> userLoginRecordRepository,
            IFileManager fileManager,
            IUserFavoriteRepository userFavoriteRepository,
            IFootPrintRepository footPrintRepository,
            IAddressBookMobileRepository addressBookMobileRepository,
            IRelationRepository relationRepository,
            IRepository<Data.Trade> tradeRepository,
            IRepository<Data.UserServiceStateUpdateRecord> userServiceStateUpdateRecordRepository,
            ICallRecordRepository callRecordRepository,
            IRepository<Data.UserViewFootPrintRecord> userViewFootPrintRecordRepository,
            IMessageService messageService,
            IRepository<Data.UserComplain> userComplainRepository,
            FCRMAPI.IPushManager fCRMAPIpushManager,
            ISearchManager searchManager,
            IChannelProviderService<VerifyService.IVerifyService> verifyServiceProvider,
            IDockedRecordRepository dockedRecordRepository
            )
        {
            _UserRepository = userRepository;
            _UserServiceStateRepository = userServiceStateRepository;
            _UserBusinessAreaRepository = userBusinessAreaRepository;
            _UserProductRepository = userProductRepository;
            _UserBrandRepository = userBrandRepository;
            _UserLoginRecordRepository = userLoginRecordRepository;
            _UserManagerServiceChannelProvider = userManagerServiceChannelProvider;
            _FileManager = fileManager;
            _UserFavoriteRepository = userFavoriteRepository;
            _FootPrintRepository = footPrintRepository;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _RelationRepository = relationRepository;
            _TradeRepository = tradeRepository;
            _UserServiceStateUpdateRecordRepository = userServiceStateUpdateRecordRepository;
            _CallRecordRepository = callRecordRepository;
            _UserViewFootPrintRecordRepository = userViewFootPrintRecordRepository;
            _MessageService = messageService;
            _UserComplainRepository = userComplainRepository;
            _FCRMAPIPushManager = fCRMAPIpushManager;
            _SearchManager = searchManager;
            _VerifyServiceProvider = verifyServiceProvider;
            _DockedRecordRepository = dockedRecordRepository;

        }
        public IUserService GetService(long uid)
        {
            return new UserService(uid, _UserRepository, _UserServiceStateRepository,
                _UserBusinessAreaRepository, _UserProductRepository, _UserBrandRepository,
               _UserManagerServiceChannelProvider, _UserLoginRecordRepository, _FileManager,
               _UserFavoriteRepository, _FootPrintRepository,_AddressBookMobileRepository,
               _RelationRepository, _TradeRepository,_UserServiceStateUpdateRecordRepository, 
               _CallRecordRepository, _UserViewFootPrintRecordRepository, _MessageService, 
               _UserComplainRepository, _FCRMAPIPushManager, _SearchManager,_VerifyServiceProvider, _DockedRecordRepository);
        }
    }
    public interface IUserService
    {
        #region 属性
        long Uid { get; }
        string UserFacePath { get; }
        string UserFacePathSmall { get; }
        string Name { get; }
        string Mobile { get; }
        UserSex? Sex { get; }
        string Company { get; }
        string Job { get; }
        string VerifyImage { get; }
        bool IsLocked { get; }
        DateTime? SubmiVerifytDate { get; }
        VerifyStatus VerifyStatus { get; }
        IQueryable<Data.UserFavorite> UserFavorite { get; }
        string AreaNo { get; }
        DateTime Created { get; }
        DateTime LastLogin { get; }
        DateTime? LockDate { get; }
        long? LockOperator { get; }
        string LockReason { get; }
        bool IsNeedVerify { get; }
        string Cover { get; }
        VerifyState VerifyState { get; }
        bool IsVerified { get; }
        #endregion

        /// <summary>
        /// 获取用户服务类
        /// </summary>
        /// <returns></returns>
        IServiceStateService GetUserSeriviceState();
        /// <summary>
        /// 更新个人基本信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns>是否有更新</returns>
        bool UpdateInfo(UpdateUserInfoModel model);
        void UpdateMobile(string mobile);
        void UpdateBusinessAreaNos(string[] names);
        void UpdateProducts(string[] names);
        void UpdateBrands(string[] areaNos);
        void VerifiedLock();
        void VerifiedUnLock();
        void VerifyUser(VerifyStatus status, long @operator, string reason, out bool isOpenTrail);
        UserFaceUrls UploadFace(string fid);
        void SetLoginRecord(string ip);
        bool CheckUserIsCompeleteBaseInfo(Models.User.CheckInfoCondiction condiction);
        string[] GetBusinessAreaNos();
        string[] GetProductNames();
        string[] GetBrandNames();
        void SubmitVerifyRequest();
        void FavoriteProj(long[] pids, bool isFavorite);
        Dictionary<long, bool> GetUserFavorites(long[] pids);
        void Lock(long operatorId, string reason);
        void UnLock();
        int GetUserFootPrintNum();
        int GetUserViewFootPrintCount();
        int GetUserCallTimes();
        IQueryable<Data.Trade> GetUserTrade();
        void AddCallRecord(long uid);
        void AddViewFootPrintRecord(long fid);
        void AddViewFootPrintRecord(long[] fids);
        void UpdateUserCover(string fid);
        int GetUserFavoProjNum();
        int GetMessageCount(Range<DateTime> range = null);
        Dictionary<long, bool> GetUserFootChatPermission(long[] uids, out Tgnet.FootChat.Data.AddressBookMobile[] addressBooks);
        UserFriendCountModel GetUserFriendCount();
        void AddSuggestFeekback(string content);
        PageModel<Models.SqlQueryModel.ProjFavorite> GetUserFavoriteProjs(int start, int limit);
        UserDockedNum GetUserDockedNum();
    }
    public class UserService : IUserService
    {
        private readonly long _Uid;
        private readonly Lazy<Data.FootUser> _LazyValue;
        private readonly IFootChatUserRepository _UserRepository;
        private readonly IUserServiceStateRepository _UserServiceStateRepository;
        private readonly IRepository<UserBusinessArea> _UserBusinessAreaRepository;
        private readonly IRepository<UserProduct> _UserProductRepository;
        private readonly IRepository<UserBrand> _UserBrandRepository;
        private readonly IChannelProviderService<Tgnet.FootChat.UserService.IUserManagerService> _UserManagerServiceChannelProvider;
        private readonly IRepository<Data.UserLoginRecord> _UserLoginRecordRepository;
        private readonly IFileManager _FileManager;
        private readonly IUserFavoriteRepository _UserFavoriteRepository;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IRelationRepository _RelationRepository;
        private readonly IRepository<Data.Trade> _TradeRepository;
        private readonly IRepository<Data.UserServiceStateUpdateRecord> _UserServiceStateUpdateRecordRepository;
        private readonly ICallRecordRepository _CallRecordRepository;
        private readonly IRepository<Data.UserViewFootPrintRecord> _UserViewFootPrintRecordRepository;
        private readonly IMessageService _MessageService;
        private readonly IRepository<Data.UserComplain> _UserComplainRepository;
        private readonly FCRMAPI.IPushManager _FCRMAPIPushManager;
        private readonly ISearchManager _SearchManager;
        private readonly IChannelProviderService<VerifyService.IVerifyService> _VerifyServiceProvider;
        private readonly IDockedRecordRepository _DockedRecordRepository;
        public UserService(long uid,
            IFootChatUserRepository userRepository,
            IUserServiceStateRepository userServiceStateRepository,
            IRepository<UserBusinessArea> userBusinessAreaRepository,
             IRepository<UserProduct> userProductRepository,
            IRepository<UserBrand> userBrandRepository,
            IChannelProviderService<Tgnet.FootChat.UserService.IUserManagerService> userManagerServiceChannelProvider,
            IRepository<Data.UserLoginRecord> userLoginRecordRepository,
            IFileManager fileManager,
            IUserFavoriteRepository userFavoriteRepository,
            IFootPrintRepository footPrintRepository,
            IAddressBookMobileRepository addressBookMobileRepository,
            IRelationRepository relationRepository,
            IRepository<Data.Trade> tradeRepository,
            IRepository<Data.UserServiceStateUpdateRecord> userServiceStateUpdateRecordRepository,
            ICallRecordRepository callRecordRepository,
            IRepository<Data.UserViewFootPrintRecord> userViewFootPrintRecordRepository,
            IMessageService messageService,
            IRepository<Data.UserComplain> userComplainRepository,
            FCRMAPI.IPushManager fCRMAPIpushManager,
            ISearchManager searchManager,
            IChannelProviderService<VerifyService.IVerifyService> verifyServiceProvider,
            IDockedRecordRepository dockedRecordRepository
            )
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            _Uid = uid;
            _UserRepository = userRepository;
            _UserServiceStateRepository = userServiceStateRepository;
            _UserBusinessAreaRepository = userBusinessAreaRepository;
            _UserProductRepository = userProductRepository;
            _UserBrandRepository = userBrandRepository;
            _UserManagerServiceChannelProvider = userManagerServiceChannelProvider;
            _UserLoginRecordRepository = userLoginRecordRepository;
            _FileManager = fileManager;
            _UserFavoriteRepository = userFavoriteRepository;
            _FootPrintRepository = footPrintRepository;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _RelationRepository = relationRepository;
            _TradeRepository = tradeRepository;
            _UserServiceStateUpdateRecordRepository = userServiceStateUpdateRecordRepository;
            _CallRecordRepository = callRecordRepository;
            _UserViewFootPrintRecordRepository = userViewFootPrintRecordRepository;
            _MessageService = messageService;
            _UserComplainRepository = userComplainRepository;
            _FCRMAPIPushManager = fCRMAPIpushManager;
            _SearchManager = searchManager;
            _VerifyServiceProvider = verifyServiceProvider;
            _DockedRecordRepository = dockedRecordRepository;

            _LazyValue = new Lazy<FootUser>(() =>
            {
                var entity = _UserRepository.Entities.FirstOrDefault(p => p.uid == _Uid);
                if (entity == null)
                    throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目);
                return entity;
            });
        }

        #region 属性
        public long Uid
        {
            get
            {
                return _LazyValue.Value.uid;
            }
        }

        public string UserFacePath
        {
            get
            {
                return _LazyValue.Value.userFacePah;
            }
        }

        public string UserFacePathSmall
        {
            get
            {
                return _LazyValue.Value.userFacePathSmall;
            }
        }

        public string Name
        {
            get
            {
                return _LazyValue.Value.name;
            }
        }

        public string Mobile
        {
            get
            {
                return _LazyValue.Value.mobile;
            }
        }

        public UserSex? Sex
        {
            get
            {
                return _LazyValue.Value.sex;
            }
        }

        public string Company
        {
            get
            {
                return _LazyValue.Value.company;
            }
        }

        public string Job
        {
            get
            {
                return _LazyValue.Value.job;
            }
        }

        public string VerifyImage
        {
            get
            {
                return _LazyValue.Value.verifyImage;
            }
        }

        public bool IsLocked
        {
            get
            {
                return _LazyValue.Value.isLocked;
            }
        }

        public DateTime? SubmiVerifytDate
        {
            get
            {
                return _LazyValue.Value.submiVerifytDate;
            }
        }

        public VerifyStatus VerifyStatus
        {
            get
            {
                return _LazyValue.Value.verifyStatus;
            }
        }

        public IQueryable<UserFavorite> UserFavorite
        {
            get
            {
                return _UserFavoriteRepository.Entities.Where(p => p.uid == _Uid && p.isEnabled);
            }
        }

        public string AreaNo
        {
            get
            {
                return _LazyValue.Value.areaNo;
            }
        }

        public DateTime Created
        {
            get
            {
                return _LazyValue.Value.created;
            }
        }

        public DateTime LastLogin
        {
            get
            {
                return _LazyValue.Value.lastLogin;
            }
        }

        public VerifyStatus UserVerifyStatus
        {
            get
            {
                return _LazyValue.Value.verifyStatus;
            }
        }

        public DateTime? LockDate
        {
            get
            {
                return _LazyValue.Value.lockDate;
            }
        }

        public long? LockOperator
        {
            get
            {
                return _LazyValue.Value.lockOperator;
            }
        }

        public string LockReason
        {
            get
            {
                return _LazyValue.Value.lockReason;
            }
        }

        public bool IsNeedVerify
        {
            get
            {
                return _LazyValue.Value.isNeedVerify;
            }
        }

        public string Cover
        {
            get
            {
                return _LazyValue.Value.cover;
            }
        }

        private VerifyState? _State;
        public VerifyState VerifyState
        {
            get
            {
                if (_State == null)
                {
                    _State = VerifyState.None;
                    switch (VerifyStatus)
                    {
                        case VerifyStatus.None:
                            if (SubmiVerifytDate.HasValue && IsNeedVerify)
                                _State = VerifyState.Verifying;
                            break;
                        case VerifyStatus.Pass:
                            _State = VerifyState.Pass;
                            break;
                        case VerifyStatus.Unpass:
                            _State = VerifyState.Unpass;
                            break;
                    }
                }
                return _State.Value;
            }
        }


        public bool IsVerified
        {
            get
            {
                var isVerified = _LazyValue.Value.verifyDate.HasValue;
                if (isVerified)
                {
                    if (_LazyValue.Value.isNeedVerify)
                    {
                        isVerified = false;
                    }
                }
                return isVerified;
            }           
        }

        #endregion

        public IServiceStateService GetUserSeriviceState()
        {
            return new ServiceStateService(this, _UserServiceStateRepository, _TradeRepository, _UserServiceStateUpdateRecordRepository);
        }

        public bool UpdateInfo(UpdateUserInfoModel model)
        {
            ExceptionHelper.ThrowIfNull(model, nameof(model));
            bool isUpdate = false;
            if (!string.IsNullOrWhiteSpace(model.Name))
            {
                _LazyValue.Value.name = model.Name;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.AreaNo))
            {
                _LazyValue.Value.areaNo = model.AreaNo;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.Company))
            {
                _LazyValue.Value.company = model.Company;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.Job))
            {
                _LazyValue.Value.job = model.Job;
                isUpdate = true;
            }
            if (model.Sex.HasValue)
            {
                _LazyValue.Value.sex = model.Sex.Value;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.VerifyImage))
            {
                _LazyValue.Value.verifyImage = model.VerifyImage;
                isUpdate = true;
            }
            if (isUpdate)
            {
                if (_LazyValue.Value.verifyStatus == VerifyStatus.Pass)
                    _LazyValue.Value.isNeedVerify = true;
                _UserRepository.SaveChanges();
            }
            return isUpdate;
        }

        public void UpdateBusinessAreaNos(string[] areaNos)
        {
            areaNos = (areaNos ?? new string[0]).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct().Select(p => p.Trim()).ToArray();
            if (!areaNos.Any()) return;
            var now = DateTime.Now;
            _UserBusinessAreaRepository.AddAndDeleteExcept(p => p.uid == _Uid,
                areaNos,
                (u, v) => u.areaNo == v,
                (u, v) => { },
                u =>
                {
                    return true;
                },
                v => new UserBusinessArea()
                {
                    areaNo = v,
                    created = now,
                    uid = _Uid
                });
        }

        //审核认证资料时锁定
        public void VerifiedLock()
        {
            _LazyValue.Value.isVerifiedLocked = true;
            _LazyValue.Value.verifiedlockDate = DateTime.Now;
            _UserRepository.SaveChanges();
        }

        //审核完认证资料时解锁
        public void VerifiedUnLock()
        {
            var minTime = "1900-01-01".To<DateTime>();
            _LazyValue.Value.isVerifiedLocked = false;
            _LazyValue.Value.verifiedlockDate = minTime;
            _UserRepository.SaveChanges();
        }

        public void VerifiedAutoUnLock()
        {

        }

        public Dictionary<long,bool> GetUserFootChatPermission(long[] uids, out Tgnet.FootChat.Data.AddressBookMobile[] addressBooks)
        {
            Dictionary<long, bool> result = new Dictionary<long, bool>();
            addressBooks = Enumerable.Empty<Tgnet.FootChat.Data.AddressBookMobile>().ToArray();
           var relations = Enumerable.Empty<Tgnet.FootChat.Data.Relation>().ToArray();
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            if (uids.Length==0)
            {
                return result;
            }
            addressBooks = _AddressBookMobileRepository.Entities.Where(a => a.uid == Uid && a.tguid != null && uids.Contains(a.tguid.Value)).ToArray();
            foreach(var a in addressBooks)
            {
                result.Add(a.tguid.Value, true);
            }
            uids = uids.Except(result.Select(r => r.Key)).ToArray();
            if (uids.Length>0)
            {
                relations = _RelationRepository.ConnectionAndBeApplys.Where(r => r.sender == Uid && uids.Contains(r.receiver)).ToArray() ;
            }
            foreach(var r in relations)
            {
                result.Add(r.receiver, true);
            }
            uids = uids.Except(result.Select(r => r.Key)).ToArray();
            foreach(var id in uids)
            {
                result.Add(id, false);
            }
            return result;
        }

        public void VerifyUser(VerifyStatus status, long @operator, string reason,out bool isOpenTrail)
        {
            isOpenTrail = false;
            ExceptionHelper.ThrowIfNotId(@operator, nameof(@operator));
            ExceptionHelper.ThrowIfTrue(status == VerifyStatus.Unpass && string.IsNullOrWhiteSpace(reason), "请输入认证失败原因");
            using (var scope = new TransactionScope())
            {
                _LazyValue.Value.verifyDate = DateTime.Now;
                var userServiceState = GetUserSeriviceState();
                if (UserVerifyStatus == VerifyStatus.None || UserVerifyStatus == VerifyStatus.Unpass)//用户认证状态为未认证 或者 审核不通过情况下
                {
                    if (userServiceState.UserLevel == UserServiceLevel.Normal && status == VerifyStatus.Pass)//用户等级为普通会员 并且 当前操作为审核通过
                    {
                        userServiceState.OpenTrail(7);//增加7天试用期
                        isOpenTrail = true;
                    }
                }
                _LazyValue.Value.verifyStatus = status;
                if (status == VerifyStatus.Unpass)
                {
                    _LazyValue.Value.isNeedVerify = true;
                }
                else
                {
                    _LazyValue.Value.isNeedVerify = false;
                }
                _LazyValue.Value.verifyUser = @operator;
                if (status == VerifyStatus.Unpass && !string.IsNullOrWhiteSpace(reason))
                    _LazyValue.Value.verifyFailReason = reason;
                _UserRepository.SaveChanges();
                scope.Complete();
            }

        }

        public UserFaceUrls UploadFace(string fid)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(fid, nameof(fid));
            var path = string.Format("FootUserFaces/{0}", _Uid);
            var virtualName = _FileManager.SaveTempFile(path, _Uid, fid);
            string bigFilePath;
            string smalFilePath;
            bigFilePath = virtualName + "@120w_120h";
            smalFilePath = virtualName + "@50w_50h";
            _LazyValue.Value.userFacePah = bigFilePath;
            _LazyValue.Value.userFacePathSmall = smalFilePath;
            _UserRepository.SaveChanges();
            return new UserFaceUrls()
            {
                BigVirtualPath = bigFilePath,
                SmallVirtualPath = smalFilePath
            };
        }

        public void SetLoginRecord(string ip)
        {
            var now = DateTime.Now;
            using (var scope = new TransactionScope())
            {
                _UserLoginRecordRepository.Add(new UserLoginRecord()
                {
                    ip = ip,
                    loginTime = now,
                    uid = _Uid,
                });
                _UserLoginRecordRepository.SaveChanges();
                _LazyValue.Value.lastLogin = now;
                _LazyValue.Value.loginCount = _LazyValue.Value.loginCount + 1;
                _UserRepository.SaveChanges();
                scope.Complete();
            }
        }

        public void UpdateMobile(string mobile)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, nameof(mobile));
            ExceptionHelper.ThrowIfTrue(!StringRule.VerifyMobile(mobile), "手机号不符合格式");
            if (mobile != _LazyValue.Value.mobile)
            {
                using (var scope = new TransactionScope())
                {
                    var isExist = _UserRepository.Entities.FirstOrDefault(p => p.mobile == mobile) != null;
                    if (isExist)
                        throw new ExceptionWithErrorCode(ErrorCode.该手机号码已被注册);
                    _LazyValue.Value.mobile = mobile;
                    _UserRepository.SaveChanges();
                    scope.Complete();
                }
                //推送到图数据库
                var taskFactory = new TaskFactory();
                taskFactory.StartNew(() =>
                {
                    _FCRMAPIPushManager.UpdateFootUserMobile(_Uid, mobile, false);
                });
            }
        }

        public bool CheckUserIsCompeleteBaseInfo(Models.User.CheckInfoCondiction condiction)
        {
            condiction = condiction ?? new Models.User.CheckInfoCondiction();
            if (condiction.checkName && string.IsNullOrWhiteSpace(_LazyValue.Value.name))
                return false;
            if (condiction.checkSex && !_LazyValue.Value.sex.HasValue)
                return false;
            if (condiction.checkCompany && string.IsNullOrWhiteSpace(_LazyValue.Value.company))
                return false;
            if (condiction.checkBusniessArea && !_UserBusinessAreaRepository.Entities.Any(p => p.uid == _Uid))
                return false;
            if (condiction.checkProduct && !_UserProductRepository.Entities.Any(p => p.uid == _Uid &&p.name!=null&&p.name!=""))
                return false;
            return true;
        }

        public void UpdateProducts(string[] names)
        {
            names = (names ?? new string[0]).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct().Select(p => p.Trim()).ToArray();
            if (!names.Any()) return;
            var now = DateTime.Now;
            _UserProductRepository.AddAndDeleteExcept(p => p.uid == _Uid,
                names,
                (u, v) => u.name == v,
                (u, v) =>
                {
                    u.updated = now;
                },
                u =>
                {
                    return true;
                },
                v => new UserProduct()
                {
                    name = v,
                    updated = now,
                    uid = _Uid
                });
        }

        public void UpdateBrands(string[] names)
        {
            names = (names ?? new string[0]).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct().Select(p => p.Trim()).ToArray();
            if (!names.Any()) return;
            var now = DateTime.Now;
            _UserBrandRepository.AddAndDeleteExcept(p => p.uid == _Uid,
                names,
                (u, v) => u.name == v,
                (u, v) =>
                {
                    u.updated = now;
                },
                u =>
                {
                    return true;
                },
                v => new UserBrand()
                {
                    name = v,
                    updated = now,
                    uid = _Uid
                });
        }

        public string[] GetBusinessAreaNos()
        {
            return _UserBusinessAreaRepository.Entities.Where(p => p.uid == _Uid).Select(p => p.areaNo).ToArray();
        }

        public string[] GetProductNames()
        {
            return _UserProductRepository.Entities.Where(p => p.uid == _Uid).Select(p => p.name).ToArray();
        }

        public string[] GetBrandNames()
        {
            return _UserBrandRepository.Entities.Where(p => p.uid == _Uid).Select(p => p.name).ToArray();
        }

        public void SubmitVerifyRequest()
        {
            _LazyValue.Value.submiVerifytDate = DateTime.Now;
            _LazyValue.Value.isNeedVerify = true;
            if (_LazyValue.Value.verifyStatus != VerifyStatus.Pass)
            {
                _LazyValue.Value.verifyStatus = VerifyStatus.None;
            }
            _UserRepository.SaveChanges();
        }

        public void FavoriteProj(long[] pids, bool isFavorite)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return;
            var now = DateTime.Now;
            _UserFavoriteRepository.AddAndDeleteExcept(p => p.uid == _Uid,
                pids,
                (u, v) => u.pid == v,
                (u, v) =>
                {
                    u.isEnabled = isFavorite;
                    u.Updated = now;
                },
                u => { return false; },
                v => new UserFavorite()
                {
                    isEnabled = isFavorite,
                    pid = v,
                    uid = _Uid,
                    Updated = now
                });
            
        }

        public void FavoriteProj(long pid, bool isFavorite)
        {
            ExceptionHelper.ThrowIfTrue(pid<=0, nameof(pid));
            using (var scope = new TransactionScope())
            {
                var entity = _UserFavoriteRepository.Entities.Where(p => p.uid == _Uid && p.pid == pid).FirstOrDefault();
                var now = DateTime.Now;
                if (entity == null)
                {
                    if (isFavorite)
                    {
                        entity = _UserFavoriteRepository.Add(new Data.UserFavorite()
                        {
                            pid = pid,
                            uid = _Uid,
                            isEnabled = true,
                            Updated = now
                        });
                        _FCRMAPIPushManager.CollectProj(_Uid, pid, 20, true);
                    }
                }
                else
                {
                    entity.isEnabled = isFavorite;
                    entity.Updated = now;
                    if (isFavorite)
                        _FCRMAPIPushManager.CollectProj(_Uid, pid, 0, true);
                    else
                        _FCRMAPIPushManager.CancelCollectProj(_Uid, pid, 0, true);
                }
                _UserFavoriteRepository.SaveChanges();
                scope.Complete();
            }
            
               
        }

        public Dictionary<long, bool> GetUserFavorites(long[] pids)
        {
            return _UserFavoriteRepository.GetUserFavorites(_Uid, pids);
        }

        public void Lock(long operatorId, string reason)
        {
            ExceptionHelper.ThrowIfNotId(operatorId, nameof(operatorId));
            ExceptionHelper.ThrowIfNullOrWhiteSpace(reason, nameof(reason));
            if (IsLocked == false)
            {
                _LazyValue.Value.isLocked = true;
                _LazyValue.Value.lockOperator = operatorId;
                _LazyValue.Value.lockReason = reason;
                _LazyValue.Value.lockDate = DateTime.Now;
                _UserRepository.SaveChanges();
            }
            ClearToken(_Uid);

        }
        private void ClearToken(long uid)
        {
            try
            {
                ExceptionHelper.ThrowIfNotId(uid, "uid");
                using (var service = _VerifyServiceProvider.NewChannelProvider())
                {
                    service.Channel.ClearToken(new Api.OAuth2ClientIdentity(), Api.IdentityType.FootChat, uid);
                    Tgnet.Log.LoggerResolver.Current.Debug("clear Token");
                }
            }
            catch (System.Exception ex)
            {
                Tgnet.Log.LoggerResolver.Current.Error("清除token出错：",ex);
                Tgnet.Log.LoggerResolver.Current.Debug("清除token出错：", ex);
            }

        }


            public void UnLock()
        {
            if (IsLocked == true)
            {
                _LazyValue.Value.isLocked = false;
                _LazyValue.Value.lockOperator = null;
                _LazyValue.Value.lockReason = null;
                _LazyValue.Value.lockDate = null;
                _UserRepository.SaveChanges();
            }
        }


        public int GetUserFootPrintNum()
        {
            return _FootPrintRepository.Entities.AsNoTracking().Where(p => p.uid == Uid && p.state == FootPrintState.Pass && p.isEnable).Count();
        }

        public int GetUserViewFootPrintCount()
        {
            return _UserViewFootPrintRecordRepository.Entities.AsNoTracking().Where(p => p.uid == Uid).Select(p => p.count).DefaultIfEmpty().Sum();
        }

        public int GetUserCallTimes()
        {
            return _CallRecordRepository.Entities.AsNoTracking().Where(p => p.caller == Uid).Count();
        }

        public IQueryable<Data.Trade> GetUserTrade()
        {
            return _TradeRepository.Entities.Where(p => p.uid == Uid);
        }

        public void AddCallRecord(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            _CallRecordRepository.Add(new CallRecord()
            {
                caller = _Uid,
                receiver = uid,
                created = Created
            });
            _CallRecordRepository.SaveChanges();
        }

        public void AddViewFootPrintRecord(long fid)
        {
            ExceptionHelper.ThrowIfNotId(fid, nameof(fid));
            var fids = new long[] { fid };
            var now = DateTime.Now;
            _UserViewFootPrintRecordRepository.AddAndDeleteExcept(p => p.uid == _Uid && p.fid == fid,
                fids,
                (u, v) => u.fid == v,
                (u, v) =>
                {
                    u.count = u.count + 1;
                    u.updated = now;
                },
                u => { return false; },
                v => new UserViewFootPrintRecord()
                {
                    fid = fid,
                    uid = _Uid,
                    count = 1,
                    updated = now
                });
        }
        public void AddViewFootPrintRecord(long[] fids)
        {
            fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (fids.Length == 0) return;
            var now = DateTime.Now;
            _UserViewFootPrintRecordRepository.AddAndDeleteExcept(p => p.uid == _Uid&&fids.Contains(p.fid),
                fids,
                (u, v) => u.fid == v,
                (u, v) =>
                {
                    u.count = u.count + 1;
                    u.updated = now;
                },
                u => { return false; },
                v => new UserViewFootPrintRecord()
                {
                    fid = v,
                    uid = _Uid,
                    count = 1,
                    updated = now
                });
        }

        public void UpdateUserCover(string fid)
        {
            if (!string.IsNullOrWhiteSpace(fid))
            {
                _LazyValue.Value.cover = fid;
                _UserRepository.SaveChanges();
            }
        }

        public int GetUserFavoProjNum()
        {
            return _UserFavoriteRepository.Entities.AsNoTracking().Where(p => p.uid == _Uid && p.isEnabled).Count();
        }

        public int GetMessageCount(Range<DateTime> range = null)
        {
            return _MessageService.GetMessageCout(Uid, "/Single/Message", null);//留言总数
        }

        public UserFriendCountModel GetUserFriendCount()
        {
           return _SearchManager.GetFriendCountd(Uid);
        }

        public void AddSuggestFeekback(string content)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(content, nameof(content));
            var now = DateTime.Now;
            _UserComplainRepository.Add(new UserComplain()
            {
                uid = _Uid,
                content = content,
                created = now,
                kind= ComplainKind.Suggestion
            });
            _UserComplainRepository.SaveChanges();
        }
       

       

        public PageModel<ProjFavorite> GetUserFavoriteProjs(int start, int limit)
        {
           return _UserFavoriteRepository.GetUserFavoriteProjs(_Uid, start, limit);
        }

        public UserDockedNum GetUserDockedNum()
        {
            return _DockedRecordRepository.GetUserDockedNum(_Uid);
        }
    }

    
    

    public enum VerifyFailType : byte
    {
        所处图片模糊不清 = 0,
        所填资料与图片不符 = 1,
        其他 = 2,
    }
}
