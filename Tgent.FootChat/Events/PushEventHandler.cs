using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Aliyun.MNS.Contents;
using Tgnet.Aliyun.MNS.FootChat;
using Tgnet.Aliyun.MNS.ProjectEvents;

namespace Tgnet.FootChat.Events
{
    public interface IPushEventHandler
    {
        void TryHandleEvent(FootChatPublishCollectEvent @event);
        void TryHandleEvent(FootChatServiceExpiredEvent @event);
        void TryHandleEvent(FootChatStatisticsEvent @event);
        void TryHandleEvent(FootChatUnpaidEvent @event);
        void SendFootChatPublishCollectEvent();
        void SendFootChatServiceExpiredEvent(int day, bool isTrial);
        void SendFootChatStatisticsEvent();
        void SendFootChatUnpaidEvent(byte type, long uid, DateTime? delay = null);
    }
    class PushEventHandler : IPushEventHandler
    {
        private readonly IServiceEventFactory _ServiceEventFactory;
        private readonly IFootPrintEventFactory _FootPrintEventFactory;
        private readonly IStatisticsEventFactory _StatisticsEventFactory;
        public PushEventHandler(IServiceEventFactory serviceEventFactory,
            IFootPrintEventFactory footPrintEventFactory,
            IStatisticsEventFactory statisticsEventFactory)
        {
            _ServiceEventFactory = serviceEventFactory;
            _FootPrintEventFactory = footPrintEventFactory;
            _StatisticsEventFactory = statisticsEventFactory;
        }
        public void TryHandleEvent(FootChatPublishCollectEvent @event)
        {
            try
            {
                _FootPrintEventFactory.CreateEvent(null).PushUnReadFPsOfFriendsInYesterday();
            }
            catch (System.Exception e)
            {
                Tgnet.Log.LoggerResolver.Current.Debug("推送用户未读足迹失败！");
                Tgnet.Log.LoggerResolver.Current.Fail(e);
            }
            finally
            {
                //SendFootChatPublishCollectEvent();
            }
        }

        public void TryHandleEvent(FootChatServiceExpiredEvent @event)
        {
            var day = @event.Content.day;
            var isTrail = @event.Content.trial;
            try
            {
                var serviceEvent = _ServiceEventFactory.CreateEvent();
                if (isTrail)
                {
                    switch (day)
                    {
                        case -3:
                            serviceEvent.TrialExpiredBefore3Days();
                            break;
                        case 0:
                            serviceEvent.TrialWillExpiredToday();
                            break;
                        case 3:
                            serviceEvent.TrialWillExpiredAfter3Days();
                            break;
                    }
                }
                else if (day == -7)
                {
                    serviceEvent.VipWillExpiredBefore7Days();
                }
            }
            catch (System.Exception e)
            {
                Tgnet.Log.LoggerResolver.Current.Debug(string.Format("用户服务状态过期提醒推送失败！day is {0} istrail is {1}", day, isTrail));
                Tgnet.Log.LoggerResolver.Current.Fail(e);
            }
            finally
            {
               SendFootChatServiceExpiredEvent(day, isTrail);
            }
        }

        public void TryHandleEvent(FootChatStatisticsEvent @event)
        {
            var date = @event.Content.Date;
            var statisticsEvent = _StatisticsEventFactory.CreateEvent();
            statisticsEvent.AddTodayFootPrintStatistics(date);
            statisticsEvent.AddTodayUserStatistics(date);
            statisticsEvent.AddTodayAttentionStatistics(date);
            statisticsEvent.AddTodayInteractionStatistics(date);
            statisticsEvent.AddTodayDockedStatistics(date);
            SendFootChatStatisticsEvent();
        }

        public void TryHandleEvent(FootChatUnpaidEvent @event)
        {
            var uid = @event.Content.uid;
            //0:半小时未支付 1:1天未支付
            var type = @event.Content.type;
            var firstIsPayFail = false;
            try
            {
                var serviceEvent = _ServiceEventFactory.CreateEvent();
                switch (type)
                {
                    case 0:
                        serviceEvent.PayFail(uid,out firstIsPayFail);
                        break;
                    case 1:
                        serviceEvent.PayFailAfterOneDay(uid);
                        break;
                }
            }
            catch (System.Exception e)
            {
                Tgnet.Log.LoggerResolver.Current.Debug(string.Format("用户未支付消息推送失败！uid is {0} type is {1}", uid, type));
                Tgnet.Log.LoggerResolver.Current.Fail(e);
            }
            finally
            {
                if (type == 0&& firstIsPayFail)
                {
                    SendFootChatUnpaidEvent(1, uid, DateTime.Now.AddDays(1));
                }
            }



        }
        public void SendFootChatPublishCollectEvent()
        {
            var newEvent = new FootChatPublishCollectEvent
            {
                Delay = DateTime.Now.Date.AddHours(8).AddDays(1),
                Priority = 8,
                Content = new FootChatPublishCollectContentcs
                {
                }
            };
            new Tgnet.Aliyun.MNS.EventService().Post(newEvent);
        }
        public void SendFootChatServiceExpiredEvent(int day, bool isTrial)
        {
            var newEvent = new FootChatServiceExpiredEvent
            {
                Delay = DateTime.Now.Date.AddHours(9).AddDays(1),
                Priority = 8,
                Content = new FootChatServiceExpiredContent
                {
                    day = day,
                    trial = isTrial,
                }
            };
            new Tgnet.Aliyun.MNS.EventService().Post(newEvent);
        }
        public void SendFootChatStatisticsEvent()
        {
            var newEvent = new FootChatStatisticsEvent
            {
                Delay = DateTime.Now.Date.AddDays(1),
                Priority = 8,
                Content = new FootChatStatisticsContent
                {
                    Date = DateTime.Now.Date
                }
            };
            new Tgnet.Aliyun.MNS.EventService().Post(newEvent);
        }
        public void SendFootChatUnpaidEvent(byte type, long uid, DateTime? delay = null)
        {
            var newEvent = new FootChatUnpaidEvent
            {
                Delay = delay,
                Priority = 8,
                Content = new FootChatUnpaidContent
                {
                    type = type,
                    uid = uid
                }
            };
            new Tgnet.Aliyun.MNS.EventService().Post(newEvent);
        }
    }
}
