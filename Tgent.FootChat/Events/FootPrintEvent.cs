using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.FootPrint;
using Tgnet.FootChat.Mobile;
using Tgnet.FootChat.Project;
using Tgnet.FootChat.Push;
using Tgnet.FootChat.User;
using Tgnet.FootChat.YwqWcfService;

namespace Tgnet.FootChat.Events
{
    public interface IFootPrintEventFactory
    {
        IFootPrintEvent CreateEvent(IFootPrintService service);
    }
    public class FootPrintEventFactory : IFootPrintEventFactory
    {
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        private readonly IUserManager _UserManager;
        private readonly IMessageService _MessageService;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IFootPrintManager _FootPrintManager;
        private readonly IProjSourceManager _ProjSourceManager;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IUserServiceFactory _UserServiceFactory;
        private readonly FCRMAPI.IPushManager _FCRMAPIPushManager;
        private readonly IRepository<Data.FootPrintTag> _FootPrintTagRepository;
        private readonly Push.IPushManager _PushManager;


        public FootPrintEventFactory(
            INotifyServiceProxy notifyServiceProxy,
            IUserManager userManager,
            IMessageService messageService,
            Tgnet.FootChat.Data.IFootPrintRepository footPrintRepository,
            IFootPrintManager footPrintManager,
            IProjSourceManager projSourceManager,
            IAddressBookMobileRepository addressBookMobileRepository,
            IUserServiceFactory userServiceFactory,
            FCRMAPI.IPushManager fCRMAPIpushManager,
            IRepository<Data.FootPrintTag> footPrintTagRepository,
            Push.IPushManager pushManager)
        {
            _NotifyServiceProxy = notifyServiceProxy;
            _UserManager = userManager;
            _MessageService = messageService;
            _FootPrintRepository = footPrintRepository;
            _FootPrintManager = footPrintManager;
            _ProjSourceManager = projSourceManager;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _UserServiceFactory = userServiceFactory;
            _FCRMAPIPushManager = fCRMAPIpushManager;
            _FootPrintTagRepository = footPrintTagRepository;
            _PushManager = pushManager;
        }

        public IFootPrintEvent CreateEvent(IFootPrintService service)
        {
            return new FootPrintEvent(service, _MessageService, _FootPrintRepository, _FootPrintManager, _ProjSourceManager, _AddressBookMobileRepository, _UserServiceFactory, _NotifyServiceProxy, _FCRMAPIPushManager, _FootPrintTagRepository, _PushManager, _UserManager);
        }
    }
    public interface IFootPrintEvent
    {
        void OnPass(bool hasImageInvalid = false);
        void OnUnpass();
        void PushUnReadFPsOfFriendsInYesterday();
    }
    public class FootPrintEvent : IFootPrintEvent
    {
        private readonly IMessageService _MessageService;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IFootPrintManager _FootPrintManager;
        private readonly IProjSourceManager _ProjSourceManager;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IUserServiceFactory _UserServiceFactory;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        private readonly FCRMAPI.IPushManager _FCRMAPIPushManager;
        private readonly IRepository<Data.FootPrintTag> _FootPrintTagRepository;
        private readonly Push.IPushManager _PushManager;
        private readonly IUserManager _UserManager;
        private readonly IFootPrintService _FootPrintService;


