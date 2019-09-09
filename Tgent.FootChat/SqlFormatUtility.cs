using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat
{
    public static class SqlFormatUtility
    {
        public static string GetTableQuerySqlFormat(SqlFormatComponent component)
        {
            ExceptionHelper.ThrowIfNull(component, nameof(component));
            component.CheckAndFormat();
            var sql = string.Format("select {0} from {1}", string.Join(",", component.Column), component.From);
            if (component.Andwhere.Any())
            {
                sql = string.Format("{0} where {1} ", sql, string.Join(" and ", component.Andwhere));
            }
            if (component.Groupby.Any())
            {
                sql = string.Format("{0} group by {1}", sql, string.Join(",", component.Groupby));
            }

            if (component.Orderby.Any())
            {
                sql = string.Format("{0} order by {1}", sql, string.Join(",", component.Orderby));
            }
            if (component.Start .HasValue && component.Limit .HasValue)
            {
                sql = string.Format("{0} offset {1} rows fetch next {2} rows only ", sql, component.Start, component.Limit);
            }
            return sql;

        }
    }

    public class SqlFormatComponent
    {
       public string From { get; set; }
        public IEnumerable<string> Column{get;set;}
        public IEnumerable<string> Andwhere{get;set;}
        public IEnumerable<string> Groupby{get;set;}
        public IEnumerable<string> Orderby{get;set;}
        public int? Start{get;set;}
        public int? Limit { get; set; }

        public void CheckAndFormat()
        {
            Column = (Column ?? new string[0]).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
            Andwhere = (Andwhere ?? new string[0]).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
            Groupby = (Groupby ?? new string[0]).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
            Orderby = (Orderby ?? new string[0]).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
            if (!Column.Any())
                Column = new string[] { "*" };
            ExceptionHelper.ThrowIfNullOrWhiteSpace(From, nameof(From));
        }
    }
}
