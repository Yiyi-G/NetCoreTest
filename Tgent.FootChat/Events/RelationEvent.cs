using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.ServiceModel;
using Tgnet.FootChat.Push;
using Tgnet.FootChat.Mobile;

namespace Tgnet.FootChat.Events
{
    public interface IRelationEventFactory
    {
        IRelationEvent CreateEvent(Relation.IUserRelationService relation);
    }

    class RelationEventFactory : IRelationEventFactory
    {
        private readonly Tgnet.FootChat.Push.INotifyServiceProxy _NotifyServiceProxy;
        private readonly Tgnet.FootChat.User.IUserManager _UserManager;
        private readonly Tgnet.FootChat.Push.IPushManager _PushManager;

        public RelationEventFactory(Tgnet.FootChat.Push.INotifyServiceProxy notifyServiceProxy,
              Tgnet.FootChat.User.IUserManager userManager,
              Tgnet.FootChat.Push.IPushManager pushManager)
        {
            _NotifyServiceProxy = notifyServiceProxy;
            _UserManager = userManager;
            _PushManager = pushManager;
        }

        public IRelationEvent CreateEvent(Relation.IUserRelationService relation)
        {
            ExceptionHelper.ThrowIfNull(relation, "relation");
            return new RelationEvent(relation, _NotifyServiceProxy, _UserManager,_PushManager);
        }
    }


    public interface IRelationEvent
    {
        void MoveToBlacklist();
        void OnRemoveFromBlackList();
    }

    class RelationEvent : IRelationEvent
    {
        private readonly Relation.IUserRelationService _UserRelationService;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        private readonly Tgnet.FootChat.User.IUserManager _UserManager;
        private readonly Tgnet.FootChat.Push.IPushManager _PushManager;

        public RelationEvent(
            Relation.IUserRelationService userRelationService,
            INotifyServiceProxy notifyServiceProxy,
              Tgnet.FootChat.User.IUserManager userManager,
              Tgnet.FootChat.Push.IPushManager pushManager)
        {
            _UserRelationService = userRelationService;
            _NotifyServiceProxy = notifyServiceProxy;
            _UserManager = userManager;
            _PushManager = pushManager;
        }

        public void OnApply(string message)
        {
            var request = new NotifyMessageRequest(ActionType.FRIEND_APPLY, _UserRelationService.Receiver, _UserRelationService.Sender, new long[] { _UserRelationService.Receiver },
                new { message = message });
            _NotifyServiceProxy.Notify(request);
        }

        public void OnPass(bool notifySender, long cpid)
        {
            var extension = new Dictionary<string, object>();
            var requests = new List<NotifyMessageRequest>();
            requests.Add(new NotifyMessageRequest(ActionType.FRIEND_PASS, _UserRelationService.Receiver, _UserRelationService.Sender, new long[] { _UserRelationService.Receiver }, String.Empty, extension: extension));
            if (notifySender)
                requests.Add(new NotifyMessageRequest(ActionType.FRIEND_PASS, _UserRelationService.Sender, _UserRelationService.Receiver, new long[] { _UserRelationService.Sender }, String.Empty, extension: extension));
            _NotifyServiceProxy.Notify(requests);
        }
        public void OnRemoveFromBlackList()
        {
            var request = new NotifyMessageRequest(ActionType.BLACKLIST_DELETE, _UserRelationService.Receiver, _UserRelationService.Sender, new long[] { _UserRelationService.Receiver }, String.Empty);
            _NotifyServiceProxy.Notify(request);
        }
        public void MoveToBlacklist()
        {
            var requests = new List<NotifyMessageRequest>();
            requests.Add(new NotifyMessageRequest(ActionType.BLACKLIST_ADD, _UserRelationService.Receiver, _UserRelationService.Sender, new long[] { _UserRelationService.Receiver }, String.Empty));
            _NotifyServiceProxy.Notify(requests);
        }
    }

}
