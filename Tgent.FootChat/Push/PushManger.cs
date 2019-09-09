using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using Tgnet.FootChat.PushService;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Push
{
    public interface IPushManager
    {
        void PushJsonMessage(PushService.PushJsonMessageRequest request, PushService.Targets targets, PushService.PushSetting setting);
        void PushMessage(PushService.PushMessageRequest request, PushService.Targets targets, PushService.PushSetting setting);
        void PushRemind(PushService.PushRemindRequest request, PushService.Targets targets, PushService.PushSetting setting);
        void SendSms(string[] mobiles, Dictionary<string, string> values, SmsTemplateKinds templateKind);
        void SendSms(int templateId, string[] mobiles, Dictionary<string, string> values, string signName);
    }
    class PushManager : IPushManager
    {
        private readonly IChannelProviderService<PushService.IPushService> _PushServiceChannelProvider;
        public PushManager(IChannelProviderService<PushService.IPushService> pushServiceChannelProvider)
        {
            _PushServiceChannelProvider = pushServiceChannelProvider;
        }
        public void PushJsonMessage(PushService.PushJsonMessageRequest request, PushService.Targets targets, PushService.PushSetting setting)
        {
            ExceptionHelper.ThrowIfNull(request, "request");
            using (var provider = _PushServiceChannelProvider.NewChannelProvider())
            {
                provider.Channel.PushJsonMessage(new OAuth2ClientIdentity(), request, targets, setting);
            }
        }
        public void PushMessage(PushService.PushMessageRequest request, PushService.Targets targets, PushService.PushSetting setting)
        {
            ExceptionHelper.ThrowIfNull(request, "request");
            using (var provider = _PushServiceChannelProvider.NewChannelProvider())
            {
                provider.Channel.PushMessage(new OAuth2ClientIdentity(), request, targets, setting);
            }
        }
        public void PushRemind(PushService.PushRemindRequest request, PushService.Targets targets, PushService.PushSetting setting)
        {
            ExceptionHelper.ThrowIfNull(request, "request");
            using (var provider = _PushServiceChannelProvider.NewChannelProvider())
            {
                provider.Channel.PushRemind(new OAuth2ClientIdentity(), request, targets, setting);
            }
        }
        public void SendSms(string[] mobiles, Dictionary<string, string> values, SmsTemplateKinds templateKind)
        {
            mobiles = (mobiles ?? Enumerable.Empty<string>()).Where(m => !String.IsNullOrWhiteSpace(m)).Distinct().ToArray();
            if (mobiles.Length == 0)
                throw new ExceptionWithErrorCode(ErrorCode.输入的数据格式错误, "手机号码不能为空");
            using (var provider = _PushServiceChannelProvider.NewChannelProvider())
            {
                provider.Channel.SmsPushTemplateMessage(new Api.OAuth2ClientIdentity(), new PushService.SmsPushTemplateMessageRequest()
                {
                    TemplateKind = templateKind,
                    Values = values
                }, new SmsTargets
                {
                    Mobiles = mobiles
                });
            }
        }
        public void SendSms(int templateId, string[] mobiles, Dictionary<string, string> values,string signName)
        {
            ExceptionHelper.ThrowIfNotId(templateId, "templateId");
            mobiles = (mobiles ?? Enumerable.Empty<string>()).Where(m => !String.IsNullOrWhiteSpace(m)).Distinct().ToArray();
            if (mobiles.Length == 0)
                throw new ExceptionWithErrorCode(ErrorCode.输入的数据格式错误, "手机号码不能为空");
            using (var provider = _PushServiceChannelProvider.NewChannelProvider())
            {
                provider.Channel.SmsPushTemplateMessageV2(new Api.OAuth2ClientIdentity(), new PushService.SmsPushTemplateMessageRequestV2()
                {
                    TemplateId = templateId,
                    Values = values,
                    SignName = signName
                }, new SmsTargets
                {
                    Mobiles = mobiles
                });
            }
        }
    }
}
