using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class SearchStudentResult
    {
        public long uid { get; set; }
        public string name { get; set; }
        public string weChat { get; set; }
        public string bussinessAreas { get; set; }
        public DateTime created { get; set; }
    }
}
