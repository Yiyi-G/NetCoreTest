using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity.Core;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.Models.Dock;
using Tgnet.Core;

namespace Tgnet.FootChat.Data
{
    public interface IDockedRecordRepository : IRepository<Data.DockedRecord>
    {
        IQueryable<Data.DockedRecord> DockedRecords { get; }
        PageModel<SearchDockedResult> SearchDockedRecord(SearchDockedArgs args, int start, int limit);       
        Dictionary<int, int> GetTodayPerHourDockedSuccessNum(DateTime? time);
        Dictionary<int, int> GetTodayPerHourDockedPassNum(DateTime? time);
        Dictionary<int, int> GetThisWeekDockedSuccessNum();
        Dictionary<int, int> GetThisWeekDockedPassNum();
        Dictionary<int, int> GetThisMontDockedSuccessNum();
        Dictionary<int, int> GetThisMontDockedPassNum();
        Dictionary<int, int> GetThisYearDockedSuccessNum();
        Dictionary<int, int> GetThisYearDockedPassNum();
        Dictionary<int, int> GetRangeTimeDockedSuccessNum(DateTime startTime, DateTime endTime);
        Dictionary<int, int> GetRangeTimeDockedPassNum(DateTime startTime, DateTime endTime);
        DockedCount GetDockedCount(DateTime date);
        UserDockedNum GetUserDockedNum(long uid);
    }
    class DockedRecordRepository : BaseRepository<DockedRecord>, IDockedRecordRepository
    {
        public DockedRecordRepository(FootChatContext context) : base(context)
        {
        }

        public IQueryable<DockedRecord> DockedRecords
        {
            get
            {
                return Entities;
            }
        }

        public PageModel<SearchDockedResult> SearchDockedRecord(SearchDockedArgs args, int start, int limit)
        {
            args.VerifySearchDockedArgs();
            StringBuilder sb = new StringBuilder();
            string withFuSql = "";
            string whereSenderSql = "";
            string whereReceiverSql = "";
            if (!string.IsNullOrWhiteSpace(args.sender)|| !string.IsNullOrWhiteSpace(args.receiver))
            {
                withFuSql = @" with fu
 as
( 
    select fu.name,fu.uid from FootChat.dbo.FootUser fu WITH(NOLOCK)
)
  ";
                if (!string.IsNullOrWhiteSpace(args.sender))
                {
                    whereSenderSql = " AND EXISTS(select 1 from  fu WITH(NOLOCK) where fu.uid=dr.sender and fu.name like '" + args.sender.Trim() + "%') ";
                }
                if (!string.IsNullOrWhiteSpace(args.receiver))
                {
                    whereReceiverSql = " AND EXISTS(select 1 from  fu WITH(NOLOCK) where fu.uid=dr.receiver and fu.name like '" + args.receiver.Trim() + "%') ";
                }
            }           
            sb.Append(withFuSql + "select fid,dr.sender,dr.receiver,status,created,message,COUNT(1) OVER() AS total from FootChat.dbo.DockedRecord dr where 1=1" + whereSenderSql+ whereReceiverSql);
            if (!string.IsNullOrWhiteSpace(args.startTime))
            {
                //开始时间(创建时间)
                var minTime = args.startTime.To<DateTime>();
                sb.Append(" AND dr.created>='" + minTime + "' ");
            }
            if (!string.IsNullOrWhiteSpace(args.endTime))
            {
                //结束时间（创建时间）
                var endTime = args.endTime.To<DateTime>();
                var maxTime = endTime.AddDays(1).Date;
                sb.Append(" AND dr.created<'" + maxTime + "' ");
            }
            if (args.status.HasValue)
            {
                //对接处理结果
                if (args.status.Value == DockedStatus.None)
                    sb.Append(" AND dr.status=0 ");
                if (args.status.Value == DockedStatus.Apply)
                    sb.Append(" AND dr.status=1 ");
                if (args.status.Value == DockedStatus.Pass)
                    sb.Append(" AND dr.status=2 ");
                if (args.status.Value == DockedStatus.UnPass)
                    sb.Append(" AND dr.status=3 ");
            }
            sb.Append("ORDER BY dr.created desc ");
            sb.AppendFormat("OFFSET {0} ROWS ", start);
            sb.AppendFormat("FETCH NEXT {0} ROWS ONLY ", limit);
            var result = Context.Database.SqlQuery<SearchDockedResult>(sb.ToString());
            return new PageModel<SearchDockedResult>(result.ToArray(), result.Select(p=>p.total).FirstOrDefault());
        }

