using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Pay;
using Tgnet.FootChat.Push;
using Tgnet.FootChat.Trade;

namespace Tgnet.FootChat.Events
{
    public interface IServiceEventFactory
    {
        IServiceEvent CreateEvent();
    }
    public class ServiceEventFactory : IServiceEventFactory
    {
        private readonly IMessageService _MessageService;
        private readonly Trade.ITradeManager _TradeManager;
        private readonly IUserServiceStateRepository _UserServiceStateRepository;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        public ServiceEventFactory(
            IMessageService messageService,
            ITradeManager tradeManager,
            IUserServiceStateRepository userServiceStateRepository,
            INotifyServiceProxy notifyServiceProxy)
        {
            _MessageService = messageService;
            _TradeManager = tradeManager;
            _UserServiceStateRepository = userServiceStateRepository;
            _NotifyServiceProxy = notifyServiceProxy;

        }
        public IServiceEvent CreateEvent()
        {
            return new ServiceEvent(
                _MessageService,
                _TradeManager, _UserServiceStateRepository, _NotifyServiceProxy);
        }
    }
    public interface IServiceEvent
    {
        void PayFail(long uid, out bool ispayFail);
        void PayFailAfterOneDay(long uid);
        void TrialWillExpiredAfter3Days();
        void TrialWillExpiredToday();
        void TrialExpiredBefore3Days();
        void VipWillExpiredBefore7Days();
        void TrialWillExpiredAfterSomeDays(int day);


    }
    public class ServiceEvent : IServiceEvent
    {
        private readonly IMessageService _MessageService;
        private readonly Trade.ITradeManager _TradeManager;
        private readonly IUserServiceStateRepository _UserServiceStateRepository;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        public ServiceEvent(
            IMessageService messageService,
            ITradeManager tradeManager,
            IUserServiceStateRepository userServiceStateRepository,
            INotifyServiceProxy notifyServiceProxy)
        {
            _MessageService = messageService;
            _TradeManager = tradeManager;
            _UserServiceStateRepository = userServiceStateRepository;
            _NotifyServiceProxy = notifyServiceProxy;

        }
        public void PayFail(long uid,out bool ispayFail)
        {
            ispayFail = false;
            if (_TradeManager.CheckLastTradeIsUnpaid(uid, null))
            {
                ispayFail = true;
                var content = "您的vip会员付费未成功，请重新支付，以免影响功能正常体验，错失项目交流机会！";
                var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { uid }, ContentType.Text, content);
                _NotifyServiceProxy.AdminNotify(request, true);
            }
        }
        public void PayFailAfterOneDay(long uid)
        {
            if (_TradeManager.CheckLastTradeIsUnpaid(uid, null))
            {
                var content = "您的vip会员付费未成功，请重新支付，以免影响功能正常体验，错失项目交流机会！";
                var request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, 0, 0, new long[] { uid }, ContentType.Text, content);
                _NotifyServiceProxy.AdminNotify(request, true);
            }
        }
        public void TrialWillExpiredAfter3Days()
        {
            var uids = _UserServiceStateRepository.GetWillOrExipredUid(User.UserServiceLevel.Trail, 3);
            if (uids.Any())
            {

                var content = "您的VIP体验即将到期，请及时续费，以免影响功能正常体验，错失项目交流机会！";
                var remind = new PushRemindRequest()
                {
                    Title = "足聊",
                    Body = content,
                    MessageType = MessageType.Once,
                    URL = "http://m.fc.tgnet.com/User/Index",
                };
                _NotifyServiceProxy.PushRemind(remind, uids);
            }
        }
        public void TrialWillExpiredToday()
        {
            var uids = _UserServiceStateRepository.GetWillOrExipredUid(User.UserServiceLevel.Trail, 0);
            if (uids.Any())
            {
                var content = "您的VIP体验已到期，马上续费，以免影响功能正常体验，错失项目签单机会！";
                var remind = new PushRemindRequest()
                {
                    Title = "足聊",
                    Body = content,
                    MessageType = MessageType.Once,
                    URL = "http://m.fc.tgnet.com/User/Index",
                };
                _NotifyServiceProxy.PushRemind(remind, uids);
            }

        }
        public void TrialExpiredBefore3Days()
        {
            var uids = _UserServiceStateRepository.GetWillOrExipredUid(User.UserServiceLevel.Trail, -3);
            if (uids.Any())
            {
                var content = "您的VIP体验已过期，将无法与其他人快速交流对接！马上续费，以免错失更多项目签单机会！";
                var remind = new PushRemindRequest()
                {
                    Title = "足聊",
                    Body = content,
                    MessageType = MessageType.Once,
                    URL = "http://m.fc.tgnet.com/User/Index",
                };
                _NotifyServiceProxy.PushRemind(remind, uids);
            }
        }

        public void TrialWillExpiredAfterSomeDays(int day)
        {
            var uids = _UserServiceStateRepository.GetWillOrExipredUid(User.UserServiceLevel.Trail, day);
            if (uids.Any())
            {
                var content = "您的VIP体验已过期，将无法与其他人快速交流对接！马上续费，以免错失更多项目签单机会！";
                var remind = new PushRemindRequest()
                {
                    Title = "足聊",
                    Body = content,
                    MessageType = MessageType.Once,
                    URL = "http://m.fc.tgnet.com/User/Index",
                };
                _NotifyServiceProxy.PushRemind(remind, uids);
            }
        }

        public void VipWillExpiredBefore7Days()
        {
            var uids = _UserServiceStateRepository.GetWillOrExipredUid(User.UserServiceLevel.Official, 7);
            if (uids.Any())
            {
                var content = "您的VIP会员即将到期，请及时续费，以免影响项目交流合作，错失项目签单机会！";
                var remind = new PushRemindRequest()
                {
                    Title = "足聊",
                    Body = content,
                    MessageType = MessageType.Once,
                    URL = "http://m.fc.tgnet.com/User/Index",
                };
                _NotifyServiceProxy.PushRemind(remind, uids);
            }
        }
    }
}
