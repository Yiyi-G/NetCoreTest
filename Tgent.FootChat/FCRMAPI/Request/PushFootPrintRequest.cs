using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;

namespace Tgnet.FootChat.FCRMAPI.Request
{
    public class PushFootPrintRequest
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "pid")]
        public long Fid { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName ="pid")]
        public long Pid { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "uid")]
        public long Uid { get; set; }
        /// <summary>
        /// 初始热度
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scoreType")]
        public int ScopeType { get; set; }
        /// <summary>
        /// 国家级别代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "countryNo")]
        public string CountryNo { get; set; }
        /// <summary>
        /// 省级别代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provinceNo")]
        public string ProvinceNo { get; set; }

        /// <summary>
        /// 市级别代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cityNo")]
        public string CityNo { get; set; }

        /// <summary>
        /// 区级别代码
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "areaNo")]
        public string AreaNo { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        public void CheckPropertyIsVaild()
        {
            ExceptionHelper.ThrowIfTrue(Fid <= 0, "pid必须大于0");
            ExceptionHelper.ThrowIfTrue(Pid <= 0, "pid必须大于0");
            ExceptionHelper.ThrowIfTrue(Uid <= 0, "Uid必须大于0");

        }

    }
}
