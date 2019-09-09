using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.ProjectService;
using Tgnet.FootChat.User;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Project
{
    public interface IUserProjectManager
    {
        RoleDetail[] GetProjectRoleDetail(long tgPid, bool isPreview);
    }
    public  class UserProjectManager: IUserProjectManager
    {
        private readonly IChannelProviderService<IProjectService> _ProjectServiceProvider;

        public UserProjectManager(IChannelProviderService<IProjectService> projectServiceProvider)
        {
            _ProjectServiceProvider = projectServiceProvider;
        }

        public RoleDetail[] GetProjectRoleDetail(long tgPid,bool isPreview)
        {
            ExceptionHelper.ThrowIfNotId(tgPid, nameof(tgPid));
            var encryptPid = Tgnet.Security.NumberConfuse.Confuse(tgPid);
            
            using (var provider = _ProjectServiceProvider.NewChannelProvider())
            {
               return  provider.Channel.GetProjectRoleDetail(new Api.OAuth2ClientIdentity(), encryptPid, isPreview);
            }
        }
    }
}
