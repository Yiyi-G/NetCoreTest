using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Docked;
using Tgnet.FootChat.FootPrint;
using Tgnet.FootChat.Push;

namespace Tgnet.FootChat.Events
{
    public interface IFootPrintDockedEventFactory
    {
        IFootPrintDockedEvent CreateEvent();
    }

    class FootPrintDockedEventFactory : IFootPrintDockedEventFactory
    {
        private readonly Tgnet.FootChat.User.IUserManager _UserManager;
        private readonly Tgnet.FootChat.Push.IPushManager _PushManager;
        private readonly IMessageService _MessageService;
        private readonly INotifyServiceProxy _NotifyServiceProxy;


        public FootPrintDockedEventFactory(
            Tgnet.FootChat.User.IUserManager userManager,
            Tgnet.FootChat.Push.IPushManager pushManager,
            IMessageService messageService,
            INotifyServiceProxy notifyServiceProxy
            )
        {
            _UserManager = userManager;
            _PushManager = pushManager;
            _MessageService = messageService;
            _NotifyServiceProxy = notifyServiceProxy;
        }

        public IFootPrintDockedEvent CreateEvent()
        {
            return new FootPrintDockedEvent(_UserManager, _PushManager, _NotifyServiceProxy);
        }
    }
    public interface IFootPrintDockedEvent
    {
        void OnDockedApply(IUserDockedService userDockedService);
        void OnDockedApply(Data.DockedRecord[] dockEntities);
        void OnDockedPass(IUserDockedService userDockedService, long pid, string projectName);
        void OnDockedUnPass(IUserDockedService userDockedService, string projectName);
    }
    class FootPrintDockedEvent : IFootPrintDockedEvent
    {
        private readonly Tgnet.FootChat.User.IUserManager _UserManager;
        private readonly Tgnet.FootChat.Push.IPushManager _PushManager;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        public FootPrintDockedEvent(
            Tgnet.FootChat.User.IUserManager userManager,
            Tgnet.FootChat.Push.IPushManager pushManager,
            INotifyServiceProxy notifyServiceProxy)
        {
            _UserManager = userManager;
            _PushManager = pushManager;
            _NotifyServiceProxy = notifyServiceProxy;
        }
        public void OnDockedApply(IUserDockedService userDockedService)
        {
            ExceptionHelper.ThrowIfNull(userDockedService, nameof(userDockedService));
            var actionType = ActionType.FOOTPRINT_DOCKED_APPLY;
            var notifyRequest = new NotifyMessageRequest(actionType, actionType.DefaultMessageType, userDockedService.Receiver, userDockedService.Sender, new long[] { userDockedService.Receiver }, ContentType.Text, userDockedService.Message);
            _NotifyServiceProxy.Notify(notifyRequest);
        }
        public void OnDockedApply(Data.DockedRecord[] dockEntities)
        {
            if (dockEntities == null || !dockEntities.Any()) return;
            var actionType = ActionType.FOOTPRINT_DOCKED_APPLY;
            foreach (var dockEntity in dockEntities)
            {
                var reciver = dockEntity.receiver;
                var notifyRequest = new NotifyMessageRequest(actionType, actionType.DefaultMessageType, reciver, dockEntity.sender, new long[] { reciver }, ContentType.Text, dockEntity.message);
                _NotifyServiceProxy.Notify(notifyRequest);
            }
        }
        public void OnDockedPass(IUserDockedService userDockedService, long pid, string projectName)
        {
            ExceptionHelper.ThrowIfNull(userDockedService, nameof(userDockedService));
            var receiver = userDockedService.Sender;
            var name = _UserManager.GetUserNames(new long[] { receiver }, null).Select(p => p.Value).FirstOrDefault();
            var message = string.Format("你好，我叫{0}，希望能和你合作~", name);
            var content = new
            {
                fid = userDockedService.Fid,
                pid = pid,
                project_name = projectName,
                message = message,
            };
            var actionType = ActionType.FOOTPRINT_DOCKED_PASS;
            
            var notifyRequest = new NotifyMessageRequest(actionType, receiver, userDockedService.Receiver, new long[] { receiver }, content);
            Tgnet.Log.LoggerResolver.Current.Debug("OnDockedPass", Newtonsoft.Json.JsonConvert.SerializeObject(notifyRequest));
            _NotifyServiceProxy.Notify(notifyRequest);

            //发送足聊小蜜
            var adminContent = string.Format("您的对接请求已通过，快去交流吧！项目：{0}", projectName);
            var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { receiver }, ContentType.Text, adminContent);
            _NotifyServiceProxy.AdminNotify(request, true);
            // _NotifyServiceProxy.SendAdminMessageToUser(receiver, "");
        }
        public void OnDockedUnPass(IUserDockedService userDockedService,string projectName)
        {
            //发送足聊小蜜
            var receiver = userDockedService.Sender;
            var adminContent = string.Format("您的对接请求失败，发布足迹越多对接成功率越高喔！项目：{0}", projectName);
            var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { receiver }, ContentType.Text, adminContent);
            _NotifyServiceProxy.AdminNotify(request, true);
        }
    }

    public class UserDockMsg
    {
        public long Uid { get; set; }
        public string Msg { get; set; }
    }
}
