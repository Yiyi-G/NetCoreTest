using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Push;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Message
{
    public interface IMessageManager
    {
        PageModel<Tgnet.FootChat.Push.Data.AdminSessionStatistics> HelpMessageSearch(bool? isReply, long? user, bool? byUser, Range<DateTime?> sendTime, int start, int limit);
        Models.Message[] GetHelpDisposeMessageList(long uid, Range<DateTime?> time, int? limit);
        void SendAdminMessage(long sender, long[] recivers, string message, string contentType);
        void SetAdminMessageReplied(long[] uids);
        Dictionary<long, int> GetSingleMessageSessionDayCount(long? uid, Range<DateTime> timeRange, params long[] excludeUserIds);
        PageModel<Models.Message> GetFriendMessageCollect(long? sender, Range<DateTime?> timestamp, int start, int limit);
        PageModel<Models.Message> GetSingleMessages(long sender, long receiver, Range<DateTime?> timestamp, int start, int limit);
    }
    public class MessageManager: IMessageManager
    {
        private readonly IMessageService _MessageService;
        private readonly INotifyServiceProxy _NotifyService;

        public MessageManager(IMessageService messageService,
            INotifyServiceProxy notifyService)
        {
            _MessageService = messageService;
            _NotifyService = notifyService;
        }

        /// <summary>
        /// 足聊小蜜消息搜索
        /// </summary>
        /// <param name="isReply"></param>
        /// <param name="user"></param>
        /// <param name="byUser"></param>
        /// <param name="sendTime"></param>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public PageModel<Tgnet.FootChat.Push.Data.AdminSessionStatistics> HelpMessageSearch(bool? isReply, long? user, bool? byUser, Range<DateTime?> sendTime, int start, int limit)
        {
            return _MessageService.GetAdminMessageSessions(user, isReply, byUser, sendTime, start, limit);
        }

        /// <summary>
        /// 获取用户与足聊小蜜消息
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="time"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public Models.Message[] GetHelpDisposeMessageList(long uid, Range<DateTime?> time, int? limit)
        {
            ExceptionHelper.ThrowIfNotId(uid, "uid");
            var source = _MessageService.GetAdminMessages(uid, Tgnet.FootChat.Push.ActionType.ADMIN_MESSAGE.Action, time, 0, limit);
            return source.Select(m => new Models.Message
            {
                id = m.msgId,
                sender = m.sender,
                byUser = m.byUser,
                content = m.content,
                contentType = m.contentType,
                msgType = m.sessionType,
                timestamp = (long)Math.Floor(m.timestamp.ToTimestamp().TotalMilliseconds),
            }).ToArray();
        }

        /// <summary>
        /// 管理员发送足聊小蜜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="recivers"></param>
        /// <param name="message"></param>
        /// <param name="contentType"></param>
        public void SendAdminMessage(long sender, long[] recivers, string message, string contentType)
        {
            ExceptionHelper.ThrowIfNotId(sender, "sender");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(message, "message", "不能发送空内容");

            var request = new Tgnet.FootChat.Push.NotifyMessageRequest(Tgnet.FootChat.Push.ActionType.ADMIN_MESSAGE, 0, sender, recivers, contentType, message);
            _NotifyService.AdminNotify(request, true);
            if (recivers != null && recivers.Length == 1)
            {
                _MessageService.SetAdminMessageReplied(recivers);
            }
        }

        /// <summary>
        /// 设置用户发送消息为已处理
        /// </summary>
        /// <param name="uids"></param>
        public void SetAdminMessageReplied(long[] uids)
        {
            _MessageService.SetAdminMessageReplied(uids);
        }

        /// <summary>
        /// 单聊每天会话数统计
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="timeRange"></param>
        /// <param name="excludeUserIds"></param>
        /// <returns></returns>
        public Dictionary<long, int> GetSingleMessageSessionDayCount(long? uid, Range<DateTime> timeRange, params long[] excludeUserIds)
        {
            return _MessageService.GetSingleMessageDayCount(uid, timeRange, excludeUserIds);
        }

        /// <summary>
        /// 获取单聊流水账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="timestamp"></param>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public PageModel<Models.Message> GetFriendMessageCollect(long? sender, Range<DateTime?> timestamp, int start, int limit)
        {
            var result = _MessageService.GetFriendMessages(sender, timestamp, start, limit);
            return new Tgnet.Data.PageModel<Models.Message>(result.Models.Select(m => new Models.Message
            {
                id = m.messageId,
                content = m.content,
                contentType = m.contentType,
                msgType = m.sessionType,
                receiver = m.receiver,
                sender = m.sender,
                timestamp = m.timestamp
            }), result.Count);
        }

        /// <summary>
        /// 获取单聊聊天内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        /// <param name="timestamp"></param>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public PageModel<Models.Message> GetSingleMessages(long sender, long receiver, Range<DateTime?> timestamp, int start, int limit)
        {
            var result = _MessageService.GetSingleMessages(sender, receiver, timestamp, start, limit);
            return new Tgnet.Data.PageModel<Models.Message>(result.Models.Select(m => new Models.Message
            {
                id = m.messageId,
                content = m.content,
                contentType = m.contentType,
                msgType = m.sessionType,
                receiver = m.receiver,
                sender = m.sender,
                timestamp = m.timestamp
            }), result.Count);
        }
    }
    public class SearchHelpMsgArgs
    {
        public string mobile { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public bool? byUser { get; set; }
        public bool? isReply { get; set; }

        public void VerifySearchHelpMsgArgs()
        {
            if (!string.IsNullOrWhiteSpace(startDate) && !string.IsNullOrWhiteSpace(endDate))
            {
                DateTime minTime = startDate.To<DateTime>();
                DateTime maxTime = endDate.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "time", "开始时间不能大于结束时间");
            }           
        }
    }
}
