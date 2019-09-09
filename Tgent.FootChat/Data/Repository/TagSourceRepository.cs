using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity.Core;

namespace Tgnet.FootChat.Data
{
    public interface ITagSourceRepository : IRepository<Data.TagSource>
    {
        Dictionary<long, string[]> GetFootPrintTagNameByFids(long[] fids);
        Dictionary<long, string> GetTagName(long[] tids);
    }

    public class TagSourceRepository : BaseRepository<TagSource>, ITagSourceRepository
    {
        public TagSourceRepository(FootChatContext context) : base(context)
        {
        }

        public Dictionary<long, string[]> GetFootPrintTagNameByFids(long[] fids)
        {
            var result = new Dictionary<long, string[]>();
            if (fids.Length <= 0) return result;
            var sql = @"SELECT fp.fid,ts.name FROM FootChat.dbo.TagSource ts WITH(NOLOCK)
INNER JOIN FootChat.dbo.FootPrintTag fpt WITH(NOLOCK)
ON fpt.tid=ts.tid
INNER JOIN FootChat.dbo.FootPrint fp WITH(NOLOCK)
ON fpt.fid=fp.fid
WHERE fp.fid IN(" + String.Join(",", fids) + @")";
            var source = Context.Database.SqlQuery<FootPrintTagName>(sql).ToArray();
            result = source.GroupBy(p => p.fid).ToDictionary(p => p.Key, p => p.Select(d => d.name).ToArray());
            return result;
        }

        public Dictionary<long, string> GetTagName(long[] tids)
        {
            tids = (tids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (tids.Length == 0) return new Dictionary<long, string>();
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("ts.tid");
            column.Add("ts.name ");
            builder.AppendFormat(" select {0} from FootChat.dbo.TagSource ts with(nolock) ", string.Join(",", column));
            builder.AppendFormat(" where ts.tid in ({0})  ", string.Join(",", tids));
            return Context.Database.SqlQuery<Models.SqlQueryModel.TagName>(builder.ToString()).ToDictionary(p => p.tid, p => p.name);
        }



    }

    public class FootPrintTagName
    {
        public long fid { get; set; }
        public string name { get; set; }
    }
}
