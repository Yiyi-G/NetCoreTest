using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Tgnet.Api
{
    internal class OAuth2ContextManager
    {
        private static Regex m_rId = new Regex("(?:^|;)id=(\\w+)(?:$|;)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex m_rSecret = new Regex("(?:^|;)secret=(\\w+)(?:$|;)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static Dictionary<string, Context> m_Contexts = new Dictionary<string, Context>();
        private static IConfiguration configuration = NetCore.Commen.ConfigurationManager.Configuration; 

        internal struct Context
        {
            public static Context Null = new Context(null, null);

            public readonly string id;
            public readonly string secret;

            public Context(string id, string secret)
            {
                this.id = id;
                this.secret = secret;
            }
        }

        public static void SetContextByConifg(OAuth2Context context)
        {
            var value = configuration["OAuth2Authorize"].GetValue(context.ConfigKey);
            Context result;
            if(!m_Contexts.TryGetValue(value, out result))
            {
                string id = null, secret = null;
                var match = m_rId.Match(value);
                if (match.Success)
                {
                    id = match.Groups[1].Value.Trim();
                }
                else
                {
                    throw new Exception("配置中不包含id值");
                }
                match = m_rSecret.Match(value);
                if (match.Success)
                {
                    secret = match.Groups[1].Value.Trim();
                }
                else
                {
                    throw new Exception("配置中不包含secret值");
                }
                result = new Context(id, secret);
            }
            context.Set(result);
        }
    }

    public class OAuth2Context
    {
        public static readonly OAuth2Context Null = new OAuth2Context();

        private static OAuth2Context m_Current;
        
        private OAuth2ContextManager.Context m_InnerContext = OAuth2ContextManager.Context.Null;

        public string ClientId { get { return m_InnerContext.id; } }
        public string ClientSecret { get { return m_InnerContext.secret; } }

        internal readonly string ConfigKey;

        private OAuth2Context(string configKey) 
        {
            ConfigKey = configKey;
        }

        private OAuth2Context(){}

        public static OAuth2Context Current
        {
            get
            {
                if(m_Current == null)
                    throw new Exception("必须先调用Load方法来设定客户端上下文在OAuth2Authorize.config文件中的key");

                OAuth2ContextManager.SetContextByConifg(m_Current);
                return m_Current;
            }
        }

        public static void Load(string configKey)
        {
            m_Current = new OAuth2Context(configKey);
        }

        internal void Set(OAuth2ContextManager.Context context)
        {
            if(!m_InnerContext.Equals(context))
                m_InnerContext = context;
        }
    }
}
