using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet;
using Tgnet.Api;
using Tgnet.FootChat.PayService;
using Tgnet.FootChat.User;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Pay
{
    public interface IPayManager
    {
        string GetProductKeyFromTime(PayServiceKinds kind, int time);
        int GetProductTime(string productKey);
        ProductResult GetProducts(long uid, Dictionary<string, string> extension);
        void ApplyInvoice(string tradeNo, long @operator);
        string CreateAppPayInfo(string access_token, long uid, int type, int time, int quantity);
        string GetWebPayUrl(string access_token, long uid, int type, int time, PayServiceKinds kind, int quantity, bool isH5, bool isWeixinClient, PayFromKinds from, string scene_info);
        OrderModel Remittance(PayService.RemittanceModel request);
    }
    class PayManager : IPayManager
    {
        private const string PRODUCT_FOOTCHAT_SERVICE_6MONTH = "tgnet.pay.products.footchatservice6month";
        private const string PRODUCT_FOOTCHAT_SERVICE_12MONTH = "tgnet.pay.products.footchatservice12month";
        private const string PRODUCT_GROWTH_APPLY = "tgnet.pay.products.growthapplyservice";
        private readonly IChannelProviderService<PayService.IPayService> _PayServiceChannelProvider;
        public PayManager(IChannelProviderService<PayService.IPayService> payServiceChannelProvider)
        {
            _PayServiceChannelProvider = payServiceChannelProvider;
        }
        public int GetProductTime(string productKey)
        {
            switch (productKey.ToLower())
            {
                case PRODUCT_FOOTCHAT_SERVICE_6MONTH:
                    return 6;
                case PRODUCT_FOOTCHAT_SERVICE_12MONTH:
                    return 12;
                default:
                    throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目, "未定义的类型");
            }
        }
        public string GetProductKeyFromTime(PayServiceKinds kind, int time)
        {
            switch (kind)
            {
                case PayServiceKinds.InstitudeOfGrowth:
                    return PRODUCT_GROWTH_APPLY;
                case PayServiceKinds.FootChat:
                    {
                        switch (time)
                        {
                            case 6:
                                return PRODUCT_FOOTCHAT_SERVICE_6MONTH;
                            case 12:
                                return PRODUCT_FOOTCHAT_SERVICE_12MONTH;
                            default:
                                throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目, "未定义的类型");
                        }
                    }
                default:
                    throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目, "未定义的类型");
            }
        }
        public ProductResult GetProducts(long uid, Dictionary<string, string> extension)
        {
            var products = new string[]
            {
                PRODUCT_FOOTCHAT_SERVICE_6MONTH,
                PRODUCT_FOOTCHAT_SERVICE_12MONTH
            };
            var result = new ProductResult();
            using (var provider = _PayServiceChannelProvider.NewChannelProvider())
            {
                result.Products = provider.Channel.GetProducts(new OAuth2ClientIdentity(), products, null, extension);
            }
            return result;
        }
        public void ApplyInvoice(string tradeNo, long @operator)
        {
            if (String.IsNullOrWhiteSpace(tradeNo)) return;
            tradeNo = tradeNo.Trim();
            using (var provider = _PayServiceChannelProvider.NewChannelProvider())
            {
                provider.Channel.UpdateInvoiceState(new OAuth2ClientIdentity(), @operator, tradeNo, PayService.InvoiceStates.Apply, "用户申请发票");
            }
        }
        public string CreateAppPayInfo(string access_token, long uid, int type, int time, int quantity)
        {
            ExceptionHelper.ThrowIfNotId(uid, "uid");
            ExceptionHelper.ThrowIfTrue(quantity < 1, "quantity", "quantity < 1");
            if (String.IsNullOrWhiteSpace(access_token))
                throw new ExceptionWithErrorCode(ErrorCode.未登录);

            var productKey = GetProductKeyFromTime(PayServiceKinds.FootChat, time);

            var queries = new List<string>();
            queries.Add("product=" + productKey);
            queries.Add("quantity=" + quantity.ToString());
            queries.Add("type=" + type.ToString());
            queries.Add("uid=" + uid.ToString());
            queries.Add("access_token=" + access_token);
            queries.Add("extension=" + System.Web.HttpUtility.UrlEncode(JsonConvert.SerializeObject(new { app = 2 }), Encoding.UTF8));

            var url = "http://api.pay.tgnet.com/mobile/order/create?" + String.Join("&", queries);
            var grab = new Web.HttpRequestGrab();
            var responce = grab.GetContent(url, null);

            return responce;
        }

        public string GetWebPayUrl(string access_token, long uid, int type, int time, PayServiceKinds kind, int quantity, bool isH5, bool isWeixinClient, PayFromKinds from, string scene_info)
        {
            ExceptionHelper.ThrowIfNotId(uid, "uid");
            ExceptionHelper.ThrowIfTrue(quantity < 1, "quantity", "quantity < 1");
            var productKey = GetProductKeyFromTime(kind, time);

            var queries = new List<string>();
            queries.Add("product=" + productKey);
            queries.Add("quantity=" + quantity.ToString());
            queries.Add("type=" + type.ToString());
            queries.Add("uid=" + uid.ToString());
            queries.Add("access_token=" + access_token);
            queries.Add("from_kind=" + from.To<byte>().ToString());
            if (isH5)
            {
                queries.Add("h5=1");
            }
            if (isWeixinClient)
            {
                queries.Add("payment=jsapi");
            }
            if (!String.IsNullOrWhiteSpace(scene_info))
            {
                queries.Add("extension=" + System.Web.HttpUtility.UrlEncode(JsonConvert.SerializeObject(new { scene_info = scene_info }), Encoding.UTF8));
            }
            var url = "http://api.pay.tgnet.com/order/create?" + String.Join("&", queries);
            if (type == 1 && isWeixinClient)
            {
                url = "http://api.weixin.tgnet.com/token/getopenid?appid=wxc72923937e510ab4&redirect_uri=" + System.Web.HttpUtility.UrlEncode(url);
            }
            return url;
        }

        public OrderModel Remittance(PayService.RemittanceModel request)
        {
            using (var provider = _PayServiceChannelProvider.NewChannelProvider())
            {
                return provider.Channel.Remittance(new Api.OAuth2ClientIdentity(), request);
            }
        }
    }
    public enum PayServiceKinds : byte
    {
        FootChat = 0,
        InstitudeOfGrowth = 1
    }
}
