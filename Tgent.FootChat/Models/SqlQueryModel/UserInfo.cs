using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models.SqlQueryModel
{
    public class UserInfo
    {
        public long uid { get; set; }
        public string mobile { get; set; }
        public string name { get; set; }
        public Nullable<Tgnet.FootChat.User.UserSex> sex { get; set; }
        public string job { get; set; }
        public Tgnet.FootChat.User.VerifyStatus verifyStatus { get; set; }
        public string cover { get; set; }
        public string company { get; set; }
        public Nullable<System.DateTime> submiVerifytDate { get; set; }
        public bool isNeedVerify { get; set; }

    }
}
