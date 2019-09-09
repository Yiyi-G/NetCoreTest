using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Docked;
using Tgnet.FootChat.FootPrint;
using Tgnet.FootChat.Mobile;
using Tgnet.FootChat.Statistics;
using Tgnet.FootChat.Trade;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Events
{
    public interface IStatisticsEventFactory
    {
        IStatisticsEvent CreateEvent();
    }

    public class StatisticsEventFactory : IStatisticsEventFactory
    {
        private readonly IUserManager _UserManager;
        private readonly IUserServiceStateManager _UserServiceStateManager;
        private readonly ITradeManager _TradeManager;
        private readonly IFootPrintManager _FootPrintManager;
        private readonly IUserStatisticsManager _UserStatisticsManager;
        private readonly IFootPrintStatisticsManager _FootPrintStatisticsManager;
        private readonly IAddressBookManager _AddressBookManager;
        private readonly IAttentionStatisticsManager _AttentionStatisticsManager;
        private readonly ICallRecordManager _CallRecordManager;
        private readonly IInteractionStatisticsManager _InteractionStatisticsManager;
        private readonly IDockedManager _DockedManager;
        private readonly IDockedStatisticsManager _DockedStatisticsManager;

        public StatisticsEventFactory(IUserManager userManager,
            IUserServiceStateManager userServiceStateManager,
            ITradeManager tradeManager,
            IFootPrintManager footPrintManager,
            IUserStatisticsManager userStatisticsManager,
            IFootPrintStatisticsManager footPrintStatisticsManager,
            IAddressBookManager addressBookManager,
            IAttentionStatisticsManager attentionStatisticsManager,
            ICallRecordManager callRecordManager,
            IInteractionStatisticsManager interactionStatisticsManager,
            IDockedManager dockedManager,
            IDockedStatisticsManager dockedStatisticsManager)
        {
            _UserManager = userManager;
            _UserServiceStateManager = userServiceStateManager;
            _TradeManager = tradeManager;
            _FootPrintManager = footPrintManager;
            _UserStatisticsManager = userStatisticsManager;
            _FootPrintStatisticsManager = footPrintStatisticsManager;
            _AddressBookManager = addressBookManager;
            _AttentionStatisticsManager = attentionStatisticsManager;
            _CallRecordManager = callRecordManager;
            _InteractionStatisticsManager = interactionStatisticsManager;
            _DockedManager = dockedManager;
            _DockedStatisticsManager = dockedStatisticsManager;
        }

        public IStatisticsEvent CreateEvent()
        {
            return new StatisticsEvent(_UserManager, _UserServiceStateManager, _TradeManager, _FootPrintManager,_UserStatisticsManager, _FootPrintStatisticsManager,
                _AddressBookManager, _AttentionStatisticsManager, _CallRecordManager, _InteractionStatisticsManager, _DockedManager, _DockedStatisticsManager);
        }
    }

    public interface IStatisticsEvent
    {
        void AddTodayUserStatistics(DateTime date);
        void AddTodayFootPrintStatistics(DateTime date);
        void AddTodayAttentionStatistics(DateTime date);
        void AddTodayInteractionStatistics(DateTime date);
        void AddTodayDockedStatistics(DateTime date);
    }

    public class StatisticsEvent : IStatisticsEvent
    {
        private readonly IUserManager _UserManager;
        private readonly IUserServiceStateManager _UserServiceStateManager;
        private readonly ITradeManager _TradeManager;
        private readonly IFootPrintManager _FootPrintManager;
        private readonly IUserStatisticsManager _UserStatisticsManager;
        private readonly IFootPrintStatisticsManager _FootPrintStatisticsManager;
        private readonly IAddressBookManager _AddressBookManager;
        private readonly IAttentionStatisticsManager _AttentionStatisticsManager;
        private readonly ICallRecordManager _CallRecordManager;
        private readonly IInteractionStatisticsManager _InteractionStatisticsManager;
        private readonly IDockedManager _DockedManager;
        private readonly IDockedStatisticsManager _DockedStatisticsManager;

        public StatisticsEvent(IUserManager userManager,
            IUserServiceStateManager userServiceStateManager,
            ITradeManager tradeManager,
            IFootPrintManager footPrintManager,
            IUserStatisticsManager userStatisticsManager,
            IFootPrintStatisticsManager footPrintStatisticsManager,
            IAddressBookManager addressBookManager,
            IAttentionStatisticsManager attentionStatisticsManager,
            ICallRecordManager callRecordManager,
            IInteractionStatisticsManager interactionStatisticsManager,
            IDockedManager dockedManager,
            IDockedStatisticsManager dockedStatisticsManager
            )
        {
            _UserManager = userManager;
            _UserServiceStateManager = userServiceStateManager;
            _TradeManager = tradeManager;
            _FootPrintManager = footPrintManager;
            _UserStatisticsManager = userStatisticsManager;
            _FootPrintStatisticsManager = footPrintStatisticsManager;
            _AddressBookManager = addressBookManager;
            _AttentionStatisticsManager = attentionStatisticsManager;
            _CallRecordManager = callRecordManager;
            _InteractionStatisticsManager = interactionStatisticsManager;
            _DockedManager = dockedManager;
            _DockedStatisticsManager = dockedStatisticsManager;
        }

        public void AddTodayUserStatistics(DateTime date)
        {
            var footUserStatistics = _UserManager.GetFootUserStatistics(date);//用户总数、用户每日新增、认证人数（通过）、当天认证通过数、当天认证不通过数
            var userServiceStateStatistics = _UserServiceStateManager.GetUserServiceStateStatistics(date);//vip试用用户（在试用期未付费用户）、付费用户总数（在服务期内的付费用户）
            var todayPaidUserCount = _TradeManager.GetTheDayPaidUserCount(date);//当天付费用户新增数
            //添加数据
            var args = new AddUserStatisticsArgs();
            args.date = date;//时间
            int officialUserCount = userServiceStateStatistics.officialUserCount; //付费用户总数（在服务期内的付费用户）
            int totalCount = footUserStatistics.totalCount;//用户总数

            args.totalCount = totalCount;//用户总数
            args.todayCreatedCount = footUserStatistics.todayCreatedCount;//用户每日新增
            args.verifiedCount = footUserStatistics.verifiedCount;//认证人数（通过）
            args.todayPassCount = footUserStatistics.todayPassCount;//当天认证通过数
            args.todayUnPassCount = footUserStatistics.todayUnPassCount;//当天认证不通过数
            args.trailUserCount = userServiceStateStatistics.trailUserCount;//vip试用用户（在试用期未付费用户）
            args.officialUserCount = officialUserCount;//付费用户总数（在服务期内的付费用户）
            args.todayPaidUserCount = todayPaidUserCount;//当天付费用户新增数
            if (totalCount == 0)
            {
                args.paidRate = 0;
            }
            else
            {
                //付费率=付费用户/总用户 
                var rate = (decimal)officialUserCount / totalCount;
                args.paidRate = Math.Round(rate, 4);//保留4位小数           
            }
            _UserStatisticsManager.Add(args);
        }

        public void AddTodayFootPrintStatistics(DateTime date)
        {
            var footPrintStatistics = _FootPrintManager.GetFootPrintCount(date);//足迹总数、通过总数、当天新增通过、当天未通过审核
            var creatorCount = _FootPrintManager.GetFootPrintCreatorCount(date);//足迹发布总人数
            var todayCreatorCount = _FootPrintManager.GetTodayFootPrintCreatorCount(date);//当天足迹发布人数
            var viewFootPrintCount = _UserManager.GetViewFootPrintCount(date);//足迹浏览数
            var TotalViewUserCount = _UserManager.GetTotalViewUserCount(date);//足迹浏览总人数
            //添加数据
            var args = new AddFootPrintStatisticsArgs();
            args.date = date;//时间
            args.totalCount = footPrintStatistics.totalCount;//足迹总数
            args.totalPassFootPrintCount = footPrintStatistics.totalPassFootPrintCount;//足迹通过总数
            args.todayPassFootPrintCount = footPrintStatistics.todayPassFootPrintCount;//当天新增通过
            args.todayUnPassFootPrintCount = footPrintStatistics.todayUnPassFootPrintCount;//当天未通过审核
            args.creatorCount = creatorCount;//足迹发布总人数
            args.todayCreatorCount = todayCreatorCount;//当天足迹发布人数
            args.fpViewCount = viewFootPrintCount;//足迹浏览数
            args.totalViewUserCount = TotalViewUserCount;//足迹浏览总人数
            var fpProjFollowUserCount = _FootPrintManager.GetFootPrintProjFollowUserCount();
            var gt2FollowProjNum = fpProjFollowUserCount.Where(p => p.Value > 2).Select(p => p.Key).Count();//跟进人大于2的项目数
            var gt2FollowUserNum = fpProjFollowUserCount.Where(p => p.Value > 2).Select(p => p.Value).Sum();//跟进人大于2的项目人数
            args.gt2FollowProjNum = gt2FollowProjNum;
            args.gt2FollowUserNum = gt2FollowUserNum;
            _FootPrintStatisticsManager.Add(args);
        }

        public void AddTodayAttentionStatistics(DateTime date)
        {
            var attentionCount = _AddressBookManager.GetAttentionCount(date);//关注好友总次数 每日新增关注次数
            var attentionUserCount = _AddressBookManager.GetAttentionUserCount(date);//关注好友的总人数
            var todayAttentionUserCount = _AddressBookManager.GetTodayAttentionUserCount(date);//每日新增关注好友人数
            var invitationNum = _AddressBookManager.GetInvitationNum(date);//成功邀请数
            var todayInvitationNum = _AddressBookManager.GetTodayInvitationNum(date);//每日新增成功邀请数
            //添加数据
            var args = new AddAttentionStatisticsArgs();
            args.date = date;
            int totalAttentionCount = attentionCount.totalAttentionCount;
            args.attentionCount = totalAttentionCount;//关注好友总次数
            args.todayAttentionCount = attentionCount.todayAttentionCount;//每日新增关注次数
            args.attentionUserCount = attentionUserCount;//关注好友总人数
            args.todayAttentionUserCount = todayAttentionUserCount;//每日新增关注好友人数
            args.invitationCount = invitationNum;//成功邀请数
            args.todayInvitationCount = todayInvitationNum; //每日新增成功邀请数
            if (totalAttentionCount == 0)
            {
                args.successRate = 0;
            }
            else
            {
                //成功率=成功邀请总数/关注好友总数
                var rate = (decimal)invitationNum / totalAttentionCount;
                args.successRate = Math.Round(rate, 4);//保留4位小数
            }
            _AttentionStatisticsManager.Add(args);
        }

        
        public void AddTodayInteractionStatistics(DateTime date)
        {
            var callNum = _CallRecordManager.GetCallNum(date);//点击拨打总条数 每日点击拨打条数
            var vipCallNum = _CallRecordManager.GetVipCallNum(date);//vip拨打总条数 每日vip拨打条数
            var callUserNum = _CallRecordManager.GetCallUserNum(date);//拨打电话总人数
            var vipCallUserNum = _CallRecordManager.GetVipCallUserNum(date);//vip拨打人数
            var todayVipCallUserNum = _CallRecordManager.GetTodayVipCallUserNum(date);//每日vip拨打人数
            var callTotalNum = callNum.callTotalNum; //点击拨打总条数
            var todayCallTotalNum = callNum.todayCallTotalNum;//每日点击拨打条数
            var vipCallTotalNum = vipCallNum.vipCallTotalNum;//vip拨打总条数
            var vipTodayCallTotalNum = vipCallNum.vipTodayCallTotalNum;//每日vip拨打条数
            //添加数据
            var args = new AddInteractionStatisticsArgs();
            args.date = date;
            args.callTotalNum = callTotalNum;//点击拨打总条数
            args.todayCallTotalNum = todayCallTotalNum;//每日点击拨打条数
            args.callUserNum = callUserNum;//拨打电话总人数
            args.vipCallTotalNum = vipCallTotalNum;//vip拨打总条数
            args.vipTodayCallTotalNum = vipTodayCallTotalNum;//每日vip拨打条数
            args.vipCallUserNum = vipCallUserNum;//vip拨打人数
            args.todayVipCallUserNum = todayVipCallUserNum;//每日vip拨打人数
            _InteractionStatisticsManager.Add(args);
        }

        public void AddTodayDockedStatistics(DateTime date)
        {
            var dockedNum = _DockedManager.GetDockedCount(date);
            //添加数据
            var args = new AddDockedStatisticsArgs();
            args.date = date;
            args.dockedTotalNum = dockedNum.dockedTotalCount;//对接请求总数
            args.todayDockedNum = dockedNum.todayDockedCount;//每日对接请求数
            args.todaySuccessfulDockedNum = dockedNum.todaySuccessfulDockedCount;//每日成功对接请求数
            args.agreedDockedTotalNum = dockedNum.agreedDockedTotalCount;//同意对接总数
            args.todayAgreedDockedNum = dockedNum.todayAgreedDockedCount;//每日同意对接
            args.todayRejectedDockedNum = dockedNum.todayRejectedDockedCount;//每日拒绝对接
            _DockedStatisticsManager.Add(args);
        }
    }
}
