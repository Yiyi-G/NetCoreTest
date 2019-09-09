using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Models
{
    public class UpdateStudentInfoModel
    {
        public string Name { get; set; }
        public Tgnet.FootChat.User.UserSex? Sex { get; set; }
        public string WeChat { get; set; }
        public string Products { get; set; }
        public string Company { get; set; }
        public string Job { get; set; }
        public string BussinessAreas { get; set; }
        public int? YearOfWorking { get; set; }
        public string StageNos { get; set; }
        public string NeedCustomSource { get; set; }
        public string NeedCooperateProduct { get; set; }
        public double? LastYearAchievement { get; set; }
        public double? ThisYearGoal { get; set; }
        public string NecessaryDoTypes { get; set; }

        public void Convert()
        {
            if (!string.IsNullOrWhiteSpace(StageNos))
            {
                var stageNos = StageNos.SplitTo();
                StageNos =string.Join(",",stageNos.Where(p => !string.IsNullOrWhiteSpace(p)).Select(p => p.Trim()));
            }
            if (!string.IsNullOrWhiteSpace(NecessaryDoTypes))
            {
                var necessaryDoTypes = NecessaryDoTypes.SplitTo().Select(p => (byte)Enum.Parse(typeof(StudentNecessaryDoType), p));
                NecessaryDoTypes = string.Join(",", necessaryDoTypes);
            }

        }
    }
    //Tgnet.FootChat.Models.StudentNecessaryDoType
    public enum StudentNecessaryDoType:byte
    {
        [Description("强化技能")]
        AbilityStrengthen = 1,
        [Description("提升效率")]
        UpEfficiancy = 2,
        [Description("拓展人脉")]
        ExtendFriend = 3,
        [Description("积累客户")]
        AccumulateCustomer = 4,
        [Description("加入组织")]
        JoinGroup = 5,
        [Description("参加培训")]
        AttendTrain = 6,
        [Description("加强合作")]
        StrengthenCooperation = 7,
        [Description("挖掘关系")]
        DigRelation = 8,
        [Description("借助工具")]
        UseTool = 9,
        [Description("收集信息")]
        CollectMsg = 10
    }
}
