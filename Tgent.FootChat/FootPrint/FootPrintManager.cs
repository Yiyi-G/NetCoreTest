using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.User;
using Tgnet.FootChat.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Tgnet.Core.Data;

namespace Tgnet.FootChat.FootPrint
{
    public interface IFootPrintManager
    {
        IFootPrintService AddOrUpdateFootPrint(User.IUserService user, UpdateFootPrintModel model);
        FootPrintModel[] GetFootPrints(long[] fids);
        Dictionary<long, string[]> GetEnableFootPrintImgs(long[] fids);
        Dictionary<long, long[]> GetFootPrintTagIds(long[] fids);
        /// <summary>
        /// 获取项目下的第一个足迹
        /// </summary>
        /// <param name="pids"></param>
        /// <returns></returns>
        Dictionary<long, long> GetProjPassFisrtFid(long[] pids);

        Dictionary<long, int> GetUserFootPrintNumByUids(long[] uids, FootPrintState[] states);
        PageModel<Data.FootPrint> SearchFootPrint(SearchFootPrintArgs args, int start, int limit);
        Data.FootPrint GetRandomUnverifiedFootPrint();
        Data.FootPrint GetFirstUnverifiedFootPrint();
        int GetUnverifiedFootPrintNum();
        IQueryable<Data.FootPrint> GetFootPrintByPids(long[] pids);
        IQueryable<Data.FootPrint> PassFootPrints { get; }

        StatisticalItem[] TodayFootPrintStatisticalItem(DateTime? time);
        StatisticalItem[] ThisWeekFootPrintStatisticalItem();
        StatisticalItem[] ThisMonthFootPrintStatisticalItem();
        StatisticalItem[] ThisYearFootPrintStatisticalItem();
        RangeStatistics RangeTimeFootPrintStatisticalItem(DateTime? startTime, DateTime? endTime);

        FootPrintCount GetFootPrintCount(DateTime date);
        int GetFootPrintCreatorCount(DateTime date);
        int GetTodayFootPrintCreatorCount(DateTime date);
        Dictionary<long, int> GetFootPrintProjFollowUserCount();
        PageModel<long> GetFollowProjs(long uid, int start, int limit);
        PageModel<FootPrintModel> GetProjFootPrintByPid(long pid, int start, int limit, long? exceptUid, DateTime? maxTime, FootPrintState[] states);
        /// <summary>
        /// 获取游客浏览过的足迹
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="exceptFids"></param>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        long[] GetTouristViewFootPrints(string deviceId, long[] exceptFids, int start, int limit);

        void UpdateProjBind(long pid, long newPid);
        void RestProjBind(long fid, long pid);
    }
    public class FootPrintManager : IFootPrintManager
    {
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IRepository<Data.FootPrintImg> _FootPrintImgRepository;
        private readonly IStaticResourceManager _StaticResourceManager;
        private readonly IRepository<Data.FootPrintTag> _FootPrintTagRepository;
        private readonly Project.IProjSourceManager _ProjSourceManager;
        private readonly IUserManager _UserManager;
        private readonly IFootPrintServiceFactory _FootPrintServiceFactory;
        private readonly IUserViewProjFootListRecordRepository _UserViewProjFootListRecordRepository;
        private readonly IUserFavoriteRepository _UserFavoriteRepository;
        private readonly FCRMAPI.IPushManager _EventPushManager;
        private readonly Docked.IDockedManager _DockedManager;


        public IQueryable<Data.FootPrint> PassFootPrints
        {
            get
            {
                return _FootPrintRepository.Entities.AsNoTracking().Where(f => f.isEnable && f.state == FootPrintState.Pass);
            }
        }


        public FootPrintManager(
            IFootPrintRepository footPrintRepository,
            IRepository<Data.FootPrintImg> footPrintImgRepository,
            IStaticResourceManager staticResourceManager,
            IRepository<Data.FootPrintTag> footPrintTagRepository,
            Project.IProjSourceManager projSourceManager,
            IUserManager userManager,
            IFootPrintServiceFactory footPrintServiceFactory,
            IUserViewProjFootListRecordRepository userViewProjFootListRecordRepository,
            IUserFavoriteRepository userFavoriteRepository,
            FCRMAPI.IPushManager eventPushManager,
            Docked.IDockedManager dockedManager
            )
        {
            _FootPrintRepository = footPrintRepository;
            _FootPrintImgRepository = footPrintImgRepository;
            _StaticResourceManager = staticResourceManager;
            _FootPrintTagRepository = footPrintTagRepository;
            _ProjSourceManager = projSourceManager;
            _FootPrintTagRepository = footPrintTagRepository;
            _ProjSourceManager = projSourceManager;
            _UserManager = userManager;
            _FootPrintServiceFactory = footPrintServiceFactory;
            _UserViewProjFootListRecordRepository = userViewProjFootListRecordRepository;
            _UserFavoriteRepository = userFavoriteRepository;
            _EventPushManager = eventPushManager;
            _DockedManager = dockedManager;

        }

