using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.InstitudeOfGrowth;

namespace Tgnet.FootChat.Models
{
    public class StuClassInfo
    {
        public long ClassId { get; set; }//班级id
        public string ClassName { get; set; }//班级名称
        public System.DateTime StartDate { get; set; }//班级开始时间
        public System.DateTime EndDate { get; set; }//班级结束时间
        public string Property { get; set; }//班级属性
        public bool IsEnable { get; set; }//班级是否有效
        public ClassCommitteeType? ClassCommittee { get; set; }//班委
    }
}
