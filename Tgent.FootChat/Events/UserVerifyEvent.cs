using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Push;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Events
{
    public interface IUserVerifyEventFactory
    {
        IUserVerifyEvent CreateEvent();
    }
    public class UserVerifyEventFactory : IUserVerifyEventFactory
    {
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        public UserVerifyEventFactory(INotifyServiceProxy notifyServiceProxy)
        {
            _NotifyServiceProxy = notifyServiceProxy;

        }
        public IUserVerifyEvent CreateEvent()
        {
            return new UserVerifyEvent(_NotifyServiceProxy);
        }
    }

    public interface IUserVerifyEvent
    {
        void OnPass(IUserService user, bool openTrail);
        void OnUnpass(IUserService user);
    }
    public class UserVerifyEvent : IUserVerifyEvent
    {
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        public UserVerifyEvent(INotifyServiceProxy notifyServiceProxy)
        {
            _NotifyServiceProxy = notifyServiceProxy;

        }
        public void OnPass(IUserService user, bool openTrail)
        {
            if (user.VerifyStatus == VerifyStatus.Pass)
            {
                var content = "";
                if (openTrail)
                    content = "您提交的认证资料已通过审核，即刻开始7天VIP会员免费体验！查看其他项目足迹，跟其他人交流对接更多项目~";
                else
                    content = "您提交的认证资料已通过审核，查看其他项目足迹，跟其他人交流对接更多项目~";
                var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { user.Uid }, ContentType.Text, content);
                _NotifyServiceProxy.AdminNotify(request, true);
            }
        }

        public void OnUnpass(IUserService user)
        {
            if (user.VerifyStatus == VerifyStatus.Unpass)
            {
                var content = "";
                if (user.GetUserSeriviceState().UserLevel == UserServiceLevel.Normal)
                    content = "您提交的认证资料未通过审核，请尽快重新提交，限时免费体验7天VIP会员，不错过项目交流合作机会！";
                else
                    content = "您提交的认证资料未通过审核，请尽快重新提交，不错过项目交流合作机会！";
                var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { user.Uid }, ContentType.Text, content);
                _NotifyServiceProxy.AdminNotify(request, true);
            }
        }
    }
}
