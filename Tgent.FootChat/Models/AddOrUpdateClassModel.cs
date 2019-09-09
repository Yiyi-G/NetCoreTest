using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class AddOrUpdateClassModel
    {
        public string Name { get; set; }//班级名称
        public DateTime StartDate { get; set; }//开始时间
        public DateTime EndDate { get; set; }//结束时间
        public string Property { get; set; }//班级属性
    }
}
