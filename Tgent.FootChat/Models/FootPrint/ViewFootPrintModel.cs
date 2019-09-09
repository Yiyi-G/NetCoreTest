using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models.FootPrint
{
    public class ViewFootPrintModel
    {
        public long Fid { get; set; }
        public long Pid { get; set; }
        public long Uid { get; set; }
        public DateTime ViewDate { get; set; }
        public bool IsEnable { get; set; }
    }
}
