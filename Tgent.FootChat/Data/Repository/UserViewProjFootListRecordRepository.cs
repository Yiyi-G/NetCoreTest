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
    public interface IUserViewProjFootListRecordRepository : IRepository<Data.UserViewProjFootListRecord>
    {
        /// <summary>
        /// 获取用户跟进项目是否有新的足迹
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        bool CheckUserFollowProjHasNewOtherFootPrint(long uid);
        /// <summary>
        /// 获取用户收藏项目是否有新的足迹
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        bool CheckUserFavoriteProjHasNewOtherFootPrint(long uid);
        /// <summary>
        /// 获取项目下新的足迹数量
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pids"></param>
        /// <returns></returns>
        Dictionary<long, int> GetProjNewOtherFootPrintCount(long uid, long[] pids);

    }
    public class UserViewProjFootListRecordRepository : BaseRepository<UserViewProjFootListRecord>, IUserViewProjFootListRecordRepository
    {
        public UserViewProjFootListRecordRepository(FootChatContext context) : base(context)
        {
        }

        public bool CheckUserFavoriteProjHasNewOtherFootPrint(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            var sqlFormat = @"
                                SELECT CASE 
		                                WHEN EXISTS (
			                                SELECT 1
			                                FROM  FootChat.dbo.UserFavorite uf WITH (nolock)
				                                JOIN FootChat.dbo.FootPrint othorfp WITH (nolock) ON othorfp.pid = uf.pid
				                                left join (select * from  FootChat.dbo.UserViewProjFootListRecord WITH (nolock)  where uid = {0} ) uvp ON uf.pid = uvp.pid
			                                WHERE
				                                uf.uid = {0}
				                                AND othorfp.state = 2
				                                AND uf.isEnabled =1
				                                AND othorfp.isEnable = 1 
				                                AND (uvp.updated is null or othorfp.orderUpdated > uvp.updated)
				                                AND othorfp.uid != {0}
		                                ) THEN 'true'
		                                ELSE 'false'
	                                END
                        ";
            var sql = string.Format(sqlFormat, uid);
            return Boolean.Parse(Context.Database.SqlQuery<string>(sql).FirstOrDefault());
        }

        public bool CheckUserFollowProjHasNewOtherFootPrint(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            var sqlFormat = @"
                            SELECT CASE 
		                            WHEN EXISTS (
			                            SELECT 1
			                            FROM  FootChat.dbo.FootPrint fp WITH (nolock)
				                            JOIN FootChat.dbo.FootPrint othorfp WITH (nolock) ON othorfp.pid = fp.pid
				                            left JOIN (select * from  FootChat.dbo.UserViewProjFootListRecord WITH (nolock)  where uid = {0}) uvp ON fp.pid = uvp.pid
			                            WHERE
				                            fp.uid = {0}
				                            AND othorfp.state = 2
				                            AND fp.isEnable =1
				                            AND othorfp.isEnable = 1
				                            AND (uvp.updated is null or othorfp.orderUpdated > uvp.updated)
				                            AND othorfp.uid != {0}
		                            ) THEN 'true'
		                            ELSE 'false'
	                            END
                        ";
            var sql = string.Format(sqlFormat, uid);
            return Boolean.Parse(Context.Database.SqlQuery<string>(sql).FirstOrDefault());
        }

        public Dictionary<long,int> GetProjNewOtherFootPrintCount(long uid, long[] pids)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new Dictionary<long, int>();
            var sqlFormat = @"
                                SELECT othorfp.pid, COUNT(othorfp.pid) AS [count]
                                FROM FootChat.dbo.FootPrint othorfp WITH (nolock)
	                                LEFT JOIN (select * from  FootChat.dbo.UserViewProjFootListRecord WITH (nolock) where uid = {1})  uvp ON othorfp.pid = uvp.pid
                                WHERE othorfp.pid IN ({0})
                                    AND othorfp.state = 2
	                                AND (uvp.updated IS NULL  OR othorfp.orderUpdated > uvp.updated)
	                                AND othorfp.isEnable = 1
	                                AND othorfp.uid != {1}
                                GROUP BY othorfp.pid		
                        ";
            var sql = string.Format(sqlFormat,string.Join(",",pids) ,uid);
            return Context.Database.SqlQuery<ProjFootCount>(sql).ToDictionary(p=>p.pid,p=>p.count);
        }
    }
    public class ProjFootCount
    {
        public long pid { get; set; }
        public int count { get; set; }
    }
}
