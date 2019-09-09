using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Model
{
    public class UpdateUserInfoModel
    {
        public string Name { get; set; }
        public string AreaNo { get; set; }
        public UserSex? Sex { get; set; }
        public string Company { get; set; }
        public string Job { get; set; }
        public string VerifyImage { get; set; }
       
    }
}
