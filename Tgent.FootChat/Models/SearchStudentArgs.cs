using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;
using Tgnet.FootChat.InstitudeOfGrowth;

namespace Tgnet.FootChat.Models
{
    public class SearchStudentArgs
    {
        public string Name { get; set; }//姓名
        public string Mobile { get; set; }//手机
        public string Wechat { get; set; }//微信
        public StudentStatus? StuStatus { get; set; }//支付状态或分班情况
        public long? ClassId { get; set; }//班级id
        public bool IsSignUpList { get; set; }//是否报名列表

        public void VerifySearchStudentArgs()
        {
            if (StuStatus.HasValue)
            {
                ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(StudentStatus), StuStatus.Value), "StuStatus", "值不在范围内");
            }
            if (ClassId.HasValue)
            {
                ExceptionHelper.ThrowIfNotId(ClassId.Value,nameof(ClassId.Value));
            }
        }
    }
}
