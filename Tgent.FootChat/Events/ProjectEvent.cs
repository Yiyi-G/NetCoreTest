using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Project;
using Tgnet.FootChat.Push;

namespace Tgnet.FootChat.Events
{
    public interface IProjectEventFactory
    {
        IProjectEvent CreateEvent();
    }
    public class ProjectEventFactory : IProjectEventFactory
    {
        private readonly IProjSourceManager _ProjSourceManager;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly INotifyServiceProxy _NotifyServiceProxy;
        public ProjectEventFactory(IProjSourceManager projSourceManager,
            IFootPrintRepository footPrintRepository,
            INotifyServiceProxy notifyServiceProxy
            )
        {
            _ProjSourceManager = projSourceManager;
            _FootPrintRepository = footPrintRepository;
            _NotifyServiceProxy = notifyServiceProxy;
        }
        public IProjectEvent CreateEvent()
        {
            return new ProjectEvent(_ProjSourceManager, _FootPrintRepository, _NotifyServiceProxy);
        }
    }

    public interface IProjectEvent
    {
        void OnProjUpdate(long pid);
    }
    public class ProjectEvent : IProjectEvent
    {
        private readonly IProjSourceManager _ProjSourceManager;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly INotifyServiceProxy _NotifyServiceProxy;

        public ProjectEvent(IProjSourceManager projSourceManager,
            IFootPrintRepository footPrintRepository,
            INotifyServiceProxy notifyServiceProxy
            )
        {
            _ProjSourceManager = projSourceManager;
            _FootPrintRepository = footPrintRepository;
            _NotifyServiceProxy = notifyServiceProxy;

        }

        public void OnProjUpdate(long pid)
        {
            var proj = _ProjSourceManager.GetSource(pid);
            if (proj != null)
            {
                var name = proj.name;
                var focusProjUids = _FootPrintRepository.GetFollowAndFavoriteUids(pid).Distinct().ToArray();
                if (focusProjUids.Any())
                {
                    var content = string.Format("您的在跟/收藏项目{0}有新的动态/联系人，点击查看最新资料！", name);
                    var remind = new PushRemindRequest() {
                        Title = "足聊",
                        Body = content,
                        MessageType = MessageType.Once,
                        URL = "http://m.fc.tgnet.com/ProjFollow/List",
                    };
                    _NotifyServiceProxy.PushRemind(remind,focusProjUids);
                }
            }

        }
    }
}
