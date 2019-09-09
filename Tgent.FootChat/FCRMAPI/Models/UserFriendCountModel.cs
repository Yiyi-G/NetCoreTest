using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.FCRMAPI.Models
{
    public class UserFriendCountModel
    {
    
       [JsonProperty(PropertyName = "level1")]
       public int AddressBookFrindCount { get; set; }
        [JsonProperty(PropertyName = "level2")]
        public int IndirectFriendCount { get; set; }
    }

    public class UserFriendCountBody
    {
        [JsonProperty(PropertyName = "body")]
        public UserFriendCountModel Body { get; set; }
    }
}
