using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity.Core;
using Tgnet.FootChat.Models.SqlQueryModel;

namespace Tgnet.FootChat.Data
{
    public interface IFootChatUserRepository : IRepository<Data.FootUser>
    {
        Dictionary<int, int> GetTodayPerHourRegisterNum(DateTime? time);
        Dictionary<int, int> GetTodayPerHourVerifiedNum(DateTime? time);
        Dictionary<int, int> GetThisWeekRegisterNum();
        Dictionary<int, int> GetThisWeekVerifiedUserNum();
        Dictionary<int, int> GetThisMontRegisterNum();
        Dictionary<int, int> GetThisMonthVerifiedUserNum();
        Dictionary<int, int> GetThisYearRegisterNum();
        Dictionary<int, int> GetThisYearVerifiedUserNum();
        Dictionary<int, int> GetRangeTimeRegisterNum(DateTime startTime, DateTime endTime);
        Dictionary<int, int> GetRangeTimeVerifiedUserNum(DateTime startTime, DateTime endTime);
        FootUserStatistics GetFootUserStatistics(DateTime date);
        UserInfo[] GetUserInfo(long[] uids);
    }
    public class FootChatUserRepository : BaseRepository<Data.FootUser>, IFootChatUserRepository
    {
        public FootChatUserRepository(FootChatContext context) : base(context)
        {
        }

        //今天每个小时注册的用户数
        public Dictionary<int, int> GetTodayPerHourRegisterNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND fu.created>='" + startTime + "' AND fu.created<'" + endTime + @"'
AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(hh,created)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DateDiff(dd,created,GETDATE())=0
AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(hh,created)";
            }           
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }

        //今天每个小时的认证用户数
        public Dictionary<int, int> GetTodayPerHourVerifiedNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,verifyDate) as hour,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND fu.verifyDate>='" + startTime + "' AND fu.verifyDate<'" + endTime + @"'
AND fu.verifyStatus=1 AND DATEPART(YEAR,verifyDate)=year(getdate())
GROUP BY DATEPART(hh,verifyDate)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,verifyDate) as hour,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DateDiff(dd,verifyDate,GETDATE())=0
AND fu.verifyStatus=1 AND DATEPART(YEAR,verifyDate)=year(getdate())
GROUP BY DATEPART(hh,verifyDate)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }

        //本周注册用户数
        public Dictionary<int, int> GetThisWeekRegisterNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DateDiff(WEEK,created,getdate())=0
AND DATEPART(YEAR,created)=year(getdate()) 
GROUP BY DATEPART(dd,created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本周认证用户数
        public Dictionary<int, int> GetThisWeekVerifiedUserNum()
        {
            string sql = @"SELECT DATEPART(dd,verifyDate) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DateDiff(WEEK,verifyDate,getdate())=0
AND fu.verifyStatus=1 AND DATEPART(YEAR,verifyDate)=year(getdate()) 
GROUP BY DATEPART(dd,verifyDate)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月注册用户数
        public Dictionary<int, int> GetThisMontRegisterNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DateDiff(MONTH,created,getdate())=0 
AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(dd,created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月认证用户数
        public Dictionary<int, int> GetThisMonthVerifiedUserNum()
        {
            string sql = @"SELECT DATEPART(dd,verifyDate) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DateDiff(MONTH,verifyDate,getdate())=0 
AND fu.verifyStatus=1 AND DATEPART(YEAR,verifyDate)=year(getdate())
GROUP BY DATEPART(dd,verifyDate)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //获取本年的注册用户数
        public Dictionary<int, int> GetThisYearRegisterNum()
        {
            string sql = @"SELECT DATEPART(mm,created) as month,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(mm,created)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //获取本年的认证用户数
        public Dictionary<int, int> GetThisYearVerifiedUserNum()
        {
            string sql = @"SELECT DATEPART(mm,verifyDate) as month,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND fu.verifyStatus=1 AND DATEPART(YEAR,verifyDate)=year(getdate())
GROUP BY DATEPART(mm,verifyDate)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //获取时间段的注册用户数
        public Dictionary<int, int> GetRangeTimeRegisterNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DATEPART(YEAR,created)=year(getdate()) 
AND fu.created>='" + startTime + "' AND fu.created< '" + endTime + @"' 
GROUP BY DATEPART(dd,created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //获取时间段的认证用户数
        public Dictionary<int, int> GetRangeTimeVerifiedUserNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,verifyDate) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE 1=1
AND DATEPART(YEAR,verifyDate)=year(getdate()) 
AND fu.verifyStatus=1 AND fu.created>='" + startTime + "' AND fu.created< '" + endTime + @"' 
GROUP BY DATEPART(dd,verifyDate)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        public FootUserStatistics GetFootUserStatistics(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"WITH FootUserDeadTable
AS
(
	select uid,created,verifyStatus,verifyDate   from FootChat.dbo.FootUser fu WITH(NOLOCK) 
	WHERE fu.isInner=0
)
select  
sum(case when FootUserDeadTable.created<'" + endTime + @"' then 1 else 0 end ) AS totalCount,
sum(case when FootUserDeadTable.created>='" + startTime + "' AND FootUserDeadTable.created<'" + endTime + @"' then 1 else 0 end )as todayCreatedCount,
sum(case when FootUserDeadTable.verifyStatus=1 AND FootUserDeadTable.verifyDate<'" + endTime + @"' then 1 else 0 end ) AS verifiedCount,
sum(case when FootUserDeadTable.verifyDate>='" + startTime + "' AND FootUserDeadTable.verifyDate<'" + endTime + @"' AND FootUserDeadTable.verifyStatus=1 then 1 else 0 end ) AS todayPassCount,
sum(case when FootUserDeadTable.verifyDate>= '" + startTime + "' AND FootUserDeadTable.verifyDate<'" + endTime + @"' AND FootUserDeadTable.verifyStatus=2 then 1 else 0 end ) AS todayUnPassCount
from FootUserDeadTable";
            return Context.Database.SqlQuery<FootUserStatistics>(sql).First();
        }

        public UserInfo[] GetUserInfo(long[] uids)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (uids.Length == 0) return new UserInfo[0];
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fu.uid"); 
            column.Add("fu.mobile ");
            column.Add("fu.name ");
            column.Add("fu.sex ");
            column.Add("fu.job ");
            column.Add("fu.verifyStatus ");
            column.Add("fu.cover ");
            column.Add("fu.submiVerifytDate ");
            column.Add("fu.isNeedVerify ");
            column.Add("fu.company");
            builder.AppendFormat("select {0} from FootChat.dbo.FootUser fu with(nolock)", string.Join(",", column));
            builder.AppendFormat(" where fu.uid in ({0})  ", string.Join(",", uids));
            return Context.Database.SqlQuery<Models.SqlQueryModel.UserInfo>(builder.ToString()).ToArray();
        }
    }

    public class FootUserStatistics
    {
        public int totalCount { get; set; }//用户总数
        public int todayCreatedCount { get; set; }//用户每日新增
        public int verifiedCount { get; set; }//认证人数（通过与不通过）
        public int todayPassCount { get; set; }//当天认证通过数
        public int todayUnPassCount { get; set; }//当天认证不通过数
    }
}
