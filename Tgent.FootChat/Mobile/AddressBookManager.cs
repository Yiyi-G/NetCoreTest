using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Linq;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.User;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.Events;

namespace Tgnet.FootChat.Mobile
{
    public interface IAddressBookManager
    {
        /// <summary>
        /// 获取有特定号码且未推荐给好友的记录
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        IQueryable<Data.AddressBookMobile> GetHas(string mobile);
        void SetRecommendedState(bool recommended, string mobile, long[] uids);
        IUserAddressBookManager GetUserAddressBookManager(IUserService user);
        IQueryable<Data.AddressBookMobile> Attention { get; }
        int GetMaxAttentionCount();

        /// <summary>
        /// 今天24小时关注好友统计数据
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        StatisticalItem[] TodayAttentionStatisticalItem(DateTime? time);

        /// <summary>
        /// 本周关注好友统计数据
        /// </summary>
        /// <returns></returns>
        StatisticalItem[] ThisWeekAttentionStatisticalItem();

        /// <summary>
        /// 本月关注好友统计数据
        /// </summary>
        /// <returns></returns>
        StatisticalItem[] ThisMonthAttentionStatisticalItem();

        /// <summary>
        /// 今年关注好友统计数据
        /// </summary>
        /// <returns></returns>
        StatisticalItem[] ThisYearAttentionStatisticalItem();

        /// <summary>
        /// //时间段内关注好友统计数据
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        RangeStatistics RangeTimeAttentionStatisticalItem(DateTime? startTime, DateTime? endTime);

        AttentionCount GetAttentionCount(DateTime date);//关注好友总次数 每日新增关注次数
        int GetAttentionUserCount(DateTime date);//关注好友的总人数
        int GetTodayAttentionUserCount(DateTime date);//每日新增关注好友人数
        int GetInvitationNum(DateTime date);//成功邀请数
        int GetTodayInvitationNum(DateTime date);//每日新增成功邀请数
    }

    class AddressBookManager : IAddressBookManager
    {
        private readonly Data.IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IFootChatUserRepository _UserRepository;
        private readonly IUserEventFactory _UserEventFactory;
        private readonly FCRMAPI.IPushManager _PushManager;


        public IQueryable<AddressBookMobile> Attention
        {
            get
            {
                return _AddressBookMobileRepository.Entities.Where(a => a.isAttention);
            }
        }

        public AddressBookManager(Data.IAddressBookMobileRepository addressBookMobileRepository,
            IFootChatUserRepository userRepository,
            IUserEventFactory userEventFactory,
            FCRMAPI.IPushManager pushManager)
        {
            _AddressBookMobileRepository = addressBookMobileRepository;
            _UserRepository = userRepository;
            _UserEventFactory = userEventFactory;
            _PushManager = pushManager;
        }
        public IQueryable<Data.AddressBookMobile> GetHas(string mobile)
        {
            if (!StringRule.VerifyMobile(mobile))
                return Enumerable.Empty<Data.AddressBookMobile>().AsQueryable();
            return _AddressBookMobileRepository.Entities.Where(b => b.mobile == mobile && !b.haveRecommended);
        }
        public void SetRecommendedState(bool recommended, string mobile, long[] uids)
        {
            if (StringRule.VerifyMobile(mobile) && uids != null && uids.Length > 0)
            {
                _AddressBookMobileRepository.Update(a => a.mobile == mobile && uids.Contains(a.uid), a => new Data.AddressBookMobile { haveRecommended = recommended });
            }
        }
        public IUserAddressBookManager GetUserAddressBookManager(IUserService user)
        {
            return new UserAddressBookManager(user, _AddressBookMobileRepository, _UserRepository,_UserEventFactory,_PushManager);
        }
        public int GetMaxAttentionCount()
        {
            var count = Attention.GroupBy(a => a.uid).Max(a => a.Count());
            return count > 100 ? count : 128;
        }

        public StatisticalItem[] TodayAttentionStatisticalItem(DateTime? time)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var perHourAttentionNum = _AddressBookMobileRepository.GetTodayPerHourAttentionNum(time);//今天24小时关注次数                   
            var perHourInvitationNum = _AddressBookMobileRepository.GetTodayPerHourInvitationNum(time);//今天24小时成功邀请数
            var result = GetAttentionStatisticalItem(perHourAttentionNum, perHourInvitationNum);
            return result;
        }

