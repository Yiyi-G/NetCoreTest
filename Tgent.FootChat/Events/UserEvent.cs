using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Push;

namespace Tgnet.FootChat.Events
{
    public interface IUserEventFactory
    {
        IUserEvent CreateEvent(Tgnet.FootChat.User.IUserService user);
    }

    class UserEventFactory : IUserEventFactory
    {
        private readonly Tgnet.FootChat.User.IUserManager _UserManager;
        private readonly Tgnet.FootChat.Push.IPushManager _PushManager;
        private readonly IMessageService _MessageService;
        private readonly INotifyServiceProxy _NotifyServiceProxy;


        public UserEventFactory(
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

        public IUserEvent CreateEvent(Tgnet.FootChat.User.IUserService user)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            return new UserEvent(user, _UserManager, _PushManager, _NotifyServiceProxy);
        }
    }
    public interface IUserEvent
    {
        void OnAttention(string mobile);
    }
    class UserEvent : IUserEvent
    {
        private readonly Tgnet.FootChat.User.IUserManager _UserManager;
        private readonly Tgnet.FootChat.Push.IPushManager _PushManager;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        private readonly Tgnet.FootChat.User.IUserService _User;
        public UserEvent(Tgnet.FootChat.User.IUserService user,
            Tgnet.FootChat.User.IUserManager userManager,
            Tgnet.FootChat.Push.IPushManager pushManager,
            INotifyServiceProxy notifyServiceProxy)
        {
            _User = user;
            _UserManager = userManager;
            _PushManager = pushManager;
            _NotifyServiceProxy = notifyServiceProxy;

        }

        public void OnAttention(string mobile)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(mobile, nameof(mobile));
            var users = _UserManager.GetUsers(new string[] { mobile }).ToArray();
            if (users != null && users.Count() > 0)
            {
                var content = string.Format("您的好友<a href=\"http://m.fc.tgnet.com/User/Info?uid={0}\">{1}</a>关注了您！马上关注TA，查看好友足迹，快速交流，获取更多项目资源！~", _User.Uid, _User.Name);
                var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { users[0].uid }, ContentType.Html, content);
                _NotifyServiceProxy.AdminNotify(request, true);
            }
            else
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                values.Add("name", _User.Name);
                values.Add("status", "使用业务签单新模式，期待与你进行更多的");
                _PushManager.SendSms(131, new String[] { mobile }, values, "足聊");
            }
        }
    }
}
