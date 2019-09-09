using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Model
{
    public class UserAddressBookMobileModel
    {
        public long uid { get; set; }
        public string mobile { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public bool haveRecommended { get; set; }
        public long? tguid { get; set; }
        public bool isAttention { get; set; }
        public int? verifyCount { get; set; }
        public int? footPrintCount { get; set; }
    }
}
