using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Events
{
    public class PushMessage
    {
        [Newtonsoft.Json.JsonProperty(PropertyName ="content")]
        public string Content { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
