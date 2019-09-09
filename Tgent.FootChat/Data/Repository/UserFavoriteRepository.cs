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
    public interface IUserFavoriteRepository:IRepository<Data.UserFavorite>
    {
        Dictionary<long, bool> GetUserFavorites(long uid, long[] pids);
        PageModel<Models.SqlQueryModel.ProjFavorite> GetUserFavoriteProjs(long uid,int start, int limit);
    }

    public class UserFavoriteRepository: BaseRepository<UserFavorite>, IUserFavoriteRepository
    {
        public UserFavoriteRepository(FootChatContext context) : base(context)
        {
        }

        public PageModel<ProjFavorite> GetUserFavoriteProjs(long uid,int start, int limit)
        {
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("count(1) over() as total");
            column.Add("uf.pid ");
            column.Add("uf.updated ");
            builder.AppendFormat(" select {0} from FootChat.dbo.UserFavorite uf with(nolock) ", string.Join(",", column));
            builder.AppendFormat(" where uf.uid={0} and uf.isEnabled =1 ", uid);
            builder.Append(" order by uf.Updated desc");
            builder.AppendFormat(" offset {0} row fetch next {1} rows only",start,limit);
            var source = Context.Database.SqlQuery<ProjFavorite>(builder.ToString());
            var count = source.Select(p => p.total).FirstOrDefault();

            return new PageModel<ProjFavorite>(source.ToArray(), count);
        }

        public Dictionary<long, bool> GetUserFavorites(long uid,long[] pids)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new Dictionary<long, bool>();
            var builder = new StringBuilder();
            var column = new List<string>();
            column.Add("uf.pid");
            column.Add("uf.isEnabled ");
            builder.AppendFormat(" select {0} from FootChat.dbo.UserFavorite uf with(nolock) ", string.Join(",", column));
            builder.AppendFormat(" where uf.uid={0} and uf.pid in ({1})  ",uid, string.Join(",", pids));

            return Context.Database.SqlQuery<Models.SqlQueryModel.UserProjFavorite>(builder.ToString())
                .ToDictionary(p => p.pid, p => p.isEnabled);
        }
    }
}