        public FootPrintEvent(
            IFootPrintService footPrintService,
            IMessageService messageService,
            Tgnet.FootChat.Data.IFootPrintRepository footPrintRepository,
            IFootPrintManager footPrintManager,
            IProjSourceManager projSourceManager,
            IAddressBookMobileRepository addressBookMobileRepository,
            IUserServiceFactory userServiceFactory,
            INotifyServiceProxy notifyServiceProxy,
            FCRMAPI.IPushManager fCRMAPIpushManager,
            IRepository<Data.FootPrintTag> footPrintTagRepository,
            Push.IPushManager pushManager,
            IUserManager userManager)
        {
            _MessageService = messageService;
            _FootPrintRepository = footPrintRepository;
            _FootPrintManager = footPrintManager;
            _ProjSourceManager = projSourceManager;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _UserServiceFactory = userServiceFactory;
            _NotifyServiceProxy = notifyServiceProxy;
            _FCRMAPIPushManager = fCRMAPIpushManager;
            _FootPrintTagRepository = footPrintTagRepository;
            _PushManager = pushManager;
            _UserManager = userManager;
            _FootPrintService = footPrintService;
        }
        public void OnPass(bool hasImageInvalid = false)
        {
            var task = new TaskFactory();
            var fid = _FootPrintService.Fid;
            //推送到图数据库
            int scopeType = 20;
            //5.找到关键人，12.已签单，30.可推荐
            var bonusTagId = new long[] { 5, 12, 30 };
            if (_FootPrintTagRepository.Entities.Any(p => p.fid == fid && bonusTagId.Contains(p.tid)))
                scopeType = 100;
            var areaNo = _FootPrintService.AreaNo;
            var areaLength = !string.IsNullOrWhiteSpace(areaNo) ? areaNo.Length : 0;
            var request = new FCRMAPI.Request.PushFootPrintRequest()
            {
                Fid = _FootPrintService.Fid,
                Pid = _FootPrintService.Pid,
                ScopeType = scopeType,
                Uid = _FootPrintService.Uid,
                CountryNo = areaLength >= 4 ? areaNo.Left(4) : "",
                ProvinceNo = areaLength >= 8 ? areaNo.Left(8) : "",
                CityNo = areaLength >= 12 ? areaNo.Left(12) : "",
                AreaNo = areaLength >= 16 ? areaNo.Left(16) : "",
                Created = _FootPrintService.OrderUpdated
            };
            task.StartNew(() =>
            {
                _FCRMAPIPushManager.PublisSingleFootPrint(request, false);
            });

            //try
            //{
            //    var passNotifySevice = new PassFootPrintNotifyService(_FootPrintService, _FootPrintRepository, _FootPrintManager, _ProjSourceManager, _AddressBookMobileRepository, _UserServiceFactory, _NotifyServiceProxy, _MessageService, _PushManager, _UserManager);
            //    passNotifySevice.NotifyPublishUser();
            //    passNotifySevice.NotifyFollowSameProjUser();
            //    passNotifySevice.NotifyFriendsOnecAWeek();
            //    passNotifySevice.NotifyFriendsOnecInDay(_FootPrintService.Pid);
            //    if (hasImageInvalid)
            //        passNotifySevice.NotifyUserIfHasImgInvalid();
            //}
            //catch (System.Exception ex)
            //{
            //    Tgnet.Log.LoggerResolver.Current.Error("push Error ", ex);
            //    Tgnet.Log.LoggerResolver.Current.Debug("push Error ", ex.Message);
            //}


        }

        public void OnUnpass()
        {
            //推送到图数据库
            var taskFactory = new TaskFactory();
            var fid = _FootPrintService.Fid;
            taskFactory.StartNew(() =>
            {
                _FCRMAPIPushManager.DeleteFootPrint(fid, transmitToMQ: false);
            });

            var uid = _FootPrintService.Uid;
            var remark = _FootPrintService.ExamineRemark;
            if (_FootPrintService.State == FootPrintState.UnPass)
            {
                var pid = _FootPrintService.Pid;
                string projName = "";
                var proj = _ProjSourceManager.GetSource(pid);
                if (proj != null)
                    projName = proj.name;
                var reason = "";
                if (!string.IsNullOrWhiteSpace(remark))
                    reason = "，原因：{" + remark + "}";
                var content = string.Format("您发布的#{0}#关联的足迹未通过审核，原因：{1}，请重新发布，以免错失项目交流机会~", projName, reason);
                var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { uid }, ContentType.Text, content);
                _NotifyServiceProxy.AdminNotify(request, true);


            }
        }



