using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.InstitudeOfGrowth
{
    public enum StudentStatus : byte
    {
        [Description("未支付")]
        Unpaid = 0,
        [Description("已支付")]
        Paid = 1,
        [Description("已退款")]
        Refunded = 2,
        [Description("已分班")]
        Divided = 3,
        [Description("未分班")]
        WaitingToBeDivided = 4,
        [Description("已毕业")]
        Graduated = 5,
    }
}
