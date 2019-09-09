using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data.Entity;
using Tgnet.Data.Entity.Core;
using Tgnet.FootChat.FootPrint;

namespace Tgnet.FootChat.Data
{
    public class BaseRepository<T> : DbSetRepository<DbContext, T> where T : class
    {
        private readonly DbContext _Context;
        private readonly DbSet<T> _DbSet;
        public BaseRepository(DbContext context) : base(context)
        {
            _Context = context;
            _DbSet = _Context.Set<T>();
        }
        protected override DbSet<T> DbSet
        {
            get { return _DbSet; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableWithWhere">from后面的sql，没有order by形如：dbo.Project p where p.projNo!=''</param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected int GetCount(String tableWithWhere, IDictionary<String, String> parameters)
        {
            if (parameters == null)
            {
                parameters = new Dictionary<String, String>();
            }
            return Context.Database.SqlQuery<int>("select count(1) from " + tableWithWhere, parameters.Select(p => new SqlParameter(p.Key, p.Value)).ToArray()).First();
        }

        protected RT[] GetItems<RT>(String sql, IDictionary<String, String> parameters)
        {
            if (parameters == null)
            {
                parameters = new Dictionary<String, String>();
            }
            return Context.Database.SqlQuery<RT>(sql, parameters.Select(p => new SqlParameter(p.Key, p.Value)).ToArray()).ToArray();
        }
    }


    public class HourCount
    {
        public int hour { get; set; }
        public int count { get; set; }
    }

    public class DayCount
    {
        public int day { get; set; }
        public int count { get; set; }
    }

    public class MonthCount
    {
        public int month { get; set; }
        public int count { get; set; }
    }

    public class DateCount
    {
        public string dt { get; set; }
        public int count { get; set; }
    }

   
    public class FootPrintImgRepository : BaseRepository<FootPrintImg>
    {
        public FootPrintImgRepository(FootChatContext context) : base(context)
        {
        }
    }

    public class FootPrintTagRepository : BaseRepository<FootPrintTag>
    {
        public FootPrintTagRepository(FootChatContext context) : base(context)
        {
        }
    }
   



    public class UserBusinessAreaRepository : BaseRepository<UserBusinessArea>
    {
        public UserBusinessAreaRepository(FootChatContext context) : base(context)
        {
        }
    }
    public class MobileInfoRepository : BaseRepository<MobileInfo>
    {
        public MobileInfoRepository(FootChatContext context) : base(context)
        {
        }
    }
    public class UserComplainRepository : BaseRepository<UserComplain>
    {
        public UserComplainRepository(FootChatContext context) : base(context)
        {
        }
    }


    public class UserLoginRecordRepository : BaseRepository<UserLoginRecord>
    {
        public UserLoginRecordRepository(FootChatContext context) : base(context)
        {
        }
    }
    public class UserProductRepository : BaseRepository<UserProduct>
    {
        public UserProductRepository(FootChatContext context) : base(context)
        {
        }
    }
    public class UserBrandRepository : BaseRepository<UserBrand>
    {
        public UserBrandRepository(FootChatContext context) : base(context)
        {
        }
    }

    public class TradeRepository : BaseRepository<Trade>
    {
        public TradeRepository(FootChatContext context) : base(context)
        { }
    }

    public class UserServiceStateUpdateRecordRepository : BaseRepository<UserServiceStateUpdateRecord>
    {
        public UserServiceStateUpdateRecordRepository(FootChatContext context) : base(context)
        { }
    }

    public class UserViewFootPrintRecordRepository : BaseRepository<UserViewFootPrintRecord>
    {
        public UserViewFootPrintRecordRepository(FootChatContext context) : base(context)
        { }
    }
    public class TouristViewFootPrintRecordRepository : BaseRepository<TouristViewFootPrintRecord>
    {
        public TouristViewFootPrintRecordRepository(FootChatContext context) : base(context)
        { }
    }

    public class UserStatisticsRepository : BaseRepository<UserStatistics>
    {
        public UserStatisticsRepository(FootChatContext context) : base(context)
        { }
    }

    public class FootPrintStatisticsRepository : BaseRepository<FootPrintStatistics>
    {
        public FootPrintStatisticsRepository(FootChatContext context) : base(context)
        { }
    }

    public class AttentionStatisticsRepository : BaseRepository<AttentionStatistics>
    {
        public AttentionStatisticsRepository(FootChatContext context) : base(context)
        { }
    }

    public class SuggestFeedbackRepository : BaseRepository<SuggestFeedback>
    {
        public SuggestFeedbackRepository(FootChatContext context) : base(context)
        { }
    }
    public class ImportUserRecordRepository : BaseRepository<ImportUserRecord>
    {
        public ImportUserRecordRepository(FootChatContext context) : base(context)
        { }
    }
    public class ImportFootPrintRecordRepository : BaseRepository<ImportFootPrintRecord>
    {
        public ImportFootPrintRecordRepository(FootChatContext context) : base(context)
        { }
    }

    public class InstitudeOfGrowthTradeRepository : BaseRepository<InstitudeOfGrowthTrade>
    {
        public InstitudeOfGrowthTradeRepository(FootChatContext context) : base(context)
        { }
    }

    public class InteractionStatisticsRepository : BaseRepository<InteractionStatistics>
    {
        public InteractionStatisticsRepository(FootChatContext context) : base(context)
        { }
    }

    public class DockedStatisticsRepository : BaseRepository<DockedStatistics>
    {
        public DockedStatisticsRepository(FootChatContext context) : base(context)
        { }
    }

    public class ClassRepository : BaseRepository<Class>
    {
        public ClassRepository(FootChatContext context) : base(context)
        { }
    }

    public class ClassStuRelationRepository : BaseRepository<ClassStuRelation>
    {
        public ClassStuRelationRepository(FootChatContext context) : base(context)
        { }
    }

    public class AssociatedProjRecordRepository : BaseRepository<AssociatedProjRecord>
    {
        public AssociatedProjRecordRepository(FootChatContext context) : base(context)
        { }
    }

    //public class AdminUserRepository : BaseRepository<AdminUser>
    //{
    //    public AdminUserRepository(AdminDBContext context) : base(context)
    //    { }
    //}

    //public class ViewSysACLCacheRepository : BaseRepository<ViewSysACLCache>
    //{
    //    public ViewSysACLCacheRepository(AdminDBContext context) : base(context)
    //    { }
    //}

   


    public static class SqlUtility
    {
        public static string GetPageSql(int pageIndex, int pageSize, string columns, string tableWithWhere, string orderBy)
        {
            pageIndex = Math.Max(pageIndex, 1);
            int min = (pageIndex - 1) * pageSize;
            int max = pageIndex * pageSize;
            string sqlFormate = @"SELECT * FROM(
SELECT ROW_NUMBER() OVER(ORDER BY {0}) AS rno, {1} From {2}
) AS table0 WHERE rno>{3} AND rno<={4} order by rno asc";
            return string.Format(sqlFormate, orderBy, columns, tableWithWhere, min, max);
        }

        public static string GetPageLimitSql(int start, int limit, string columns, string tableWithWhere, string orderBy)
        {
            if (start > 0)
            {
                return @"SELECT * FROM(
SELECT ROW_NUMBER() OVER(ORDER BY " + orderBy + ") AS rno, " + columns + @" From " + tableWithWhere + @"
) AS table0 WHERE rno>" + start + " AND rno<=" + (start + limit) + "  order by rno asc";
            }
            else
            {
                return "select top " + limit + " " + columns + " from " + tableWithWhere + " order by " + orderBy;
            }
        }
        public static string GetPageLimitSql(int start, int limit, string sql, string orderBy)
        {
            sql += " order by " + orderBy;
            sql += string.Format(" offset {0} rows fetch next {1} rows only ", start, limit);
            return sql;
        }

        public static String GetSafeSqlValue(this String value)
        {
            return value.Replace("'", String.Empty).Replace("--", String.Empty);
        }


        public static string GetWithASPageSql(string columns, string tableWithWhere, string orderBy, int pageIndex, int pageSize)
        {
            pageIndex = Math.Max(pageIndex, 1);
            int min = (pageIndex - 1) * pageSize;
            int max = pageIndex * pageSize;

            string sqlFormate = @"WITH t AS( SELECT {0} FROM {1})
SELECT * FROM (
SELECT ROW_NUMBER() OVER(ORDER BY {2}) AS row ,* FROM t
)AS tb WHERE tb.row BETWEEN {3} AND {4} order by tb.row asc";

            return string.Format(sqlFormate, columns, tableWithWhere, orderBy, min + 1, max);
        }
    }
}
