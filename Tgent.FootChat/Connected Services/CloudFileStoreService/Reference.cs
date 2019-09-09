//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace CloudFileStoreService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
    public partial class ErrorCode
    {
        
        private string codeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
    public enum ErrorResponseType
    {
        
        /// <remarks/>
        none,
        
        /// <remarks/>
        invalid_request,
        
        /// <remarks/>
        unauthorized_client,
        
        /// <remarks/>
        access_denied,
        
        /// <remarks/>
        unsupported_response_type,
        
        /// <remarks/>
        invalid_scope,
        
        /// <remarks/>
        server_error,
        
        /// <remarks/>
        temporarily_unavailable,
        
        /// <remarks/>
        invalid_client,
        
        /// <remarks/>
        invalid_grant,
        
        /// <remarks/>
        unsupported_grant_type,
        
        /// <remarks/>
        username_non_existent,
        
        /// <remarks/>
        username_locked,
        
        /// <remarks/>
        invalid_verification_code,
        
        /// <remarks/>
        verification_code_expired,
    }
}