        public StatisticalItem[] ThisWeekAttentionStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisWeekAttentionNum = _AddressBookMobileRepository.GetThisWeekAttentionNum();//本周关注次数
            var thisWeekInvitationNum = _AddressBookMobileRepository.GetThisWeekInvitationNum();//本周成功邀请数
            var result = GetAttentionStatisticalItem(thisWeekAttentionNum, thisWeekInvitationNum);
            return result;
        }

        public StatisticalItem[] ThisMonthAttentionStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisMontAttentionNum = _AddressBookMobileRepository.GetThisMontAttentionNum();//本月关注次数
            var thisMonthInvitationNum = _AddressBookMobileRepository.GetThisMonthInvitationNum();//本月成功邀请数
            var result = GetAttentionStatisticalItem(thisMontAttentionNum, thisMonthInvitationNum);
            return result;
        }

        public StatisticalItem[] ThisYearAttentionStatisticalItem()
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var thisYearAttentionNum = _AddressBookMobileRepository.GetThisYearAttentionNum();//本年关注次数
            var thisYearInvitationNum = _AddressBookMobileRepository.GetThisYearInvitationNum();//本年成功邀请数
            var result = GetAttentionStatisticalItem(thisYearAttentionNum, thisYearInvitationNum);
            return result;
        }

        private StatisticalItem[] GetRangeTimeAttentionStatisticalItem(DateTime startTime, DateTime endTime)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var rangeTimeAttentionNum = _AddressBookMobileRepository.GetRangeTimeAttentionNum(startTime, endTime);//时间段范围内关注次数
            var rangeTimeInvitationNum = _AddressBookMobileRepository.GetRangeInvitationNum(startTime, endTime);//时间段内陈工邀请数
            var result = GetAttentionStatisticalItem(rangeTimeAttentionNum, rangeTimeInvitationNum);
            return result;
        }

        public RangeStatistics RangeTimeAttentionStatisticalItem(DateTime? startTime, DateTime? endTime)
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
                    result.item = TodayAttentionStatisticalItem(date);
                    result.type = "24hour";
                }
                else
                {
                    //循环跨度遍历时间
                    //用天
                    result.item = GetRangeTimeAttentionStatisticalItem(minTime, maxTime);
                    result.type = "range";
                }
            }
            if (startTime.HasValue && !endTime.HasValue)
            {
                var date = startTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayAttentionStatisticalItem(date);
                result.type = "24hour";
            }
            if (!startTime.HasValue && endTime.HasValue)
            {
                var date = endTime.Value.Date;
                //获取当天24小时的数据
                result.item = TodayAttentionStatisticalItem(date);
                result.type = "24hour";
            }
            return result;
        }

        private StatisticalItem[] GetAttentionStatisticalItem(Dictionary<int, int> attentionNumDict, Dictionary<int, int> invitationNumDict)
        {
            List<StatisticalItem> item = new List<StatisticalItem>();
            var attentionItem = new StatisticalItem { Name = "关注次数", NumDict = attentionNumDict };
            var invitationItem = new StatisticalItem { Name = "成功邀请数", NumDict = invitationNumDict };
            item.Add(attentionItem);
            item.Add(invitationItem);
            return item.ToArray();
        }

        public AttentionCount GetAttentionCount(DateTime date)//关注好友总次数 每日新增关注次数
        {
            return _AddressBookMobileRepository.GetAttentionCount(date);
        }
        public int GetAttentionUserCount(DateTime date)//关注好友的总人数
        {
            return _AddressBookMobileRepository.GetAttentionUserCount(date);
        }
        public int GetTodayAttentionUserCount(DateTime date)//每日新增关注好友人数
        {
            return _AddressBookMobileRepository.GetTodayAttentionUserCount(date);
        }
        public int GetInvitationNum(DateTime date)//成功邀请数
        {
            return _AddressBookMobileRepository.GetInvitationNum(date);
        }
        public int GetTodayInvitationNum(DateTime date)//每日新增成功邀请数
        {
            return _AddressBookMobileRepository.GetTodayInvitationNum(date);
        }
    }
}
