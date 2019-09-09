using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.InstitudeOfGrowth
{
    public enum InsOfGrowthPayState : byte
    {
        [Description("未支付")]
        Unpaid = 0,
        [Description("已支付")]
        Paid = 1,
        [Description("已退款")]
        Refunded = 2,
    }
}
