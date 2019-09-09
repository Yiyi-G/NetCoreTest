using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity.Core;
using Tgnet.FootChat.FootPrint;
using Tgnet.FootChat.Model;

namespace Tgnet.FootChat.Data
{
    public interface IFootPrintRepository : IRepository<Data.FootPrint>
    {
        long[] GetMutualUids(long uid, long[] others);
        PageModel<FootPrint> GetPageItems(SearchFootPrintArgs args, int start, int limit);
        Dictionary<int, int> GetTodayPerHourFootPrintCreateNum(DateTime? time);
        Dictionary<int, int> GetThisWeekFootPrintCreateNum();
        Dictionary<int, int> GetThisMontFootPrintCreateNum();
        Dictionary<int, int> GetThisYearFootPrintCreateNum();
        Dictionary<int, int> GetRangeTimeFootPrintCreateNum(DateTime startTime, DateTime endTime);
        FootPrintCount GetFootPrintCount(DateTime date);
        int GetFootPrintCreatorCount(DateTime date);
        int GetTodayFootPrintCreatorCount(DateTime date);
        long[] GetFollowAndFavoriteUids(long pid);
        Dictionary<long, int> GetUserYesterdayUnReadFPCount();
        PageModel<long> GetFollowProjs(long uid, int start, int limit);
        FootPrintModel[] GetFootPrints(long[] fids);
        Dictionary<long, string[]> GetEnableFootPrintImgs(long[] fids);
        Dictionary<long, long[]> GetFootPrintTagIds(long[] fids);
        Dictionary<long, int> GetProjFootUserCount(long[] pids, long? exceptUid,FootPrintState[] states);
        Dictionary<long, long[]> GetProjLatestUids(long[] pids, FootPrintState[] states, long? exceptUid, int count);
        Dictionary<long, long> GetProjFirstPassFid(long[] pids);
        FootPrintModel[] GetUserFootPrintByPids(long uid, long[] pids);
        PageModel<FootPrintModel> GetProjFootPrintByPid(long pid, int start, int limit, long? exceptUid, DateTime? maxTime, FootPrintState[] states);
        long[] GetUserViewFootPrints(long uid, long[] exceptFids, int start, int limit);
        long[] GetTouristViewFootPrints(string deviceId, long[] exceptFids, int start, int limit);
    }
    public class FootPrintRepository : BaseRepository<FootPrint>, IFootPrintRepository
    {
        public FootPrintRepository(FootChatContext context) : base(context)
        {
        }

