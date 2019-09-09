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
    public interface IUserViewProjRecordRepository : IRepository<Data.UserViewProjRecord>
    {
        /// <summary>
        /// 判断用户跟进项目是否有新的动态
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        bool CheckUserFollowProjDynamicHasUpdated(long uid);
        /// <summary>
        /// 判断用户收藏项目是否有新的动态
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        bool CheckUserFavoriteProjDynamicHasUpdated(long uid);
        /// <summary>
        /// 获取项目下更新动态数量
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pids"></param>
        /// <returns></returns>
        Dictionary<long, int> GetProjDynamicUpdatedCount(long uid,long[] pids);
    }
    public class UserViewProjRecordRepository : BaseRepository<UserViewProjRecord>, IUserViewProjRecordRepository
    {
        public UserViewProjRecordRepository(FootChatContext context) : base(context)
        {
        }

        public bool CheckUserFavoriteProjDynamicHasUpdated(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            var sqlformat = @"
	                        SELECT CASE 
		                        WHEN EXISTS (
			                        SELECT 1
			                        FROM FootChat.dbo.UserFavorite uf WITH (nolock)  
				                        JOIN Tg_Ywt.dbo.ProjectSource ps WITH (nolock) ON uf.pid = ps.pid
				                        JOIN JSEC_ProjectDB.dbo.ProjVersion pv WITH (nolock) ON ps.tgProjId = pv.projID
				                        left join (select * from FootChat.dbo.UserViewProjRecord WITH (nolock) where uid = {0} ) uvp  ON uf.pid = uvp.pid
			                        WHERE 
				                        uf.uid = {0} 
				                        AND (uvp.updated is null or pv.projVerPublishDate > uvp.updated )
				                        AND pv.projVerIsStageUpdated = 0
				                        AND ( pv.projVerIsFollow = 1 OR pv.projVerIsContentUpdated = 1)
				                        AND pv.projVerEnabled = 1
				                        AND uf.isEnabled = 1
		                        ) THEN 'true'
		                        WHEN EXISTS (
			                        SELECT 1
			                        FROM  FootChat.dbo.UserFavorite uf WITH (nolock)
				                        JOIN Tg_Ywt.dbo.ProjectSource ps WITH (nolock) ON uf.pid = ps.pid
				                        JOIN JSEC_ProjectDB.dbo.BidProjectRelation bpr WITH (nolock) ON ps.tgProjId = bpr.tgPid
				                        left JOIN  (select * from FootChat.dbo.UserViewProjRecord WITH (nolock) where uid = {0} ) uvp  ON uf.pid = uvp.pid
			                        WHERE 
				                        uf.uid = {0}
				                        AND (uvp.updated is null or bpr.bidPublish > uvp.updated )
				                        AND uf.isEnabled = 1
				                        AND bpr.enabled = 1
		                        ) THEN 'true'
		                        ELSE 'false'
	                        END
	    
                ";
            var sql = string.Format(sqlformat, uid);
            return Boolean.Parse(Context.Database.SqlQuery<string>(sql).FirstOrDefault());
        }

        public bool CheckUserFollowProjDynamicHasUpdated(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            var sqlformat = @"
                            SELECT CASE 
		                            WHEN EXISTS (
			                            SELECT 1
			                            FROM FootChat.dbo.FootPrint fp WITH (nolock)  
				                            JOIN Tg_Ywt.dbo.ProjectSource ps WITH (nolock) ON fp.pid = ps.pid
				                            JOIN JSEC_ProjectDB.dbo.ProjVersion pv WITH (nolock) ON ps.tgProjId = pv.projID
				                            left join (select * from FootChat.dbo.UserViewProjRecord WITH (nolock) where uid = {0} )  uvp  ON fp.pid = uvp.pid
			                            WHERE 
				                            fp.uid = {0} 
				                            AND (uvp.updated is null or pv.projVerPublishDate > uvp.updated )
				                            AND pv.projVerIsStageUpdated = 0
				                            AND ( pv.projVerIsFollow = 1 OR pv.projVerIsContentUpdated = 1)
				                            AND fp.isEnable = 1
				                            AND pv.projVerEnabled = 1
		                            ) THEN 'true'
		                            WHEN EXISTS (
			                            SELECT 1
			                            FROM  FootChat.dbo.FootPrint fp WITH (nolock) 
				                            JOIN Tg_Ywt.dbo.ProjectSource ps WITH (nolock) ON fp.pid = ps.pid
				                            JOIN JSEC_ProjectDB.dbo.BidProjectRelation bpr WITH (nolock) ON ps.tgProjId = bpr.tgPid
				                            left JOIN (select * from FootChat.dbo.UserViewProjRecord WITH (nolock) where uid = {0} ) uvp  ON fp.pid = uvp.pid
			                            WHERE 
			                            fp.uid = {0}  
				                        AND (uvp.updated is null or bpr.bidPublish > uvp.updated )
			                            AND fp.isEnable = 1
				                        AND bpr.enabled = 1
		                            ) THEN 'true'
		                            ELSE 'false'
	                            END
                        ";
            var sql = string.Format(sqlformat, uid);
            return Boolean.Parse(Context.Database.SqlQuery<string>(sql).FirstOrDefault());
        }

        public Dictionary<long, int> GetProjDynamicUpdatedCount(long uid,long[] pids)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new Dictionary<long, int>();
            var sqlFormat = @"
                                SELECT upd.pid, COUNT(upd.pid) AS [count]
                                FROM (
	                                SELECT ps.pid
	                                FROM Tg_Ywt.dbo.ProjectSource ps WITH (nolock)
		                                JOIN JSEC_ProjectDB.dbo.ProjVersion pv WITH (nolock) ON ps.tgProjId = pv.projID
		                                LEFT JOIN (select * from FootChat.dbo.UserViewProjRecord WITH (nolock) where uid = {1} )  uvp  ON uvp.pid = ps.pid
	                                WHERE ps.pid IN ({0})
		                                AND pv.projVerIsStageUpdated = 0
		                                AND pv.projVerEnabled = 1
		                                AND ( pv.projVerIsFollow = 1 OR pv.projVerIsContentUpdated = 1)
		                                AND (uvp.updated IS NULL OR pv.projVerPublishDate > uvp.updated)
	                                UNION ALL
	                                SELECT ps.pid
	                                FROM Tg_Ywt.dbo.ProjectSource ps WITH (nolock)
		                                JOIN JSEC_ProjectDB.dbo.BidProjectRelation bpr WITH (nolock) ON ps.tgProjId = bpr.tgPid
		                                LEFT JOIN (select * from FootChat.dbo.UserViewProjRecord WITH (nolock) where uid = {1} ) uvp ON uvp.pid = ps.pid
	                                WHERE ps.pid IN ({0})
		                                AND (uvp.updated IS NULL OR bpr.bidPublish > uvp.updated)
		                                AND bpr.enabled = 1
                                ) upd
                                GROUP BY upd.pid
                        ";
            var sql = string.Format(sqlFormat, string.Join(",", pids), uid);
            return Context.Database.SqlQuery<ProjDynmicCount>(sql).ToDictionary(p => p.pid, p => p.count);
        }
    }

    public class ProjDynmicCount
    {
        public long pid { get; set; }
        public int count { get; set; }
    }
}
