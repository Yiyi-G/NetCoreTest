using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Push
{
    public class NotifyServiceProxy : INotifyServiceProxy
    {
        private class MessageStoreResult
        {
            public bool IsInsert { get; set; }
            public Tgnet.FootChat.Push.Data.IDBMessage Message { get; set; }
        }

        private readonly IMessageService _MessageService;
        private readonly IUserNameProviderFactory _UserNameProviderFactory;
        private readonly IPushManager _PushManager;
        private readonly IUserNotifyTypeProvider _UserNotifyTypeProvider;
        private const string ANDROIDPOPUPACTIVITY = "com.tgnet.footchat.activity.PopupPushActivity";
        public NotifyServiceProxy(
            IMessageService messageService,
            IUserNameProviderFactory userNameProviderFactory,
            IPushManager pushManager,
            IUserNotifyTypeProvider userNotifyTypeProvider)
        {
            _MessageService = messageService;
            _UserNameProviderFactory = userNameProviderFactory;
            _PushManager = pushManager;
            _UserNotifyTypeProvider = userNotifyTypeProvider;
        }

        private Dictionary<long, MessageStoreResult> SaveMessage(NotifyMessageRequest message, out Tgnet.FootChat.Push.Data.IDBMessage senderMessage)
        {
            if (message.Receivers != null)
            {
                var kind = _MessageService.GetMessageKind(message.MessageType, message.SessionType);
                Dictionary<long, MessageStoreResult> result;
                bool firstSave = false;
                switch (kind)
                {
                    case MessageKind.User:
                        result = new Dictionary<long, MessageStoreResult>();
                        foreach (var receiver in message.Receivers)
                        {
                            var r = new MessageStoreResult
                            {
                                Message = _MessageService.SaveUserMessage(message.SessionType, message.Sender, receiver, message.Created, message.ContentType, message.Content, message.Extension, out firstSave)
                            };
                            r.IsInsert = firstSave;
                            result[receiver] = r;
                        }
                        senderMessage = result.Values.Select(r => r.Message).FirstOrDefault();
                        return result;
                    case MessageKind.MuiltUser:
                        var muiltMessage = _MessageService.SaveMultiUserMessage(message.SessionType, message.SessionId, message.Sender, message.Created, message.ContentType, message.Content, message.Receivers, message.Extension, out firstSave);
                        result = message.Receivers.Distinct().ToDictionary(r => r, r => new MessageStoreResult
                        {
                            Message = muiltMessage,
                            IsInsert = firstSave,
                        });
                        senderMessage = muiltMessage;
                        return result;
                    case MessageKind.Other:
                        result = new Dictionary<long, MessageStoreResult>();
                        switch (message.MessageType)
                        {
                            case MessageType.Once:
                            case MessageType.OnceAndOnce:
                                var onceMessage = _MessageService.SaveOnceMessage(message.SessionType, message.SessionId, message.Sender, message.Receivers, message.Created, message.ContentType, message.Content,
                                    MessageType.OnceAndOnce == message.MessageType, null, message.Extension);
                                foreach (var item in message.Receivers)
                                {
                                    result[item] = new MessageStoreResult
                                    {
                                        Message = onceMessage,
                                        IsInsert = true,
                                    };
                                }
                                break;
                            case MessageType.Online:
                                var onlineMessage = _MessageService.SaveOnlineMessage(message.SessionType, message.SessionId, message.Sender, message.Receivers, message.Created, message.ContentType, message.Content, null);
                                foreach (var item in message.Receivers)
                                {
                                    result[item] = new MessageStoreResult
                                    {
                                        Message = onlineMessage,
                                        IsInsert = true,
                                    };
                                }
                                break;
                        }
                        senderMessage = result.Values.Select(r => r.Message).FirstOrDefault();
                        return result;
                }
            }
            senderMessage = null;
            return new Dictionary<long, MessageStoreResult>();
        }

        public Dictionary<long, Push.Data.IDBMessage> Notify(NotifyMessageRequest request)
        {
            Push.Data.IDBMessage senderMessage;
            return Notify(request, out senderMessage);
        }
        public Dictionary<long, Push.Data.IDBMessage> Notify(NotifyMessageRequest request, out Push.Data.IDBMessage senderMessage)
        {
            ExceptionHelper.ThrowIfNull(request, "request");
            var messages = SaveMessage(request, out senderMessage);
            _DoNotify(ref messages, request, senderMessage);
            return messages.ToDictionary(r => r.Key, r => r.Value.Message);
        }
        private void _DoNotify(ref Dictionary<long, MessageStoreResult> messages, NotifyMessageRequest request, Push.Data.IDBMessage senderMessage)
        {
            if (request.IsNotNotify)
                return;
            if (messages != null && messages.Count > 0)
            {
                var insterMessage = messages.Where(m => m.Value.IsInsert).ToDictionary(m => m.Key, m => m.Value);
                if (insterMessage.Count > 0)
                {
                    var sessionId = senderMessage.sessionId;
                    if ((!insterMessage.ContainsKey(request.Sender)) && request.MessageType == MessageType.Message)
                        insterMessage.Add(request.Sender, insterMessage.First().Value);
                    var uids = insterMessage.Keys.Distinct().ToArray();

                    var nicks = new Dictionary<long, UserName>();
                    if (request.Sender == 0)
                    {
                        nicks = insterMessage.Keys.ToDictionary(k => k, k => new UserName(String.Empty, NameKind.Name));
                    }
                    else if (request.SessionType != ActionType.ADMIN_MESSAGE.Action)
                    {
                        var nameProvider = _UserNameProviderFactory.CreateProvider(request.Sender);
                        uids = nameProvider.GetNotifyUsers(uids, request.SessionId, request.SessionType);
                        nicks = nameProvider.NickForUsers(uids);
                        if (request.SessionType == ActionType.SINGLE_MESSAGE.Action)
                        {
                            sessionId = request.Sender;
                        }
                    }
                    else
                    {
                        nicks = insterMessage.Keys.ToDictionary(k => k, k => new UserName("足聊小蜜", NameKind.Name));
                    }

                    //处理阿里云推送
                    var senderNames = nicks.GroupBy(n => n.Value.Name).Select(ns => new { nick = ns.Key, receivers = ns.Select(n => n.Key) }).ToDictionary(n => n.nick, n => n.receivers);
                    var unNicks = uids.Except(nicks.Keys.Distinct()).ToArray();
                    if (unNicks.Length > 0)
                    {
                        if (senderNames.ContainsKey(String.Empty))
                            senderNames[String.Empty] = senderNames[String.Empty].Concat(unNicks);
                        else
                            senderNames.Add(String.Empty, unNicks);
                    }
                    foreach (var name in senderNames)
                    {
                        var receivers = name.Value.ToArray();
                        var msg = new Tgnet.FootChat.Push.MessageModel(name.Key, senderMessage);
                        msg.SessionId = sessionId;
                        Push(request, msg, receivers, true);
                    }
                }
            }
        }

        public Dictionary<long, Push.Data.IDBMessage> Notify(IEnumerable<NotifyMessageRequest> requests)
        {
            var result = new Dictionary<long, Push.Data.IDBMessage>();
            foreach (var request in requests)
            {
                foreach (var pair in Notify(request))
                {
                    result[pair.Key] = pair.Value;
                }
            }
            return result;
        }

        public Dictionary<long, Push.Data.IDBMessage> AdminNotify(NotifyMessageRequest message, bool byAdmin)
        {
            ExceptionHelper.ThrowIfNull(message, "message");
            ExceptionHelper.ThrowIfTrue(message.SessionType != ActionType.ADMIN_MESSAGE.Action, "serssionType");
            if (byAdmin)
            {
                var id = MessageExtensions.MessageId.GetValue(message.Extension);
                if (!String.IsNullOrWhiteSpace(id))
                {
                    var entity = _MessageService.ReplyAdminMessage(id, message.SessionType, message.SessionId, message.ContentType, message.Content);
                    var receiver = entity.targets.Keys.First().To<long>();
                    Push(message, new Tgnet.FootChat.Push.MessageModel(entity), new long[] { receiver }, true);
                    return new Dictionary<long, Tgnet.FootChat.Push.Data.IDBMessage> { { receiver, entity } };
                }
                else if (message.Receivers != null && message.Receivers.Length > 0)
                {
                    var msg = _MessageService.SendAdminMessageToUser(message.Sender, message.SessionType, message.Receivers, message.Created, message.ContentType, message.Content);
                    var result = new Dictionary<long, Push.Data.IDBMessage>();
                    foreach (var item in message.Receivers)
                    {
                        result[item] = msg;
                    }
                    msg.sender = 0;
                    Push(message, new Tgnet.FootChat.Push.MessageModel(msg), message.Receivers, true);
                    return result;
                }
                else
                {
                    var msg = _MessageService.Broadcast(message.Sender, message.SessionType, message.Created, message.ContentType, message.Content);
                    Push(message, new Tgnet.FootChat.Push.MessageModel(msg), message.Receivers, true, NotifyTypes.SoundAndVibration);
                    return new Dictionary<long, Push.Data.IDBMessage>();
                }
            }
            else
            {
                bool firstSave;
                var msg = _MessageService.SaveAdminMessage(message.Sender, message.SessionType, message.Receivers != null && message.Receivers.Length > 0 ? message.Receivers.First() : 0, message.Created, message.ContentType, message.Content, message.Extension, out firstSave);
                return new Dictionary<long, Push.Data.IDBMessage> { { msg.targets.Count > 0 ? msg.targets.Keys.First().To<long>() : 0, msg } };
            }
        }
        public Dictionary<long, Push.Data.IDBMessage> SendAdminMessageToUser(long receiver,string content, string contentType= "text")
        {
            NotifyMessageRequest request = new NotifyMessageRequest(ActionType.ADMIN_MESSAGE, MessageType.Message, 0, 0, new long[] { receiver },contentType, content);
           return AdminNotify(request, true);
        }
        public Push.Data.IDBMessage AdminBroadcast(NotifyMessageRequest message)
        {
            ExceptionHelper.ThrowIfNull(message, "message");
            ExceptionHelper.ThrowIfNullOrEmpty(message.SessionType, "serssionType");
            if (message.Receivers != null && message.Receivers.Length > 0)
                throw new Api.ExceptionWithErrorCode(Api.ErrorCode.输入的数据格式错误, "广播不支持设置接收用户");
            var msg = _MessageService.Broadcast(message.Sender, message.SessionType, message.Created, message.ContentType, message.Content);
            Push(message, new Tgnet.FootChat.Push.MessageModel(msg), message.Receivers, true, NotifyTypes.SoundAndVibration);
            return msg;
        }
        private void Push(NotifyMessageRequest request, Tgnet.FootChat.Push.MessageModel message, long[] receivers, bool remind)
        {
            ExceptionHelper.ThrowIfNull(message, "message");
            receivers = (receivers ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();

            var nameProvider = _UserNameProviderFactory.CreateProvider(request.Sender);
            var notyTypes = _UserNotifyTypeProvider.GetNotifyTypes(message.Sender, receivers, message.SessionId, message.SessionType);
            foreach (var t in notyTypes)
            {
                Push(request, message, t.Value, remind, t.Key);
            }
        }
        /// <summary>
        /// 阿里云推送
        /// </summary>
        /// <param name="request"></param>
        /// <param name="message"></param>
        /// <param name="receivers"></param>
        private void Push(NotifyMessageRequest request, Tgnet.FootChat.Push.MessageModel message, long[] receivers, bool remind, NotifyTypes notifyType)
        {
            ExceptionHelper.ThrowIfNull(message, "message");
            receivers = (receivers ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            PushService.PushSetting setting = null;
            if (request.MessageType != MessageType.Online)
            {
                setting = new PushService.PushSetting
                {
                    ExpireTime = TimeSpan.FromDays(1),
                    StoreOffline = true,
                    NotifyType = (PushService.PushSettingNotifyTypes)notifyType.To<byte>(),
                };
            }
            List<PushService.TargetsAppKinds> apps = new List<PushService.TargetsAppKinds>() { PushService.TargetsAppKinds.FootChatAndroid, PushService.TargetsAppKinds.FootChatiOS };
            _PushManager.PushJsonMessage(new PushService.PushJsonMessageRequest
            {
                Content = message.Content,
                ContentType = message.ContentType,
                Extensions = message.Extensions,
                MessageId = message.MessageId,
                Sender = message.Sender,
                SenderName = message.SenderName,
                SessionId = message.SessionId,
                SessionType = message.SessionType,
                Timestamp = message.Timestamp,
                Remind = WrapperRemind(message, remind)
            }, new PushService.Targets
            {
                Uids = receivers,
                Apps = apps.ToArray(),
                Testing = false,
            }, setting);
        }
        private PushService.PushRemindRequest WrapperRemind(Tgnet.FootChat.Push.MessageModel message, bool remind)
        {
            if (!remind)
                return null;
            var content = ActionType.GetActionType(message.SessionType).GetContent(message.ContentType, message.Content);
            var url = ActionType.GetActionType(message.SessionType).GetUrl(message.SessionType, message.SessionId.ToString(), message.SenderName);
            PushService.PushRemindRequest r = null;
            var title = String.Empty;

            if (!String.IsNullOrWhiteSpace(content))
            {
                Dictionary<string, string> extensions = new Dictionary<string, string>();
                extensions.Add("t", message.SessionType);
                extensions.Add("sid", message.SessionId.ToString());
                extensions.Add("sn", message.SenderName);
                extensions.Add("url", url);

                if (message.Extensions != null && message.Extensions.Count > 0)
                {
                    foreach (var e in message.Extensions)
                    {
                        if (!extensions.ContainsKey(e.Key) && e.Value != null)
                            extensions.Add(e.Key, e.Value.ToString());
                    }
                }

                if (message.SessionType.Equals(ActionType.SINGLE_MESSAGE.Action))
                    content = String.Format("{0}：{1}", message.SenderName, content);
                else if (message.SessionType.Equals(ActionType.ADMIN_MESSAGE.Action))
                    content = String.Format("足聊小蜜：{0}", content);
                else
                {
                    if (!String.IsNullOrWhiteSpace(message.SenderName))
                    {
                        content = String.Format("{0}：{1}", message.SenderName, content);
                    }
                }
                r = new PushService.PushRemindRequest { Title = title, Body = content, Extensions = extensions, AndroidPopupActivity=ANDROIDPOPUPACTIVITY };
            }
            return r;
        }

        public void PushRemind(PushRemindRequest remind, long[] receivers, NotifyTypes? notifyType = null)
        {
            ExceptionHelper.ThrowIfNull(remind, "remind");
            receivers = (receivers ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            PushService.PushSetting setting = new PushService.PushSetting
            {
                NotifyType = notifyType == null ? PushService.PushSettingNotifyTypes.SoundAndVibration : (PushService.PushSettingNotifyTypes)notifyType.To<byte>()
            };
            if (remind.MessageType != MessageType.Online)
            {
                setting.ExpireTime = TimeSpan.FromDays(1);
                setting.StoreOffline = true;
            }
            var extensions = remind.Extensions ?? new Dictionary<string, string>();
            if (!String.IsNullOrWhiteSpace(remind.URL))
            {
                extensions["url"] = remind.URL.Trim();
            }
            List<PushService.TargetsAppKinds> apps = new List<PushService.TargetsAppKinds>() { PushService.TargetsAppKinds.FootChatAndroid, PushService.TargetsAppKinds.FootChatiOS };
            _PushManager.PushRemind(new PushService.PushRemindRequest
            {
                Accumulate = remind.Accumulate,
                Body = remind.Body,
                Extensions = extensions,
                Title = remind.Title,
                AndroidPopupActivity=ANDROIDPOPUPACTIVITY,
            }, new PushService.Targets
            {
                Uids = receivers,
                Apps = apps.ToArray(),
            }, setting);
        }
        public void GlobalNotify(Push.Data.IGlobalDBMessage message)
        {
            ExceptionHelper.ThrowIfNull(message, "message");
            var msg = new Tgnet.FootChat.Push.MessageModel(message);
            _PushManager.PushJsonMessage(new PushService.PushJsonMessageRequest
            {
                Content = message.content,
                ContentType = message.contentType,
                Extensions = message.extensions,
                MessageId = message.messageId,
                Sender = message.sender,
                SessionId = message.sessionId,
                SessionType = message.sessionType,
                Timestamp = message.timestamp,
            }, new PushService.Targets
            {
                Apps = new PushService.TargetsAppKinds[] { PushService.TargetsAppKinds.Project }
            },
                new PushService.PushSetting
                {
                    ExpireTime = TimeSpan.FromDays(1),
                    StoreOffline = true,
                });
        }
    }
}
