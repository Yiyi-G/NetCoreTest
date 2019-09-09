using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Weixin
{
    public interface IWeixinManager
    {
        void Bind(string app, string openId, long tgUid);
    }
    public class WeixinManager: IWeixinManager
    {
        private readonly IChannelProviderService<WeixinService.IWeixinService> _WeixinServiceProvider;
        public WeixinManager(IChannelProviderService<WeixinService.IWeixinService> weixinServiceProvider)
        {
            _WeixinServiceProvider = weixinServiceProvider;
        }

        public void Bind(string app, string openId, long tgUid)
        {
            using (var provider = _WeixinServiceProvider.NewChannelProvider())
            {
                provider.Channel.AccountBinding(new Api.OAuth2ClientIdentity(), app, openId, tgUid);
            }
        }
    }
}