        public IFootPrintService AddOrUpdateFootPrint(User.IUserService user, UpdateFootPrintModel model)
        {
            IFootPrintStrategy strategy;
            if (model.Pid > 0)
            {
                strategy = new ProjFootPrintWithPidStrategy(user,model, _FootPrintServiceFactory, _FootPrintRepository, _StaticResourceManager, _ProjSourceManager, _FootPrintImgRepository);
            }
            else
            {
                strategy = new ProjFootPrintWithNameStrategy(user,model, _FootPrintServiceFactory, _FootPrintRepository, _StaticResourceManager, _ProjSourceManager, _FootPrintImgRepository);
            }
            
            var service = strategy.SaveFootPrint();

            var fid = service.Fid;
            var taskFactory = new TaskFactory().StartNew(() =>
            {
                var url = "http://api.fc.t.tgnet.com/Api/InitFootPrintAddress";
                var query = new System.Collections.Specialized.NameValueCollection();
                query.Add("fid", fid.ToString());
                FCRMAPI.RequstUtility.TransmitToMQ(url, query, null);
            });
            return service;
        }

        public FootPrintModel[] GetFootPrints(long[] fids)
        {
            return _FootPrintRepository.GetFootPrints(fids);
        }
        public Dictionary<long, string[]> GetEnableFootPrintImgs(long[] fids)
        {
            return _FootPrintRepository.GetEnableFootPrintImgs(fids);
        }

        public Dictionary<long, long[]> GetFootPrintTagIds(long[] fids)
        {
            return _FootPrintRepository.GetFootPrintTagIds(fids);
        }



        public Dictionary<long,long> GetProjPassFisrtFid(long[] pids)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            return _FootPrintRepository.GetProjFirstPassFid(pids);
        }



        public IQueryable<Data.FootPrint> GetFootPrintByPids(long[] pids)
        {
            pids = (pids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (pids.Length == 0) return new Data.FootPrint[0].AsQueryable();
            var source = _FootPrintRepository.Entities.AsNoTracking();
            source = source.Where(p => pids.Any(i => i == p.pid && p.isEnable));
            return source;
        }

        public PageModel<FootPrintModel> GetProjFootPrintByPid(long pid, int start, int limit, long? exceptUid, DateTime? maxTime, FootPrintState[] states)
        {
            return _FootPrintRepository.GetProjFootPrintByPid(pid, start, limit, exceptUid, maxTime,states);
        }

        public Dictionary<long, int> GetUserFootPrintNumByUids(long[] uids,FootPrintState[] states)
        {
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            var result = new Dictionary<long, int>();
            if (uids.Length <= 0) return result;
            var source = _FootPrintRepository.Entities.AsNoTracking().Where(p => uids.Contains(p.uid) && p.isEnable);
            if (states != null && states.Length > 0)
            {
                source = source.Where(p => states.Contains(p.state));
            }
            result =source.GroupBy(p => p.uid).ToDictionary(p => p.Key, p => p.Count());
            return result;
        }

        public PageModel<Data.FootPrint> SearchFootPrint(SearchFootPrintArgs args, int start, int limit)
        {
            return _FootPrintRepository.GetPageItems(args, start, limit);
        }

        public Data.FootPrint GetRandomUnverifiedFootPrint()
        {
            var result = new Data.FootPrint();
            var source = _FootPrintRepository.Entities.AsNoTracking().Where(p => p.state == FootPrintState.None && p.isEnable);
            if (source.Any())
            {
                var pids = source.Select(p => p.pid).ToArray();
                var Seed = Guid.NewGuid().GetHashCode();
                var random = new Random(Seed);
                int index = random.Next(0, pids.Length); //生成随机下标
                var pid = pids[index];
                result = source.FirstOrDefault(p => p.pid == pid);
            }
            else
            {
                result = null;
            }
            return result;
        }

        public Data.FootPrint GetFirstUnverifiedFootPrint()
        {
            var minTime = "1900-01-01".To<DateTime>();
            //先判断有没有超时未完成的审核进行解锁（超过半个小时没有操作的）
            _FootPrintRepository.Update(p => p.isVerifiedLocked && System.Data.Entity.DbFunctions.DiffMinutes(p.verifiedlockDate, DateTime.Now) > 30, p => new Data.FootPrint { isVerifiedLocked = false, verifiedlockDate = minTime });

            //再拿出第一条未审核未锁定的
            var source = _FootPrintRepository.Entities.AsNoTracking().Where(p => p.state == FootPrintState.None && p.isVerifiedLocked == false && p.isEnable).OrderBy(p => p.created).FirstOrDefault();

            if (source != null)
            {
                //锁定
                _FootPrintRepository.Update(p => p.fid == source.fid, p => new Data.FootPrint { isVerifiedLocked = true, verifiedlockDate = DateTime.Now });
            }

            return source;
        }

        public int GetUnverifiedFootPrintNum()
        {
            return _FootPrintRepository.Entities.AsNoTracking().Where(p => p.state == FootPrintState.None && p.isEnable).Count();
        }

        public StatisticalItem[] TodayFootPrintStatisticalItem(DateTime? time)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisDayFpCreateNum = _FootPrintRepository.GetTodayPerHourFootPrintCreateNum(time);
            var result = GetFootPrintStatisticalItem(thisDayFpCreateNum);
            return result;
        }

