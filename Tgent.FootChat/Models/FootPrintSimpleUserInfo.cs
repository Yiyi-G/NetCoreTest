using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Models
{
    public interface IFootPrintSimpleUserInfo:ISimpleUserInfo
    {
        long Fid { get;  }
        bool ForceHideMobile { get; set; }
    }
    public class FootPrintSimpleUserInfo : IFootPrintSimpleUserInfo
    {
        public UserDisplayKind Kind { get; set; }

        public long Uid { get; internal set; }
        public UserSex? Sex { get; internal set; }
        private string _UserName;
        public string UserName
        {
            get
            {
                if (ForceShowName || IsSelf)
                    return _UserName;
                else
                    return Utility.HideUserName(_UserName, Sex);
            }
            internal set
            {
                _UserName = (value ?? "").Trim();
            }
        }

        private string _Mobile;
        public string Mobile
        {
            get
            {
                if (ForceShowMobile)
                    return _Mobile;
                if(ForceHideMobile)
                    return Utility.GetHiddenTel(_Mobile);
                switch (Kind)
                {
                    case UserDisplayKind.HideInfo:
                        return Utility.GetHiddenTel(_Mobile);
                    case UserDisplayKind.OnlyHideOrtherInfo:
                        return IsSelf ? _Mobile : Utility.GetHiddenTel(_Mobile);
                    default:
                        return _Mobile;
                }
            }
            internal set
            {
                _Mobile = (value ?? "").Trim();
            }
        }

        public bool IsSelf { get; set; }

        public VerifyState VerifyState { get; internal set; }
        public bool ForceShowName { get; set; }
        public bool ForceShowMobile { get; set; }

        public string Job { get; internal set; }

        public string Corver { get; internal set; }
        public string Company { get; internal set; }

        public long Fid   { get; internal set; }
        public bool ForceHideMobile { get; set; }
    }
}