        //今天每个小时的成功对接请求数
        public Dictionary<int, int> GetTodayPerHourDockedSuccessNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,updated) as hour,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status>=1 AND dr.status<=3 AND dr.updated>='" + startTime + "' AND dr.updated<'" + endTime + @"'
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(hh,updated)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,updated) as hour,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status>=1 AND dr.status<=3 AND DateDiff(dd,updated,GETDATE())=0
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(hh,updated)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }


        //今天每个小时的同意对接数
        public Dictionary<int, int> GetTodayPerHourDockedPassNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,updated) as hour,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status=2 AND dr.updated>='" + startTime + "' AND dr.updated<'" + endTime + @"'
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(hh,updated)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,updated) as hour,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status=2 AND DateDiff(dd,updated,GETDATE())=0
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(hh,updated)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }


        //本周成功对接请求数
        public Dictionary<int, int> GetThisWeekDockedSuccessNum()
        {
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status>=1 AND dr.status<=3 AND DateDiff(WEEK,updated,getdate())=0
AND DATEPART(YEAR,updated)=year(getdate()) 
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本周同意对接数
        public Dictionary<int, int> GetThisWeekDockedPassNum()
        {
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status=2 AND DateDiff(WEEK,updated,getdate())=0
AND DATEPART(YEAR,updated)=year(getdate()) 
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月成功对接请求数
        public Dictionary<int, int> GetThisMontDockedSuccessNum()
        {
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status>=1 AND dr.status<=3 AND DateDiff(MONTH,updated,getdate())=0 
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月同意对接数
        public Dictionary<int, int> GetThisMontDockedPassNum()
        {
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status=2 AND DateDiff(MONTH,updated,getdate())=0 
AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //获取本年的成功对接请求数
        public Dictionary<int, int> GetThisYearDockedSuccessNum()
        {
            string sql = @"SELECT DATEPART(mm,updated) as month,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status>=1 AND dr.status<=3 AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(mm,updated)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //获取本年的同意对接数
        public Dictionary<int, int> GetThisYearDockedPassNum()
        {
            string sql = @"SELECT DATEPART(mm,updated) as month,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status=2 AND DATEPART(YEAR,updated)=year(getdate())
GROUP BY DATEPART(mm,updated)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }

        //获取时间段的成功对接请求数
        public Dictionary<int, int> GetRangeTimeDockedSuccessNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status>=1 AND dr.status<=3 AND DATEPART(YEAR,updated)=year(getdate()) 
AND dr.updated>='" + startTime + "' AND dr.updated< '" + endTime + @"' 
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //获取时间段的同意对接数
        public Dictionary<int, int> GetRangeTimeDockedPassNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,updated) as day,count(1) as count from FootChat.dbo.DockedRecord dr WITH(NOLOCK) WHERE 1=1
AND dr.status=2 AND DATEPART(YEAR,updated)=year(getdate()) 
AND dr.updated>='" + startTime + "' AND dr.updated< '" + endTime + @"' 
GROUP BY DATEPART(dd,updated)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //获取具体时间的对接统计数据
        public DockedCount GetDockedCount(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"WITH DockedRecord
AS
(
	select fid,sender,receiver,status,created,updated,message from FootChat.dbo.DockedRecord dr WITH(NOLOCK)
)
select
sum(case when DockedRecord.created<'" + endTime + @"' then 1 else 0 end) AS dockedTotalCount,
sum(case when DockedRecord.created>='" + startTime + "' and DockedRecord.created<'" + endTime + @"' then 1 else 0 end) AS todayDockedCount,
sum(case when DockedRecord.updated>='" + startTime + "' and DockedRecord.updated<'" + endTime + @"' and DockedRecord.status>=1 and DockedRecord.status<=3  then 1 else 0 end) AS todaySuccessfulDockedCount,
sum(case when DockedRecord.updated<'" + endTime + @"' and DockedRecord.status=2 then 1 else 0 end) AS agreedDockedTotalCount,
sum(case when DockedRecord.updated>='" + startTime + "' and DockedRecord.updated<'" + endTime + @"' and DockedRecord.status=2 then 1 else 0 end) AS todayAgreedDockedCount,
sum(case when DockedRecord.updated>='" + startTime + "' and DockedRecord.updated<'" + endTime + @"' and DockedRecord.status=3 then 1 else 0 end) AS todayRejectedDockedCount
from DockedRecord";
            return Context.Database.SqlQuery<DockedCount>(sql).First();
        }

        public UserDockedNum GetUserDockedNum(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid,nameof(uid));
            string sql = @"WITH DockedRecord
AS
(
	select fid,sender,receiver,status,created,updated,message from FootChat.dbo.DockedRecord dr WITH(NOLOCK)
)
select
sum(case when DockedRecord.sender="+uid+ @" then 1 else 0 end) AS sendRequestNum,
sum(case when DockedRecord.sender=" + uid + @" and DockedRecord.status>=1 and DockedRecord.status<=3  then 1 else 0 end) AS sendSuccessfulNum,
sum(case when DockedRecord.receiver=" + uid + @" and DockedRecord.status>=1 and DockedRecord.status<=3 then 1 else 0 end) AS receiveDockedNum,
sum(case when DockedRecord.receiver=" + uid + @" and DockedRecord.status=2 then 1 else 0 end) AS agreedDockedNum,
sum(case when DockedRecord.receiver=" + uid + @" and DockedRecord.status=3 then 1 else 0 end) AS rejectedDockedNum
from DockedRecord";
            return Context.Database.SqlQuery<UserDockedNum>(sql).First();
        }
    }
    
    public class DockedCount
    {
        public int dockedTotalCount { get; set; }//对接请求总数
        public int todayDockedCount { get; set; }//每日对接请求数
        public int todaySuccessfulDockedCount { get; set; }//每日成功对接请求数
        public int agreedDockedTotalCount { get; set; }//同意对接总数
        public int todayAgreedDockedCount { get; set; }//每日同意对接
        public int todayRejectedDockedCount { get; set; }//每日拒绝对接
    }

    public class UserDockedNum
    {
        public int sendRequestNum { get; set; }//发送对接请求数
        public int sendSuccessfulNum { get; set; }//发送成功对接请求数
        public int receiveDockedNum { get; set; }//收到对接请求数
        public int agreedDockedNum { get; set; }//同意对接总数
        public int rejectedDockedNum { get; set; }//拒绝对接数
    }
}
