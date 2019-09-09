using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.FCRMAPI.Request
{
    public class Contact
    {
        
        [JsonProperty(PropertyName = "aid")]
        public long Aid { get; set; }
        [JsonProperty(PropertyName = "mobile")]
        public string Mobile { get; set; }
    }
}
