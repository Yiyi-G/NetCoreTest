using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.FCRMAPI
{
    public class Response<T>
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }
        [JsonProperty(PropertyName = "body")]
        public T Body { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }

    public class Response
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }
        [JsonProperty(PropertyName = "body")]
        public object Body { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
