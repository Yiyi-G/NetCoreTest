using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data.Entity.Core;

namespace Tgnet.FootChat.Data
{
    public interface ICallRecordRepository :IRepository<CallRecord>
    {
        Dictionary<int, int> GetTodayPerHourCallNum(DateTime? time);//今天24小时的点击拨打条数
        Dictionary<int, int> GetThisWeekCallNum();//本周每天的点击拨打条数
        Dictionary<int, int> GetThisMonthCallNum();//本月每天的点击拨打条数
        Dictionary<int, int> GetThisYearCallNum();//全年每月的点击拨打条数
        Dictionary<int, int> GetRangeTimeCallNum(DateTime startTime, DateTime endTime);//时间段内的点击拨打条数
        Dictionary<int, int> GetTodayPerHourVipCallNum(DateTime? time);//今天24小时的vip点击拨打条数
        Dictionary<int, int> GetThisWeekVipCallNum();//本周每天的vip点击拨打条数
        Dictionary<int, int> GetThisMonthVipCallNum();//本月每天的vip点击拨打条数
        Dictionary<int, int> GetThisYearVipCallNum();//全年每月的vip点击拨打条数
        Dictionary<int, int> GetRangeTimeVipCallNum(DateTime startTime, DateTime endTime);//时间段内的vip点击拨打条数
        CallNum GetCallNum(DateTime date);//点击拨打总条数 每日点击拨打条数
        VipCallNum GetVipCallNum(DateTime date);//vip拨打总条数 每日vip拨打条数
        int GetCallUserNum(DateTime date);//拨打电话总人数
        int GetVipCallUserNum(DateTime date);//vip拨打人数
        int GetTodayVipCallUserNum(DateTime date);//每日vip拨打人数
    }
    public class CallRecordRepository: BaseRepository<CallRecord>, ICallRecordRepository
    {
        public CallRecordRepository(FootChatContext context) : base(context)
        {
        }

        //今天24小时的点击拨打条数
        public Dictionary<int, int> GetTodayPerHourCallNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK) WHERE 1=1
AND cr.created>='" + startTime + "' AND cr.created<'" + endTime + @"'
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(hh,cr.created)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK) WHERE 1=1
AND DateDiff(dd,cr.created,GETDATE())=0
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(hh,cr.created)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }

        //本周每天的点击拨打条数
        public Dictionary<int, int> GetThisWeekCallNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK) WHERE 1=1
AND DateDiff(WEEK,cr.created,getdate())=0
AND DATEPART(YEAR,cr.created)=year(getdate()) 
GROUP BY DATEPART(dd,cr.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月每天的点击拨打条数
        public Dictionary<int, int> GetThisMonthCallNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK) WHERE 1=1
AND DateDiff(MONTH,cr.created,getdate())=0 
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(dd,cr.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //全年每月的点击拨打条数
        public Dictionary<int, int> GetThisYearCallNum()
        {
            string sql = @"SELECT DATEPART(mm,created) as month,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK) WHERE 1=1
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(mm,cr.created)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //时间段内的点击拨打条数
        public Dictionary<int, int> GetRangeTimeCallNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK) WHERE 1=1
AND DATEPART(YEAR,cr.created)=year(getdate()) 
AND cr.created>='" + startTime + "' AND cr.created< '" + endTime + @"' 
GROUP BY DATEPART(dd,cr.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }


        //今天24小时的vip点击拨打条数
        public Dictionary<int, int> GetTodayPerHourVipCallNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND cr.created>='" + startTime + "' AND cr.created<'" + endTime + @"'
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(hh,cr.created)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND DateDiff(dd,cr.created,GETDATE())=0
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(hh,cr.created)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }

        //本周每天的vip点击拨打条数
        public Dictionary<int, int> GetThisWeekVipCallNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND DateDiff(WEEK,cr.created,getdate())=0
AND DATEPART(YEAR,cr.created)=year(getdate()) 
GROUP BY DATEPART(dd,cr.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月每天的vip点击拨打条数
        public Dictionary<int, int> GetThisMonthVipCallNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND DateDiff(MONTH,cr.created,getdate())=0 
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(dd,cr.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //全年每月的vip点击拨打条数
        public Dictionary<int, int> GetThisYearVipCallNum()
        {
            string sql = @"SELECT DATEPART(mm,created) as month,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND DATEPART(YEAR,cr.created)=year(getdate())
GROUP BY DATEPART(mm,cr.created)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //时间段内的vip点击拨打条数
        public Dictionary<int, int> GetRangeTimeVipCallNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND DATEPART(YEAR,cr.created)=year(getdate()) 
AND cr.created>='" + startTime + "' AND cr.created< '" + endTime + @"' 
GROUP BY DATEPART(dd,cr.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }


        //点击拨打总条数 每日点击拨打条数
        public CallNum GetCallNum(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"WITH CallRecordTable
AS
(
	SELECT caller,created from FootChat.dbo.CallRecord cr WITH(NOLOCK)
)
select
sum(case when CallRecordTable.created<'" + endTime + @"' then 1 else 0 end) AS callTotalNum,
sum(case when CallRecordTable.created>='" + startTime + "' AND CallRecordTable.created<'" + endTime + @"' then 1 else 0 end) AS todayCallTotalNum
from CallRecordTable";
            return Context.Database.SqlQuery<CallNum>(sql).First();
        }

        //vip拨打总条数 每日vip拨打条数
        public VipCallNum GetVipCallNum(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"WITH VipCallRecordTable
AS
(
	SELECT caller,created from FootChat.dbo.CallRecord cr WITH(NOLOCK)
	inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
	on cr.caller=uss.uid
	where uss.level=2
)
select
sum(case when VipCallRecordTable.created<'" + endTime + @"' then 1 else 0 end) AS vipCallTotalNum,
sum(case when VipCallRecordTable.created>='" + startTime + "' AND VipCallRecordTable.created<'" + endTime + @"' then 1 else 0 end) AS vipTodayCallTotalNum
from VipCallRecordTable";
            return Context.Database.SqlQuery<VipCallNum>(sql).First();
        }

        //拨打电话总人数
        public int GetCallUserNum(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            string sql = @"SELECT count(distinct caller) from FootChat.dbo.CallRecord cr WITH(NOLOCK) where cr.created<'" + endTime + @"'";
            return Context.Database.SqlQuery<int>(sql).First();
        }

        //vip拨打人数
        public int GetVipCallUserNum(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            string sql = @"SELECT count(distinct caller) from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND cr.created<'" + endTime + @"'";
            return Context.Database.SqlQuery<int>(sql).First();
        }

        //每日vip拨打人数
        public int GetTodayVipCallUserNum(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"SELECT count(distinct caller) from FootChat.dbo.CallRecord cr WITH(NOLOCK)
inner join FootChat.dbo.UserServiceState uss WITH(NOLOCK)
on cr.caller=uss.uid
where uss.level=2
AND cr.created>='" + startTime + "' AND cr.created<'" + endTime + @"'";
            return Context.Database.SqlQuery<int>(sql).First();
        }
    }
    public class CallNum
    {
        public int callTotalNum { get; set; }
        public int todayCallTotalNum { get; set; }
    }

    public class VipCallNum
    {
        public int vipCallTotalNum { get; set; }
        public int vipTodayCallTotalNum { get; set; }
    }
}
