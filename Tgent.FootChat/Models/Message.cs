using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class Message
    {
        public string id { get; set; }
        public long sender { get; set; }
        public long receiver { get; set; }
        public long sessionId { get; set; }
        public string contentType { get; set; }
        public string content { get; set; }
        public long timestamp { get; set; }
        public string msgType { get; set; }
        public bool byUser { get; set; }
    }
}
