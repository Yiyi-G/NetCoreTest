using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using Tgnet.Core;

namespace Tgnet.Api
{
    public interface IOAuth2IdentityProvider
    {
        OAuth2Identity Identity { get; }
    }

    public interface IOAuth2ClientIdentityProvider
    {
        OAuth2ClientIdentity Identity { get; }
    }

    [DataContract]
    public class OAuth2Identity : OAuth2ClientIdentity, IEquatable<OAuth2Identity>
    {
        [DataMember]
        public string access_token { get; set; }
        [DataMember]
        public string scope { get; set; }
        [DataMember]
        public IdentityType identity_type { get; set; }
        [DataMember]
        public string ip { get; set; }

        public OAuth2Identity()
            : this(OAuth2Context.Current ?? OAuth2Context.Null, null)
        { }

        public OAuth2Identity(string accessToken)
            : this(OAuth2Context.Current ?? OAuth2Context.Null, accessToken)
        { }

        public OAuth2Identity(string accessToken, string scope)
            : this(OAuth2Context.Current ?? OAuth2Context.Null, accessToken, scope)        
        { }
        public OAuth2Identity(OAuth2Context context, string accessToken)
            : this(context, accessToken, null)
        {
        }

        public OAuth2Identity(OAuth2Context context, string accessToken, string scope)
            : base(context)
        {
            this.access_token = accessToken;
            this.scope = scope;
        }

        private static bool _Equals(OAuth2Identity identity1, OAuth2Identity identity2)
        {
            return 
                (identity1.identity_type == identity2.identity_type
                && (StringExtension.IsNullOrWhiteSpace(identity1.client_id, identity2.client_id) || identity1.client_id == identity2.client_id)
                && (StringExtension.IsNullOrWhiteSpace(identity1.client_secret, identity2.client_secret) || identity1.client_secret == identity2.client_secret)
                && (StringExtension.IsNullOrWhiteSpace(identity1.access_token, identity2.access_token) || identity1.access_token == identity2.access_token)
                && (StringExtension.IsNullOrWhiteSpace(identity1.scope, identity2.scope) || identity1.access_token == identity2.access_token));
        }

        public bool Equals(OAuth2Identity other)
        {
            return other != null && OAuth2ClientIdentity.Equals(this, other) && _Equals(this, other);
        }
    }

    [KnownType(typeof(OAuth2Identity))]
    [DataContract]
    public class OAuth2ClientIdentity : IEquatable<OAuth2ClientIdentity>
    {
        [DataMember]
        public string client_id { get; set; }
        [DataMember]
        public string client_secret { get; set; }

        public OAuth2ClientIdentity()
            : this(OAuth2Context.Current ?? OAuth2Context.Null)
        { }
        public OAuth2ClientIdentity(OAuth2Context context)
            :this(context.ClientId, context.ClientSecret)
        {
        }

        public OAuth2ClientIdentity(string id, string secret)
        {
            client_id = id;
            client_secret = secret;
        }

        protected static bool _Equals(OAuth2ClientIdentity identity1, OAuth2ClientIdentity identity2)
        {
            return
                ((StringExtension.IsNullOrWhiteSpace(identity1.client_id, identity2.client_id) || identity1.client_id == identity2.client_id)
                && (StringExtension.IsNullOrWhiteSpace(identity1.client_secret, identity2.client_secret) || identity1.client_secret == identity2.client_secret));
        }

        public bool Equals(OAuth2ClientIdentity other)
        {
            return other != null && _Equals(this, other);
        }
    }
}