        public StatisticalItem[] ThisWeekFootPrintStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisWeekFpCreateNum = _FootPrintRepository.GetThisWeekFootPrintCreateNum();
            var result = GetFootPrintStatisticalItem(thisWeekFpCreateNum);
            return result;
        }

        public StatisticalItem[] ThisMonthFootPrintStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisMonthFpCreateNum = _FootPrintRepository.GetThisMontFootPrintCreateNum();
            var result = GetFootPrintStatisticalItem(thisMonthFpCreateNum);
            return result;
        }

        public StatisticalItem[] ThisYearFootPrintStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisYearFpCreateNum = _FootPrintRepository.GetThisYearFootPrintCreateNum();
            var result = GetFootPrintStatisticalItem(thisYearFpCreateNum);
            return result;
        }

        private StatisticalItem[] GetRangeTimeFootPrintStatisticalItem(DateTime startTime, DateTime endTime)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var rangeTimeFpcreateNum = _FootPrintRepository.GetRangeTimeFootPrintCreateNum(startTime, endTime);
            var result = GetFootPrintStatisticalItem(rangeTimeFpcreateNum);
            return result;
        }

        public RangeStatistics RangeTimeFootPrintStatisticalItem(DateTime? startTime, DateTime? endTime)
        {
            var result = new RangeStatistics();
            if (startTime.HasValue && endTime.HasValue)
            {
                var minTime = startTime.Value;
                var maxTime = endTime.Value;
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "时间范围", "开始日期不能大于结束日期");
                var ts = maxTime - minTime;
                ExceptionHelper.ThrowIfTrue(ts.Days > 31, "时间范围", "时间区间不得超过31天");
                if (minTime.Date == maxTime.Date)
                {
                    //用24小时的
                    var date = minTime.Date;
                    result.item = TodayFootPrintStatisticalItem(date);
                    result.type = "24hour";
                }
                else
                {
                    //循环跨度遍历时间
                    //用天
                    result.item = GetRangeTimeFootPrintStatisticalItem(minTime, maxTime);
                    result.type = "range";
                }
            }
            if (startTime.HasValue && !endTime.HasValue)
            {
                var date = startTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayFootPrintStatisticalItem(date);
                result.type = "24hour";
            }
            if (!startTime.HasValue && endTime.HasValue)
            {
                var date = endTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayFootPrintStatisticalItem(date);
                result.type = "24hour";
            }
            return result;
        }

        private StatisticalItem[] GetFootPrintStatisticalItem(Dictionary<int, int> createNumDict)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var createNumItem = new StatisticalItem { Name = "发布量", NumDict = createNumDict };
            item.Add(createNumItem);
            return item.ToArray();
        }

        public FootPrintCount GetFootPrintCount(DateTime date)
        {
            return _FootPrintRepository.GetFootPrintCount(date);
        }

        public int GetFootPrintCreatorCount(DateTime date)
        {
            return _FootPrintRepository.GetFootPrintCreatorCount(date);
        }

        public int GetTodayFootPrintCreatorCount(DateTime date)
        {
            return _FootPrintRepository.GetTodayFootPrintCreatorCount(date);
        }

        public Dictionary<long,int> GetFootPrintProjFollowUserCount()
        {
            return _FootPrintRepository.Entities.AsNoTracking().Where(p => p.isEnable).GroupBy(p => p.pid).ToDictionary(p => p.Key, p => p.Select(d => d.uid).Distinct().Count());
        }

        public PageModel<long> GetFollowProjs(long uid, int start, int limit)
        {
            return _FootPrintRepository.GetFollowProjs(uid,start,limit);
        }

        public long[] GetTouristViewFootPrints(string deviceId, long[] exceptFids, int start, int limit)
        {
            return _FootPrintRepository.GetTouristViewFootPrints(deviceId, exceptFids, start, limit);
        }

        public void UpdateProjBind(long pid, long newPid)
        {
            if (pid != newPid)
            {
                var passFids = new List<long>();
                using (var scope = new TransactionScope())
                {
                    var entitys = _FootPrintRepository.Entities.Where(p => p.pid == pid).ToArray();
                    foreach (var entity in entitys)
                    {
                        entity.pid = newPid;
                        if (entity.state == FootPrintState.Pass)
                            passFids.Add(entity.fid);
                    }
                    _FootPrintRepository.SaveChanges();
                    _UserFavoriteRepository.Update(p => p.pid == pid, p => new UserFavorite()
                    {
                        pid = newPid
                    });
                    _UserViewProjFootListRecordRepository.Update(p => p.pid == pid, p => new UserViewProjFootListRecord()
                    {
                        pid = newPid
                    });
                    scope.Complete();
                }
                if (passFids.Any())
                {
                    var taskFactory = new TaskFactory();
                    foreach (var fid in passFids)
                    {
                        taskFactory.StartNew(() =>
                        {
                            _EventPushManager.UpdateFootPrintProj(fid, newPid, transmitToMQ: true);
                        });
                    }
                }
            }
        }


        /// <summary>
        /// 重置足迹项目id（但暂时业务圈那边修改不了）
        /// </summary>
        /// <param name="fid"></param>
        /// <param name="pid"></param>
        public void RestProjBind(long fid,long pid)
        {
            ExceptionHelper.ThrowIfNotId(fid,nameof(fid));
            ExceptionHelper.ThrowIfNotId(pid, nameof(pid));
            _FootPrintRepository.Update(p => p.fid == fid, p => new Data.FootPrint { pid = pid });
        }

    }
    public class SearchFootPrintArgs
    {
        public void VerifySearchFootPrintArgs()
        {
            if (!string.IsNullOrWhiteSpace(startTime) && !string.IsNullOrWhiteSpace(endTime))
            {
                var minTime = startTime.To<DateTime>();
                var maxTime = endTime.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "时间范围", "开始日期不能大于结束日期");
                var ts = maxTime - minTime;
                ExceptionHelper.ThrowIfTrue(ts.Days > 365, "时间范围", "时间区间不得超过1年");
            }
            if (!string.IsNullOrWhiteSpace(transferMinTime) && !string.IsNullOrWhiteSpace(transferMaxTime))
            {
                var sTime = transferMinTime.To<DateTime>();
                var eTime = transferMaxTime.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(sTime > eTime, "时间范围", "开始日期不能大于结束日期");
            }
        }

        public SearchFootPrintArgs()
        {
            isInner = false;
        }
        public string keyWord { get; set; }
        public string userName { get; set; }
        public string startTime { get; set; }//搜索创建时间
        public string endTime { get; set; }//搜索创建时间
        public string projName { get; set; }
        public string mobile { get; set; }
        public FootPrintState? footPrintState { get; set; }
        public TransferScales? transferScales { get; set; }//采编标签
        public TransferState? transferState { get; set; }//采编状态
        public bool? isInnerProject { get; set; }//项目属性
        public bool? isInner { get; set; }
        public long? userId { get; set; }
        public bool? isProjectEdition { get; set; }//是否项目采编
        public string transferMinTime { get; set; }//搜索采编时间
        public string transferMaxTime { get; set; }//搜索采编时间
        public long? fid { get; set; }//足迹id
    }

    
}
