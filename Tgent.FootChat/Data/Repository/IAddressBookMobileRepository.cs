using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity.Core;

namespace Tgnet.FootChat.Data
{
    public interface IAddressBookMobileRepository : IRepository<AddressBookMobile>
    {
        Model.UserAddressBookMobileModel[] GetUserAddressBooks(long uid, string keyword, bool? isAttention, int start, int limit);
        Models.AddressBookRelation[] GetUserAddressBookRelation(long uid, long[] others);
        long[] GetTgUidAndNotFootUidOfInBook(long uid);
        long[] GetFootUidOfInBook(long uid);
        Dictionary<int, int> GetTodayPerHourAttentionNum(DateTime? time);//今天24小时关注统计数据
        Dictionary<int, int> GetThisWeekAttentionNum();//本周关注统计数据
        Dictionary<int, int> GetThisMontAttentionNum();//本月关注统计数据
        Dictionary<int, int> GetThisYearAttentionNum();//今年关注统计数据
        Dictionary<int, int> GetRangeTimeAttentionNum(DateTime startTime, DateTime endTime);//时间段内关注统计数据

        Dictionary<int, int> GetTodayPerHourInvitationNum(DateTime? time);//今天24小时邀请统计数据
        Dictionary<int, int> GetThisWeekInvitationNum();//本周邀请统计数据
        Dictionary<int, int> GetThisMonthInvitationNum();//本月邀请统计数据
        Dictionary<int, int> GetThisYearInvitationNum();//今年邀请统计数据
        Dictionary<int, int> GetRangeInvitationNum(DateTime startTime, DateTime endTime);//时间段内邀请统计数据

        AttentionCount GetAttentionCount(DateTime date);//关注好友总次数 每日新增关注次数
        int GetAttentionUserCount(DateTime date);//关注好友的总人数
        int GetTodayAttentionUserCount(DateTime date);//每日新增关注好友人数
        int GetInvitationNum(DateTime date);//成功邀请数
        int GetTodayInvitationNum(DateTime date);//每日新增成功邀请数
    }
    class AddressBookMobileRepository : Tgnet.Data.Entity.DbSetRepository<FootChatContext, Data.AddressBookMobile>, IAddressBookMobileRepository
    {
        public AddressBookMobileRepository(FootChatContext context)
               : base(context) { }
        protected override DbSet<AddressBookMobile> DbSet
        {
            get { return Context.AddressBookMobile; }
        }
        public Model.UserAddressBookMobileModel[] GetUserAddressBooks(long uid, string keyword, bool? isAttention, int start, int limit)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT a.[uid],a.[mobile],a.[createDate],a.[name],a.[company] ,a.[haveRecommended],a.[tguid],a.[isAttention],");
            sb.Append(" (SELECT 1 FROM FootChat.dbo.FootUser AS u WHERE u.uid=a.tguid AND  u.verifyStatus=1) AS verifyCount,");
            sb.Append("(SELECT COUNT(*) FROM FootChat.dbo.FootPrint AS f WHERE f.uid=a.tguid AND f.isEnable=1 AND f.state=2) AS footPrintCount ");
            sb.Append("FROM [FootChat].[dbo].[AddressBookMobile]  AS a ");
            sb.AppendFormat("WHERE a.uid={0} ", uid);
            if (!String.IsNullOrWhiteSpace(keyword))
            {
                sb.AppendFormat(" AND a.name LIKE '%{0}%' ", keyword.Trim());
            }
            if (isAttention.HasValue)
            {
                sb.AppendFormat(" AND a.isAttention={0} ", isAttention.Value ? 1 : 0);
            }
            sb.Append("ORDER BY verifyCount DESC,footPrintCount DESC, name ASC ");
            sb.AppendFormat("OFFSET {0} ROWS ", start);
            sb.AppendFormat("FETCH NEXT {0} ROWS ONLY ", limit);
            var result = Context.Database.SqlQuery<Model.UserAddressBookMobileModel>(sb.ToString()).ToArray();
            return result;
        }
        public Models.AddressBookRelation[] GetUserAddressBookRelation(long uid, long[] others)
        {
            others = (others ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT a.name ,a.mobile,b.uid,b.id from FootChat.dbo.AddressBookMobile as a ");
            sb.Append("INNER  JOIN  FootChat.dbo.AddressBookMobile as b on a.mobile = b.mobile ");
            sb.AppendFormat(" WHERE a.uid={0} AND  b.uid in ({1}) ", uid, String.Join(",", others));
            var result = Context.Database.SqlQuery<Models.AddressBookRelation>(sb.ToString()).ToArray();
            return result;
        }

        public long[] GetTgUidAndNotFootUidOfInBook(long uid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ab.tguid ");
            sb.Append(" FROM FootChat.dbo.AddressBookMobile ab WITH(NOLOCK) ");
            sb.Append(" LEFT JOIN FootChat.dbo.FootUser fu WITH(NOLOCK) ON ab.tguid = fu.uid ");
            sb.AppendFormat(" WHERE ab.uid = {0} and ab.tguid is not null and fu.uid is null ", uid);
            var result = Context.Database.SqlQuery<long>(sb.ToString()).ToArray();
            return result;
        }

        public long[] GetFootUidOfInBook(long uid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT fu.uid ");
            sb.Append(" FROM FootChat.dbo.AddressBookMobile ab WITH(NOLOCK) ");
            sb.Append(" JOIN FootChat.dbo.FootUser fu WITH(NOLOCK) ON ab.tguid = fu.uid ");
            sb.AppendFormat(" WHERE ab.uid = {0}", uid);
            var result = Context.Database.SqlQuery<long>(sb.ToString()).ToArray();
            return result;
        }

        //今天24小时的关注次数 与 传入时间24小时的关注次数
        public Dictionary<int, int> GetTodayPerHourAttentionNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,attentionDate) as hour,count(1) as count from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) WHERE 1=1 AND abm.isAttention=1
