using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using System.Data.Entity;
using Tgnet.Linq;
using Tgnet.FootChat.User;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.Models.FootPrint;

namespace Tgnet.FootChat.FootPrint
{
    public interface IUserFootPrintManager
    {
        /// <summary>
        /// 获取项目下发布足迹的用户量
        /// </summary>
        /// <returns></returns>
        Dictionary<long, int> GetProjFootUserCount(long[] pids, long exceptUid, FootPrintState[] states);
        /// <summary>
        /// 获取项目下最新发布足迹的uids
        /// </summary>
        /// <param name="pids"></param>
        /// <param name="state"></param>
        /// <param name="exceptUids"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Dictionary<long, long[]> GetProjLatestUids(long[] pids, FootPrintState[] states, long exceptUid, int count);

        IQueryable<Data.FootPrint> GetUserFootPrints(long uid);
        PageModel<FootPrintModel> GetUserFootPrints(long uid, FootPrintState[] states, DateTime? max, bool showContent, int start, int limit);


        void DeleteByPid(IUserService user, long pid);
        void Delete(IUserService user, long[] fids);
        /// <summary>
        /// 获取用户查看项目下足迹的权限
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pid"></param>
        /// <param name="fids">返回审核不通过的fid</param>
        /// <returns></returns>
        ViewProjFootPrintAuth GetUserViewProjFootPrintAuth(IUserService user, long pid, out long[] fids);
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

        /// <summary>
        /// 获取用户足迹（通过pids）
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pids"></param>
        /// <returns></returns>
        FootPrintModel[] GetUserFootPrintByPids(long uid, long[] pids);
        /// <summary>
        /// 获取用户查看过的足迹
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="exceptFids"></param>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        long[] GetUserViewFootPrints(long uid, long[] exceptFids, int start, int limit);

        Models.FootPrint.ViewFootPrintModel[] GetUserViewFootPrints(long uid, int start, int limit, out int count);

    }
    public class UserFootPrintManager : IUserFootPrintManager
    {

        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IUserViewProjFootListRecordRepository _UserViewProjFootListRecordRepository;
        private readonly FCRMAPI.IPushManager _PushManager;
        private readonly IRepository<Data.UserViewFootPrintRecord> _UserViewFootPrintRecordRepository;


        public UserFootPrintManager(
           IFootPrintRepository footPrintRepository,
           IUserViewProjFootListRecordRepository userViewProjFootListRecordRepository,
           FCRMAPI.IPushManager pushManager,
           IRepository<Data.UserViewFootPrintRecord> userViewFootPrintRecordRepository
           )
        {
            _FootPrintRepository = footPrintRepository;
            _UserViewProjFootListRecordRepository = userViewProjFootListRecordRepository;
            _PushManager = pushManager;
            _UserViewFootPrintRecordRepository = userViewFootPrintRecordRepository;
        }

        public IQueryable<Data.FootPrint> GetUserFootPrints(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            return _FootPrintRepository.Entities.AsNoTracking().Where(p => p.uid == uid && p.isEnable);
        }
        public PageModel<FootPrintModel> GetUserFootPrints(long uid, FootPrintState[] states, DateTime? max, bool showContent, int start, int limit)
        {
            if (uid <= 0) return new PageModel<FootPrintModel>();

            FootPrintModel[] list;
            var source = _FootPrintRepository.Entities.AsNoTracking().Where(p => p.uid == uid && p.isEnable);
            if (states!=null&&states.Length>0)
                source = source.Where(p => states.Contains(p.state));
            if (max.HasValue)
                source = source.Where(p => p.orderUpdated < max.Value);
            var count = source.Count();
            source = source.OrderByDescending(p => p.orderUpdated).Take(start, limit);
            if (showContent)
                list = source.Select(p => new FootPrintModel()
                {
                    Pid = p.pid,
                    Uid = p.uid,
                    Fid = p.fid,
                    Address = p.address,
                    Updated = p.updated,
                    IsEnabled = p.isEnable
                }).ToArray();
            else
                list = source.Select(p => new FootPrintModel()
                {
                    Pid = p.pid,
                    Uid = p.uid,
                    Fid = p.fid,
                    Address = p.address,
                    Content = p.content,
                    Updated = p.updated,
                    IsEnabled = p.isEnable
                }).ToArray();
            return new PageModel<FootPrintModel>(list, count);
        }

