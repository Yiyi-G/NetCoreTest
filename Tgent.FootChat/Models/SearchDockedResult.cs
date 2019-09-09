using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class SearchDockedResult
    {
        public long fid { get; set; }
        public long sender { get; set; }
        public long receiver { get; set; }
        public Tgnet.FootChat.Docked.DockedStatus status { get; set; }
        public DateTime created { get; set; }
        public string message { get; set; }
        public int total { get; set; }
    }
}