        public PageModel<FootPrint> GetPageItems(SearchFootPrintArgs args, int start, int limit)
        {
            ExceptionHelper.ThrowIfTrue(limit <= 0, "limit");
            args.VerifySearchFootPrintArgs();
            var parameters = new Dictionary<String, String>();
            var sbTableWithWhere = new StringBuilder();
            var isInner = args.isInner.Value ? 1 : 0;
            string sqlWhereUserName = "";
            if (!string.IsNullOrWhiteSpace(args.userName))
            {
                //发布人姓名
                sqlWhereUserName = " AND fu.name LIKE '" + args.userName.Trim() + "%' ";
            }
            string sqlWhereMobile = "";
            if (!string.IsNullOrWhiteSpace(args.mobile))
            {
                //发布人手机
                sqlWhereMobile = " AND fu.mobile LIKE '" + args.mobile.Trim() + "%' ";
            }

            sbTableWithWhere.Append(@"FootChat.dbo.FootPrint fp WITH(NOLOCK) WHERE 1=1 AND fp.isEnable=1 
AND EXISTS(SELECT 1 FROM FootChat.dbo.FootUser fu WITH(NOLOCK) WHERE fu.uid=fp.uid AND fu.isInner=" + isInner + "" + sqlWhereUserName + sqlWhereMobile + ") ");
            if (args.isProjectEdition.HasValue && args.isProjectEdition.Value)
            {
                //项目采编
                sbTableWithWhere.Append(" AND fp.transferScales IN(1,2,3) ");

                if (!string.IsNullOrWhiteSpace(args.transferMinTime))
                {
                    //开始时间（采编时间）
                    var sTime = args.transferMinTime.To<DateTime>();
                    sbTableWithWhere.Append(" AND fp.transferUpdated>='" + sTime + "' ");
                }
                if (!string.IsNullOrWhiteSpace(args.transferMaxTime))
                {
                    //结束时间（采编时间）
                    var endd = args.transferMaxTime.To<DateTime>();
                    var eTime = endd.AddDays(1).Date;
                    sbTableWithWhere.Append(" AND fp.transferUpdated<'" + eTime + "' ");
                }
            }
            if (args.userId.HasValue)
            {
                //用户存在，查询审核通过的足迹
                sbTableWithWhere.Append(" AND fp.uid=" + args.userId.Value + " AND fp.state=2 ");
            }
            if (args.fid.HasValue)
            {
                //某条足迹
                sbTableWithWhere.Append(" AND fp.fid=" + args.fid.Value + " ");                
            }
            if (!string.IsNullOrWhiteSpace(args.keyWord))
            {
                //关键词
                sbTableWithWhere.Append(" AND fp.content LIKE @keyWord ");
                parameters.Add("keyWord", "" + args.keyWord.Trim() + "%");
            }
            if (!string.IsNullOrWhiteSpace(args.startTime))
            {
                //开始时间(创建时间)
                var minTime = args.startTime.To<DateTime>();
                sbTableWithWhere.Append(" AND fp.created>='" + minTime + "' ");
            }
            if (!string.IsNullOrWhiteSpace(args.endTime))
            {
                //结束时间（创建时间）
                var endTime = args.endTime.To<DateTime>();
                var maxTime = endTime.AddDays(1).Date;
                sbTableWithWhere.Append(" AND fp.created<'" + maxTime + "' ");
            }
            if (!string.IsNullOrWhiteSpace(args.projName) || args.isInnerProject.HasValue)
            {
                string isInnerProject = "";
                string newProject = "";
                string projName = "";
                if (args.isInnerProject.HasValue)
                {
                    if (args.isInnerProject.Value)
                    {
                        isInnerProject = " AND ps.tgProjId!='' ";
                    }
                    else
                    {
                        newProject = " AND ps.tgProjId is null ";
                    }
                }
                if (!string.IsNullOrWhiteSpace(args.projName))
                {
                    projName = " AND ps.name LIKE @projName ";
                    parameters.Add("projName", "" + args.projName.Trim() + "%");
                }
                //项目名称
                sbTableWithWhere.Append(" AND EXISTS(SELECT 1 FROM Tg_Ywt.dbo.ProjectSource ps WITH(NOLOCK) WHERE ps.pid=fp.pid " + projName + isInnerProject + newProject + ") ");
            }
            if (args.footPrintState.HasValue)
            {
                //足迹审核状态
                ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(FootPrintState), args.footPrintState), "footPrintState", "值不在范围内");
                if (args.footPrintState.Value == FootPrintState.None)
                    sbTableWithWhere.Append(" AND fp.state=1 ");
                if (args.footPrintState.Value == FootPrintState.Pass)
                    sbTableWithWhere.Append(" AND fp.state=2 ");
                if (args.footPrintState.Value == FootPrintState.UnPass)
                    sbTableWithWhere.Append(" AND fp.state=3 ");
            }
            if (args.transferScales.HasValue)
            {
                //采编便签
                ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(TransferScales), args.transferScales), "transferScales", "值不在范围内");
                if (args.transferScales.Value == TransferScales.有单位无联系人)
                    sbTableWithWhere.Append(" AND fp.transferScales=1 ");
                if (args.transferScales.Value == TransferScales.有单位有人有号码)
                    sbTableWithWhere.Append(" AND fp.transferScales=2 ");
                if (args.transferScales.Value == TransferScales.有单位有人无号码)
                    sbTableWithWhere.Append(" AND fp.transferScales=3 ");
            }
            if (args.transferState.HasValue)
            {
                //采编状态
                ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(TransferState), args.transferState), "transferScales", "值不在范围内");
                if (args.transferState.Value == TransferState.已处理)
                    sbTableWithWhere.Append(" AND fp.transferState=1 ");
                if (args.transferState.Value == TransferState.无法采编)
                    sbTableWithWhere.Append(" AND fp.transferState=2 ");
                if (args.transferState.Value == TransferState.未处理)
                    sbTableWithWhere.Append(" AND fp.transferState=0 ");
            }
            var orderBy = " fp.created desc";
            var sql = SqlUtility.GetPageLimitSql(start: start, limit: limit, columns: "*", tableWithWhere: sbTableWithWhere.ToString(), orderBy: orderBy);
            var model = new PageModel<FootPrint>();
            model.Models = GetItems<FootPrint>(sql, parameters);
            model.Count = GetCount(sbTableWithWhere.ToString(), parameters);
            return model;
        }
        public long[] GetMutualUids(long uid, long[] others)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            others = (others ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            if (others.Length == 0)
                return Enumerable.Empty<long>().ToArray();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT f.uid FROM FootChat.DBO.FootPrint AS f ");
            sb.AppendFormat("WHERE f.state=2 AND f.uid IN ({0}) AND f.isEnable=1 AND f.pid IN ", String.Join(",", others));
            sb.AppendFormat("(SELECT fs.pid FROM FootChat.DBO.FootPrint AS fs WHERE fs.state=2 AND fs.uid={0} AND fs.isEnable=1) ", uid);
            var result = Context.Database.SqlQuery<long>(sb.ToString()).ToArray();
            return result;

        }


        //今天每个小时的足迹发布量
        public Dictionary<int, int> GetTodayPerHourFootPrintCreateNum(DateTime? time)
        {
            string sql = "";
            if (time.HasValue)
            {
                var startTime = time.Value.Date;
                var endTime = time.Value.Date.AddDays(1);
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.FootPrint fp WITH(NOLOCK) WHERE 1=1
AND fp.isEnable=1 AND fp.created>='" + startTime + "' AND fp.created<'" + endTime + @"'
AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(hh,created)";
            }
            else
            {
                sql = @"SELECT DATEPART(hh,created) as hour,count(1) as count from FootChat.dbo.FootPrint fp WITH(NOLOCK) WHERE 1=1
AND fp.isEnable=1 AND DateDiff(dd,created,GETDATE())=0
AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(hh,created)";
            }
            var result = Context.Database.SqlQuery<HourCount>(sql);
            return result.ToDictionary(p => p.hour, p => p.count);
        }

        //本周足迹发布数
        public Dictionary<int, int> GetThisWeekFootPrintCreateNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.FootPrint fp WITH(NOLOCK) WHERE 1=1
