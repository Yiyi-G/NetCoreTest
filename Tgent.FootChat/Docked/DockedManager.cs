using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Events;
using Tgnet.FootChat.FootPrint;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Docked
{
    public interface IDockedManager
    {
        long AddDockRequest(IUserService user, long dockUid, long fid, string message, bool hasPassFootPirnt, out bool isNeedNotifyReciver);
        IQueryable<Data.DockedRecord> GetDockedRecords();
        Dictionary<long, DockedState> GetDockStates(IUserService user, long[] fids);
        void ApplyUserRequest(IUserService user);
        int GetUserUnSendRequestCount(long uid, DateTime? min);
        StatisticalItem[] TodayDockedNumStatisticalItem(DateTime? time);
        StatisticalItem[] ThisWeekDockedNumStatisticalItem();
        StatisticalItem[] ThisMonthDockedNumStatisticalItem();
        StatisticalItem[] ThisYearDockedNumStatisticalItem();
        RangeStatistics RangeTimeDockedNumStatisticalItem(DateTime? startTime, DateTime? endTime);
        DockedCount GetDockedCount(DateTime date);
        Dictionary<long, int> GetReceiverPassDockedNum(long[] uids);
        Dictionary<long, int> GetSenderPassedDockedNum(long[] uids);
        PageModel<SearchDockedResult> SearchDockedRecord(SearchDockedArgs args, int start, int limit);
    }
    public class DockedManager : IDockedManager
    {
        private readonly Data.IDockedRecordRepository _DockedRecordRepository;
        private readonly IFootPrintDockedEventFactory _FootPrintDockedEventFactory;
        public DockedManager(
            Data.IDockedRecordRepository dockedRecordRepository,
            IFootPrintDockedEventFactory footPrintDockedEventFactory)
        {
            _DockedRecordRepository = dockedRecordRepository;
            _FootPrintDockedEventFactory = footPrintDockedEventFactory;
        }
        public long  AddDockRequest(IUserService user, long dockUid,long fid, string message,bool hasPassFootPirnt,out bool isNeedNotifyReciver)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            ExceptionHelper.ThrowIfNotId(dockUid, nameof(dockUid));
            ExceptionHelper.ThrowIfNotId(fid, nameof(fid));
            var uid = user.Uid;
            var now = DateTime.Now;
            var entity = _DockedRecordRepository.Entities.Where(p => p.sender == uid && p.receiver == dockUid&&p.fid==fid).FirstOrDefault();
            isNeedNotifyReciver = false;
            if (entity == null)
            {
                if (hasPassFootPirnt)
                    isNeedNotifyReciver = true;
                entity = _DockedRecordRepository.Add(new Data.DockedRecord()
                {
                    sender = uid,
                    receiver = dockUid,
                    fid = fid,
                    message = message,
                    status = hasPassFootPirnt ? DockedStatus.Apply : DockedStatus.None,
                    created = now,
                    updated = now
                });
                _DockedRecordRepository.Add(entity);
                _DockedRecordRepository.SaveChanges();
            }
            else
            {
                if (entity.status== DockedStatus.None&&hasPassFootPirnt)
                {
                    isNeedNotifyReciver = true;
                    entity.status = DockedStatus.Apply;
                    entity.updated = now;
                    _DockedRecordRepository.SaveChanges();
                }
            }
            return entity.fid;
        }

        public void ApplyUserRequest(IUserService user)
        {
            var uid = user.Uid;
            bool needNotify = false;
            var now = DateTime.Now;
            List<UserDockMsg> unSendUserDockMsgs = new List<UserDockMsg>(); ;
            var dockRecoreds = _DockedRecordRepository.Entities.Where(p => p.sender == uid && p.status == Docked.DockedStatus.None).ToArray();
            if (dockRecoreds.Any())
            {
                needNotify = true;
                foreach (var dockRecord in dockRecoreds)
                {
                    dockRecord.status = Docked.DockedStatus.Apply;
                    dockRecord.updated = now;
                    unSendUserDockMsgs.Add(new UserDockMsg() { Uid = dockRecord.receiver, Msg = dockRecord.message });
                }
                _DockedRecordRepository.SaveChanges();
            }
            if (needNotify)
            {
                try
                {
                    _FootPrintDockedEventFactory.CreateEvent().OnDockedApply(dockRecoreds);
                }
                catch (System.Exception e)
                {
                    Tgnet.Log.LoggerResolver.Current.Error(e);
                    Tgnet.Log.LoggerResolver.Current.Debug("请求对接，发送通知失败", e.Message);
                }
            }
        }

        public IQueryable<DockedRecord> GetDockedRecords()
        {
            return _DockedRecordRepository.Entities;
        }

        public Dictionary<long, DockedState> GetDockStates(IUserService user, long[] fids)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            fids = (fids ?? new long[0]).Distinct().ToArray();
            var uid = user.Uid;
            var source = from u in _DockedRecordRepository.Entities
                         where fids.Contains(u.fid) && u.sender == uid
                         select new {
                             u.fid,
                             u.updated,
                             u.status
                         };
            var footsDocks = source.ToArray();
            var dockStates = new Dictionary<long, DockedState>();
            foreach (var fid in fids)
            {
                var state = DockedState.None;
                var footDocks = footsDocks.Where(p => p.fid==fid);
                foreach (var footDock in footDocks)
                {
                    if (footDock.status == DockedStatus.Pass)
                    {
                        state = DockedState.Success;
                        break;
                    }
                    if (footDock.status == DockedStatus.UnPass || footDock.status == DockedStatus.Apply)
                    {
                        state = DockedState.Requested;
                        break;
                    }
                }
                dockStates.Add(fid, state);
            }
            return dockStates;
        }

        public int GetUserUnSendRequestCount(long uid, DateTime? min)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            var source = _DockedRecordRepository.Entities.Where(p => p.sender == uid && p.status == DockedStatus.None);
            if (min.HasValue)
            {
                source = source.Where(p => p.updated > min.Value);
            }
            return source.Count();
        }

        public StatisticalItem[] TodayDockedNumStatisticalItem(DateTime? time)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var todayPerHrDockedSuccessNum = _DockedRecordRepository.GetTodayPerHourDockedSuccessNum(time);
            var todayPerHrDockedPassNum = _DockedRecordRepository.GetTodayPerHourDockedPassNum(time);
            var result = GetDockedNumStatisticalItem(todayPerHrDockedSuccessNum, todayPerHrDockedPassNum);
            return result;
        }

        public StatisticalItem[] ThisWeekDockedNumStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisWeekDockedSuccessNum = _DockedRecordRepository.GetThisWeekDockedSuccessNum();
            var thisWeekDockedPassNum = _DockedRecordRepository.GetThisWeekDockedPassNum();
            var result = GetDockedNumStatisticalItem(thisWeekDockedSuccessNum, thisWeekDockedPassNum);
            return result;
        }

        public StatisticalItem[] ThisMonthDockedNumStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisMonthDockedSuccessNum = _DockedRecordRepository.GetThisMontDockedSuccessNum();
            var thisMonthDockedPassNum = _DockedRecordRepository.GetThisMontDockedPassNum();
            var result = GetDockedNumStatisticalItem(thisMonthDockedSuccessNum, thisMonthDockedPassNum);
            return result;
        }

        public StatisticalItem[] ThisYearDockedNumStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisYearDockedSuccessNum = _DockedRecordRepository.GetThisYearDockedSuccessNum();
            var thisYearDockedPassNum = _DockedRecordRepository.GetThisYearDockedPassNum();
            var result = GetDockedNumStatisticalItem(thisYearDockedSuccessNum, thisYearDockedPassNum);
            return result;
        }

        private StatisticalItem[] GetRangeTimeDockedNumStatisticalItem(DateTime startTime, DateTime endTime)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var rangeTimeDockedSuccessNum = _DockedRecordRepository.GetRangeTimeDockedSuccessNum(startTime, endTime);
            var rangeTimeDockedPassNum = _DockedRecordRepository.GetRangeTimeDockedPassNum(startTime, endTime);
            var result = GetDockedNumStatisticalItem(rangeTimeDockedSuccessNum, rangeTimeDockedPassNum);
            return result;
        }

        public RangeStatistics RangeTimeDockedNumStatisticalItem(DateTime? startTime, DateTime? endTime)
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
                    result.item = TodayDockedNumStatisticalItem(date);
                    result.type = "24hour";
                }
                else
                {
                    //循环跨度遍历时间
                    //用天
                    result.item = GetRangeTimeDockedNumStatisticalItem(minTime, maxTime);
                    result.type = "range";
                }
            }
            if (startTime.HasValue && !endTime.HasValue)
            {
                var date = startTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayDockedNumStatisticalItem(date);
                result.type = "24hour";
            }
            if (!startTime.HasValue && endTime.HasValue)
            {
                var date = endTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayDockedNumStatisticalItem(date);
                result.type = "24hour";
            }
            return result;
        }

        private StatisticalItem[] GetDockedNumStatisticalItem(Dictionary<int, int> dockedSuccessNumDict, Dictionary<int, int> dockedPassNumDict)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var dockedSuccessNumItem = new StatisticalItem { Name = "成功对接请求数", NumDict = dockedSuccessNumDict };
            var dockedPassNumItem = new StatisticalItem { Name = "同意对接数", NumDict = dockedPassNumDict };
            item.Add(dockedSuccessNumItem);
            item.Add(dockedPassNumItem);
            return item.ToArray();
        }

        public DockedCount GetDockedCount(DateTime date)
        {
            return _DockedRecordRepository.GetDockedCount(date);
        }

        /// <summary>
        /// 收到对接请求主动同意
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        public Dictionary<long, int> GetReceiverPassDockedNum(long[] uids)
        {
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            var result = new Dictionary<long, int>();
            if (uids.Length <= 0) return result;
            //收到对接请求主动同意
            var source = _DockedRecordRepository.Entities.AsNoTracking().Where(p => uids.Contains(p.receiver) && p.status == DockedStatus.Pass);
            result = source.GroupBy(p => p.receiver).ToDictionary(p => p.Key, p => p.Count());
            return result;           
        }

        /// <summary>
        /// 发出对接请求被同意的 
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        public Dictionary<long, int> GetSenderPassedDockedNum(long[] uids)
        {
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            var result = new Dictionary<long, int>();
            if (uids.Length <= 0) return result;
            //发出对接请求被同意的 
            var source = _DockedRecordRepository.Entities.AsNoTracking().Where(p => uids.Contains(p.sender) && p.status == DockedStatus.Pass);
            result = source.GroupBy(p => p.sender).ToDictionary(p => p.Key, p => p.Count());
            return result;            
        }

        public PageModel<SearchDockedResult> SearchDockedRecord(SearchDockedArgs args, int start, int limit)
        {
            return _DockedRecordRepository.SearchDockedRecord(args, start, limit);
        }
    }
    public class SearchDockedArgs
    {
        public void VerifySearchDockedArgs()
        {
            if (!string.IsNullOrWhiteSpace(startTime) && !string.IsNullOrWhiteSpace(endTime))
            {
                var minTime = startTime.To<DateTime>();
                var maxTime = endTime.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "时间范围", "开始日期不能大于结束日期");
            }
            if(status.HasValue)
            {
                ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(DockedStatus), status.Value), "status", "值不在范围内");
            }            
        }

        public string sender { get; set; }//发送人
        public string receiver { get; set; }//接收人
        public string startTime { get; set; }//搜索发送时间
        public string endTime { get; set; }//搜索发送时间
        public DockedStatus? status { get; set; }//处理结果
    }
}
