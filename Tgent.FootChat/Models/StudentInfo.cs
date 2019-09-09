using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Models
{
    public class StudentInfo
    {
        public long Uid { get; set; }
        public string Name { get; set; }
        public string WeChat { get; set; }
        public string BussinessAreas { get; set; }
        public DateTime Created { get; set; }
        public StudentInfo(Student s)
        {
            Uid = s.uid;
            Name = s.name;
            WeChat = s.weChat;
            BussinessAreas = s.bussinessAreas;
            Created = s.created;
        }
    }
}
