using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.UserService;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Mobile
{
    internal class VerifyHelper
    {
        private readonly IChannelProviderService<UserService.IUserManagerService> _UserManagerService;

        public VerifyHelper(IChannelProviderService<UserService.IUserManagerService> userManagerService)
        {
            _UserManagerService = userManagerService;
        }

        public void SendVerifyCode(string mobile, ValidateType verifyType, long? uid,string signName,string ip,string from )
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, "mobile", "手机号码不能为空");
            ExceptionHelper.ThrowIfTrue(!StringRule.VerifyMobile(mobile), "mobile", "手机号码格式错误");
            using (var service = _UserManagerService.NewChannelProvider())
            {
                service.Channel.SendCode(new OAuth2ClientIdentity(), mobile, verifyType, uid,signName,ip,from);
            }
        }
        public string Verify(string mobile, string code, ValidateType type)
        {
            var error = ErrorCode.None;
            ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, "mobile", "手机号码不能为空");

            ExceptionHelper.ThrowIfTrue(!StringRule.VerifyMobile(mobile), "mobile", "手机号码格式错误");

            using (var service = _UserManagerService.NewChannelProvider())
            {
                return service.Channel.Verify(new OAuth2ClientIdentity(), mobile, code, type);
            }
        }
    }
}
