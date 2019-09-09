using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity.Core;
using Tgnet.FootChat.Models;

namespace Tgnet.FootChat.Data
{
    public interface IStudentRepository : IRepository<Data.Student>
    {
        PageModel<SearchStudentResult> SearchStudent(SearchStudentArgs args, int start, int limit);
        int GetWaitingToBeDividedNum();
    }

    public class StudentRepository : BaseRepository<Data.Student>, IStudentRepository
    {
        public StudentRepository(FootChatContext context) : base(context)
        {
        }

        public PageModel<SearchStudentResult> SearchStudent(SearchStudentArgs args, int start, int limit)
        {
            ExceptionHelper.ThrowIfTrue(limit <= 0, "limit");
            var parameters = new Dictionary<String, String>();
            var sbTableWithWhere = new StringBuilder();
            sbTableWithWhere.Append(@"FootChat.dbo.Student stu WITH(NOLOCK) WHERE 1=1 ");
            if (!string.IsNullOrWhiteSpace(args.Name))
            {
                //姓名
                sbTableWithWhere.Append(" AND stu.name Like @name ");
                parameters.Add("name", "" + args.Name.Trim() + "%");
            }
            if (!string.IsNullOrWhiteSpace(args.Mobile))
            {
                //手机
                sbTableWithWhere.Append(" AND EXISTS(select 1 from FootChat.dbo.FootUser fu WITH(NOLOCK) where stu.uid=fu.uid and fu.mobile Like @mobile) ");
                parameters.Add("mobile", "" + args.Mobile.Trim() + "%");
            }
            if (!string.IsNullOrWhiteSpace(args.Wechat))
            {
                //微信
                sbTableWithWhere.Append(" AND stu.weChat Like @wechat ");
                parameters.Add("wechat", "" + args.Wechat.Trim() + "%");
            }
            if (!args.IsSignUpList)
            {
                sbTableWithWhere.Append(" AND EXISTS(select 1 from FootChat.dbo.InstitudeOfGrowthTrade trade WITH(NOLOCK) where trade.isPaied=1 and trade.uid=stu.uid) ");
            }
            if (args.StuStatus.HasValue)
            {
                if (args.StuStatus.Value == InstitudeOfGrowth.StudentStatus.Paid)
                {
                    //已付费
                    sbTableWithWhere.Append(" AND EXISTS(select 1 from FootChat.dbo.InstitudeOfGrowthTrade trade WITH(NOLOCK) where trade.isPaied=1 and trade.uid=stu.uid) ");
                }
                if (args.StuStatus.Value == InstitudeOfGrowth.StudentStatus.Unpaid)
                {
                    //未付费
                    sbTableWithWhere.Append(" AND NOT EXISTS(select 1 from FootChat.dbo.InstitudeOfGrowthTrade trade WITH(NOLOCK) where trade.isPaied=1 and trade.uid=stu.uid) ");
                }
                if (args.StuStatus.Value == InstitudeOfGrowth.StudentStatus.Refunded)
                {
                    //已退款
                }
                if (args.StuStatus.Value == InstitudeOfGrowth.StudentStatus.Divided)
                {
                    //已分班
                    sbTableWithWhere.Append(" AND EXISTS(select 1 from FootChat.dbo.ClassStuRelation csr WITH(NOLOCK) where csr.uid=stu.uid) ");
                }
                if (args.StuStatus.Value == InstitudeOfGrowth.StudentStatus.WaitingToBeDivided)
                {
                    //未分班
                    sbTableWithWhere.Append(" AND NOT EXISTS(select 1 from FootChat.dbo.ClassStuRelation csr WITH(NOLOCK) where csr.uid=stu.uid) ");
                }
                if (args.StuStatus.Value == InstitudeOfGrowth.StudentStatus.Graduated)
                {
                    //已毕业
                    var now = DateTime.Now;
                    sbTableWithWhere.Append(@" AND EXISTS(select 1 from FootChat.dbo.ClassStuRelation csr WITH(NOLOCK) where csr.uid=stu.uid 
                    AND EXISTS(select 1 from FootChat.dbo.Class c WITH(NOLOCK) where c.endDate < '"+now+"' and c.classId = csr.classId)) ");
                }
            }
            if (args.ClassId.HasValue)
            {
                sbTableWithWhere.Append(" AND EXISTS(select 1 from FootChat.dbo.ClassStuRelation csr WITH(NOLOCK) where csr.classId="+args.ClassId.Value+" AND csr.uid=stu.uid) ");
            }
            var orderBy = " stu.created desc";
            var sql = SqlUtility.GetPageLimitSql(start: start, limit: limit, columns: "uid,name,weChat,bussinessAreas,created", tableWithWhere: sbTableWithWhere.ToString(), orderBy: orderBy);
            var model = new PageModel<SearchStudentResult>();
            model.Models = GetItems<SearchStudentResult>(sql, parameters);
            model.Count = GetCount(sbTableWithWhere.ToString(), parameters);
            return model;
        }

        public int GetWaitingToBeDividedNum()
        {
            string sql = @"select count(distinct trade.uid) from FootChat.dbo.InstitudeOfGrowthTrade trade WITH(NOLOCK)
left join FootChat.dbo.ClassStuRelation csr WITH(NOLOCK)
on trade.uid = csr.uid
where trade.isPaied=1 and csr.uid is null";
            return Context.Database.SqlQuery<int>(sql).First();
        }
    }
}
