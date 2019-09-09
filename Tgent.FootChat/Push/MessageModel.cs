using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Push
{
    public class MessageModel
    {
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MessageId { get; set; }
        [JsonProperty(PropertyName = "v", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Timestamp { get; set; }
        [JsonProperty(PropertyName = "t", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SessionType { get; set; }
        [JsonProperty(PropertyName = "sid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long SessionId { get; set; }
        [JsonProperty(PropertyName = "s", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Sender { get; set; }
        [JsonProperty(PropertyName = "ct", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ContentType { get; set; }
        [JsonProperty(PropertyName = "e", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dictionary<string, object> Extensions { get; set; }

        [JsonProperty(PropertyName = "c", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "sn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SenderName { get; set; }

        public MessageModel() { }

        public MessageModel(Tgnet.FootChat.Push.Data.IDBMessage message)
        {
            ContentType = message.contentType;
            MessageId = message.messageId;
            SessionType = message.sessionType;
            Timestamp = message.timestamp;
            Sender = message.sender;
            SessionId = message.sessionId;
            Content = message.content;

            Extensions = new Dictionary<string, object>();
            if (message.extensions != null)
                foreach (var item in message.extensions)
                {
                    if (Tgnet.FootChat.Push.MessageExtensions.IncludeToMessage(item.Key))
                        Extensions[item.Key] = item.Value;
                }

        }

        public MessageModel(string senderName, Tgnet.FootChat.Push.Data.IDBMessage message)
            : this(message)
        {
            SenderName = senderName;
        }
    }
}
