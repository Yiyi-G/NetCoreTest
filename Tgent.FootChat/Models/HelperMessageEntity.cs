using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tgnet.Core;

namespace Tgnet.FootChat.Models
{
    public class HelperMessageEntity
    {
        public string HMID { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public long SendUserID { get; set; }
        public string SendUserName { get; set; }
        public long ReceiveUserID { get; set; }
        public string ReceiveUserName { get; set; }
        public long UserID { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime PubDate { get; set; }
        public bool IsReplied { get; set; }
        public string ReadyContent
        {
            get
            {
                switch (Type)
                {
                    case "voice/json":
                        string reg = "(?<=\\[\")[^\"]+";
                        return Regex.Match(Content, reg).ToString();
                    default:
                        return Content;
                }
            }
        }

        public int VoiveLength
        {
            get
            {
                switch (Type)
                {
                    case "voice/json":
                        string reg = "(?<=\",)\\d+";
                        return Regex.Match(Content, reg).ToString().To<int>() / 1000;
                    default:
                        return 0;
                }
            }
        }
    }
}
