using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models.SqlQueryModel
{
    class ProjFootPrint
    {
        public long Uid { get; set; }
        public long Pid { get; set; }
        public long Fid { get; set; }
        public string Address { get; set; }
        public DateTime? Updated { get; set; }
        public int Total { get; set; }
    }
}