        public void PushUnReadFPsOfFriendsInYesterday()
        {
            var userCountDic = _FootPrintRepository.GetUserYesterdayUnReadFPCount();
            foreach (var item in userCountDic)
            {
                var content = string.Format("您的好友昨天发布的{0}条新的项目足迹您还未查看，及时了解，获取更多项目资源！{1}", item.Value, "http://m.fc.tgnet.com/Home/Index");
                var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { item.Key }, ContentType.Text, content);
                _NotifyServiceProxy.AdminNotify(request, true);
            }
        }
    }

    public class PassFootPrintNotifyService
    {
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IFootPrintManager _FootPrintManager;
        private readonly IProjSourceManager _ProjSourceManager;
        private readonly IFootPrintService _FootPrintService;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IUserServiceFactory _UserServiceFactory;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        private readonly IMessageService _MessageService;
        private readonly Push.IPushManager _PushManager;
        private readonly IUserManager _UserManager;


        public PassFootPrintNotifyService(IFootPrintService service,
            IFootPrintRepository footPrintRepository,
            IFootPrintManager footPrintManager,
            IProjSourceManager projSourceManager,
            IAddressBookMobileRepository addressBookMobileRepository,
            IUserServiceFactory userServiceFactory,
            INotifyServiceProxy notifyServiceProxy,
            IMessageService messageService,
            Push.IPushManager pushManager,
            IUserManager userManager
            )
        {
            _FootPrintService = service;
            _FootPrintRepository = footPrintRepository;
            _FootPrintManager = footPrintManager;
            _ProjSourceManager = projSourceManager;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _UserServiceFactory = userServiceFactory;
            _NotifyServiceProxy = notifyServiceProxy;
            _MessageService = messageService;
            _PushManager = pushManager;
            _UserManager = userManager;

        }

        private ProjectSource _ProjectSource;
        public ProjectSource ProjectSource
        {
            get
            {
                if (_ProjectSource == null)
                {
                    _ProjectSource = _ProjSourceManager.GetSource(_FootPrintService.Pid);
                    if (_ProjectSource == null)
                        throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目);
                }
                return _ProjectSource;
            }
        }

        public void NotifyPublishUser()
        {
            var uid = _FootPrintService.Uid;
            var isHaveFollowOtherUser = _FootPrintManager.PassFootPrints.Any(p => p.uid != uid);
            var content = "您发布的{0}关联的足迹已经审核通过，马上查看项目动态及其他同跟人项目信息，获取更多项目线索";
            var viewDetial = "";
            if (isHaveFollowOtherUser)
                viewDetial = "项目动态及其他同跟人项目信息";
            else
                viewDetial = "项目最新动态";
            content = string.Format(content, ProjectSource.name, viewDetial);
            var request = new NotifyMessageRequest(ActionType.FOOTCHAT_PASS, 0, 0, new long[] { uid }
            , new PushMessage() { Content = content, Url = "http://m.fc.tgnet.com/ProjFollow/List" });
            _NotifyServiceProxy.Notify(request);
        }

        public void NotifyFollowSameProjUser()
        {
            var uid = _FootPrintService.Uid;
            var pid = _FootPrintService.Pid;
            var focusProjUids = _FootPrintRepository.GetFollowAndFavoriteUids(pid).Where(p => p != uid).Distinct().ToArray();
            if (focusProjUids.Any())
            {
                var projName = ProjectSource.name;
                var content = string.Format("您的在跟/收藏项目{0}新增1人也在跟进，马上查看跟进状况，获得更多签单帮助！", projName);
                var remind = new PushRemindRequest()
                {
                    Title = "足聊",
                    Body = content,
                    MessageType = MessageType.Once,
                    URL = "http://m.fc.tgnet.com/ProjFollow/List",
                };
                _NotifyServiceProxy.PushRemind(remind, focusProjUids);

            }

        }


        public void NotifyFriendsOnecAWeek()
        {
            var uid = _FootPrintService.Uid;
            var user = _UserServiceFactory.GetService(uid);
            var timeBefore7Days = DateTime.Now.AddDays(-7);
            var isPublishedIn7Days = _FootPrintRepository.Entities.Count(p => p.uid == uid && p.state == FootPrintState.Pass && p.orderUpdated > timeBefore7Days) > 1;
            var name = user.Name;
            if (!isPublishedIn7Days)
            {

                var inTgAnNotInFc = _AddressBookMobileRepository.GetTgUidAndNotFootUidOfInBook(uid).Distinct().ToArray();
                var mobiles = _UserManager.GetEnableUser().Where(p => inTgAnNotInFc.Contains(p.uid)).Select(p => p.mobile).ToArray().Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
                if (mobiles.Any())
                {
                    Dictionary<string, string> values = new Dictionary<string, string>();
                    values.Add("name", name);
                    _PushManager.SendSms(130, mobiles, values, "足聊");
                }
            }
        }
        public void NotifyFriendsOnecInDay(long pid)
        {
            var uid = _FootPrintService.Uid;
            var user = _UserServiceFactory.GetService(uid);
            var today = DateTime.Now.Date;
            var isPublishedIn7Days = _FootPrintRepository.Entities.Count(p => p.uid == uid && p.state == FootPrintState.Pass && p.orderUpdated > today) > 1;
            var name = user.Name;
            if (!isPublishedIn7Days)
            {
                var fcfriendUids = _AddressBookMobileRepository.GetFootUidOfInBook(uid).Distinct().ToArray();
                var content = string.Format("您的好友{0}分享了一条最新的项目动态，马上查看了解更多关系项目~", user.Name);

                var remind = new PushRemindRequest()
                {
                    Title = "足聊",
                    Body = content,
                    MessageType = MessageType.Once,
                    URL = string.Format("http://m.fc.tgnet.com/Footprint/Detail?pid={0}", pid),
                };
                _NotifyServiceProxy.PushRemind(remind, fcfriendUids);
            }
        }

        public void NotifyUserIfHasImgInvalid()
        {
            var uid = _FootPrintService.Uid;
            var user = _UserServiceFactory.GetService(uid);
            var updated = _FootPrintService.Updated.ToString("yyyy-MM-dd HH:mm");
            var content = string.Format("您{0}发布的足迹，因部分照片不符合要求，平台做了过滤处理，请知悉。", updated);
            _MessageService.SendAdminMessageToUser(uid, ActionType.ADMIN_MESSAGE.Action, ContentType.Text, content, null);
        }
    }
}
