using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class StatisticalItem
    {
        public string Name { get; set; }
        public Dictionary<int, int> NumDict { get; set; }
    }
}
