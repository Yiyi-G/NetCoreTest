using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.InstitudeOfGrowth
{
    //Tgnet.FootChat.InstitudeOfGrowth.ClassCommitteeType
    public enum ClassCommitteeType : byte
    {
        [Description("班长")]
        Monitor = 0,
        [Description("活动委")]
        ActivityCommittee = 1,
        [Description("宣传委")]
        Promoter = 2,
        [Description("导师")]
        Tutor = 3,
    }
}
