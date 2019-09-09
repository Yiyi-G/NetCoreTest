using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class RangeStatistics
    {
        public string type { get; set; }
        public StatisticalItem[] item { get; set; }
        public RangeStatistics()
        {
            item = new StatisticalItem[0];
        }
    }
}
