using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Trade
{
    //Tgnet.FootChat.Trade.Payment
    public enum Payment : byte
    {
        [Description("")]
        None = 0,
        [Description("支付宝")]
        AliPay = 1,
        [Description("微信")]
        Weixin = 2,
        [Description("Bill")]
        Bill = 3,
        /// <summary>
        /// 苹果支付
        /// </summary>
        [Description("苹果支付")]
        IAP = 4,
        /// <summary>
        /// 现金支付
        /// </summary>
        [Description("现金")]
        Cash = 5,
        /// <summary>
        /// 企业用劵
        /// </summary>
        [Description("企业用劵")]
        CorporateCoupons = 6,
        /// <summary>
        /// 银行汇款:企业建行
        /// </summary>
        [Description("企业建行")]
        BankCCB = 31,
        /// <summary>
        /// 银行汇款:企业工行
        /// </summary>
        [Description("企业工行")]
        BankICBC = 32,
        /// <summary>
        /// 个人建行
        /// </summary>
        [Description("个人建行")]
        BankCCBPersonal = 33,
        /// <summary>
        /// 个人工行
        /// </summary>
        [Description("个人工行")]
        BankICBCPersonal = 34,
        /// <summary>
        /// 个人农行
        /// </summary>
        [Description("个人农行")]
        BankABChinaPersonal = 35,
        /// <summary>
        /// 余额支付
        /// </summary>
        [Description("余额支付")]
        Balance = 250,
    }
}