AND abm.attentionDate>='" + startTime + "' AND abm.attentionDate<'" + endTime + @"'
AND DATEPART(YEAR,attentionDate)=year(getdate())
GROUP BY DATEPART(hh,attentionDate)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,attentionDate) as hour,count(1) as count from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) WHERE 1=1 AND abm.isAttention=1
AND DateDiff(dd,attentionDate,GETDATE())=0
AND DATEPART(YEAR,attentionDate)=year(getdate())
GROUP BY DATEPART(hh,attentionDate)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }

        //今天24小时的成功邀请数 与 传入时间24小时的成功邀请数
        public Dictionary<int,int> GetTodayPerHourInvitationNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"select DATEPART(hh,fu.created) as hour,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND fu.created>='" + startTime + "' AND fu.created<'" + endTime + @"'
AND DATEPART(YEAR,fu.created)=year(getdate())
group by DATEPART(hh,fu.created)";
            }
            else
            {
                sql = @"select DATEPART(hh,fu.created) as hour,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND DateDiff(dd,fu.created,GETDATE())=0
AND DATEPART(YEAR,fu.created)=year(getdate())
group by DATEPART(hh,fu.created)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }


        //本周每天的关注次数
        public Dictionary<int, int> GetThisWeekAttentionNum()
        {
            string sql = @"SELECT DATEPART(dd,attentionDate) as day,count(1) as count from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) WHERE 1=1 AND abm.isAttention=1
AND DateDiff(WEEK,attentionDate,getdate())=0
AND DATEPART(YEAR,attentionDate)=year(getdate()) 
GROUP BY DATEPART(dd,attentionDate)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本周每天的成功邀请数 
        public Dictionary<int, int> GetThisWeekInvitationNum()
        {
            string sql = @"select DATEPART(dd,fu.created) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND DateDiff(WEEK,fu.created,GETDATE())=0
AND DATEPART(YEAR,fu.created)=year(getdate())
group by DATEPART(dd,fu.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月每天的关注次数
        public Dictionary<int, int> GetThisMontAttentionNum()
        {
            string sql = @"SELECT DATEPART(dd,attentionDate) as day,count(1) as count from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) WHERE 1=1 AND abm.isAttention=1
AND DateDiff(MONTH,attentionDate,getdate())=0 
AND DATEPART(YEAR,attentionDate)=year(getdate())
GROUP BY DATEPART(dd,attentionDate)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月每天的成功邀请数
        public Dictionary<int, int> GetThisMonthInvitationNum()
        {
            string sql = @"select DATEPART(dd,fu.created) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND DateDiff(MONTH,fu.created,GETDATE())=0
AND DATEPART(YEAR,fu.created)=year(getdate())
group by DATEPART(dd,fu.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //获取本年的关注次数
        public Dictionary<int, int> GetThisYearAttentionNum()
        {
            string sql = @"SELECT DATEPART(mm,attentionDate) as month,count(1) as count from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) WHERE 1=1 AND abm.isAttention=1
AND DATEPART(YEAR,attentionDate)=year(getdate())
GROUP BY DATEPART(mm,attentionDate)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //本年每月的成功邀请数
        public Dictionary<int, int> GetThisYearInvitationNum()
        {
            string sql = @"select DATEPART(mm,fu.created) as month,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND DATEPART(YEAR,fu.created)=year(getdate())
group by DATEPART(mm,fu.created)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //时间段内的关注次数
        public Dictionary<int, int> GetRangeTimeAttentionNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,attentionDate) as day,count(1) as count from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) WHERE 1=1 AND abm.isAttention=1
AND DATEPART(YEAR,attentionDate)=year(getdate()) 
AND abm.attentionDate>='" + startTime + "' AND abm.attentionDate< '" + endTime + @"' 
GROUP BY DATEPART(dd,attentionDate)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //时间段内的成功邀请数
        public Dictionary<int, int> GetRangeInvitationNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"select DATEPART(dd,fu.created) as day,count(1) as count from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND DATEPART(YEAR,fu.created)=year(getdate())
AND fu.created>='" + startTime + "' AND fu.created<'" + endTime + @"'
group by DATEPART(dd,fu.created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //关注好友总次数 每日新增关注次数
        public AttentionCount GetAttentionCount(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"WITH AddressBookMobileTable
AS
(
	select isAttention,attentionDate from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) where abm.isAttention=1
)
select
sum(case when AddressBookMobileTable.attentionDate< '" + endTime + @"' then 1 else 0 end) AS totalAttentionCount,
sum(case when AddressBookMobileTable.attentionDate>='" + startTime + @"' AND AddressBookMobileTable.attentionDate<'" + endTime + @"' then 1 else 0 end) as todayAttentionCount 
from AddressBookMobileTable";
            return Context.Database.SqlQuery<AttentionCount>(sql).First();
        }

        //关注好友的总人数
        public int GetAttentionUserCount(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            string sql = @"select count(distinct uid) from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) where abm.isAttention=1 AND abm.attentionDate<'" + endTime + "'";
            return Context.Database.SqlQuery<int>(sql).First();
        }

        //每日新增关注好友人数
        public int GetTodayAttentionUserCount(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"select count(distinct uid) from FootChat.dbo.AddressBookMobile abm WITH(NOLOCK) where abm.isAttention=1 AND abm.attentionDate>='" + startTime + "' AND abm.attentionDate<'" + endTime + "'";
            return Context.Database.SqlQuery<int>(sql).First();
        }

        //成功邀请数
        public int GetInvitationNum(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            string sql = @"select count(1) from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND fu.created<'" + endTime + @"'";
            return Context.Database.SqlQuery<int>(sql).First();
        }

        //每日新增成功邀请数
        public int GetTodayInvitationNum(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"select count(1) from FootChat.dbo.FootUser fu WITH(NOLOCK)
inner join FootChat.dbo.AddressBookMobile abm WITH(NOLOCK)
on fu.mobile=abm.mobile
where abm.isAttention=1
AND fu.created>='" + startTime + @"' AND fu.created<'" + endTime + @"'";
            return Context.Database.SqlQuery<int>(sql).First();
        }


    }

    public class AttentionCount
    {
        public int totalAttentionCount { get; set; }
        public int todayAttentionCount { get; set; }
    }
}
