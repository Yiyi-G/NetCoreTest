using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity.Core;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Data
{
    public interface IUserServiceStateRepository : IRepository<Data.FootCharUserServiceState>
    {
        Dictionary<int, int> GetTodayPerHourPaidUserNum(DateTime? time);
        Dictionary<int, int> GetThisWeekPaidUserNum();
        Dictionary<int, int> GetThisMontPaidUserNum();
        Dictionary<int, int> GetThisYearPaidUserNum();
        Dictionary<int, int> GetRangeTimePaidUserNum(DateTime startTime, DateTime endTime);
        UserServiceStateStatistics GetUserServiceStateStatistics(DateTime date);
        long[] GetWillOrExipredUid(User.UserServiceLevel level, int day);
        Dictionary<long, DateTime> GetUserExipired(long[] uids);

    }
    public class UserServiceStateRepository : BaseRepository<FootCharUserServiceState>, IUserServiceStateRepository
    {
        public UserServiceStateRepository(FootChatContext context) : base(context)
        {
        }

        //今天24小时每小时付费用户数
        public Dictionary<int, int> GetTodayPerHourPaidUserNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,updated) as hour,count(1) as count from FootChat.dbo.UserServiceState us WITH(NOLOCK) WHERE 1=1 AND us.level=2
AND us.updated>='" + startTime + "' AND us.updated<'" + endTime + @"'
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(hh,updated)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,updated) as hour,count(1) as count from FootChat.dbo.UserServiceState us WITH(NOLOCK) WHERE 1=1 AND us.level=2
AND DateDiff(dd,updated,GETDATE())=0
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(hh,updated)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }


        //本周每天付费用户数
        public Dictionary<int, int> GetThisWeekPaidUserNum()
        {
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.UserServiceState us WITH(NOLOCK) WHERE 1=1 AND us.level=2
AND DateDiff(WEEK,updated,getdate())=0
AND DATEPART(YEAR,updated)=year(getdate()) 
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月每天付费用户数
        public Dictionary<int, int> GetThisMontPaidUserNum()
        {
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.UserServiceState us WITH(NOLOCK) WHERE 1=1 AND us.level=2
AND DateDiff(MONTH,updated,getdate())=0 
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }


        //本年每月付费用户数
        public Dictionary<int, int> GetThisYearPaidUserNum()
        {
            string sql = @"SELECT DATEPART(mm,updated) as month,count(1) as count from FootChat.dbo.UserServiceState us WITH(NOLOCK) WHERE 1=1 AND us.level=2
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(mm,updated)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //获取时间段的付费用户数
        public Dictionary<int, int> GetRangeTimePaidUserNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.UserServiceState us WITH(NOLOCK) WHERE 1=1 AND us.level=2
AND DATEPART(YEAR,updated)=year(getdate()) 
AND us.updated>='" + startTime + "' AND us.updated< '" + endTime + @"' 
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        public UserServiceStateStatistics GetUserServiceStateStatistics(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            string sql = @"WITH UserServiceStateTable
AS
(
	SELECT level,expired FROM FootChat.dbo.UserServiceState uss WITH(NOLOCK)
)
select
sum(case when UserServiceStateTable.level=1 AND UserServiceStateTable.expired>'" + endTime + @"' then 1 else 0 end) AS trailUserCount,
sum(case when UserServiceStateTable.level=2 AND UserServiceStateTable.expired>'" + endTime + @"' then 1 else 0 end) AS officialUserCount
from UserServiceStateTable";
            return Context.Database.SqlQuery<UserServiceStateStatistics>(sql).First();
        }

        public long[] GetWillOrExipredUid(UserServiceLevel level, int day)
        {
            var afterDay = DateTime.Now.AddDays(day);
            var builder = new StringBuilder();
            builder.Append(" SELECT us.uid");
            builder.Append(" FROM FootChat.dbo.UserServiceState us with(nolock)");
            builder.AppendFormat(" WHERE us.expired > '{0}'", afterDay.ToString("yyyy-MM-dd"));
            builder.AppendFormat(" AND us.expired < '{0}'", afterDay.AddDays(1).ToString("yyyy-MM-dd"));
            builder.AppendFormat("AND us.level = {0}", (int)level);
            return Context.Database.SqlQuery<long>(builder.ToString()).ToArray();
        }

        public Dictionary<long, DateTime> GetUserExipired(long[] uids)
        {
            uids = (uids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (uids.Length == 0) return new Dictionary<long, DateTime>();
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("uss.uid");
            column.Add("uss.expired");
            builder.AppendFormat("select {0} from FootChat.dbo.UserServiceState uss with (nolock) ", string.Join(",", column));
            builder.AppendFormat(" where uss.uid in ({0})  ", string.Join(",", uids));

            var userExpireds = Context.Database.SqlQuery<Models.SqlQueryModel.UserExipired>(builder.ToString());
            return userExpireds.ToDictionary(p => p.uid, p => p.expired);
        }
    }

    public class UserServiceStateStatistics
    {
        public int trailUserCount { get; set; }//vip试用用户（在试用期未付费用户）
        public int officialUserCount { get; set; }//付费用户总数（在服务期内的付费用户）
    }
}
