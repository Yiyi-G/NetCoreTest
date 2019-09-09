using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.User;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Project
{
    public interface IUserProjectSourceManager
    {
        void AddUserViewProjRecord(IUserService user, long pid);
        void AddViewProjFootPrintRecord(IUserService user, long pid);
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
        Dictionary<long, int> GetProjDynamicUpdatedCount(long uid, long[] pids);

    }

    public class UserProjectSourceManager : IUserProjectSourceManager
    {
        private readonly IUserViewProjFootListRecordRepository _UserViewProjFootListRecordRepository;
        private readonly IUserViewProjRecordRepository _UserViewProjRecordRepository;

        public UserProjectSourceManager(
            IUserViewProjRecordRepository userViewProjRecordRepository,
            IUserViewProjFootListRecordRepository userViewProjFootListRecordRepository
            )
        {

            _UserViewProjRecordRepository = userViewProjRecordRepository;
            _UserViewProjFootListRecordRepository = userViewProjFootListRecordRepository;
        }

        public void AddUserViewProjRecord(IUserService user, long pid)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            ExceptionHelper.ThrowIfNotId(pid, nameof(pid));
            var uid = user.Uid;
            var pids = new long[] { pid };
            var now = DateTime.Now;
            _UserViewProjRecordRepository.AddAndDeleteExcept(
                p => p.uid == uid&&p.pid==pid,
                pids,
                (u, v) => u.pid == v,
                (u, v) =>
                {
                    u.updated = now;
                },
                u => { return false; },
                v => new UserViewProjRecord()
                {
                    uid = uid,
                    pid = v,
                    updated = now
                });
        }

        public void AddViewProjFootPrintRecord(IUserService user, long pid)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            ExceptionHelper.ThrowIfNotId(pid, nameof(pid));
            var uid = user.Uid;
            var pids = new long[] { pid };
            var now = DateTime.Now;
            _UserViewProjFootListRecordRepository.AddAndDeleteExcept(
                p => p.uid == uid && p.pid == pid,
                pids,
                (u, v) => u.pid == v,
                (u, v) =>
                {
                    u.updated = now;
                },
                u => { return false; },
                v => new UserViewProjFootListRecord()
                {
                    uid = uid,
                    pid = v,
                    updated = now
                });
        }

        public bool CheckUserFollowProjDynamicHasUpdated(long uid)
        {
           return _UserViewProjRecordRepository.CheckUserFollowProjDynamicHasUpdated(uid);
        }

        public bool CheckUserFavoriteProjDynamicHasUpdated(long uid)
        {
            return _UserViewProjRecordRepository.CheckUserFavoriteProjDynamicHasUpdated(uid);
        }

        public Dictionary<long, int> GetProjDynamicUpdatedCount(long uid, long[] pids)
        {
            return _UserViewProjRecordRepository.GetProjDynamicUpdatedCount(uid, pids);
        }
    }


}
