using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Trade
{
    [DataContract]
   public class TradeExtension
    {
        [DataMember]
        public string[] areaNos { get; set; }
        [DataMember]
        public TimeSpan timeSpan { get; set; }
        [DataMember]
        public string[] typeNos { get; set; }
    }
}
