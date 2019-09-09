using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.FCRMAPI.Models
{
    public  class RecommenedFootPrinModel
    {
        [JsonProperty(PropertyName = "fid")]
        public long? Fid { get; set; }
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }
        [JsonProperty(PropertyName = "uid")]
        public int? Uid { get; set; }
        [JsonProperty(PropertyName = "isCollect")]
        public bool? IsCollect { get; set; }
    }

    public class RecommenedFootPrinPageModel
    {
        public int Total { get; set; }
        public RecommenedFootPrinModel[] FootPointList { get; set; }
    }

    public class RecommenedFootPrinResultData
    {
        public RecommenedFootPrinPageModel Body { get; set; }
    }
}