AND fp.isEnable=1 AND DateDiff(WEEK,created,getdate())=0
AND DATEPART(YEAR,created)=year(getdate()) 
GROUP BY DATEPART(dd,created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //本月足迹发布数
        public Dictionary<int, int> GetThisMontFootPrintCreateNum()
        {
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.FootPrint fp WITH(NOLOCK) WHERE 1=1
AND fp.isEnable=1 AND DateDiff(MONTH,created,getdate())=0 
AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(dd,created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        //获取本年的足迹发布数
        public Dictionary<int, int> GetThisYearFootPrintCreateNum()
        {
            string sql = @"SELECT DATEPART(mm,created) as month,count(1) as count from FootChat.dbo.FootPrint fp WITH(NOLOCK) WHERE 1=1
AND fp.isEnable=1 AND DATEPART(YEAR,created)=year(getdate())
GROUP BY DATEPART(mm,created)";
            var result = Context.Database.SqlQuery<MonthCount>(sql);
            return result.ToDictionary(p => p.month, p => p.count);
        }


        //获取时间段的足迹发布数
        public Dictionary<int, int> GetRangeTimeFootPrintCreateNum(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            string sql = @"SELECT DATEPART(dd,created) as day,count(1) as count from FootChat.dbo.FootPrint fp WITH(NOLOCK) WHERE 1=1
AND fp.isEnable=1 AND DATEPART(YEAR,created)=year(getdate()) 
AND fp.created>='" + startTime + "' AND fp.created< '" + endTime + @"' 
GROUP BY DATEPART(dd,created)";
            var result = Context.Database.SqlQuery<DayCount>(sql);
            return result.ToDictionary(p => p.day, p => p.count);
        }

        public FootPrintCount GetFootPrintCount(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"WITH FootPrintTable
AS
(
	select state,isEnable,examineDate,created from FootChat.dbo.FootPrint fp WITH(NOLOCK) where fp.isEnable=1
)
select
sum(case when FootPrintTable.created< '" + endTime + @"' then 1 else 0 end) AS totalCount,
sum(case when FootPrintTable.state=2 AND FootPrintTable.examineDate< '" + endTime + @"' then 1 else 0 end) AS totalPassFootPrintCount,
sum(case when FootPrintTable.state=2 AND FootPrintTable.examineDate>='" + startTime + "' AND FootPrintTable.examineDate< '" + endTime + @"' then 1 else 0 end) AS todayPassFootPrintCount,
sum(case when FootPrintTable.state=3 AND FootPrintTable.examineDate>='" + startTime + "' AND FootPrintTable.examineDate< '" + endTime + @"' then 1 else 0 end) AS todayUnPassFootPrintCount
from FootPrintTable";
            return Context.Database.SqlQuery<FootPrintCount>(sql).First();
        }


        public int GetFootPrintCreatorCount(DateTime date)
        {
            var endTime = date.AddDays(1).Date;
            string sql = @"select count(distinct uid) from FootChat.dbo.FootPrint fp WITH(NOLOCK) where fp.isEnable=1 AND fp.created<'" + endTime + "'";
            return Context.Database.SqlQuery<int>(sql).First();
        }

        public int GetTodayFootPrintCreatorCount(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            string sql = @"select count(distinct uid) from FootChat.dbo.FootPrint fp WITH(NOLOCK) where fp.isEnable=1 AND fp.created>='" + startTime + "' AND fp.created<'" + endTime + "'";
            return Context.Database.SqlQuery<int>(sql).First();
        }

        public long[] GetFollowAndFavoriteUids(long pid)
        {
            var buider = new StringBuilder();
            buider.Append("SELECT uf.uid ");
            buider.Append("FROM FootChat.dbo.UserFavorite uf WITH(NOLOCK) ");
            buider.AppendFormat("WHERE uf.pid = {0} AND uf.isEnabled = 1 ", pid);
            buider.Append("UNION ALL ");
            buider.Append("SELECT fp.uid ");
            buider.Append("FROM FootChat.dbo.FootPrint fp WITH(NOLOCK) ");
            buider.AppendFormat("WHERE fp.pid ={0} AND fp.isEnable = 1 ", pid);
            return Context.Database.SqlQuery<long>(buider.ToString()).ToArray();
        }

        public Dictionary<long, int> GetUserYesterdayUnReadFPCount()
        {
            var today = DateTime.Now.Date;
            var yesterday = today.AddDays(-1);
            var builder = new StringBuilder();
            builder.Append(" SELECT fu.uid, COUNT(fu.uid) AS count");
            builder.Append(" FROM FootChat.dbo.FootUser  fu WITH(NOLOCK)");
            builder.Append(" JOIN FootChat.dbo.AddressBookMobile ab WITH(NOLOCK) ON fu.uid = ab.uid");
            builder.Append(" JOIN FootChat.dbo.FootPrint fp WITH(NOLOCK) ON ab.tguid = fp.uid");
            builder.Append(" LEFT JOIN FootChat.dbo.UserViewFootPrintRecord uv WITH(NOLOCK) ON fu.uid = uv.uid AND fp.fid = uv.fid");
            builder.AppendFormat(" WHERE fp.state=2 and fp.orderUpdated > '{0}' AND fp.orderUpdated < '{1}'  AND (uv.fid IS NULL	OR uv.updated > fp.orderUpdated)", yesterday.ToString("yyyy-MM-dd"), today.ToString("yyyy-MM-dd"));
            builder.AppendFormat(" GROUP BY fu.uid");
            return Context.Database.SqlQuery<UserUnReadFPCount>(builder.ToString()).ToDictionary(p => p.uid, p => p.count);
        }

        public PageModel<long> GetFollowProjs(long uid, int start, int limit)
        {
            var builder = new StringBuilder();
            builder.Append(" SELECT pid, COUNT(1) OVER () AS total");
            builder.AppendFormat(" FROM FootChat.dbo.FootPrint WITH(NOLOCK) WHERE uid = {0} AND isEnable = 1", uid.ToString());
            builder.Append(" GROUP BY pid ORDER BY MAX(updated) DESC");
            builder.AppendFormat(" OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, limit);
            var followProjs = Context.Database.SqlQuery<FollowProj>(builder.ToString());
            return new PageModel<long>(followProjs.Select(p => p.pid), followProjs.Select(p => p.total).FirstOrDefault());
        }

        public FootPrintModel[] GetFootPrints(long[] fids)
        {
            fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (fids.Length == 0) return new FootPrintModel[0];
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fp.fid as Fid");
            column.Add("fp.pid as Pid");
            column.Add("fp.uid as Uid");
            column.Add("fp.address as Address");
            column.Add("fp.content as Content");
            column.Add("fp.updated as Updated");
            column.Add("fp.isenable as IsEnabled ");
            column.Add("fp.state as State ");
            builder.AppendFormat(" SELECT {0} from FootChat.dbo.FootPrint fp with(nolock) ",string.Join(",",column));
            builder.AppendFormat(" where  fp.fid in ({0})",string.Join(",",fids));

            return Context.Database.SqlQuery<FootPrintModel>(builder.ToString()).ToArray();
        }

        public FootPrintModel[] GetUserFootPrintByPids(long uid,long[] pids)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new FootPrintModel[0];
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fp.fid as Fid");
            column.Add("fp.pid as Pid");
            column.Add("fp.content as Content");
            column.Add("fp.updated as Updated");
            column.Add("fp.state as State ");
            builder.AppendFormat(" SELECT {0} from FootChat.dbo.FootPrint fp with(nolock) ", string.Join(",", column));
            builder.AppendFormat(" where  fp.pid in ({0}) and fp.uid={1} and fp.isenable =1", string.Join(",", pids),uid);
            return Context.Database.SqlQuery<FootPrintModel>(builder.ToString()).ToArray();
        }

        public PageModel<FootPrintModel> GetProjFootPrintByPid(long pid,int start,int limit,long? exceptUid,DateTime? maxTime,FootPrintState[] states)
        {
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fp.fid AS Fid");
            column.Add("fp.pid as Pid");
            column.Add("fp.uid AS Uid");
            column.Add("fp.updated as Updated");
            column.Add("fp.address AS Address");
            column.Add("COUNT(1) OVER () AS Total");
            builder.AppendFormat(" SELECT {0} FROM FootChat.dbo.FootPrint fp WITH (nolock) ", string.Join(",", column));
            var where = new List<string>();
            where.Add(string.Format("fp.pid = {0}", pid));
            where.Add("fp.isenable = 1");
            if (states != null && states.Length > 0)
            {
                where.Add(string.Format("fp.state in ({0}) ",string.Join(",",states.Select(p=>(byte)p))));
            }
            if (maxTime.HasValue)
            {
                where.Add(string.Format("fp.orderUpdated < '{0}'", maxTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")));
            }
            if (exceptUid.HasValue)
            {
                where.Add(string.Format("uid != {0}", exceptUid.Value));
            }
            builder.AppendFormat(" where {0} ORDER BY fp.orderUpdated DESC", string.Join(" and ", where));
            builder.AppendFormat(" OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, limit);
            var source = Context.Database.SqlQuery<Models.SqlQueryModel.ProjFootPrint>(builder.ToString());
            var count = source.Select(p => p.Total).FirstOrDefault();
            var model = source.Select(p => new Model.FootPrintModel()
            {
                Pid = p.Pid,
                Fid = p.Fid,
                Uid = p.Uid,
                Updated = p.Updated,
                Address = p.Address
            });
            return new PageModel<FootPrintModel>(model, count);
        }

        public Dictionary<long, string[]> GetEnableFootPrintImgs(long[] fids)
        {
            fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (fids.Length == 0) return new Dictionary<long, string[]>();
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fpi.fid");
            column.Add("fpi.[order]");
            column.Add("fpi.imageKey");
            builder.AppendFormat(" SELECT {0} from FootChat.dbo.FootPrintImg fpi with(nolock) ", string.Join(",", column));
            builder.AppendFormat(" where fpi.fid in ({0}) and fpi.isEnabled=1 ", string.Join(",", fids));

            var imgs = Context.Database.SqlQuery<Models.SqlQueryModel.EnableImag>(builder.ToString());
            return imgs.GroupBy(p=>p.fid).
                ToDictionary(p => p.Key, p => p.OrderBy(o => o.order == null).ThenBy(o => o.order).Select(o => o.imageKey).ToArray());
        }

        public Dictionary<long, long[]> GetFootPrintTagIds(long[] fids)
        {
            fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (fids.Length == 0) return new Dictionary<long, long[]>();
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fpt.fid");
            column.Add("fpt.tid ");
            builder.AppendFormat(" select {0} from FootChat.dbo.FootPrintTag fpt with (nolock) ", string.Join(",", column));
            builder.AppendFormat(" where fpt.fid in ({0})  ", string.Join(",", fids));

            return Context.Database.SqlQuery<Models.SqlQueryModel.FootPrintTagId>(builder.ToString())
                .GroupBy(p => p.fid).ToDictionary(p => p.Key, p => p.Select(t => t.tid).ToArray());
        }

        public Dictionary<long, long> GetProjFirstPassFid(long[] pids)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new Dictionary<long, long>(); 
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fp2.pid");
            column.Add("fp2.fid ");
            var innerColumn = new List<string>();
            var innerBuilder = new StringBuilder();
            innerColumn.Add("fp.pid");
            innerColumn.Add("fp.fid");
            innerColumn.Add("row_number() over(partition by fp.pid order by fp.updated desc) as num");
            innerBuilder.AppendFormat("select {0} from FootChat.dbo.FootPrint fp with(nolock)", string.Join(",", innerColumn));
            innerBuilder.AppendFormat("where fp.pid in ({0}) and fp.isEnable=1 and fp.state = 2", string.Join(",", pids));
            builder.AppendFormat(" select {0} from  ({1}) fp2 where fp2.num=1 ", string.Join(",", column) ,innerBuilder.ToString());

            return Context.Database.SqlQuery<Models.SqlQueryModel.ProjFirstPassFid>(builder.ToString()).ToDictionary(p => p.pid, p => p.fid);
        }

        public Dictionary<long, int> GetProjFootUserCount(long[] pids, long? exceptUid,FootPrintState[] states)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new Dictionary<long, int>();
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fp.pid");
            column.Add("count(distinct fp.uid) as userCount ");
            builder.AppendFormat(" select {0} from FootChat.dbo.FootPrint fp with(nolock) ", string.Join(",", column));
            var where = new List<string>();
            where.Add(string.Format("fp.pid in ({0})", string.Join(",", pids)));
            where.Add("fp.isEnable=1");
            if (states != null && states.Length > 0)
            {
                where.Add(string.Format("fp.state in ({0}) ", string.Join(",", states.Select(p => (byte)p))));
            }
            if (exceptUid.HasValue)
            {
                where.Add(string.Format("fp.uid !={0} ", exceptUid));
            }
            builder.AppendFormat(" where {0}  group by fp.pid ", string.Join(" and ", where));

            return Context.Database.SqlQuery<Models.SqlQueryModel.ProjPassFootUserCount>(builder.ToString()).ToDictionary(p => p.pid, p => p.userCount);
        }

        public Dictionary<long, long[]> GetProjLatestUids(long[] pids, FootPrintState[] states, long? exceptUid, int count)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new Dictionary<long, long[]>();
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("fp2.pid");
            column.Add("fp2.uid ");
            var innerColumn = new List<string>();
            var innerBuilder = new StringBuilder();
            innerColumn.Add("fp.pid");
            innerColumn.Add("fp.uid");
            innerColumn.Add("row_number() over(partition by fp.pid order by fp.updated desc) as num");
            innerBuilder.AppendFormat("select {0} from FootChat.dbo.FootPrint fp with(nolock)", string.Join(",", innerColumn));
            var innerWhere = new List<string>();
            innerWhere.Add(string.Format("fp.pid in ({0})", string.Join(",", pids)));
            innerWhere.Add(" fp.isEnable=1");
            if (states != null && states.Length > 0)
            {
                innerWhere.Add(string.Format("fp.state in ({0}) ", string.Join(",", states.Select(p => (byte)p))));
            }
            if (exceptUid.HasValue)
            {
                innerWhere.Add(string.Format("fp.uid !={0} ", exceptUid));
            }
            innerBuilder.AppendFormat("where {0} ", string.Join(" and ", innerWhere));
            builder.AppendFormat(" select {0} from  ({1}) fp2 where fp2.num<{2} ", string.Join(",", column) , innerBuilder.ToString(),count+1);

            return Context.Database.SqlQuery<Models.SqlQueryModel.ProjLatestUid>(builder.ToString())
                .GroupBy(p => p.pid).ToDictionary(p => p.Key, p => p.Select(u => u.uid).ToArray());
        }

        public long[] GetUserViewFootPrints(long uid,long[] exceptFids, int start, int limit)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            exceptFids = (exceptFids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            var sql = new StringBuilder();
            sql.Append("select fp.fid from FootChat.dbo.FootPrint fp  inner join FootChat.dbo.UserViewFootPrintRecord uvpr on fp.fid = uvpr.fid ");
            sql.AppendFormat("where uvpr.uid={0} and fp.state={1} and fp.isEnable=1 and fp.uid!={0} ",uid,(byte)FootPrintState.Pass);
            if (exceptFids.Any())
            {
                sql.AppendFormat(" and fp.fid not in ({0})", string.Join(",", exceptFids));
            }
            return Context.Database.SqlQuery<long>(SqlUtility.GetPageLimitSql(start, limit, sql.ToString(), "uvpr.updated")).ToArray();
        }

        public long[] GetTouristViewFootPrints(string deviceId, long[] exceptFids, int start, int limit)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(deviceId, nameof(deviceId));
            exceptFids = (exceptFids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            var sql = new StringBuilder();
            sql.Append("select fp.fid from FootChat.dbo.FootPrint fp  inner join FootChat.dbo.TouristViewFootPrintRecord tvpr on fp.fid = tvpr.fid ");
            sql.AppendFormat("where tvpr.devieceId='{0}' and fp.state={1} and fp.isEnable=1 ", deviceId, (byte)FootPrintState.Pass);
            if (exceptFids.Any())
            {
                sql.AppendFormat(" and fp.fid not in ({0})", string.Join(",", exceptFids));
            }
            return Context.Database.SqlQuery<long>(SqlUtility.GetPageLimitSql(start, limit, sql.ToString(), "tvpr.updated")).ToArray();
        }
    }

    public class FootPrintCount
    {
        public int totalCount { get; set; }
        public int totalPassFootPrintCount { get; set; }
        public int todayPassFootPrintCount { get; set; }
        public int todayUnPassFootPrintCount { get; set; }
    }

    public class UserUnReadFPCount
    {
        public long uid { get; set; }
        public int count { get; set; }
    }

    public class FollowProj
    {
        public long pid { get; set; }
        public int total { get; set; }
        public DateTime updated { get; set; }
    }
    
}
