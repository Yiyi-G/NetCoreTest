using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Models;

namespace Tgnet.FootChat.Mobile
{
    public interface ICallRecordManager
    {
        StatisticalItem[] TodayCallNumStatisticalItem(DateTime? time);
        StatisticalItem[] ThisWeekCallNumStatisticalItem();
        StatisticalItem[] ThisMonthCallNumStatisticalItem();
        StatisticalItem[] ThisYearCallNumStatisticalItem();
        RangeStatistics RangeTimeCallNumStatisticalItem(DateTime? startTime, DateTime? endTime);
        CallNum GetCallNum(DateTime date);//点击拨打总条数 每日点击拨打条数
        VipCallNum GetVipCallNum(DateTime date);//vip拨打总条数 每日vip拨打条数
        int GetCallUserNum(DateTime date);//拨打电话总人数
        int GetVipCallUserNum(DateTime date);//vip拨打人数
        int GetTodayVipCallUserNum(DateTime date);//每日vip拨打人数
    }
    public class CallRecordManager: ICallRecordManager
    {
        private readonly ICallRecordRepository _CallRecordRepository;

        public CallRecordManager(ICallRecordRepository callRecordRepository)
        {
            _CallRecordRepository = callRecordRepository;
        }

        public StatisticalItem[] TodayCallNumStatisticalItem(DateTime? time)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var todayPerHourCallNum = _CallRecordRepository.GetTodayPerHourCallNum(time);
            var todayPerHourVipCallNum = _CallRecordRepository.GetTodayPerHourVipCallNum(time);
            var result = GetCallNumStatisticalItem(todayPerHourCallNum, todayPerHourVipCallNum);
            return result;
        }

        public StatisticalItem[] ThisWeekCallNumStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisWeekCallNum = _CallRecordRepository.GetThisWeekCallNum();
            var thisWeekVipCallNum = _CallRecordRepository.GetThisWeekVipCallNum();
            var result = GetCallNumStatisticalItem(thisWeekCallNum, thisWeekVipCallNum);
            return result;
        }

        public StatisticalItem[] ThisMonthCallNumStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisMonthCallNum = _CallRecordRepository.GetThisMonthCallNum();
            var thisMonthVipCallNum = _CallRecordRepository.GetThisMonthVipCallNum();
            var result = GetCallNumStatisticalItem(thisMonthCallNum, thisMonthVipCallNum);
            return result;
        }

        public StatisticalItem[] ThisYearCallNumStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisYearCallNum = _CallRecordRepository.GetThisYearCallNum();
            var thisYearVipCallNum = _CallRecordRepository.GetThisYearVipCallNum();
            var result = GetCallNumStatisticalItem(thisYearCallNum, thisYearVipCallNum);
            return result;
        }

        private StatisticalItem[] GetRangeTimeCallNumStatisticalItem(DateTime startTime, DateTime endTime)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var rangeTimeCallNum = _CallRecordRepository.GetRangeTimeCallNum(startTime, endTime);
            var rangeTimeVipCallNum = _CallRecordRepository.GetRangeTimeVipCallNum(startTime, endTime);
            var result = GetCallNumStatisticalItem(rangeTimeCallNum, rangeTimeVipCallNum);
            return result;
        }

        public RangeStatistics RangeTimeCallNumStatisticalItem(DateTime? startTime, DateTime? endTime)
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
                    result.item = TodayCallNumStatisticalItem(date);
                    result.type = "24hour";
                }
                else
                {
                    //循环跨度遍历时间
                    //用天
                    result.item = GetRangeTimeCallNumStatisticalItem(minTime, maxTime);
                    result.type = "range";
                }
            }
            if (startTime.HasValue && !endTime.HasValue)
            {
                var date = startTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayCallNumStatisticalItem(date);
                result.type = "24hour";
            }
            if (!startTime.HasValue && endTime.HasValue)
            {
                var date = endTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayCallNumStatisticalItem(date);
                result.type = "24hour";
            }
            return result;
        }

        private StatisticalItem[] GetCallNumStatisticalItem(Dictionary<int, int> callNumDict, Dictionary<int, int> vipNumDict)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var callNumItem = new StatisticalItem { Name = "点击拨打条数", NumDict = callNumDict };
            var vipCallNumItem = new StatisticalItem { Name = "vip拨打条数", NumDict = vipNumDict };
            item.Add(callNumItem);
            item.Add(vipCallNumItem);
            return item.ToArray();
        }

        //点击拨打总条数 每日点击拨打条数
        public CallNum GetCallNum(DateTime date)
        {
            return _CallRecordRepository.GetCallNum(date);
        }

        //vip拨打总条数 每日vip拨打条数
        public VipCallNum GetVipCallNum(DateTime date)
        {
            return _CallRecordRepository.GetVipCallNum(date);
        }

        //拨打电话总人数
        public int GetCallUserNum(DateTime date)
        {
            return _CallRecordRepository.GetCallUserNum(date);
        }

        //vip拨打人数
        public int GetVipCallUserNum(DateTime date)
        {
            return _CallRecordRepository.GetVipCallUserNum(date);
        }

        //每日vip拨打人数
        public int GetTodayVipCallUserNum(DateTime date)
        {
            return _CallRecordRepository.GetTodayVipCallUserNum(date);
        }        
    }
}
