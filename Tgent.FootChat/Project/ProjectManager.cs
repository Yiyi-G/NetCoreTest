using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.ProjectService;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Project
{
    public interface IProjectManager
    {
        ProjectSurvey GetProjectSurvey(long tgPid);
        SimpleProjectInfo[] SearchProj(long[] tgpids);
        PageModel<ProjectDynamic> GetProjectDynamics(long pid, ProjectDynamicKind[] kinds, int? start, int? limit);
        FootPrintModel[] GetFootPrints(DateTime start, DateTime end, int limit);
    }
    public class ProjectManager : IProjectManager
    {
        private readonly IChannelProviderService<IProjectService> _ProjectServiceProvider;
        private readonly IChannelProviderService<IProjectMangerService> _ProjectMangerServiceProvider;

        public ProjectManager(IChannelProviderService<IProjectService> projectServiceProvider,
            IChannelProviderService<IProjectMangerService> projectMangerServiceProvider)
        {
            _ProjectServiceProvider = projectServiceProvider;
            _ProjectMangerServiceProvider = projectMangerServiceProvider;
        }

        public ProjectSurvey GetProjectSurvey(long tgPid)
        {
            ExceptionHelper.ThrowIfNotId(tgPid, nameof(tgPid));
            var encryptPid = Tgnet.Security.NumberConfuse.Confuse(tgPid);
            using (var provider = _ProjectServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetProjectSurvey(new Api.OAuth2ClientIdentity(), encryptPid);
            }
        }

        public SimpleProjectInfo[] SearchProj(long[] tgpids)
        {
            tgpids = (tgpids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (tgpids.Length == 0) return new SimpleProjectInfo[0];
            using (var provider = _ProjectServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetSimpleProjectInfo(new Api.OAuth2ClientIdentity(), tgpids);
            }
        }

        public PageModel<ProjectDynamic> GetProjectDynamics(long pid, ProjectDynamicKind[] kinds, int? start, int? limit)
        {
            ExceptionHelper.ThrowIfNotId(pid, nameof(pid));
            using (var provider = _ProjectServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetProjectDynamics(new Api.OAuth2ClientIdentity(), pid, kinds, start, limit);
            }
        }

        public FootPrintModel[] GetFootPrints(DateTime start, DateTime end, int limit)
        {
            using (var provider = _ProjectMangerServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetFootPrints(new Api.OAuth2ClientIdentity(), start, end, limit);
            }
        }
    }
}