        public void DeleteByPid(IUserService user, long pid)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            ExceptionHelper.ThrowIfNotId(pid, nameof(pid));
            var uid = user.Uid;
            var entitys = _FootPrintRepository.Entities.Where(p => p.uid == uid && p.pid == pid);
            foreach (var entity in entitys)
            {
                entity.isEnable = false;
            }
            _FootPrintRepository.SaveChanges();
            var delFids = entitys.Select(p => p.fid).ToArray();
            var taskFactory = new TaskFactory();
            taskFactory.StartNew(() =>
            {
                foreach (var delFid in delFids)
                {
                    _PushManager.DeleteFootPrint(delFid);
                }
            });
           
            //_FootPrintRepository.Update(p =>p.uid==uid&&p.pid == pid, p => new Data.FootPrint() { isEnable = false });
        }

        public void Delete(IUserService user, long[] fids)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (fids.Length == 0) return;
            var uid = user.Uid;
            var entitys = _FootPrintRepository.Entities.Where(p => p.uid == uid && fids.Contains(p.fid));
            foreach (var entity in entitys)
            {
                entity.isEnable = false;
            }
            _FootPrintRepository.SaveChanges();
            var delFids = entitys.Select(p => p.fid).ToArray();
            var taskFactory = new TaskFactory();
            taskFactory.StartNew(() =>
            {
                foreach (var delFid in delFids)
                {
                    _PushManager.DeleteFootPrint(delFid);
                }
            });
            //_FootPrintRepository.Update(p => p.uid == uid && fids.Any(f => f == p.fid), p => new Data.FootPrint() { isEnable = false });
        }

        public Dictionary<long, int> GetProjFootUserCount(long[] pids, long exceptUid, FootPrintState[] states)
        {
           return _FootPrintRepository.GetProjFootUserCount(pids, exceptUid, states);
        }
        public Dictionary<long, long[]> GetProjLatestUids(long[] pids, FootPrintState[] states, long exceptUid, int count)
        {
            return _FootPrintRepository.GetProjLatestUids(pids, states, exceptUid, count);
        }
        public ViewProjFootPrintAuth GetUserViewProjFootPrintAuth(IUserService user, long pid, out long[] fids)
        {
            ExceptionHelper.ThrowIfNotId(pid, nameof(pid));
            fids = new long[0];
            if (user == null) return ViewProjFootPrintAuth.NoFootPrint;
            var source = _FootPrintRepository.Entities.AsNoTracking().Where(p => p.pid == pid && p.uid == user.Uid && p.isEnable).Select(p => new
            {
                fid = p.fid,
                state = p.state,
                updated = p.updated
            }).ToArray();
            var state = new FootPrintState[] { FootPrintState.Pass, FootPrintState.None };
            if (!source.Any()) return ViewProjFootPrintAuth.NoFootPrint;
            if (source.Any(p => state.Contains(p.state))) return ViewProjFootPrintAuth.CanView;
            //var unpassFootPrints = source.Where(p => p.state == FootPrintState.UnPass);
            fids = source.OrderByDescending(p => p.updated).Select(p => p.fid).ToArray();
            return ViewProjFootPrintAuth.ExsitUnpassFootPrint;
        }

        public bool CheckUserFollowProjHasNewOtherFootPrint(long uid)
        {
            return _UserViewProjFootListRecordRepository.CheckUserFollowProjHasNewOtherFootPrint(uid);
        }

        public bool CheckUserFavoriteProjHasNewOtherFootPrint(long uid)
        {
            return _UserViewProjFootListRecordRepository.CheckUserFavoriteProjHasNewOtherFootPrint(uid);
        }

        public Dictionary<long, int> GetProjNewOtherFootPrintCount(long uid, long[] pids)
        {
            return _UserViewProjFootListRecordRepository.GetProjNewOtherFootPrintCount(uid, pids);
        }

        public FootPrintModel[] GetUserFootPrintByPids(long uid, long[] pids)
        {
            return _FootPrintRepository.GetUserFootPrintByPids(uid, pids);
        }

        public long[] GetUserViewFootPrints(long uid, long[] exceptFids, int start, int limit)
        {
            return _FootPrintRepository.GetUserViewFootPrints(uid, exceptFids, start, limit);
        }

        public ViewFootPrintModel[] GetUserViewFootPrints(long uid, int start, int limit, out int count)
        {
            count = _UserViewFootPrintRecordRepository.Entities.Count(p => p.uid == uid);
            var source = from uvfp in _UserViewFootPrintRecordRepository.Entities
                         join fp in _FootPrintRepository.Entities
                         on uvfp.fid equals fp.fid
                         where uvfp.uid==uid
                         select new ViewFootPrintModel
                         {
                             Fid = fp.fid,
                             ViewDate = uvfp.updated,
                             Pid = fp.pid,
                             IsEnable = fp.isEnable,
                             Uid = fp.uid
                         };
            return source.OrderByDescending(p => p.ViewDate).Take(start, limit).ToArray();

        }
    }
}
