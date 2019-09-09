using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Model
{
    public class UpdateFootPrintModel
    {
        public long? Pid { get; set; }
        public long? Fid { get; set; }
        public string Address { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Content { get; set; }
        public FootImageInfo[] Images { get; set; }
        public string ProjName { get; set; }
        public long[] TagId { get; set;}
    }

    public class FootImageInfo
    {
        public string ImageKey { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public DateTime? PhotoTime { get; set; }
        public string Address { get; set; }
    }
}
