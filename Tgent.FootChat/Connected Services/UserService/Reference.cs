//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace UserService
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
    public enum ErrorResponseType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        none = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        invalid_request = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        unauthorized_client = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        access_denied = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        unsupported_response_type = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        invalid_scope = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        server_error = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        temporarily_unavailable = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        invalid_client = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        invalid_grant = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        unsupported_grant_type = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        username_non_existent = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        username_locked = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        invalid_verification_code = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        verification_code_expired = 14,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProjectCase", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class ProjectCase : object
    {
        
        private string contentField;
        
        private string[] imagesField;
        
        private string nameField;
        
        private long pcidField;
        
        private long[] pidsField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long pcid
        {
            get
            {
                return this.pcidField;
            }
            set
            {
                this.pcidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] pids
        {
            get
            {
                return this.pidsField;
            }
            set
            {
                this.pidsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyProfile", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class CompanyProfile : object
    {
        
        private string companyField;
        
        private string companyProfileField;
        
        private string companyUrlField;
        
        private string[] imagesField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string companyProfile
        {
            get
            {
                return this.companyProfileField;
            }
            set
            {
                this.companyProfileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string companyUrl
        {
            get
            {
                return this.companyUrlField;
            }
            set
            {
                this.companyUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfoVerifyKinds", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum InfoVerifyKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotNull = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Always = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserProduct", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserProduct : object
    {
        
        private long idField;
        
        private bool is_mainField;
        
        private UserService.UserProduct.Level levelField;
        
        private string nameField;
        
        private string trademarkField;
        
        private UserService.UserProduct.Trade[] tradesField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_main
        {
            get
            {
                return this.is_mainField;
            }
            set
            {
                this.is_mainField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserProduct.Level level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string trademark
        {
            get
            {
                return this.trademarkField;
            }
            set
            {
                this.trademarkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserProduct.Trade[] trades
        {
            get
            {
                return this.tradesField;
            }
            set
            {
                this.tradesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
        [System.Runtime.Serialization.DataContractAttribute(Name="UserProduct.Level", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
        public enum Level : int
        {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            None = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            High = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            High_End = 2,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Middle = 3,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Middle_End = 4,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Low = 5,
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
        [System.Runtime.Serialization.DataContractAttribute(Name="UserProduct.Trade", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
        public partial class Trade : object
        {
            
            private string class_noField;
            
            private long idField;
            
            private bool is_mainField;
            
            private UserService.UserProduct.Kinds kindField;
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string class_no
            {
                get
                {
                    return this.class_noField;
                }
                set
                {
                    this.class_noField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public long id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public bool is_main
            {
                get
                {
                    return this.is_mainField;
                }
                set
                {
                    this.is_mainField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public UserService.UserProduct.Kinds kind
            {
                get
                {
                    return this.kindField;
                }
                set
                {
                    this.kindField = value;
                }
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
        [System.Runtime.Serialization.DataContractAttribute(Name="UserProduct.Kinds", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
        public enum Kinds : byte
        {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            None = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            My = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Interest = 2,
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserFace", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserFace : object
    {
        
        private string bigField;
        
        private string smallField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string big
        {
            get
            {
                return this.bigField;
            }
            set
            {
                this.bigField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string small
        {
            get
            {
                return this.smallField;
            }
            set
            {
                this.smallField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserSimpleInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserSimpleInfo : object
    {
        
        private string addressField;
        
        private string area_cityField;
        
        private string area_countyField;
        
        private string area_provinceField;
        
        private System.Nullable<System.DateTime> birthField;
        
        private string birth_area_noField;
        
        private string companyField;
        
        private System.Nullable<System.DateTime> createdField;
        
        private string emailField;
        
        private bool is_activateField;
        
        private string jobField;
        
        private System.Nullable<int> levelField;
        
        private string mobileField;
        
        private bool mobile_is_activateField;
        
        private string nameField;
        
        private string qqField;
        
        private string[] quingitysField;
        
        private string sexField;
        
        private string telField;
        
        private decimal tg_coinField;
        
        private long uidField;
        
        private string unoField;
        
        private string user_area_noField;
        
        private string weChatField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string area_city
        {
            get
            {
                return this.area_cityField;
            }
            set
            {
                this.area_cityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string area_county
        {
            get
            {
                return this.area_countyField;
            }
            set
            {
                this.area_countyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string area_province
        {
            get
            {
                return this.area_provinceField;
            }
            set
            {
                this.area_provinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> birth
        {
            get
            {
                return this.birthField;
            }
            set
            {
                this.birthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string birth_area_no
        {
            get
            {
                return this.birth_area_noField;
            }
            set
            {
                this.birth_area_noField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_activate
        {
            get
            {
                return this.is_activateField;
            }
            set
            {
                this.is_activateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string job
        {
            get
            {
                return this.jobField;
            }
            set
            {
                this.jobField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool mobile_is_activate
        {
            get
            {
                return this.mobile_is_activateField;
            }
            set
            {
                this.mobile_is_activateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string qq
        {
            get
            {
                return this.qqField;
            }
            set
            {
                this.qqField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] quingitys
        {
            get
            {
                return this.quingitysField;
            }
            set
            {
                this.quingitysField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tel
        {
            get
            {
                return this.telField;
            }
            set
            {
                this.telField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal tg_coin
        {
            get
            {
                return this.tg_coinField;
            }
            set
            {
                this.tg_coinField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string uno
        {
            get
            {
                return this.unoField;
            }
            set
            {
                this.unoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string user_area_no
        {
            get
            {
                return this.user_area_noField;
            }
            set
            {
                this.user_area_noField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string weChat
        {
            get
            {
                return this.weChatField;
            }
            set
            {
                this.weChatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserLoginInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserLoginInfo : object
    {
        
        private System.DateTime birthField;
        
        private string cityField;
        
        private int coinField;
        
        private string companyField;
        
        private string emailField;
        
        private int expField;
        
        private string faceField;
        
        private string jobField;
        
        private System.DateTime last_login_dateField;
        
        private int login_countField;
        
        private string mobileField;
        
        private string nameField;
        
        private string native_palceField;
        
        private string nick_nameField;
        
        private string provinceField;
        
        private System.DateTime regist_dateField;
        
        private string sexField;
        
        private string signField;
        
        private long uidField;
        
        private string unoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime birth
        {
            get
            {
                return this.birthField;
            }
            set
            {
                this.birthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int coin
        {
            get
            {
                return this.coinField;
            }
            set
            {
                this.coinField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int exp
        {
            get
            {
                return this.expField;
            }
            set
            {
                this.expField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string face
        {
            get
            {
                return this.faceField;
            }
            set
            {
                this.faceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string job
        {
            get
            {
                return this.jobField;
            }
            set
            {
                this.jobField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime last_login_date
        {
            get
            {
                return this.last_login_dateField;
            }
            set
            {
                this.last_login_dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int login_count
        {
            get
            {
                return this.login_countField;
            }
            set
            {
                this.login_countField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string native_palce
        {
            get
            {
                return this.native_palceField;
            }
            set
            {
                this.native_palceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nick_name
        {
            get
            {
                return this.nick_nameField;
            }
            set
            {
                this.nick_nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string province
        {
            get
            {
                return this.provinceField;
            }
            set
            {
                this.provinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime regist_date
        {
            get
            {
                return this.regist_dateField;
            }
            set
            {
                this.regist_dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string uno
        {
            get
            {
                return this.unoField;
            }
            set
            {
                this.unoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleAccountInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpleAccountInfo : object
    {
        
        private string mobileField;
        
        private string nameField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchUserArgs", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SearchUserArgs : object
    {
        
        private string CityField;
        
        private string ProvinceField;
        
        private string emailField;
        
        private string kwField;
        
        private string mobileField;
        
        private string nameField;
        
        private string telField;
        
        private long[] uidsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Province
        {
            get
            {
                return this.ProvinceField;
            }
            set
            {
                this.ProvinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kw
        {
            get
            {
                return this.kwField;
            }
            set
            {
                this.kwField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tel
        {
            get
            {
                return this.telField;
            }
            set
            {
                this.telField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] uids
        {
            get
            {
                return this.uidsField;
            }
            set
            {
                this.uidsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserArg", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserArg : object
    {
        
        private string EmailField;
        
        private string MobileField;
        
        private string SexField;
        
        private long[] UserIDsField;
        
        private string UserNameField;
        
        private string[] UserNosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile
        {
            get
            {
                return this.MobileField;
            }
            set
            {
                this.MobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex
        {
            get
            {
                return this.SexField;
            }
            set
            {
                this.SexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] UserIDs
        {
            get
            {
                return this.UserIDsField;
            }
            set
            {
                this.UserIDsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] UserNos
        {
            get
            {
                return this.UserNosField;
            }
            set
            {
                this.UserNosField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserBaseClassKinds", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum UserBaseClassKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Keyman = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectStage = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectType = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserBaseClass", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserBaseClass : object
    {
        
        private string ClassNameField;
        
        private string ClassNoField;
        
        private bool IsMainField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassName
        {
            get
            {
                return this.ClassNameField;
            }
            set
            {
                this.ClassNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassNo
        {
            get
            {
                return this.ClassNoField;
            }
            set
            {
                this.ClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMain
        {
            get
            {
                return this.IsMainField;
            }
            set
            {
                this.IsMainField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserProductSituationKinds", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum UserProductSituationKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectType = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectStage = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Keyman = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Contractor = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectTag = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CooperateCustomer", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class CooperateCustomer : object
    {
        
        private System.DateTime CreateDateField;
        
        private string CustomerNameField;
        
        private long IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate
        {
            get
            {
                return this.CreateDateField;
            }
            set
            {
                this.CreateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerName
        {
            get
            {
                return this.CustomerNameField;
            }
            set
            {
                this.CustomerNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiceInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class InvoiceInfo : object
    {
        
        private string BankField;
        
        private string BankAccountField;
        
        private string BusinessLicenseField;
        
        private string CompanyAddressField;
        
        private string CompanyTelField;
        
        private System.DateTime CreatedField;
        
        private System.Nullable<UserService.InvoiceKinds> KindField;
        
        private UserService.InvoiceOpenKinds OpenKindField;
        
        private string ReceiveAddressField;
        
        private string ReceiveEmailField;
        
        private string ReceiveMobileField;
        
        private string ReceiveNameField;
        
        private string ReceivePostField;
        
        private System.Nullable<UserService.InvoiceSendKinds> SendKindField;
        
        private string TaxIdField;
        
        private string TaxRegisterField;
        
        private string TaxpayerField;
        
        private string TitleField;
        
        private System.Nullable<UserService.InvoiceType> TypeField;
        
        private long UidField;
        
        private System.Nullable<System.DateTime> UpdatedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bank
        {
            get
            {
                return this.BankField;
            }
            set
            {
                this.BankField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankAccount
        {
            get
            {
                return this.BankAccountField;
            }
            set
            {
                this.BankAccountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BusinessLicense
        {
            get
            {
                return this.BusinessLicenseField;
            }
            set
            {
                this.BusinessLicenseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyAddress
        {
            get
            {
                return this.CompanyAddressField;
            }
            set
            {
                this.CompanyAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyTel
        {
            get
            {
                return this.CompanyTelField;
            }
            set
            {
                this.CompanyTelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<UserService.InvoiceKinds> Kind
        {
            get
            {
                return this.KindField;
            }
            set
            {
                this.KindField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.InvoiceOpenKinds OpenKind
        {
            get
            {
                return this.OpenKindField;
            }
            set
            {
                this.OpenKindField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceiveAddress
        {
            get
            {
                return this.ReceiveAddressField;
            }
            set
            {
                this.ReceiveAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceiveEmail
        {
            get
            {
                return this.ReceiveEmailField;
            }
            set
            {
                this.ReceiveEmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceiveMobile
        {
            get
            {
                return this.ReceiveMobileField;
            }
            set
            {
                this.ReceiveMobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceiveName
        {
            get
            {
                return this.ReceiveNameField;
            }
            set
            {
                this.ReceiveNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceivePost
        {
            get
            {
                return this.ReceivePostField;
            }
            set
            {
                this.ReceivePostField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<UserService.InvoiceSendKinds> SendKind
        {
            get
            {
                return this.SendKindField;
            }
            set
            {
                this.SendKindField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TaxId
        {
            get
            {
                return this.TaxIdField;
            }
            set
            {
                this.TaxIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TaxRegister
        {
            get
            {
                return this.TaxRegisterField;
            }
            set
            {
                this.TaxRegisterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Taxpayer
        {
            get
            {
                return this.TaxpayerField;
            }
            set
            {
                this.TaxpayerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<UserService.InvoiceType> Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Updated
        {
            get
            {
                return this.UpdatedField;
            }
            set
            {
                this.UpdatedField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiceKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Payment")]
    public enum InvoiceKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Normal = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VAT = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiceOpenKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Payment")]
    public enum InvoiceOpenKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Personal = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Company = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiceSendKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Payment")]
    public enum InvoiceSendKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RegisteredMail = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SF = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        YTO = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ZTO = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Email = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiceType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Payment")]
    public enum InvoiceType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Normal = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Electronic = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NameCard", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class NameCard : object
    {
        
        private string NameCardBackField;
        
        private string NameCardFrontField;
        
        private long UidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameCardBack
        {
            get
            {
                return this.NameCardBackField;
            }
            set
            {
                this.NameCardBackField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameCardFront
        {
            get
            {
                return this.NameCardFrontField;
            }
            set
            {
                this.NameCardFrontField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TestUserModel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class TestUserModel : object
    {
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private long UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserCredentialsArg", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserCredentialsArg : object
    {
        
        private long createrField;
        
        private string[] imagesField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long creater
        {
            get
            {
                return this.createrField;
            }
            set
            {
                this.createrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserCredential", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserCredential : object
    {
        
        private long CidField;
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private string ImageField;
        
        private long UidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Cid
        {
            get
            {
                return this.CidField;
            }
            set
            {
                this.CidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image
        {
            get
            {
                return this.ImageField;
            }
            set
            {
                this.ImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleInformationPush", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpleInformationPush : object
    {
        
        private string areaNoField;
        
        private string contentField;
        
        private long corresIdField;
        
        private System.DateTime createDateField;
        
        private string detailURLField;
        
        private long idField;
        
        private string picURLField;
        
        private string summaryField;
        
        private string titleField;
        
        private byte typeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string areaNo
        {
            get
            {
                return this.areaNoField;
            }
            set
            {
                this.areaNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long corresId
        {
            get
            {
                return this.corresIdField;
            }
            set
            {
                this.corresIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string detailURL
        {
            get
            {
                return this.detailURLField;
            }
            set
            {
                this.detailURLField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string picURL
        {
            get
            {
                return this.picURLField;
            }
            set
            {
                this.picURLField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
    public partial class Result : object
    {
        
        private string help_linkField;
        
        private string messageField;
        
        private string state_codeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string help_link
        {
            get
            {
                return this.help_linkField;
            }
            set
            {
                this.help_linkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string message
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string state_code
        {
            get
            {
                return this.state_codeField;
            }
            set
            {
                this.state_codeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidateType", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum ValidateType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        普通 = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        忘记密码 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        注册 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        绑定手机 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        验证手机 = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        团队管理成员申请 = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        领取优惠券 = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        登陆 = 7,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendValidateCodeType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.ValidateCode")]
    public enum SendValidateCodeType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sms = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Voice = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MobileGetType", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum MobileGetType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cannot_be_btained = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        automatically_access = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        users_fill = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        user_account = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClinetType", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum ClinetType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Project_App_Android = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Project_App_IOS = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Browser = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Project_Mobile_Browser = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AreaMatchType", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum AreaMatchType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IP = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Mobile = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IPOrMobile = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IPAndMbolie = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserAreaInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserAreaInfo : object
    {
        
        private string area_nameField;
        
        private string area_noField;
        
        private bool is_realityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string area_name
        {
            get
            {
                return this.area_nameField;
            }
            set
            {
                this.area_nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string area_no
        {
            get
            {
                return this.area_noField;
            }
            set
            {
                this.area_noField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_reality
        {
            get
            {
                return this.is_realityField;
            }
            set
            {
                this.is_realityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidateCode", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class ValidateCode : object
    {
        
        private string codeField;
        
        private System.DateTime create_dateField;
        
        private long idField;
        
        private string mobileField;
        
        private UserService.ValidateType typeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime create_date
        {
            get
            {
                return this.create_dateField;
            }
            set
            {
                this.create_dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ValidateType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductClass", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class ProductClass : object
    {
        
        private string ProductClassNameField;
        
        private string ProductClassNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductClassName
        {
            get
            {
                return this.ProductClassNameField;
            }
            set
            {
                this.ProductClassNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductClassNo
        {
            get
            {
                return this.ProductClassNoField;
            }
            set
            {
                this.ProductClassNoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductClassStatistics", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class ProductClassStatistics : object
    {
        
        private string ProductClassNoField;
        
        private int ProductCountField;
        
        private int UserCountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductClassNo
        {
            get
            {
                return this.ProductClassNoField;
            }
            set
            {
                this.ProductClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductCount
        {
            get
            {
                return this.ProductCountField;
            }
            set
            {
                this.ProductCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserCount
        {
            get
            {
                return this.UserCountField;
            }
            set
            {
                this.UserCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class Product : object
    {
        
        private int BusinessModelField;
        
        private int LevelField;
        
        private string ProductNameField;
        
        private string TrademarkField;
        
        private long UserIDField;
        
        private string UserNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BusinessModel
        {
            get
            {
                return this.BusinessModelField;
            }
            set
            {
                this.BusinessModelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Level
        {
            get
            {
                return this.LevelField;
            }
            set
            {
                this.LevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this.ProductNameField;
            }
            set
            {
                this.ProductNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Trademark
        {
            get
            {
                return this.TrademarkField;
            }
            set
            {
                this.TrademarkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                this.UserIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserNo
        {
            get
            {
                return this.UserNoField;
            }
            set
            {
                this.UserNoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductEntity", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class ProductEntity : object
    {
        
        private string[] BrandsField;
        
        private System.Nullable<UserService.ProductChannel> ChannelField;
        
        private string ClassNoField;
        
        private UserService.ProductGrade GradeField;
        
        private System.Nullable<bool> IsOfferConstructionField;
        
        private string ModelField;
        
        private string NameField;
        
        private long PIDField;
        
        private string[] PicturesField;
        
        private long UIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Brands
        {
            get
            {
                return this.BrandsField;
            }
            set
            {
                this.BrandsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<UserService.ProductChannel> Channel
        {
            get
            {
                return this.ChannelField;
            }
            set
            {
                this.ChannelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassNo
        {
            get
            {
                return this.ClassNoField;
            }
            set
            {
                this.ClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ProductGrade Grade
        {
            get
            {
                return this.GradeField;
            }
            set
            {
                this.GradeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsOfferConstruction
        {
            get
            {
                return this.IsOfferConstructionField;
            }
            set
            {
                this.IsOfferConstructionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model
        {
            get
            {
                return this.ModelField;
            }
            set
            {
                this.ModelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PID
        {
            get
            {
                return this.PIDField;
            }
            set
            {
                this.PIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Pictures
        {
            get
            {
                return this.PicturesField;
            }
            set
            {
                this.PicturesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UID
        {
            get
            {
                return this.UIDField;
            }
            set
            {
                this.UIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductChannel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum ProductChannel : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Manufacturer = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Agency = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Distribute = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductGrade", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public enum ProductGrade : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        High = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        High_End = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Middle_End = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleProductEntity", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpleProductEntity : object
    {
        
        private string ClassNoField;
        
        private string NameField;
        
        private long PIDField;
        
        private long UIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassNo
        {
            get
            {
                return this.ClassNoField;
            }
            set
            {
                this.ClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PID
        {
            get
            {
                return this.PIDField;
            }
            set
            {
                this.PIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UID
        {
            get
            {
                return this.UIDField;
            }
            set
            {
                this.UIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalUser", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class ExternalUser : object
    {
        
        private string CityField;
        
        private System.DateTime CreatedField;
        
        private long EuidField;
        
        private string FromIdField;
        
        private string HeadimgurlField;
        
        private string MobileField;
        
        private string NicknameField;
        
        private string ProvinceField;
        
        private UserService.ExternalUserSex SexField;
        
        private UserService.UserType TypeField;
        
        private System.DateTime UpdatedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Euid
        {
            get
            {
                return this.EuidField;
            }
            set
            {
                this.EuidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FromId
        {
            get
            {
                return this.FromIdField;
            }
            set
            {
                this.FromIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Headimgurl
        {
            get
            {
                return this.HeadimgurlField;
            }
            set
            {
                this.HeadimgurlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile
        {
            get
            {
                return this.MobileField;
            }
            set
            {
                this.MobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nickname
        {
            get
            {
                return this.NicknameField;
            }
            set
            {
                this.NicknameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Province
        {
            get
            {
                return this.ProvinceField;
            }
            set
            {
                this.ProvinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ExternalUserSex Sex
        {
            get
            {
                return this.SexField;
            }
            set
            {
                this.SexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Updated
        {
            get
            {
                return this.UpdatedField;
            }
            set
            {
                this.UpdatedField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalUserSex", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Questionnaire")]
    public enum ExternalUserSex : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Man = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Woman = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Questionnaire")]
    public enum UserType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TgUser = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WeiXinUser = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QQUser = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserArgsWrapper", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User")]
    public partial class UserArgsWrapper : object
    {
        
        private string AreaCityField;
        
        private string AreaCountryField;
        
        private string AreaProvinceField;
        
        private string AreaTownField;
        
        private string CompanyField;
        
        private string EmailField;
        
        private string FaxField;
        
        private string MobileField;
        
        private string PasswordField;
        
        private string QQField;
        
        private string TelField;
        
        private string UserNameField;
        
        private string UserNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaCity
        {
            get
            {
                return this.AreaCityField;
            }
            set
            {
                this.AreaCityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaCountry
        {
            get
            {
                return this.AreaCountryField;
            }
            set
            {
                this.AreaCountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaProvince
        {
            get
            {
                return this.AreaProvinceField;
            }
            set
            {
                this.AreaProvinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaTown
        {
            get
            {
                return this.AreaTownField;
            }
            set
            {
                this.AreaTownField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company
        {
            get
            {
                return this.CompanyField;
            }
            set
            {
                this.CompanyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fax
        {
            get
            {
                return this.FaxField;
            }
            set
            {
                this.FaxField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile
        {
            get
            {
                return this.MobileField;
            }
            set
            {
                this.MobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QQ
        {
            get
            {
                return this.QQField;
            }
            set
            {
                this.QQField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel
        {
            get
            {
                return this.TelField;
            }
            set
            {
                this.TelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserNo
        {
            get
            {
                return this.UserNoField;
            }
            set
            {
                this.UserNoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LimitKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Limit")]
    public enum LimitKinds : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Footprint = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FootprintReply = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserLimit", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserLimit : object
    {
        
        private System.DateTime CreateDateField;
        
        private long CreaterField;
        
        private bool IsEnableField;
        
        private UserService.LimitKinds LimitKindField;
        
        private System.Nullable<long> RegeneratorField;
        
        private string RemarkField;
        
        private long UidField;
        
        private long UlidField;
        
        private System.Nullable<System.DateTime> UpdateDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate
        {
            get
            {
                return this.CreateDateField;
            }
            set
            {
                this.CreateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnable
        {
            get
            {
                return this.IsEnableField;
            }
            set
            {
                this.IsEnableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.LimitKinds LimitKind
        {
            get
            {
                return this.LimitKindField;
            }
            set
            {
                this.LimitKindField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> Regenerator
        {
            get
            {
                return this.RegeneratorField;
            }
            set
            {
                this.RegeneratorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark
        {
            get
            {
                return this.RemarkField;
            }
            set
            {
                this.RemarkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Ulid
        {
            get
            {
                return this.UlidField;
            }
            set
            {
                this.UlidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> UpdateDate
        {
            get
            {
                return this.UpdateDateField;
            }
            set
            {
                this.UpdateDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AllowResetPasswordResult", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class AllowResetPasswordResult : object
    {
        
        private bool IsAllowField;
        
        private string RejectMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAllow
        {
            get
            {
                return this.IsAllowField;
            }
            set
            {
                this.IsAllowField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RejectMessage
        {
            get
            {
                return this.RejectMessageField;
            }
            set
            {
                this.RejectMessageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserCollectKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User")]
    public enum UserCollectKinds : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProductCollectionIn2016 = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserCollect", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserCollect : object
    {
        
        private System.DateTime createdField;
        
        private long operatorField;
        
        private UserService.UserCollectKinds typeField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserCollectKinds type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleUserAuthority", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpleUserAuthority : object
    {
        
        private System.DateTime expiredField;
        
        private bool is_trialField;
        
        private UserService.UserRole roleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime expired
        {
            get
            {
                return this.expiredField;
            }
            set
            {
                this.expiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_trial
        {
            get
            {
                return this.is_trialField;
            }
            set
            {
                this.is_trialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserRole role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserRole", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.p.api.wcf.Models")]
    public enum UserRole : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Personal = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Advanced = 40,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserLocationRecordRequest", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserLocationRecordRequest : object
    {
        
        private System.Nullable<System.DateTime> EndDateField;
        
        private System.Nullable<bool> IsLoginField;
        
        private System.Nullable<bool> IsPayField;
        
        private System.Nullable<float> NorthEastLatitudeField;
        
        private System.Nullable<float> NorthEastLongitudeField;
        
        private System.Nullable<float> SouthWestLatitudeField;
        
        private System.Nullable<float> SouthWestLongitudeField;
        
        private System.Nullable<System.DateTime> StartDateField;
        
        private System.Nullable<long> UidField;
        
        private long[] UidsField;
        
        private string UserNoField;
        
        private System.Nullable<bool> isDistinctField;
        
        private System.Nullable<int> limitField;
        
        private System.Nullable<int> startField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsLogin
        {
            get
            {
                return this.IsLoginField;
            }
            set
            {
                this.IsLoginField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsPay
        {
            get
            {
                return this.IsPayField;
            }
            set
            {
                this.IsPayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> NorthEastLatitude
        {
            get
            {
                return this.NorthEastLatitudeField;
            }
            set
            {
                this.NorthEastLatitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> NorthEastLongitude
        {
            get
            {
                return this.NorthEastLongitudeField;
            }
            set
            {
                this.NorthEastLongitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> SouthWestLatitude
        {
            get
            {
                return this.SouthWestLatitudeField;
            }
            set
            {
                this.SouthWestLatitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> SouthWestLongitude
        {
            get
            {
                return this.SouthWestLongitudeField;
            }
            set
            {
                this.SouthWestLongitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> StartDate
        {
            get
            {
                return this.StartDateField;
            }
            set
            {
                this.StartDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] Uids
        {
            get
            {
                return this.UidsField;
            }
            set
            {
                this.UidsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserNo
        {
            get
            {
                return this.UserNoField;
            }
            set
            {
                this.UserNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isDistinct
        {
            get
            {
                return this.isDistinctField;
            }
            set
            {
                this.isDistinctField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpUserLocationRecord", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpUserLocationRecord : object
    {
        
        private double latField;
        
        private double lngField;
        
        private long ridField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double lng
        {
            get
            {
                return this.lngField;
            }
            set
            {
                this.lngField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long rid
        {
            get
            {
                return this.ridField;
            }
            set
            {
                this.ridField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserClientSimpleInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserClientSimpleInfo : object
    {
        
        private string AppVersionField;
        
        private System.DateTime CreateTimeField;
        
        private string DeviceNameField;
        
        private string NetWorkingField;
        
        private string OsField;
        
        private long UidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AppVersion
        {
            get
            {
                return this.AppVersionField;
            }
            set
            {
                this.AppVersionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateTime
        {
            get
            {
                return this.CreateTimeField;
            }
            set
            {
                this.CreateTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DeviceName
        {
            get
            {
                return this.DeviceNameField;
            }
            set
            {
                this.DeviceNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NetWorking
        {
            get
            {
                return this.NetWorkingField;
            }
            set
            {
                this.NetWorkingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Os
        {
            get
            {
                return this.OsField;
            }
            set
            {
                this.OsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleUserNumberOfStart", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpleUserNumberOfStart : object
    {
        
        private int CountField;
        
        private long UidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count
        {
            get
            {
                return this.CountField;
            }
            set
            {
                this.CountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FeedbackArgs", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class FeedbackArgs : object
    {
        
        private UserService.ClinetType[] clinetTypeField;
        
        private System.Nullable<bool> isEnabledField;
        
        private System.Nullable<bool> isOperateField;
        
        private int pageIndexField;
        
        private int pageSizeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ClinetType[] clinetType
        {
            get
            {
                return this.clinetTypeField;
            }
            set
            {
                this.clinetTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isOperate
        {
            get
            {
                return this.isOperateField;
            }
            set
            {
                this.isOperateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pageIndex
        {
            get
            {
                return this.pageIndexField;
            }
            set
            {
                this.pageIndexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Feedback", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class Feedback : object
    {
        
        private UserService.ClinetType clientTypeField;
        
        private System.DateTime createDateField;
        
        private string fContentField;
        
        private long fidField;
        
        private System.Nullable<bool> isOperateField;
        
        private System.Nullable<UserService.MobileGetType> mGetTypeField;
        
        private string mobileField;
        
        private string operateContentField;
        
        private System.Nullable<System.DateTime> operateDateField;
        
        private System.Nullable<long> operaterField;
        
        private System.Nullable<long> uidField;
        
        private string userNameField;
        
        private string userNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ClinetType clientType
        {
            get
            {
                return this.clientTypeField;
            }
            set
            {
                this.clientTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fContent
        {
            get
            {
                return this.fContentField;
            }
            set
            {
                this.fContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long fid
        {
            get
            {
                return this.fidField;
            }
            set
            {
                this.fidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isOperate
        {
            get
            {
                return this.isOperateField;
            }
            set
            {
                this.isOperateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<UserService.MobileGetType> mGetType
        {
            get
            {
                return this.mGetTypeField;
            }
            set
            {
                this.mGetTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile
        {
            get
            {
                return this.mobileField;
            }
            set
            {
                this.mobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string operateContent
        {
            get
            {
                return this.operateContentField;
            }
            set
            {
                this.operateContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> operateDate
        {
            get
            {
                return this.operateDateField;
            }
            set
            {
                this.operateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> operater
        {
            get
            {
                return this.operaterField;
            }
            set
            {
                this.operaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userNo
        {
            get
            {
                return this.userNoField;
            }
            set
            {
                this.userNoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserPhoneNumber", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserPhoneNumber : object
    {
        
        private string MobileField;
        
        private long UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile
        {
            get
            {
                return this.MobileField;
            }
            set
            {
                this.MobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DraftProduct", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public partial class DraftProduct : object
    {
        
        private string BrandField;
        
        private long IDField;
        
        private string LevelField;
        
        private string NameField;
        
        private long UserIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand
        {
            get
            {
                return this.BrandField;
            }
            set
            {
                this.BrandField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Level
        {
            get
            {
                return this.LevelField;
            }
            set
            {
                this.LevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                this.UserIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DraftCooperationProductUser", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public partial class DraftCooperationProductUser : object
    {
        
        private string AreaNoField;
        
        private string CompanyField;
        
        private System.DateTime CreatedField;
        
        private string EmailField;
        
        private bool IsCheckField;
        
        private string JobField;
        
        private string KeyPeopleField;
        
        private string MobileField;
        
        private string NameField;
        
        private string ProjectTypeField;
        
        private string RemarkField;
        
        private long UserIDField;
        
        private string WeChatField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaNo
        {
            get
            {
                return this.AreaNoField;
            }
            set
            {
                this.AreaNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company
        {
            get
            {
                return this.CompanyField;
            }
            set
            {
                this.CompanyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCheck
        {
            get
            {
                return this.IsCheckField;
            }
            set
            {
                this.IsCheckField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Job
        {
            get
            {
                return this.JobField;
            }
            set
            {
                this.JobField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KeyPeople
        {
            get
            {
                return this.KeyPeopleField;
            }
            set
            {
                this.KeyPeopleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile
        {
            get
            {
                return this.MobileField;
            }
            set
            {
                this.MobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProjectType
        {
            get
            {
                return this.ProjectTypeField;
            }
            set
            {
                this.ProjectTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark
        {
            get
            {
                return this.RemarkField;
            }
            set
            {
                this.RemarkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                this.UserIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WeChat
        {
            get
            {
                return this.WeChatField;
            }
            set
            {
                this.WeChatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CooperationProduct", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public partial class CooperationProduct : object
    {
        
        private System.Nullable<UserService.ProductChannel1> ChannelField;
        
        private string ClassNoField;
        
        private UserService.UserDockingProduct[] DockProductField;
        
        private byte GradeField;
        
        private System.Nullable<bool> IsOfferConstructionField;
        
        private string ModelField;
        
        private string NameField;
        
        private long PIDField;
        
        private UserService.UserProductBrand[] ProductBrandField;
        
        private string[] ProductPicturesField;
        
        private long UIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<UserService.ProductChannel1> Channel
        {
            get
            {
                return this.ChannelField;
            }
            set
            {
                this.ChannelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassNo
        {
            get
            {
                return this.ClassNoField;
            }
            set
            {
                this.ClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserDockingProduct[] DockProduct
        {
            get
            {
                return this.DockProductField;
            }
            set
            {
                this.DockProductField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Grade
        {
            get
            {
                return this.GradeField;
            }
            set
            {
                this.GradeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsOfferConstruction
        {
            get
            {
                return this.IsOfferConstructionField;
            }
            set
            {
                this.IsOfferConstructionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model
        {
            get
            {
                return this.ModelField;
            }
            set
            {
                this.ModelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PID
        {
            get
            {
                return this.PIDField;
            }
            set
            {
                this.PIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserProductBrand[] ProductBrand
        {
            get
            {
                return this.ProductBrandField;
            }
            set
            {
                this.ProductBrandField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] ProductPictures
        {
            get
            {
                return this.ProductPicturesField;
            }
            set
            {
                this.ProductPicturesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UID
        {
            get
            {
                return this.UIDField;
            }
            set
            {
                this.UIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductChannel", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Products")]
    public enum ProductChannel1 : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Manufacturer = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Agency = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Distribute = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDockingProduct", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public partial class UserDockingProduct : object
    {
        
        private string ClassNoField;
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private string NameField;
        
        private long PIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassNo
        {
            get
            {
                return this.ClassNoField;
            }
            set
            {
                this.ClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PID
        {
            get
            {
                return this.PIDField;
            }
            set
            {
                this.PIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserProductBrand", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public partial class UserProductBrand : object
    {
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private string NameField;
        
        private long PIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PID
        {
            get
            {
                return this.PIDField;
            }
            set
            {
                this.PIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleClassInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpleClassInfo : object
    {
        
        private bool is_mainField;
        
        private string noField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool is_main
        {
            get
            {
                return this.is_mainField;
            }
            set
            {
                this.is_mainField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string no
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleCooperationProduct", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SimpleCooperationProduct : object
    {
        
        private string ModelField;
        
        private string[] brandsField;
        
        private System.Nullable<UserService.ProductChannel> channelField;
        
        private long idField;
        
        private System.Nullable<bool> isOfferConstructionField;
        
        private byte levelField;
        
        private string nameField;
        
        private string noField;
        
        private string[] picturesField;
        
        private long uidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model
        {
            get
            {
                return this.ModelField;
            }
            set
            {
                this.ModelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] brands
        {
            get
            {
                return this.brandsField;
            }
            set
            {
                this.brandsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<UserService.ProductChannel> channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isOfferConstruction
        {
            get
            {
                return this.isOfferConstructionField;
            }
            set
            {
                this.isOfferConstructionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string no
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] pictures
        {
            get
            {
                return this.picturesField;
            }
            set
            {
                this.picturesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RangeOfNullableOfdateTime5F2dSckg", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Data")]
    public partial class RangeOfNullableOfdateTime5F2dSckg : object
    {
        
        private bool _IsCanComparableField;
        
        private bool _IsEqualsField;
        
        private System.Nullable<System.DateTime> _MaxField;
        
        private bool _MaxAssignedField;
        
        private System.Nullable<System.DateTime> _MinField;
        
        private bool _MinAssignedField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _IsCanComparable
        {
            get
            {
                return this._IsCanComparableField;
            }
            set
            {
                this._IsCanComparableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _IsEquals
        {
            get
            {
                return this._IsEqualsField;
            }
            set
            {
                this._IsEqualsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> _Max
        {
            get
            {
                return this._MaxField;
            }
            set
            {
                this._MaxField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _MaxAssigned
        {
            get
            {
                return this._MaxAssignedField;
            }
            set
            {
                this._MaxAssignedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> _Min
        {
            get
            {
                return this._MinField;
            }
            set
            {
                this._MinField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _MinAssigned
        {
            get
            {
                return this._MinAssignedField;
            }
            set
            {
                this._MinAssignedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CooperationProductUser", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public partial class CooperationProductUser : object
    {
        
        private string AreaNoField;
        
        private System.DateTime CheckDateField;
        
        private long CheckerField;
        
        private string CompanyField;
        
        private UserService.UserProductSituation[] ContractorsField;
        
        private string EmailField;
        
        private string JobField;
        
        private UserService.UserProductSituation[] KeyPeoplesField;
        
        private byte LevelField;
        
        private string MobileField;
        
        private string NameField;
        
        private UserService.UserProductSituation[] ProjectStagesField;
        
        private UserService.UserProductSituation[] ProjectTypesField;
        
        private string RemarkField;
        
        private byte SaleModelField;
        
        private System.DateTime UserCreatedField;
        
        private long UserIDField;
        
        private string WeChatField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaNo
        {
            get
            {
                return this.AreaNoField;
            }
            set
            {
                this.AreaNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CheckDate
        {
            get
            {
                return this.CheckDateField;
            }
            set
            {
                this.CheckDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Checker
        {
            get
            {
                return this.CheckerField;
            }
            set
            {
                this.CheckerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company
        {
            get
            {
                return this.CompanyField;
            }
            set
            {
                this.CompanyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserProductSituation[] Contractors
        {
            get
            {
                return this.ContractorsField;
            }
            set
            {
                this.ContractorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Job
        {
            get
            {
                return this.JobField;
            }
            set
            {
                this.JobField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserProductSituation[] KeyPeoples
        {
            get
            {
                return this.KeyPeoplesField;
            }
            set
            {
                this.KeyPeoplesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Level
        {
            get
            {
                return this.LevelField;
            }
            set
            {
                this.LevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile
        {
            get
            {
                return this.MobileField;
            }
            set
            {
                this.MobileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserProductSituation[] ProjectStages
        {
            get
            {
                return this.ProjectStagesField;
            }
            set
            {
                this.ProjectStagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserProductSituation[] ProjectTypes
        {
            get
            {
                return this.ProjectTypesField;
            }
            set
            {
                this.ProjectTypesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark
        {
            get
            {
                return this.RemarkField;
            }
            set
            {
                this.RemarkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte SaleModel
        {
            get
            {
                return this.SaleModelField;
            }
            set
            {
                this.SaleModelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UserCreated
        {
            get
            {
                return this.UserCreatedField;
            }
            set
            {
                this.UserCreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                this.UserIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WeChat
        {
            get
            {
                return this.WeChatField;
            }
            set
            {
                this.WeChatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserProductSituation", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public partial class UserProductSituation : object
    {
        
        private string ClassNoField;
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private bool IsMainField;
        
        private UserService.ClassType TypeField;
        
        private long UIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassNo
        {
            get
            {
                return this.ClassNoField;
            }
            set
            {
                this.ClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMain
        {
            get
            {
                return this.IsMainField;
            }
            set
            {
                this.IsMainField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ClassType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UID
        {
            get
            {
                return this.UIDField;
            }
            set
            {
                this.UIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClassType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.CooperationUser")]
    public enum ClassType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectType = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectStage = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        KeyPeople = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Contractor = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectTag = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FromSaleCooperationUser", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Data")]
    public partial class FromSaleCooperationUser : object
    {
        
        private string amdinNoField;
        
        private System.DateTime createdField;
        
        private long custIDField;
        
        private bool isUserFillField;
        
        private long userIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string amdinNo
        {
            get
            {
                return this.amdinNoField;
            }
            set
            {
                this.amdinNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long custID
        {
            get
            {
                return this.custIDField;
            }
            set
            {
                this.custIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isUserFill
        {
            get
            {
                return this.isUserFillField;
            }
            set
            {
                this.isUserFillField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long userID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserFollowClassUpEdiInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserFollowClassUpEdiInfo : object
    {
        
        private UserService.UserBaseCLassEditInfo[] ContractorsField;
        
        private UserService.UserBaseCLassEditInfo[] KeyPeoplesField;
        
        private UserService.UserBaseCLassEditInfo[] ProjectStagesField;
        
        private UserService.UserBaseCLassEditInfo[] ProjectTagsField;
        
        private UserService.UserBaseCLassEditInfo[] ProjectTypesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserBaseCLassEditInfo[] Contractors
        {
            get
            {
                return this.ContractorsField;
            }
            set
            {
                this.ContractorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserBaseCLassEditInfo[] KeyPeoples
        {
            get
            {
                return this.KeyPeoplesField;
            }
            set
            {
                this.KeyPeoplesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserBaseCLassEditInfo[] ProjectStages
        {
            get
            {
                return this.ProjectStagesField;
            }
            set
            {
                this.ProjectStagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserBaseCLassEditInfo[] ProjectTags
        {
            get
            {
                return this.ProjectTagsField;
            }
            set
            {
                this.ProjectTagsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserBaseCLassEditInfo[] ProjectTypes
        {
            get
            {
                return this.ProjectTypesField;
            }
            set
            {
                this.ProjectTypesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserBaseCLassEditInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserBaseCLassEditInfo : object
    {
        
        private string ClassNoField;
        
        private bool IsMainField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassNo
        {
            get
            {
                return this.ClassNoField;
            }
            set
            {
                this.ClassNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMain
        {
            get
            {
                return this.IsMainField;
            }
            set
            {
                this.IsMainField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lottery", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class Lottery : object
    {
        
        private System.Nullable<System.DateTime> EndDateField;
        
        private long IdField;
        
        private System.Nullable<bool> IsEndField;
        
        private string NameField;
        
        private System.Nullable<int> PeriodField;
        
        private UserService.LotteryPrize[] PrizesField;
        
        private System.Nullable<long> StageField;
        
        private System.Nullable<System.DateTime> StartDateField;
        
        private System.Nullable<int> UserRemnantLotteryCountField;
        
        private System.Nullable<int> UserUsedLotteryCountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsEnd
        {
            get
            {
                return this.IsEndField;
            }
            set
            {
                this.IsEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Period
        {
            get
            {
                return this.PeriodField;
            }
            set
            {
                this.PeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.LotteryPrize[] Prizes
        {
            get
            {
                return this.PrizesField;
            }
            set
            {
                this.PrizesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> Stage
        {
            get
            {
                return this.StageField;
            }
            set
            {
                this.StageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> StartDate
        {
            get
            {
                return this.StartDateField;
            }
            set
            {
                this.StartDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserRemnantLotteryCount
        {
            get
            {
                return this.UserRemnantLotteryCountField;
            }
            set
            {
                this.UserRemnantLotteryCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserUsedLotteryCount
        {
            get
            {
                return this.UserUsedLotteryCountField;
            }
            set
            {
                this.UserUsedLotteryCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LotteryPrize", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class LotteryPrize : object
    {
        
        private int ChangeField;
        
        private int CountField;
        
        private string ImgField;
        
        private string PrizeDescriptionField;
        
        private long PrizeIdField;
        
        private string PrizeNameField;
        
        private int WonCountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Change
        {
            get
            {
                return this.ChangeField;
            }
            set
            {
                this.ChangeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count
        {
            get
            {
                return this.CountField;
            }
            set
            {
                this.CountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Img
        {
            get
            {
                return this.ImgField;
            }
            set
            {
                this.ImgField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrizeDescription
        {
            get
            {
                return this.PrizeDescriptionField;
            }
            set
            {
                this.PrizeDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PrizeId
        {
            get
            {
                return this.PrizeIdField;
            }
            set
            {
                this.PrizeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrizeName
        {
            get
            {
                return this.PrizeNameField;
            }
            set
            {
                this.PrizeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WonCount
        {
            get
            {
                return this.WonCountField;
            }
            set
            {
                this.WonCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LotteryPrizeResult", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class LotteryPrizeResult : object
    {
        
        private bool IsAssignField;
        
        private long LotteryIdField;
        
        private string MemoField;
        
        private string PrizeDescriptionField;
        
        private System.Nullable<long> PrizeIdField;
        
        private string PrizeNameField;
        
        private string ResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAssign
        {
            get
            {
                return this.IsAssignField;
            }
            set
            {
                this.IsAssignField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LotteryId
        {
            get
            {
                return this.LotteryIdField;
            }
            set
            {
                this.LotteryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Memo
        {
            get
            {
                return this.MemoField;
            }
            set
            {
                this.MemoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrizeDescription
        {
            get
            {
                return this.PrizeDescriptionField;
            }
            set
            {
                this.PrizeDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> PrizeId
        {
            get
            {
                return this.PrizeIdField;
            }
            set
            {
                this.PrizeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrizeName
        {
            get
            {
                return this.PrizeNameField;
            }
            set
            {
                this.PrizeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WonLotteryPrize", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class WonLotteryPrize : object
    {
        
        private System.DateTime DateField;
        
        private bool IsAssignField;
        
        private string PrizeDescribeField;
        
        private long PrizeIdField;
        
        private string PrizeNameField;
        
        private long UidField;
        
        private string UserNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAssign
        {
            get
            {
                return this.IsAssignField;
            }
            set
            {
                this.IsAssignField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrizeDescribe
        {
            get
            {
                return this.PrizeDescribeField;
            }
            set
            {
                this.PrizeDescribeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PrizeId
        {
            get
            {
                return this.PrizeIdField;
            }
            set
            {
                this.PrizeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrizeName
        {
            get
            {
                return this.PrizeNameField;
            }
            set
            {
                this.PrizeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Uid
        {
            get
            {
                return this.UidField;
            }
            set
            {
                this.UidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserNo
        {
            get
            {
                return this.UserNoField;
            }
            set
            {
                this.UserNoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserLotteryHistory", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class UserLotteryHistory : object
    {
        
        private System.Nullable<System.DateTime> CreateDateField;
        
        private System.Nullable<bool> EnabledField;
        
        private System.Nullable<bool> HadAssignField;
        
        private System.Nullable<long> LotIdField;
        
        private string MemoField;
        
        private string ResultField;
        
        private long UlIdField;
        
        private System.Nullable<System.DateTime> UpdateDateField;
        
        private string UpdateUserNoField;
        
        private string UserNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreateDate
        {
            get
            {
                return this.CreateDateField;
            }
            set
            {
                this.CreateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Enabled
        {
            get
            {
                return this.EnabledField;
            }
            set
            {
                this.EnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> HadAssign
        {
            get
            {
                return this.HadAssignField;
            }
            set
            {
                this.HadAssignField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> LotId
        {
            get
            {
                return this.LotIdField;
            }
            set
            {
                this.LotIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Memo
        {
            get
            {
                return this.MemoField;
            }
            set
            {
                this.MemoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UlId
        {
            get
            {
                return this.UlIdField;
            }
            set
            {
                this.UlIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> UpdateDate
        {
            get
            {
                return this.UpdateDateField;
            }
            set
            {
                this.UpdateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UpdateUserNo
        {
            get
            {
                return this.UpdateUserNoField;
            }
            set
            {
                this.UpdateUserNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserNo
        {
            get
            {
                return this.UserNoField;
            }
            set
            {
                this.UserNoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LotteryResult", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class LotteryResult : object
    {
        
        private string ActionUserField;
        
        private System.Nullable<System.DateTime> CreateDateField;
        
        private System.Nullable<bool> FinishField;
        
        private long LhIdField;
        
        private UserService.UserLotteryHistory[] LotteryHistoryField;
        
        private System.Nullable<long> LotteryIdField;
        
        private string MemoField;
        
        private string ResultField;
        
        private System.Nullable<long> UserCountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ActionUser
        {
            get
            {
                return this.ActionUserField;
            }
            set
            {
                this.ActionUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreateDate
        {
            get
            {
                return this.CreateDateField;
            }
            set
            {
                this.CreateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Finish
        {
            get
            {
                return this.FinishField;
            }
            set
            {
                this.FinishField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LhId
        {
            get
            {
                return this.LhIdField;
            }
            set
            {
                this.LhIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UserLotteryHistory[] LotteryHistory
        {
            get
            {
                return this.LotteryHistoryField;
            }
            set
            {
                this.LotteryHistoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> LotteryId
        {
            get
            {
                return this.LotteryIdField;
            }
            set
            {
                this.LotteryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Memo
        {
            get
            {
                return this.MemoField;
            }
            set
            {
                this.MemoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> UserCount
        {
            get
            {
                return this.UserCountField;
            }
            set
            {
                this.UserCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuestionnaireSubjectSource", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class QuestionnaireSubjectSource : object
    {
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private bool IsEnableField;
        
        private long OperatorsField;
        
        private UserService.QuestionnaireOptions[] OptionsField;
        
        private long QaidField;
        
        private long QssidField;
        
        private string TitleField;
        
        private System.DateTime UpdatedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnable
        {
            get
            {
                return this.IsEnableField;
            }
            set
            {
                this.IsEnableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Operators
        {
            get
            {
                return this.OperatorsField;
            }
            set
            {
                this.OperatorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.QuestionnaireOptions[] Options
        {
            get
            {
                return this.OptionsField;
            }
            set
            {
                this.OptionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qaid
        {
            get
            {
                return this.QaidField;
            }
            set
            {
                this.QaidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qssid
        {
            get
            {
                return this.QssidField;
            }
            set
            {
                this.QssidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Updated
        {
            get
            {
                return this.UpdatedField;
            }
            set
            {
                this.UpdatedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuestionnaireOptions", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class QuestionnaireOptions : object
    {
        
        private string ContentField;
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private bool IsEnableField;
        
        private long QoidField;
        
        private long QssidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content
        {
            get
            {
                return this.ContentField;
            }
            set
            {
                this.ContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnable
        {
            get
            {
                return this.IsEnableField;
            }
            set
            {
                this.IsEnableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qoid
        {
            get
            {
                return this.QoidField;
            }
            set
            {
                this.QoidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qssid
        {
            get
            {
                return this.QssidField;
            }
            set
            {
                this.QssidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuestionnairesActivity", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class QuestionnairesActivity : object
    {
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private int MaxSubjectCountField;
        
        private string NameField;
        
        private long OperatorsField;
        
        private long QaidField;
        
        private string ShareFriendIntroField;
        
        private string ShareGroupIntroField;
        
        private System.DateTime UpdatedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Creater
        {
            get
            {
                return this.CreaterField;
            }
            set
            {
                this.CreaterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxSubjectCount
        {
            get
            {
                return this.MaxSubjectCountField;
            }
            set
            {
                this.MaxSubjectCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Operators
        {
            get
            {
                return this.OperatorsField;
            }
            set
            {
                this.OperatorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qaid
        {
            get
            {
                return this.QaidField;
            }
            set
            {
                this.QaidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShareFriendIntro
        {
            get
            {
                return this.ShareFriendIntroField;
            }
            set
            {
                this.ShareFriendIntroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShareGroupIntro
        {
            get
            {
                return this.ShareGroupIntroField;
            }
            set
            {
                this.ShareGroupIntroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Updated
        {
            get
            {
                return this.UpdatedField;
            }
            set
            {
                this.UpdatedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Questionnaires", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class Questionnaires : object
    {
        
        private UserService.QuestionnairesActivity ActivityField;
        
        private System.DateTime CreatedField;
        
        private long QidField;
        
        private UserService.QuestionnaireSubject[] SubjectsField;
        
        private UserService.ExternalUser UserField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.QuestionnairesActivity Activity
        {
            get
            {
                return this.ActivityField;
            }
            set
            {
                this.ActivityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qid
        {
            get
            {
                return this.QidField;
            }
            set
            {
                this.QidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.QuestionnaireSubject[] Subjects
        {
            get
            {
                return this.SubjectsField;
            }
            set
            {
                this.SubjectsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ExternalUser User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuestionnaireSubject", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class QuestionnaireSubject : object
    {
        
        private UserService.QuestionnaireAnswer[] AnswersField;
        
        private System.DateTime CreatedField;
        
        private UserService.QuestionnaireOptions OptionField;
        
        private long QidField;
        
        private long QsidField;
        
        private UserService.QuestionnaireSubjectSource SubjectLibraryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.QuestionnaireAnswer[] Answers
        {
            get
            {
                return this.AnswersField;
            }
            set
            {
                this.AnswersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.QuestionnaireOptions Option
        {
            get
            {
                return this.OptionField;
            }
            set
            {
                this.OptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qid
        {
            get
            {
                return this.QidField;
            }
            set
            {
                this.QidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Qsid
        {
            get
            {
                return this.QsidField;
            }
            set
            {
                this.QsidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.QuestionnaireSubjectSource SubjectLibrary
        {
            get
            {
                return this.SubjectLibraryField;
            }
            set
            {
                this.SubjectLibraryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuestionnaireAnswer", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class QuestionnaireAnswer : object
    {
        
        private System.DateTime CreatedField;
        
        private UserService.QuestionnaireOptions OptionField;
        
        private UserService.SubjectAnswer SubjectField;
        
        private UserService.ExternalUser UserField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.QuestionnaireOptions Option
        {
            get
            {
                return this.OptionField;
            }
            set
            {
                this.OptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.SubjectAnswer Subject
        {
            get
            {
                return this.SubjectField;
            }
            set
            {
                this.SubjectField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ExternalUser User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SubjectAnswer", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class SubjectAnswer : object
    {
        
        private System.DateTime createdField;
        
        private long qidField;
        
        private long qoidField;
        
        private long qsidField;
        
        private long qssidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long qid
        {
            get
            {
                return this.qidField;
            }
            set
            {
                this.qidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long qoid
        {
            get
            {
                return this.qoidField;
            }
            set
            {
                this.qoidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long qsid
        {
            get
            {
                return this.qsidField;
            }
            set
            {
                this.qsidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long qssid
        {
            get
            {
                return this.qssidField;
            }
            set
            {
                this.qssidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeixinContentEditInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class WeixinContentEditInfo : object
    {
        
        private System.Nullable<long> cidField;
        
        private UserService.ContentTypes content_typeField;
        
        private string descriptionField;
        
        private string media_idField;
        
        private System.Nullable<System.DateTime> media_id_expiredField;
        
        private string picUrlField;
        
        private string titleField;
        
        private UserService.UseKinds typeField;
        
        private string urlField;
        
        private byte weightsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> cid
        {
            get
            {
                return this.cidField;
            }
            set
            {
                this.cidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ContentTypes content_type
        {
            get
            {
                return this.content_typeField;
            }
            set
            {
                this.content_typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string media_id
        {
            get
            {
                return this.media_idField;
            }
            set
            {
                this.media_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> media_id_expired
        {
            get
            {
                return this.media_id_expiredField;
            }
            set
            {
                this.media_id_expiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string picUrl
        {
            get
            {
                return this.picUrlField;
            }
            set
            {
                this.picUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UseKinds type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte weights
        {
            get
            {
                return this.weightsField;
            }
            set
            {
                this.weightsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ContentTypes", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.WeixinAutoReply")]
    public enum ContentTypes : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Text = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Image = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Voice = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Video = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Music = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        News = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UseKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.WeixinAutoReply")]
    public enum UseKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Activity = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Experience = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ContactsCircle = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Introduce = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Purchasing = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        KeywordReply = 6,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeiXinContentModel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class WeiXinContentModel : object
    {
        
        private long cidField;
        
        private UserService.ContentTypes contentTypeField;
        
        private System.DateTime createDateField;
        
        private string createUserField;
        
        private string descriptionField;
        
        private bool isEnabledField;
        
        private string media_idField;
        
        private System.Nullable<System.DateTime> media_id_expiredField;
        
        private string memoField;
        
        private string picUrlField;
        
        private string titleField;
        
        private UserService.UseKinds typeField;
        
        private System.DateTime updateDateField;
        
        private string updateUserField;
        
        private string urlField;
        
        private byte weightsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long cid
        {
            get
            {
                return this.cidField;
            }
            set
            {
                this.cidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.ContentTypes contentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string createUser
        {
            get
            {
                return this.createUserField;
            }
            set
            {
                this.createUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string media_id
        {
            get
            {
                return this.media_idField;
            }
            set
            {
                this.media_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> media_id_expired
        {
            get
            {
                return this.media_id_expiredField;
            }
            set
            {
                this.media_id_expiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string memo
        {
            get
            {
                return this.memoField;
            }
            set
            {
                this.memoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string picUrl
        {
            get
            {
                return this.picUrlField;
            }
            set
            {
                this.picUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.UseKinds type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime updateDate
        {
            get
            {
                return this.updateDateField;
            }
            set
            {
                this.updateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string updateUser
        {
            get
            {
                return this.updateUserField;
            }
            set
            {
                this.updateUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte weights
        {
            get
            {
                return this.weightsField;
            }
            set
            {
                this.weightsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeixinKeywordModel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class WeixinKeywordModel : object
    {
        
        private System.DateTime createdField;
        
        private long createrField;
        
        private bool isEnabledField;
        
        private string keywordField;
        
        private long kidField;
        
        private System.DateTime updatedField;
        
        private long updaterField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long creater
        {
            get
            {
                return this.createrField;
            }
            set
            {
                this.createrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long kid
        {
            get
            {
                return this.kidField;
            }
            set
            {
                this.kidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime updated
        {
            get
            {
                return this.updatedField;
            }
            set
            {
                this.updatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long updater
        {
            get
            {
                return this.updaterField;
            }
            set
            {
                this.updaterField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PushKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.WeixinAutoReply")]
    public enum PushKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Project = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeiXinSubscribeEditInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class WeiXinSubscribeEditInfo : object
    {
        
        private string cityField;
        
        private System.Nullable<long> groupIDField;
        
        private string headimgurlField;
        
        private bool isEnabledField;
        
        private string nicknameField;
        
        private string openIdField;
        
        private string provinceField;
        
        private System.Nullable<byte> sexField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> groupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string headimgurl
        {
            get
            {
                return this.headimgurlField;
            }
            set
            {
                this.headimgurlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nickname
        {
            get
            {
                return this.nicknameField;
            }
            set
            {
                this.nicknameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string openId
        {
            get
            {
                return this.openIdField;
            }
            set
            {
                this.openIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string province
        {
            get
            {
                return this.provinceField;
            }
            set
            {
                this.provinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                this.sexField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vote", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UserService.VoteSys))]
    public partial class Vote : object
    {
        
        private System.DateTime EndDateField;
        
        private string JoinConditionExplainField;
        
        private System.Nullable<long> LotteryIDField;
        
        private int LotteryLimitField;
        
        private string PrizeExplainField;
        
        private System.DateTime StartDateField;
        
        private string TitleField;
        
        private long VidField;
        
        private int VotenumLimitField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JoinConditionExplain
        {
            get
            {
                return this.JoinConditionExplainField;
            }
            set
            {
                this.JoinConditionExplainField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> LotteryID
        {
            get
            {
                return this.LotteryIDField;
            }
            set
            {
                this.LotteryIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LotteryLimit
        {
            get
            {
                return this.LotteryLimitField;
            }
            set
            {
                this.LotteryLimitField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrizeExplain
        {
            get
            {
                return this.PrizeExplainField;
            }
            set
            {
                this.PrizeExplainField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate
        {
            get
            {
                return this.StartDateField;
            }
            set
            {
                this.StartDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Vid
        {
            get
            {
                return this.VidField;
            }
            set
            {
                this.VidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VotenumLimit
        {
            get
            {
                return this.VotenumLimitField;
            }
            set
            {
                this.VotenumLimitField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VoteSys", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class VoteSys : UserService.Vote
    {
        
        private System.DateTime CreatedField;
        
        private System.Nullable<long> OperatorField;
        
        private System.DateTime UpdatedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created
        {
            get
            {
                return this.CreatedField;
            }
            set
            {
                this.CreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> Operator
        {
            get
            {
                return this.OperatorField;
            }
            set
            {
                this.OperatorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Updated
        {
            get
            {
                return this.UpdatedField;
            }
            set
            {
                this.UpdatedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RangeOfdateTime", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Data")]
    public partial class RangeOfdateTime : object
    {
        
        private bool _IsCanComparableField;
        
        private bool _IsEqualsField;
        
        private System.DateTime _MaxField;
        
        private bool _MaxAssignedField;
        
        private System.DateTime _MinField;
        
        private bool _MinAssignedField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _IsCanComparable
        {
            get
            {
                return this._IsCanComparableField;
            }
            set
            {
                this._IsCanComparableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _IsEquals
        {
            get
            {
                return this._IsEqualsField;
            }
            set
            {
                this._IsEqualsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime _Max
        {
            get
            {
                return this._MaxField;
            }
            set
            {
                this._MaxField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _MaxAssigned
        {
            get
            {
                return this._MaxAssignedField;
            }
            set
            {
                this._MaxAssignedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime _Min
        {
            get
            {
                return this._MinField;
            }
            set
            {
                this._MinField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _MinAssigned
        {
            get
            {
                return this._MinAssignedField;
            }
            set
            {
                this._MinAssignedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VoteHistory", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class VoteHistory : object
    {
        
        private long VhidField;
        
        private long VidField;
        
        private long VoidField;
        
        private System.DateTime VoteDateField;
        
        private string VoteIPField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Vhid
        {
            get
            {
                return this.VhidField;
            }
            set
            {
                this.VhidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Vid
        {
            get
            {
                return this.VidField;
            }
            set
            {
                this.VidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Void
        {
            get
            {
                return this.VoidField;
            }
            set
            {
                this.VoidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VoteDate
        {
            get
            {
                return this.VoteDateField;
            }
            set
            {
                this.VoteDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VoteIP
        {
            get
            {
                return this.VoteIPField;
            }
            set
            {
                this.VoteIPField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Kinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Vote")]
    public enum Kinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TgUser = 0,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VoteOption", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.user.api.wcf.Models")]
    public partial class VoteOption : object
    {
        
        private string CharacterField;
        
        private string HobbyField;
        
        private string IconField;
        
        private bool IsEnableField;
        
        private System.DateTime JoinDateField;
        
        private long KeyField;
        
        private UserService.Kinds KindField;
        
        private string ManifestoField;
        
        private string NameField;
        
        private string TestimonialsField;
        
        private long VidField;
        
        private long VoidField;
        
        private int VotenumField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Character
        {
            get
            {
                return this.CharacterField;
            }
            set
            {
                this.CharacterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hobby
        {
            get
            {
                return this.HobbyField;
            }
            set
            {
                this.HobbyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Icon
        {
            get
            {
                return this.IconField;
            }
            set
            {
                this.IconField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnable
        {
            get
            {
                return this.IsEnableField;
            }
            set
            {
                this.IsEnableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime JoinDate
        {
            get
            {
                return this.JoinDateField;
            }
            set
            {
                this.JoinDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                this.KeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserService.Kinds Kind
        {
            get
            {
                return this.KindField;
            }
            set
            {
                this.KindField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Manifesto
        {
            get
            {
                return this.ManifestoField;
            }
            set
            {
                this.ManifestoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Testimonials
        {
            get
            {
                return this.TestimonialsField;
            }
            set
            {
                this.TestimonialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Vid
        {
            get
            {
                return this.VidField;
            }
            set
            {
                this.VidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Void
        {
            get
            {
                return this.VoidField;
            }
            set
            {
                this.VoidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Votenum
        {
            get
            {
                return this.VotenumField;
            }
            set
            {
                this.VotenumField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reply", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.User.Vote")]
    public partial class Reply : object
    {
        
        private string ContentField;
        
        private string DisplayNameField;
        
        private string IconField;
        
        private System.DateTime ReplyDateField;
        
        private long RidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content
        {
            get
            {
                return this.ContentField;
            }
            set
            {
                this.ContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName
        {
            get
            {
                return this.DisplayNameField;
            }
            set
            {
                this.DisplayNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Icon
        {
            get
            {
                return this.IconField;
            }
            set
            {
                this.IconField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReplyDate
        {
            get
            {
                return this.ReplyDateField;
            }
            set
            {
                this.ReplyDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Rid
        {
            get
            {
                return this.RidField;
            }
            set
            {
                this.RidField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IUserInfoService")]
    public interface IUserInfoService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/SetRealNameExamine", ReplyAction="http://tempuri.org/IUserInfoService/SetRealNameExamineResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/SetRealNameExamineErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task SetRealNameExamineAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, bool examined, long examiner, string memo, string nameCardFront, string nameCardBack, string businessLicense);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserCompanyInfo", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserCompanyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserCompanyInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateUserCompanyInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string company, string companyProfile, string[] companyImages, string companyUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserQuingity", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserQuingityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserQuingityErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateUserQuingityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string[] quingitys);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/AddOrUpdateProjectCase", ReplyAction="http://tempuri.org/IUserInfoService/AddOrUpdateProjectCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/AddOrUpdateProjectCaseErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long> AddOrUpdateProjectCaseAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long @operator, System.Nullable<long> pcid, string name, string content, string[] images, long[] pids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/DeleteProjectCase", ReplyAction="http://tempuri.org/IUserInfoService/DeleteProjectCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/DeleteProjectCaseErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteProjectCaseAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, long pcid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserProjecCase", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserProjecCaseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserProjecCaseErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateUserProjecCaseAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long operater, UserService.ProjectCase[] args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserCompanyProfile", ReplyAction="http://tempuri.org/IUserInfoService/GetUserCompanyProfileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserCompanyProfileErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.CompanyProfile[]> GetUserCompanyProfileAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserProjectCases", ReplyAction="http://tempuri.org/IUserInfoService/GetUserProjectCasesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserProjectCasesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ProjectCase[]> GetUserProjectCasesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserName", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserNameErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserNameAsync(Tgnet.Api.OAuth2Identity identity, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserSex", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserSexResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserSexErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserSexAsync(Tgnet.Api.OAuth2Identity identity, string sex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserCompany", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserCompanyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserCompanyErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserCompanyAsync(Tgnet.Api.OAuth2Identity identity, string company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserNameAndCompany", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserNameAndCompanyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserNameAndCompanyErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserNameAndCompanyAsync(Tgnet.Api.OAuth2Identity identity, string name, string company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserJob", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserJobResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserJobErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserJobAsync(Tgnet.Api.OAuth2Identity identity, string job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserQQ", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserQQResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserQQErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserQQAsync(Tgnet.Api.OAuth2Identity identity, string qq);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessModel", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserBusinessModelResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessModelErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserBusinessModelAsync(Tgnet.Api.OAuth2Identity identity, byte businessModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserAddress", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserAddressResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserAddressErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserAddressAsync(Tgnet.Api.OAuth2Identity identity, string areaNo, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserBirth", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserBirthResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserBirthErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserBirthAsync(Tgnet.Api.OAuth2Identity identity, System.DateTime brief);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserNative", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserNativeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserNativeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserNativeAsync(Tgnet.Api.OAuth2Identity identity, string areaNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserExperience", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserExperienceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserExperienceErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserExperienceAsync(Tgnet.Api.OAuth2Identity identity, int experience);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserInterests", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserInterestsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserInterestsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserInterestsAsync(Tgnet.Api.OAuth2Identity identity, string[] interests);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessArea", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreaErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserBusinessAreaAsync(Tgnet.Api.OAuth2Identity identity, string[] areaNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreaByUserId", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreaByUserIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreaByUserIdErrorResponseTy" +
            "peFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreaByUserIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateUserBusinessAreaByUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string[] areaNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserMobile", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserMobileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserMobileErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserMobileErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateUserMobileAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string mobile, bool isVerify);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfo", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateUserSimpleInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string name, string email, string sex, string job, int experience, string company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfo2", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfo2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfo2ErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserSimpleInfo2ErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateUserSimpleInfo2Async(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string name, string email, string sex, string job, string company, string tel, string province, string city, string address, System.Nullable<UserService.InfoVerifyKinds> verifyKind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserInfo", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateUserInfoAsync(
                    Tgnet.Api.OAuth2ClientIdentity identity, 
                    long uid, 
                    string name, 
                    string email, 
                    string sex, 
                    string job, 
                    string company, 
                    string tel, 
                    string province, 
                    string city, 
                    string address, 
                    System.Nullable<System.DateTime> birth, 
                    System.Nullable<int> experience, 
                    string qq, 
                    string weixin, 
                    string birthAreaNo, 
                    System.Nullable<UserService.InfoVerifyKinds> verifyKind, 
                    string nameCardFront, 
                    string nameCardBack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserInfo2", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserInfo2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserInfo2ErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserInfo2ErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateUserInfo2Async(
                    Tgnet.Api.OAuth2ClientIdentity identity, 
                    long uid, 
                    string name, 
                    string email, 
                    string sex, 
                    string job, 
                    string company, 
                    string tel, 
                    string province, 
                    string city, 
                    string town, 
                    string address, 
                    System.Nullable<System.DateTime> birth, 
                    System.Nullable<int> experience, 
                    string qq, 
                    string weixin, 
                    string birthAreaNo, 
                    System.Nullable<UserService.InfoVerifyKinds> verifyKind, 
                    string nameCardFront, 
                    string nameCardBack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserProducts", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserProductsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserProductsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<UserService.UserProduct[]> UpdateUserProductsAsync(Tgnet.Api.OAuth2Identity identity, UserService.UserProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserProducts2", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserProducts2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserProducts2ErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserProducts2ErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserProduct[]> UpdateUserProducts2Async(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.UserProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserInterestProductsTrade2", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserInterestProductsTrade2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserInterestProductsTrade2ErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserInterestProductsTrade2ErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserProduct.Trade[]> UpdateUserInterestProductsTrade2Async(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.UserProduct.Trade[] trades);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersFaces", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersFacesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersFacesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserFace[]> GetUsersFacesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserExperiences", ReplyAction="http://tempuri.org/IUserInfoService/GetUserExperiencesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserExperiencesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, int>> GetUserExperiencesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserBusinessModels", ReplyAction="http://tempuri.org/IUserInfoService/GetUserBusinessModelsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserBusinessModelsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, int>> GetUserBusinessModelsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserInterests", ReplyAction="http://tempuri.org/IUserInfoService/GetUserInterestsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserInterestsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string[]>> GetUserInterestsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserProducts", ReplyAction="http://tempuri.org/IUserInfoService/GetUserProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserProductsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, UserService.UserProduct[]>> GetUserProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserInterestProductTrades", ReplyAction="http://tempuri.org/IUserInfoService/GetUserInterestProductTradesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserInterestProductTradesErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, UserService.UserProduct.Trade[]>> GetUserInterestProductTradesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserBusinessAreas", ReplyAction="http://tempuri.org/IUserInfoService/GetUserBusinessAreasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserBusinessAreasErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string[]>> GetUserBusinessAreasAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreabyUid", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreabyUidResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserBusinessAreabyUidErrorResponseTypeF" +
            "ault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateUserBusinessAreabyUidAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Collections.Generic.Dictionary<long, string[]> areas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersName", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersNameErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string>> GetUsersNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersNo", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersNoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersNoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string>> GetUsersNoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersIdByUserNos", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersIdByUserNosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersIdByUserNosErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, long>> GetUsersIdByUserNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] userNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfo", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByMobiles", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByMobilesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByMobilesErrorResponseTypeF" +
            "ault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByMobilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] mobiles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByUserNos", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByUserNosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByUserNosErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByUserNosErrorResponseTypeF" +
            "ault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByUserNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] userNos);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/SearchUsersSimpleInfo", ReplyAction="http://tempuri.org/IUserInfoService/SearchUsersSimpleInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/SearchUsersSimpleInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SearchUsersSimpleInfoResponse> SearchUsersSimpleInfoAsync(UserService.SearchUsersSimpleInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersInfoForLogin", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersInfoForLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersInfoForLoginErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserLoginInfo[]> GetUsersInfoForLoginAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByDateAndDelayTime", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByDateAndDelayTimeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByDateAndDelayTimeErrorResp" +
            "onseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByDateAndDelayTimeAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<System.DateTime> lastRegisterDate, int delayTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByMinRegisterDate", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByMinRegisterDateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByMinRegisterDateErrorRespo" +
            "nseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUsersSimpleInfoByMinRegisterDateErrorCodeF" +
            "ault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByMinRegisterDateAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.DateTime minRegisterDate, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UserInfoComplete", ReplyAction="http://tempuri.org/IUserInfoService/UserInfoCompleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UserInfoCompleteErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UserInfoCompleteErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UserInfoCompleteAsync(Tgnet.Api.OAuth2Identity identity, string actual_name, string company, string sex, string job, int experience);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UserInfoCompleteByUserId", ReplyAction="http://tempuri.org/IUserInfoService/UserInfoCompleteByUserIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UserInfoCompleteByUserIdErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UserInfoCompleteByUserIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UserInfoCompleteByUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string actual_name, string company, string sex, string job, int experience);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserEmail", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserEmailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserEmailErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserEmailErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> UpdateUserEmailAsync(Tgnet.Api.OAuth2Identity identity, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserSimpleInfoByKey", ReplyAction="http://tempuri.org/IUserInfoService/GetUserSimpleInfoByKeyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserSimpleInfoByKeyErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUserSimpleInfoByKeyErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserSimpleInfo> GetUserSimpleInfoByKeyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetSimpleAccountInfoByMobiles", ReplyAction="http://tempuri.org/IUserInfoService/GetSimpleAccountInfoByMobilesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetSimpleAccountInfoByMobilesErrorResponseTyp" +
            "eFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleAccountInfo[]> GetSimpleAccountInfoByMobilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] mobiles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/TestException", ReplyAction="http://tempuri.org/IUserInfoService/TestExceptionResponse")]
        System.Threading.Tasks.Task TestExceptionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/SearchUser", ReplyAction="http://tempuri.org/IUserInfoService/SearchUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/SearchUserErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/SearchUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long[]> SearchUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, byte type, string key, string userNo, string userName, string userMobile, string userEmail, string company, string businessAreaNo, System.Nullable<System.DateTime> minBirthday, System.Nullable<System.DateTime> maxBirthday, string productName, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/SearchUser2", ReplyAction="http://tempuri.org/IUserInfoService/SearchUser2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/SearchUser2ErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/SearchUser2ErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long[]> SearchUser2Async(Tgnet.Api.OAuth2ClientIdentity identity, UserService.SearchUserArgs args);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/SearchUsersByArg", ReplyAction="http://tempuri.org/IUserInfoService/SearchUsersByArgResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/SearchUsersByArgErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/SearchUsersByArgErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SearchUsersByArgResponse> SearchUsersByArgAsync(UserService.SearchUsersByArgRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserBaseClass", ReplyAction="http://tempuri.org/IUserInfoService/GetUserBaseClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserBaseClassErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUserBaseClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<UserService.UserBaseClassKinds, UserService.UserBaseClass[]>> GetUserBaseClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.UserBaseClassKinds[] kinds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersProductSituations", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersProductSituationsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersProductSituationsErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUsersProductSituationsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, System.Collections.Generic.Dictionary<UserService.UserProductSituationKinds, UserService.UserBaseClass[]>>> GetUsersProductSituationsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids, UserService.UserProductSituationKinds[] kinds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUsersBaseClass", ReplyAction="http://tempuri.org/IUserInfoService/GetUsersBaseClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUsersBaseClassErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUsersBaseClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, System.Collections.Generic.Dictionary<UserService.UserBaseClassKinds, UserService.UserBaseClass[]>>> GetUsersBaseClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids, UserService.UserBaseClassKinds[] kinds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetSuitableUids", ReplyAction="http://tempuri.org/IUserInfoService/GetSuitableUidsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetSuitableUidsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetSuitableUidsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long[]> GetSuitableUidsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids, System.Collections.Generic.Dictionary<UserService.UserProductSituationKinds, string[]> baseClasses);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateUserBaseClass", ReplyAction="http://tempuri.org/IUserInfoService/UpdateUserBaseClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateUserBaseClassErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateUserBaseClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateUserBaseClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, System.Collections.Generic.Dictionary<UserService.UserBaseClassKinds, UserService.UserBaseClass[]> baseClass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetCooperateCustomers", ReplyAction="http://tempuri.org/IUserInfoService/GetCooperateCustomersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetCooperateCustomersErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetCooperateCustomersErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, UserService.CooperateCustomer[]>> GetCooperateCustomersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/CreateCooperateCustomer", ReplyAction="http://tempuri.org/IUserInfoService/CreateCooperateCustomerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/CreateCooperateCustomerErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/CreateCooperateCustomerErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task CreateCooperateCustomerAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string[] customerName, bool isRemove);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/AddOrUpdateUserInvoiceInfo", ReplyAction="http://tempuri.org/IUserInfoService/AddOrUpdateUserInvoiceInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/AddOrUpdateUserInvoiceInfoErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/AddOrUpdateUserInvoiceInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddOrUpdateUserInvoiceInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, UserService.InvoiceInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserInvoiceInfo", ReplyAction="http://tempuri.org/IUserInfoService/GetUserInvoiceInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserInvoiceInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUserInvoiceInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.InvoiceInfo[]> GetUserInvoiceInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserInvoiceInfoList", ReplyAction="http://tempuri.org/IUserInfoService/GetUserInvoiceInfoListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserInvoiceInfoListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUserInvoiceInfoListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.InvoiceInfo>> GetUserInvoiceInfoListAsync(Tgnet.Api.OAuth2ClientIdentity identity, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UploadFace", ReplyAction="http://tempuri.org/IUserInfoService/UploadFaceResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UploadFaceResponse> UploadFaceAsync(UserService.UploadFaceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserNameCard", ReplyAction="http://tempuri.org/IUserInfoService/GetUserNameCardResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserNameCardErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUserNameCardErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.NameCard[]> GetUserNameCardAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/AddTestUsers", ReplyAction="http://tempuri.org/IUserInfoService/AddTestUsersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/AddTestUsersErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/AddTestUsersErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddTestUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userIds, string userNos, string userMobileNos, long creater);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/SearchTestUser", ReplyAction="http://tempuri.org/IUserInfoService/SearchTestUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/SearchTestUserErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/SearchTestUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.TestUserModel>> SearchTestUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/DeleteTestUsers", ReplyAction="http://tempuri.org/IUserInfoService/DeleteTestUsersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/DeleteTestUsersErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/DeleteTestUsersErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteTestUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetAllTestUserId", ReplyAction="http://tempuri.org/IUserInfoService/GetAllTestUserIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetAllTestUserIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetAllTestUserIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long[]> GetAllTestUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/IsTestUser", ReplyAction="http://tempuri.org/IUserInfoService/IsTestUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/IsTestUserErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/IsTestUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> IsTestUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserProjectCaseByPage", ReplyAction="http://tempuri.org/IUserInfoService/GetUserProjectCaseByPageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserProjectCaseByPageErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUserProjectCaseByPageErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.ProjectCase>> GetUserProjectCaseByPageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetTestUser", ReplyAction="http://tempuri.org/IUserInfoService/GetTestUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetTestUserErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetTestUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long[]> GetTestUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdateRegisteRecommender", ReplyAction="http://tempuri.org/IUserInfoService/UpdateRegisteRecommenderResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdateRegisteRecommenderErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdateRegisteRecommenderErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateRegisteRecommenderAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string recommenderUserNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/UpdteUserCredentials", ReplyAction="http://tempuri.org/IUserInfoService/UpdteUserCredentialsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/UpdteUserCredentialsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/UpdteUserCredentialsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdteUserCredentialsAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserCredentialsArg arg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/GetUserCredentials", ReplyAction="http://tempuri.org/IUserInfoService/GetUserCredentialsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/GetUserCredentialsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/GetUserCredentialsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserCredential[]> GetUserCredentialsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserInfoService/SearchUserCount", ReplyAction="http://tempuri.org/IUserInfoService/SearchUserCountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserInfoService/SearchUserCountErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserInfoService/SearchUserCountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<int> SearchUserCountAsync(Tgnet.Api.OAuth2ClientIdentity identity);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchUsersSimpleInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchUsersSimpleInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Tgnet.Api.OAuth2ClientIdentity identity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string keyword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int start;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int limit;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public long[] withoutUids;
        
        public SearchUsersSimpleInfoRequest()
        {
        }
        
        public SearchUsersSimpleInfoRequest(Tgnet.Api.OAuth2ClientIdentity identity, string keyword, int start, int limit, long[] withoutUids)
        {
            this.identity = identity;
            this.keyword = keyword;
            this.start = start;
            this.limit = limit;
            this.withoutUids = withoutUids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchUsersSimpleInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchUsersSimpleInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UserService.UserSimpleInfo[] SearchUsersSimpleInfoResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int count;
        
        public SearchUsersSimpleInfoResponse()
        {
        }
        
        public SearchUsersSimpleInfoResponse(UserService.UserSimpleInfo[] SearchUsersSimpleInfoResult, int count)
        {
            this.SearchUsersSimpleInfoResult = SearchUsersSimpleInfoResult;
            this.count = count;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchUsersByArg", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchUsersByArgRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Tgnet.Api.OAuth2ClientIdentity identity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public UserService.UserArg arg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int pageIndex;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int pageSize;
        
        public SearchUsersByArgRequest()
        {
        }
        
        public SearchUsersByArgRequest(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserArg arg, int pageIndex, int pageSize)
        {
            this.identity = identity;
            this.arg = arg;
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchUsersByArgResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchUsersByArgResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UserService.UserSimpleInfo[] SearchUsersByArgResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int pageCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int recordCount;
        
        public SearchUsersByArgResponse()
        {
        }
        
        public SearchUsersByArgResponse(UserService.UserSimpleInfo[] SearchUsersByArgResult, int pageCount, int recordCount)
        {
            this.SearchUsersByArgResult = SearchUsersByArgResult;
            this.pageCount = pageCount;
            this.recordCount = recordCount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadFaceRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UploadFaceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Tgnet.Api.OAuth2ClientIdentity Identity;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long Uid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public byte[] Stream;
        
        public UploadFaceRequest()
        {
        }
        
        public UploadFaceRequest(string FileName, Tgnet.Api.OAuth2ClientIdentity Identity, long Uid, byte[] Stream)
        {
            this.FileName = FileName;
            this.Identity = Identity;
            this.Uid = Uid;
            this.Stream = Stream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFaceResponse
    {
        
        public UploadFaceResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IUserInfoServiceChannel : UserService.IUserInfoService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class UserInfoServiceClient : System.ServiceModel.ClientBase<UserService.IUserInfoService>, UserService.IUserInfoService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserInfoServiceClient() : 
                base(UserInfoServiceClient.GetDefaultBinding(), UserInfoServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IUserInfoService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserInfoServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(UserInfoServiceClient.GetBindingForEndpoint(endpointConfiguration), UserInfoServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserInfoServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserInfoServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserInfoServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserInfoServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task SetRealNameExamineAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, bool examined, long examiner, string memo, string nameCardFront, string nameCardBack, string businessLicense)
        {
            return base.Channel.SetRealNameExamineAsync(identity, uid, examined, examiner, memo, nameCardFront, nameCardBack, businessLicense);
        }
        
        public System.Threading.Tasks.Task UpdateUserCompanyInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string company, string companyProfile, string[] companyImages, string companyUrl)
        {
            return base.Channel.UpdateUserCompanyInfoAsync(identity, uid, company, companyProfile, companyImages, companyUrl);
        }
        
        public System.Threading.Tasks.Task UpdateUserQuingityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string[] quingitys)
        {
            return base.Channel.UpdateUserQuingityAsync(identity, uid, quingitys);
        }
        
        public System.Threading.Tasks.Task<long> AddOrUpdateProjectCaseAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long @operator, System.Nullable<long> pcid, string name, string content, string[] images, long[] pids)
        {
            return base.Channel.AddOrUpdateProjectCaseAsync(identity, uid, @operator, pcid, name, content, images, pids);
        }
        
        public System.Threading.Tasks.Task DeleteProjectCaseAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, long pcid)
        {
            return base.Channel.DeleteProjectCaseAsync(identity, @operator, pcid);
        }
        
        public System.Threading.Tasks.Task UpdateUserProjecCaseAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long operater, UserService.ProjectCase[] args)
        {
            return base.Channel.UpdateUserProjecCaseAsync(identity, uid, operater, args);
        }
        
        public System.Threading.Tasks.Task<UserService.CompanyProfile[]> GetUserCompanyProfileAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserCompanyProfileAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<UserService.ProjectCase[]> GetUserProjectCasesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserProjectCasesAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserNameAsync(Tgnet.Api.OAuth2Identity identity, string name)
        {
            return base.Channel.UpdateUserNameAsync(identity, name);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserSexAsync(Tgnet.Api.OAuth2Identity identity, string sex)
        {
            return base.Channel.UpdateUserSexAsync(identity, sex);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserCompanyAsync(Tgnet.Api.OAuth2Identity identity, string company)
        {
            return base.Channel.UpdateUserCompanyAsync(identity, company);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserNameAndCompanyAsync(Tgnet.Api.OAuth2Identity identity, string name, string company)
        {
            return base.Channel.UpdateUserNameAndCompanyAsync(identity, name, company);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserJobAsync(Tgnet.Api.OAuth2Identity identity, string job)
        {
            return base.Channel.UpdateUserJobAsync(identity, job);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserQQAsync(Tgnet.Api.OAuth2Identity identity, string qq)
        {
            return base.Channel.UpdateUserQQAsync(identity, qq);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserBusinessModelAsync(Tgnet.Api.OAuth2Identity identity, byte businessModel)
        {
            return base.Channel.UpdateUserBusinessModelAsync(identity, businessModel);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserAddressAsync(Tgnet.Api.OAuth2Identity identity, string areaNo, string address)
        {
            return base.Channel.UpdateUserAddressAsync(identity, areaNo, address);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserBirthAsync(Tgnet.Api.OAuth2Identity identity, System.DateTime brief)
        {
            return base.Channel.UpdateUserBirthAsync(identity, brief);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserNativeAsync(Tgnet.Api.OAuth2Identity identity, string areaNo)
        {
            return base.Channel.UpdateUserNativeAsync(identity, areaNo);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserExperienceAsync(Tgnet.Api.OAuth2Identity identity, int experience)
        {
            return base.Channel.UpdateUserExperienceAsync(identity, experience);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserInterestsAsync(Tgnet.Api.OAuth2Identity identity, string[] interests)
        {
            return base.Channel.UpdateUserInterestsAsync(identity, interests);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserBusinessAreaAsync(Tgnet.Api.OAuth2Identity identity, string[] areaNos)
        {
            return base.Channel.UpdateUserBusinessAreaAsync(identity, areaNos);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserBusinessAreaByUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string[] areaNos)
        {
            return base.Channel.UpdateUserBusinessAreaByUserIdAsync(identity, uid, areaNos);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserMobileAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string mobile, bool isVerify)
        {
            return base.Channel.UpdateUserMobileAsync(identity, uid, mobile, isVerify);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserSimpleInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string name, string email, string sex, string job, int experience, string company)
        {
            return base.Channel.UpdateUserSimpleInfoAsync(identity, uid, name, email, sex, job, experience, company);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserSimpleInfo2Async(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string name, string email, string sex, string job, string company, string tel, string province, string city, string address, System.Nullable<UserService.InfoVerifyKinds> verifyKind)
        {
            return base.Channel.UpdateUserSimpleInfo2Async(identity, uid, name, email, sex, job, company, tel, province, city, address, verifyKind);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserInfoAsync(
                    Tgnet.Api.OAuth2ClientIdentity identity, 
                    long uid, 
                    string name, 
                    string email, 
                    string sex, 
                    string job, 
                    string company, 
                    string tel, 
                    string province, 
                    string city, 
                    string address, 
                    System.Nullable<System.DateTime> birth, 
                    System.Nullable<int> experience, 
                    string qq, 
                    string weixin, 
                    string birthAreaNo, 
                    System.Nullable<UserService.InfoVerifyKinds> verifyKind, 
                    string nameCardFront, 
                    string nameCardBack)
        {
            return base.Channel.UpdateUserInfoAsync(identity, uid, name, email, sex, job, company, tel, province, city, address, birth, experience, qq, weixin, birthAreaNo, verifyKind, nameCardFront, nameCardBack);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserInfo2Async(
                    Tgnet.Api.OAuth2ClientIdentity identity, 
                    long uid, 
                    string name, 
                    string email, 
                    string sex, 
                    string job, 
                    string company, 
                    string tel, 
                    string province, 
                    string city, 
                    string town, 
                    string address, 
                    System.Nullable<System.DateTime> birth, 
                    System.Nullable<int> experience, 
                    string qq, 
                    string weixin, 
                    string birthAreaNo, 
                    System.Nullable<UserService.InfoVerifyKinds> verifyKind, 
                    string nameCardFront, 
                    string nameCardBack)
        {
            return base.Channel.UpdateUserInfo2Async(identity, uid, name, email, sex, job, company, tel, province, city, town, address, birth, experience, qq, weixin, birthAreaNo, verifyKind, nameCardFront, nameCardBack);
        }
        
        public System.Threading.Tasks.Task<UserService.UserProduct[]> UpdateUserProductsAsync(Tgnet.Api.OAuth2Identity identity, UserService.UserProduct[] products)
        {
            return base.Channel.UpdateUserProductsAsync(identity, products);
        }
        
        public System.Threading.Tasks.Task<UserService.UserProduct[]> UpdateUserProducts2Async(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.UserProduct[] products)
        {
            return base.Channel.UpdateUserProducts2Async(identity, uid, products);
        }
        
        public System.Threading.Tasks.Task<UserService.UserProduct.Trade[]> UpdateUserInterestProductsTrade2Async(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.UserProduct.Trade[] trades)
        {
            return base.Channel.UpdateUserInterestProductsTrade2Async(identity, uid, trades);
        }
        
        public System.Threading.Tasks.Task<UserService.UserFace[]> GetUsersFacesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUsersFacesAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, int>> GetUserExperiencesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserExperiencesAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, int>> GetUserBusinessModelsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserBusinessModelsAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string[]>> GetUserInterestsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserInterestsAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, UserService.UserProduct[]>> GetUserProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserProductsAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, UserService.UserProduct.Trade[]>> GetUserInterestProductTradesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserInterestProductTradesAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string[]>> GetUserBusinessAreasAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserBusinessAreasAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserBusinessAreabyUidAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Collections.Generic.Dictionary<long, string[]> areas)
        {
            return base.Channel.UpdateUserBusinessAreabyUidAsync(identity, areas);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string>> GetUsersNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUsersNameAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string>> GetUsersNoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUsersNoAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, long>> GetUsersIdByUserNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] userNos)
        {
            return base.Channel.GetUsersIdByUserNosAsync(identity, userNos);
        }
        
        public System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUsersSimpleInfoAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByMobilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] mobiles)
        {
            return base.Channel.GetUsersSimpleInfoByMobilesAsync(identity, mobiles);
        }
        
        public System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByUserNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] userNos)
        {
            return base.Channel.GetUsersSimpleInfoByUserNosAsync(identity, userNos);
        }
        
        public System.Threading.Tasks.Task<UserService.SearchUsersSimpleInfoResponse> SearchUsersSimpleInfoAsync(UserService.SearchUsersSimpleInfoRequest request)
        {
            return base.Channel.SearchUsersSimpleInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserService.UserLoginInfo[]> GetUsersInfoForLoginAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUsersInfoForLoginAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByDateAndDelayTimeAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<System.DateTime> lastRegisterDate, int delayTime)
        {
            return base.Channel.GetUsersSimpleInfoByDateAndDelayTimeAsync(identity, lastRegisterDate, delayTime);
        }
        
        public System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUsersSimpleInfoByMinRegisterDateAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.DateTime minRegisterDate, int count)
        {
            return base.Channel.GetUsersSimpleInfoByMinRegisterDateAsync(identity, minRegisterDate, count);
        }
        
        public System.Threading.Tasks.Task<bool> UserInfoCompleteAsync(Tgnet.Api.OAuth2Identity identity, string actual_name, string company, string sex, string job, int experience)
        {
            return base.Channel.UserInfoCompleteAsync(identity, actual_name, company, sex, job, experience);
        }
        
        public System.Threading.Tasks.Task<bool> UserInfoCompleteByUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string actual_name, string company, string sex, string job, int experience)
        {
            return base.Channel.UserInfoCompleteByUserIdAsync(identity, uid, actual_name, company, sex, job, experience);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserEmailAsync(Tgnet.Api.OAuth2Identity identity, string email)
        {
            return base.Channel.UpdateUserEmailAsync(identity, email);
        }
        
        public System.Threading.Tasks.Task<UserService.UserSimpleInfo> GetUserSimpleInfoByKeyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string key)
        {
            return base.Channel.GetUserSimpleInfoByKeyAsync(identity, key);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleAccountInfo[]> GetSimpleAccountInfoByMobilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] mobiles)
        {
            return base.Channel.GetSimpleAccountInfoByMobilesAsync(identity, mobiles);
        }
        
        public System.Threading.Tasks.Task TestExceptionAsync()
        {
            return base.Channel.TestExceptionAsync();
        }
        
        public System.Threading.Tasks.Task<long[]> SearchUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, byte type, string key, string userNo, string userName, string userMobile, string userEmail, string company, string businessAreaNo, System.Nullable<System.DateTime> minBirthday, System.Nullable<System.DateTime> maxBirthday, string productName, long[] uids)
        {
            return base.Channel.SearchUserAsync(identity, type, key, userNo, userName, userMobile, userEmail, company, businessAreaNo, minBirthday, maxBirthday, productName, uids);
        }
        
        public System.Threading.Tasks.Task<long[]> SearchUser2Async(Tgnet.Api.OAuth2ClientIdentity identity, UserService.SearchUserArgs args)
        {
            return base.Channel.SearchUser2Async(identity, args);
        }
        
        public System.Threading.Tasks.Task<UserService.SearchUsersByArgResponse> SearchUsersByArgAsync(UserService.SearchUsersByArgRequest request)
        {
            return base.Channel.SearchUsersByArgAsync(request);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<UserService.UserBaseClassKinds, UserService.UserBaseClass[]>> GetUserBaseClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.UserBaseClassKinds[] kinds)
        {
            return base.Channel.GetUserBaseClassAsync(identity, uid, kinds);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, System.Collections.Generic.Dictionary<UserService.UserProductSituationKinds, UserService.UserBaseClass[]>>> GetUsersProductSituationsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids, UserService.UserProductSituationKinds[] kinds)
        {
            return base.Channel.GetUsersProductSituationsAsync(identity, uids, kinds);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, System.Collections.Generic.Dictionary<UserService.UserBaseClassKinds, UserService.UserBaseClass[]>>> GetUsersBaseClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids, UserService.UserBaseClassKinds[] kinds)
        {
            return base.Channel.GetUsersBaseClassAsync(identity, uids, kinds);
        }
        
        public System.Threading.Tasks.Task<long[]> GetSuitableUidsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids, System.Collections.Generic.Dictionary<UserService.UserProductSituationKinds, string[]> baseClasses)
        {
            return base.Channel.GetSuitableUidsAsync(identity, uids, baseClasses);
        }
        
        public System.Threading.Tasks.Task UpdateUserBaseClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, System.Collections.Generic.Dictionary<UserService.UserBaseClassKinds, UserService.UserBaseClass[]> baseClass)
        {
            return base.Channel.UpdateUserBaseClassAsync(identity, uid, baseClass);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, UserService.CooperateCustomer[]>> GetCooperateCustomersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uid)
        {
            return base.Channel.GetCooperateCustomersAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task CreateCooperateCustomerAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string[] customerName, bool isRemove)
        {
            return base.Channel.CreateCooperateCustomerAsync(identity, uid, customerName, isRemove);
        }
        
        public System.Threading.Tasks.Task AddOrUpdateUserInvoiceInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, UserService.InvoiceInfo info)
        {
            return base.Channel.AddOrUpdateUserInvoiceInfoAsync(identity, @operator, info);
        }
        
        public System.Threading.Tasks.Task<UserService.InvoiceInfo[]> GetUserInvoiceInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserInvoiceInfoAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.InvoiceInfo>> GetUserInvoiceInfoListAsync(Tgnet.Api.OAuth2ClientIdentity identity, int start, int limit)
        {
            return base.Channel.GetUserInvoiceInfoListAsync(identity, start, limit);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserService.UploadFaceResponse> UserService.IUserInfoService.UploadFaceAsync(UserService.UploadFaceRequest request)
        {
            return base.Channel.UploadFaceAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserService.UploadFaceResponse> UploadFaceAsync(string FileName, Tgnet.Api.OAuth2ClientIdentity Identity, long Uid, byte[] Stream)
        {
            UserService.UploadFaceRequest inValue = new UserService.UploadFaceRequest();
            inValue.FileName = FileName;
            inValue.Identity = Identity;
            inValue.Uid = Uid;
            inValue.Stream = Stream;
            return ((UserService.IUserInfoService)(this)).UploadFaceAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<UserService.NameCard[]> GetUserNameCardAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserNameCardAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task AddTestUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userIds, string userNos, string userMobileNos, long creater)
        {
            return base.Channel.AddTestUsersAsync(identity, userIds, userNos, userMobileNos, creater);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.TestUserModel>> SearchTestUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, int start, int limit)
        {
            return base.Channel.SearchTestUserAsync(identity, start, limit);
        }
        
        public System.Threading.Tasks.Task DeleteTestUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.DeleteTestUsersAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<long[]> GetAllTestUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity)
        {
            return base.Channel.GetAllTestUserIdAsync(identity);
        }
        
        public System.Threading.Tasks.Task<bool> IsTestUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.IsTestUserAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.ProjectCase>> GetUserProjectCaseByPageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, int start, int limit)
        {
            return base.Channel.GetUserProjectCaseByPageAsync(identity, uid, start, limit);
        }
        
        public System.Threading.Tasks.Task<long[]> GetTestUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetTestUserAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task UpdateRegisteRecommenderAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string recommenderUserNo)
        {
            return base.Channel.UpdateRegisteRecommenderAsync(identity, uid, recommenderUserNo);
        }
        
        public System.Threading.Tasks.Task UpdteUserCredentialsAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserCredentialsArg arg)
        {
            return base.Channel.UpdteUserCredentialsAsync(identity, arg);
        }
        
        public System.Threading.Tasks.Task<UserService.UserCredential[]> GetUserCredentialsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserCredentialsAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<int> SearchUserCountAsync(Tgnet.Api.OAuth2ClientIdentity identity)
        {
            return base.Channel.SearchUserCountAsync(identity);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IUserInfoService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IUserInfoService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.user.tgnet.com:18065/Services/UserService.svc/Info");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserInfoServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IUserInfoService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserInfoServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IUserInfoService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IUserInfoService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IUserManagerService")]
    public interface IUserManagerService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNo", ReplyAction="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNoErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> IsUsableMobileOfUserNoAsync(string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNo2", ReplyAction="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNo2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNo2ErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/IsUsableMobileOfUserNo2ErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> IsUsableMobileOfUserNo2Async(string mobile, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/IsUsableEmail", ReplyAction="http://tempuri.org/IUserManagerService/IsUsableEmailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/IsUsableEmailErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/IsUsableEmailErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> IsUsableEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/Register", ReplyAction="http://tempuri.org/IUserManagerService/RegisterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/RegisterErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/RegisterErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long> RegisterAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userno, string mobile, bool isVerifyMobile, string email, bool isVerifyEmail, string password, string ip, string name, string company, string registerFrom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetUidIfNonexistentRegister", ReplyAction="http://tempuri.org/IUserManagerService/GetUidIfNonexistentRegisterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetUidIfNonexistentRegisterErrorResponseTy" +
            "peFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetUidIfNonexistentRegisterErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long> GetUidIfNonexistentRegisterAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, bool isVerifyMobile, string password, string ip, string registerFrom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/SendCodeFromForgetPasswrodByNo", ReplyAction="http://tempuri.org/IUserManagerService/SendCodeFromForgetPasswrodByNoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/SendCodeFromForgetPasswrodByNoErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/SendCodeFromForgetPasswrodByNoErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task SendCodeFromForgetPasswrodByNoAsync(string userNo, string signName, string ip, string from);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/VerifyCodeForForgetPassrordByNo", ReplyAction="http://tempuri.org/IUserManagerService/VerifyCodeForForgetPassrordByNoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/VerifyCodeForForgetPassrordByNoErrorRespon" +
            "seTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/VerifyCodeForForgetPassrordByNoErrorCodeFa" +
            "ult", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<string> VerifyCodeForForgetPassrordByNoAsync(string userNo, string code, System.Nullable<int> expires_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/ResetPassword", ReplyAction="http://tempuri.org/IUserManagerService/ResetPasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/ResetPasswordErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/ResetPasswordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task ResetPasswordAsync(string code, string newPasswrod, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetInformationPushById", ReplyAction="http://tempuri.org/IUserManagerService/GetInformationPushByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetInformationPushByIdErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetInformationPushByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleInformationPush> GetInformationPushByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long id);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByUid", ReplyAction="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByUidResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByUidErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByUidErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.GetSimpleInformationPushByUidResponse> GetSimpleInformationPushByUidAsync(UserService.GetSimpleInformationPushByUidRequest request);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByAreaNos", ReplyAction="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByAreaNosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByAreaNosErrorResp" +
            "onseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetSimpleInformationPushByAreaNosErrorCode" +
            "Fault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.GetSimpleInformationPushByAreaNosResponse> GetSimpleInformationPushByAreaNosAsync(UserService.GetSimpleInformationPushByAreaNosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/AddInformationPush", ReplyAction="http://tempuri.org/IUserManagerService/AddInformationPushResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/AddInformationPushErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/AddInformationPushErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> AddInformationPushAsync(Tgnet.Api.OAuth2ClientIdentity identity, string adminUser, UserService.SimpleInformationPush informationPush);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/UpdateInformationPush", ReplyAction="http://tempuri.org/IUserManagerService/UpdateInformationPushResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/UpdateInformationPushErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/UpdateInformationPushErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> UpdateInformationPushAsync(Tgnet.Api.OAuth2ClientIdentity identity, string adminUser, UserService.SimpleInformationPush informationPush);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/DeleteInformationPush", ReplyAction="http://tempuri.org/IUserManagerService/DeleteInformationPushResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/DeleteInformationPushErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/DeleteInformationPushErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> DeleteInformationPushAsync(Tgnet.Api.OAuth2ClientIdentity identity, long id, string adminUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetNewInformationPushByMaxUid", ReplyAction="http://tempuri.org/IUserManagerService/GetNewInformationPushByMaxUidResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetNewInformationPushByMaxUidErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetNewInformationPushByMaxUidErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleInformationPush[]> GetNewInformationPushByMaxUidAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> uid, long maxId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetNewInformationPushByAreaNos", ReplyAction="http://tempuri.org/IUserManagerService/GetNewInformationPushByAreaNosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetNewInformationPushByAreaNosErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetNewInformationPushByAreaNosErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleInformationPush[]> GetNewInformationPushByAreaNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] area_nos, long maxId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/UpdatePassword", ReplyAction="http://tempuri.org/IUserManagerService/UpdatePasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/UpdatePasswordErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/UpdatePasswordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task UpdatePasswordAsync(Tgnet.Api.OAuth2Identity identity, string oldPassword, string newPasswrod, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/UpdatePassword2", ReplyAction="http://tempuri.org/IUserManagerService/UpdatePassword2Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/UpdatePassword2ErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/UpdatePassword2ErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<UserService.Result> UpdatePassword2Async(Tgnet.Api.OAuth2Identity identity, string oldPassword, string newPasswrod, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/Verify", ReplyAction="http://tempuri.org/IUserManagerService/VerifyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/VerifyErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/VerifyErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<string> VerifyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, string code, UserService.ValidateType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/SendCode", ReplyAction="http://tempuri.org/IUserManagerService/SendCodeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/SendCodeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/SendCodeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task SendCodeAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, UserService.ValidateType type, System.Nullable<long> uid, string signName, string ip, string from, UserService.SendValidateCodeType sendType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/RegisterAddProjRemainCount", ReplyAction="http://tempuri.org/IUserManagerService/RegisterAddProjRemainCountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/RegisterAddProjRemainCountErrorResponseTyp" +
            "eFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/RegisterAddProjRemainCountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task RegisterAddProjRemainCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, string password, string ip, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/UserActivate", ReplyAction="http://tempuri.org/IUserManagerService/UserActivateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/UserActivateErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/UserActivateErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UserActivateAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string mobile, string emial, string code, UserService.ValidateType v_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/FeedBack", ReplyAction="http://tempuri.org/IUserManagerService/FeedBackResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/FeedBackErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/FeedBackErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task FeedBackAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> uid, string mobile, UserService.MobileGetType get_type, UserService.ClinetType client_type, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/CheckUserAreaIsAllow", ReplyAction="http://tempuri.org/IUserManagerService/CheckUserAreaIsAllowResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/CheckUserAreaIsAllowErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/CheckUserAreaIsAllowErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> CheckUserAreaIsAllowAsync(Tgnet.Api.OAuth2ClientIdentity identity, string areaNo, string ip, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/CheckUserAreaIsLimit", ReplyAction="http://tempuri.org/IUserManagerService/CheckUserAreaIsLimitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/CheckUserAreaIsLimitErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/CheckUserAreaIsLimitErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> CheckUserAreaIsLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] area_nos, string ip, string username, UserService.AreaMatchType typ);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetAreaNoInfo", ReplyAction="http://tempuri.org/IUserManagerService/GetAreaNoInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetAreaNoInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetAreaNoInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserAreaInfo> GetAreaNoInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, string ip, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/LoginPresenter", ReplyAction="http://tempuri.org/IUserManagerService/LoginPresenterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/LoginPresenterErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/LoginPresenterErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> LoginPresenterAsync(Tgnet.Api.OAuth2Identity identity, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/WdRegister", ReplyAction="http://tempuri.org/IUserManagerService/WdRegisterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/WdRegisterErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/WdRegisterErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<string> WdRegisterAsync(Tgnet.Api.OAuth2ClientIdentity identity, string code, string email, string sex, string password, string ip, string nickname, string native_area_no, string registerFrom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetValidateCode", ReplyAction="http://tempuri.org/IUserManagerService/GetValidateCodeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetValidateCodeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetValidateCodeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ValidateCode> GetValidateCodeAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, UserService.ValidateType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/AddLoginHistory", ReplyAction="http://tempuri.org/IUserManagerService/AddLoginHistoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/AddLoginHistoryErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/AddLoginHistoryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task AddLoginHistoryAsync(Tgnet.Api.OAuth2Identity identity, string ip, string login_msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/Present", ReplyAction="http://tempuri.org/IUserManagerService/PresentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/PresentErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/PresentErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<bool> PresentAsync(Tgnet.Api.OAuth2Identity identity, byte present_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetProductClass", ReplyAction="http://tempuri.org/IUserManagerService/GetProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetProductClassErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetProductClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ProductClass[]> GetProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetProductClassStatistics", ReplyAction="http://tempuri.org/IUserManagerService/GetProductClassStatisticsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetProductClassStatisticsErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetProductClassStatisticsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ProductClassStatistics[]> GetProductClassStatisticsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] classNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetProducts", ReplyAction="http://tempuri.org/IUserManagerService/GetProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetProductsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetProductsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.Product[]> GetProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetNewProducts", ReplyAction="http://tempuri.org/IUserManagerService/GetNewProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetNewProductsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetNewProductsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ProductEntity[]> GetNewProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetNewProductsBatch", ReplyAction="http://tempuri.org/IUserManagerService/GetNewProductsBatchResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetNewProductsBatchErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetNewProductsBatchErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ProductEntity[]> GetNewProductsBatchAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetSimpleProductsBatch", ReplyAction="http://tempuri.org/IUserManagerService/GetSimpleProductsBatchResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetSimpleProductsBatchErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetSimpleProductsBatchErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleProductEntity[]> GetSimpleProductsBatchAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetProductsByPids", ReplyAction="http://tempuri.org/IUserManagerService/GetProductsByPidsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetProductsByPidsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetProductsByPidsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ProductEntity[]> GetProductsByPidsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] pids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/AddProjectRegisterPresent", ReplyAction="http://tempuri.org/IUserManagerService/AddProjectRegisterPresentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/AddProjectRegisterPresentErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/AddProjectRegisterPresentErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddProjectRegisterPresentAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetExternalUserById", ReplyAction="http://tempuri.org/IUserManagerService/GetExternalUserByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetExternalUserByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetExternalUserByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ExternalUser> GetExternalUserByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long euid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/AddExternalUser", ReplyAction="http://tempuri.org/IUserManagerService/AddExternalUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/AddExternalUserErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/AddExternalUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ExternalUser> AddExternalUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string fromId, UserService.UserType type, string nickname, UserService.ExternalUserSex sex, string province, string city, string headimgurl, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/AddOrUpdateExternalUser", ReplyAction="http://tempuri.org/IUserManagerService/AddOrUpdateExternalUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/AddOrUpdateExternalUserErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/AddOrUpdateExternalUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<UserService.ExternalUser> AddOrUpdateExternalUserAsync(Tgnet.Api.OAuth2Identity identity, string fromId, UserService.UserType type, string nickname, System.Nullable<UserService.ExternalUserSex> sex, string province, string city, string headimgurl, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetExternalUserList", ReplyAction="http://tempuri.org/IUserManagerService/GetExternalUserListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetExternalUserListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetExternalUserListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.ExternalUser>> GetExternalUserListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string fromId, System.Nullable<UserService.UserType> type, string nickname, System.Nullable<UserService.ExternalUserSex> sex, string province, string city, string mobile, System.Nullable<int> start, System.Nullable<int> limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/UpdateExternalUser", ReplyAction="http://tempuri.org/IUserManagerService/UpdateExternalUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/UpdateExternalUserErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/UpdateExternalUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateExternalUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long euid, string nickname, System.Nullable<UserService.ExternalUserSex> sex, string province, string city, string headimgurl, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetExternalUserByFromId", ReplyAction="http://tempuri.org/IUserManagerService/GetExternalUserByFromIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetExternalUserByFromIdErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetExternalUserByFromIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.ExternalUser> GetExternalUserByFromIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string fromId, UserService.UserType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetUserLastLoginDate", ReplyAction="http://tempuri.org/IUserManagerService/GetUserLastLoginDateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetUserLastLoginDateErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetUserLastLoginDateErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, System.DateTime>> GetUserLastLoginDateAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/CreateUserByAdmin", ReplyAction="http://tempuri.org/IUserManagerService/CreateUserByAdminResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/CreateUserByAdminErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/CreateUserByAdminErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long> CreateUserByAdminAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserArgsWrapper arg);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetLimitList", ReplyAction="http://tempuri.org/IUserManagerService/GetLimitListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetLimitListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetLimitListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.GetLimitListResponse> GetLimitListAsync(UserService.GetLimitListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/AddLimit", ReplyAction="http://tempuri.org/IUserManagerService/AddLimitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/AddLimitErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/AddLimitErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserLimit> AddLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long adminUid, long uid, UserService.LimitKinds kind, string remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/RemoveLimit", ReplyAction="http://tempuri.org/IUserManagerService/RemoveLimitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/RemoveLimitErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/RemoveLimitErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task RemoveLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long ulid, long adimUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/RemoveUserLimit", ReplyAction="http://tempuri.org/IUserManagerService/RemoveUserLimitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/RemoveUserLimitErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/RemoveUserLimitErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task RemoveUserLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long adminUid, UserService.LimitKinds kind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/CheckBeLimit", ReplyAction="http://tempuri.org/IUserManagerService/CheckBeLimitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/CheckBeLimitErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/CheckBeLimitErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> CheckBeLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.LimitKinds kind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/AllowResetPassword", ReplyAction="http://tempuri.org/IUserManagerService/AllowResetPasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/AllowResetPasswordErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/AllowResetPasswordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<UserService.AllowResetPasswordResult> AllowResetPasswordAsync(long uid, long operatorUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetCollectUsers", ReplyAction="http://tempuri.org/IUserManagerService/GetCollectUsersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetCollectUsersErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetCollectUsersErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.UserCollect>> GetCollectUsersAsync(Tgnet.Api.OAuth2ClientIdentity identit, UserService.UserCollectKinds[] kinds, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/CheckCollectUsersExist", ReplyAction="http://tempuri.org/IUserManagerService/CheckCollectUsersExistResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/CheckCollectUsersExistErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/CheckCollectUsersExistErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> CheckCollectUsersExistAsync(Tgnet.Api.OAuth2ClientIdentity identit, long uid, UserService.UserCollectKinds kind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetSimpleUserAuthority", ReplyAction="http://tempuri.org/IUserManagerService/GetSimpleUserAuthorityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetSimpleUserAuthorityErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetSimpleUserAuthorityErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleUserAuthority> GetSimpleUserAuthorityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/IsAllowMultipleClientsLogin", ReplyAction="http://tempuri.org/IUserManagerService/IsAllowMultipleClientsLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/IsAllowMultipleClientsLoginErrorResponseTy" +
            "peFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/IsAllowMultipleClientsLoginErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> IsAllowMultipleClientsLoginAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetUserLocationRecord", ReplyAction="http://tempuri.org/IUserManagerService/GetUserLocationRecordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetUserLocationRecordErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetUserLocationRecordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpUserLocationRecord[]> GetUserLocationRecordAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserLocationRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetUserClientInfo", ReplyAction="http://tempuri.org/IUserManagerService/GetUserClientInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetUserClientInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetUserClientInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserClientSimpleInfo[]> GetUserClientInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] rids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetUserNumberOfStart", ReplyAction="http://tempuri.org/IUserManagerService/GetUserNumberOfStartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetUserNumberOfStartErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetUserNumberOfStartErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<int> GetUserNumberOfStartAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserLocationRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetGetUserNumberOfStartByUserId", ReplyAction="http://tempuri.org/IUserManagerService/GetGetUserNumberOfStartByUserIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetGetUserNumberOfStartByUserIdErrorRespon" +
            "seTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetGetUserNumberOfStartByUserIdErrorCodeFa" +
            "ult", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleUserNumberOfStart[]> GetGetUserNumberOfStartByUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserLocationRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetFeedbackPage", ReplyAction="http://tempuri.org/IUserManagerService/GetFeedbackPageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetFeedbackPageErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetFeedbackPageErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Feedback>> GetFeedbackPageAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.FeedbackArgs arg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/UpdateFeedBackOperateContent", ReplyAction="http://tempuri.org/IUserManagerService/UpdateFeedBackOperateContentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/UpdateFeedBackOperateContentErrorResponseT" +
            "ypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/UpdateFeedBackOperateContentErrorCodeFault" +
            "", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateFeedBackOperateContentAsync(Tgnet.Api.OAuth2ClientIdentity identity, long fid, long operateId, string operateContent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/DeleteFeedBacks", ReplyAction="http://tempuri.org/IUserManagerService/DeleteFeedBacksResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/DeleteFeedBacksErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/DeleteFeedBacksErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteFeedBacksAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] fids, long operater, string deleteReason);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetPersonalServiceDateOutBeforeNDayUser", ReplyAction="http://tempuri.org/IUserManagerService/GetPersonalServiceDateOutBeforeNDayUserRes" +
            "ponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetPersonalServiceDateOutBeforeNDayUserErr" +
            "orResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetPersonalServiceDateOutBeforeNDayUserErr" +
            "orCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserPhoneNumber[]> GetPersonalServiceDateOutBeforeNDayUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.DateTime runTime, int day);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/DecryptPwd", ReplyAction="http://tempuri.org/IUserManagerService/DecryptPwdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/DecryptPwdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/DecryptPwdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<string> DecryptPwdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetPassword", ReplyAction="http://tempuri.org/IUserManagerService/GetPasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetPasswordErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetPasswordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<string> GetPasswordAsync(Tgnet.Api.OAuth2ClientIdentity identity, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserManagerService/GetUserSimpleInfoByCompany", ReplyAction="http://tempuri.org/IUserManagerService/GetUserSimpleInfoByCompanyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IUserManagerService/GetUserSimpleInfoByCompanyErrorResponseTyp" +
            "eFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IUserManagerService/GetUserSimpleInfoByCompanyErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUserSimpleInfoByCompanyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string company, int index, int limit);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSimpleInformationPushByUid", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetSimpleInformationPushByUidRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Tgnet.Api.OAuth2ClientIdentity identity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Nullable<long> uid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int start;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int limit;
        
        public GetSimpleInformationPushByUidRequest()
        {
        }
        
        public GetSimpleInformationPushByUidRequest(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> uid, int start, int limit)
        {
            this.identity = identity;
            this.uid = uid;
            this.start = start;
            this.limit = limit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSimpleInformationPushByUidResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetSimpleInformationPushByUidResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UserService.SimpleInformationPush[] GetSimpleInformationPushByUidResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int count;
        
        public GetSimpleInformationPushByUidResponse()
        {
        }
        
        public GetSimpleInformationPushByUidResponse(UserService.SimpleInformationPush[] GetSimpleInformationPushByUidResult, int count)
        {
            this.GetSimpleInformationPushByUidResult = GetSimpleInformationPushByUidResult;
            this.count = count;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSimpleInformationPushByAreaNos", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetSimpleInformationPushByAreaNosRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Tgnet.Api.OAuth2ClientIdentity identity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] area_nos;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int start;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int limit;
        
        public GetSimpleInformationPushByAreaNosRequest()
        {
        }
        
        public GetSimpleInformationPushByAreaNosRequest(Tgnet.Api.OAuth2ClientIdentity identity, string[] area_nos, int start, int limit)
        {
            this.identity = identity;
            this.area_nos = area_nos;
            this.start = start;
            this.limit = limit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSimpleInformationPushByAreaNosResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetSimpleInformationPushByAreaNosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UserService.SimpleInformationPush[] GetSimpleInformationPushByAreaNosResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int count;
        
        public GetSimpleInformationPushByAreaNosResponse()
        {
        }
        
        public GetSimpleInformationPushByAreaNosResponse(UserService.SimpleInformationPush[] GetSimpleInformationPushByAreaNosResult, int count)
        {
            this.GetSimpleInformationPushByAreaNosResult = GetSimpleInformationPushByAreaNosResult;
            this.count = count;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLimitList", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetLimitListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Tgnet.Api.OAuth2ClientIdentity identity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public UserService.LimitKinds[] kinds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public long[] uids;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int start;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public int limit;
        
        public GetLimitListRequest()
        {
        }
        
        public GetLimitListRequest(Tgnet.Api.OAuth2ClientIdentity identity, UserService.LimitKinds[] kinds, long[] uids, int start, int limit)
        {
            this.identity = identity;
            this.kinds = kinds;
            this.uids = uids;
            this.start = start;
            this.limit = limit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLimitListResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetLimitListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UserService.UserLimit[] GetLimitListResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int count;
        
        public GetLimitListResponse()
        {
        }
        
        public GetLimitListResponse(UserService.UserLimit[] GetLimitListResult, int count)
        {
            this.GetLimitListResult = GetLimitListResult;
            this.count = count;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IUserManagerServiceChannel : UserService.IUserManagerService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class UserManagerServiceClient : System.ServiceModel.ClientBase<UserService.IUserManagerService>, UserService.IUserManagerService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserManagerServiceClient() : 
                base(UserManagerServiceClient.GetDefaultBinding(), UserManagerServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IUserManagerService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserManagerServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(UserManagerServiceClient.GetBindingForEndpoint(endpointConfiguration), UserManagerServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserManagerServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserManagerServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserManagerServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserManagerServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> IsUsableMobileOfUserNoAsync(string mobile)
        {
            return base.Channel.IsUsableMobileOfUserNoAsync(mobile);
        }
        
        public System.Threading.Tasks.Task<bool> IsUsableMobileOfUserNo2Async(string mobile, long uid)
        {
            return base.Channel.IsUsableMobileOfUserNo2Async(mobile, uid);
        }
        
        public System.Threading.Tasks.Task<bool> IsUsableEmailAsync(string email)
        {
            return base.Channel.IsUsableEmailAsync(email);
        }
        
        public System.Threading.Tasks.Task<long> RegisterAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userno, string mobile, bool isVerifyMobile, string email, bool isVerifyEmail, string password, string ip, string name, string company, string registerFrom)
        {
            return base.Channel.RegisterAsync(identity, userno, mobile, isVerifyMobile, email, isVerifyEmail, password, ip, name, company, registerFrom);
        }
        
        public System.Threading.Tasks.Task<long> GetUidIfNonexistentRegisterAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, bool isVerifyMobile, string password, string ip, string registerFrom)
        {
            return base.Channel.GetUidIfNonexistentRegisterAsync(identity, mobile, isVerifyMobile, password, ip, registerFrom);
        }
        
        public System.Threading.Tasks.Task SendCodeFromForgetPasswrodByNoAsync(string userNo, string signName, string ip, string from)
        {
            return base.Channel.SendCodeFromForgetPasswrodByNoAsync(userNo, signName, ip, from);
        }
        
        public System.Threading.Tasks.Task<string> VerifyCodeForForgetPassrordByNoAsync(string userNo, string code, System.Nullable<int> expires_in)
        {
            return base.Channel.VerifyCodeForForgetPassrordByNoAsync(userNo, code, expires_in);
        }
        
        public System.Threading.Tasks.Task ResetPasswordAsync(string code, string newPasswrod, string ip)
        {
            return base.Channel.ResetPasswordAsync(code, newPasswrod, ip);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleInformationPush> GetInformationPushByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long id)
        {
            return base.Channel.GetInformationPushByIdAsync(identity, id);
        }
        
        public System.Threading.Tasks.Task<UserService.GetSimpleInformationPushByUidResponse> GetSimpleInformationPushByUidAsync(UserService.GetSimpleInformationPushByUidRequest request)
        {
            return base.Channel.GetSimpleInformationPushByUidAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserService.GetSimpleInformationPushByAreaNosResponse> GetSimpleInformationPushByAreaNosAsync(UserService.GetSimpleInformationPushByAreaNosRequest request)
        {
            return base.Channel.GetSimpleInformationPushByAreaNosAsync(request);
        }
        
        public System.Threading.Tasks.Task<bool> AddInformationPushAsync(Tgnet.Api.OAuth2ClientIdentity identity, string adminUser, UserService.SimpleInformationPush informationPush)
        {
            return base.Channel.AddInformationPushAsync(identity, adminUser, informationPush);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateInformationPushAsync(Tgnet.Api.OAuth2ClientIdentity identity, string adminUser, UserService.SimpleInformationPush informationPush)
        {
            return base.Channel.UpdateInformationPushAsync(identity, adminUser, informationPush);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteInformationPushAsync(Tgnet.Api.OAuth2ClientIdentity identity, long id, string adminUser)
        {
            return base.Channel.DeleteInformationPushAsync(identity, id, adminUser);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleInformationPush[]> GetNewInformationPushByMaxUidAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> uid, long maxId)
        {
            return base.Channel.GetNewInformationPushByMaxUidAsync(identity, uid, maxId);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleInformationPush[]> GetNewInformationPushByAreaNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] area_nos, long maxId)
        {
            return base.Channel.GetNewInformationPushByAreaNosAsync(identity, area_nos, maxId);
        }
        
        public System.Threading.Tasks.Task UpdatePasswordAsync(Tgnet.Api.OAuth2Identity identity, string oldPassword, string newPasswrod, string ip)
        {
            return base.Channel.UpdatePasswordAsync(identity, oldPassword, newPasswrod, ip);
        }
        
        public System.Threading.Tasks.Task<UserService.Result> UpdatePassword2Async(Tgnet.Api.OAuth2Identity identity, string oldPassword, string newPasswrod, string ip)
        {
            return base.Channel.UpdatePassword2Async(identity, oldPassword, newPasswrod, ip);
        }
        
        public System.Threading.Tasks.Task<string> VerifyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, string code, UserService.ValidateType type)
        {
            return base.Channel.VerifyAsync(identity, mobile, code, type);
        }
        
        public System.Threading.Tasks.Task SendCodeAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, UserService.ValidateType type, System.Nullable<long> uid, string signName, string ip, string from, UserService.SendValidateCodeType sendType)
        {
            return base.Channel.SendCodeAsync(identity, mobile, type, uid, signName, ip, from, sendType);
        }
        
        public System.Threading.Tasks.Task RegisterAddProjRemainCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, string password, string ip, string email)
        {
            return base.Channel.RegisterAddProjRemainCountAsync(identity, mobile, password, ip, email);
        }
        
        public System.Threading.Tasks.Task UserActivateAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string mobile, string emial, string code, UserService.ValidateType v_type)
        {
            return base.Channel.UserActivateAsync(identity, uid, mobile, emial, code, v_type);
        }
        
        public System.Threading.Tasks.Task FeedBackAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> uid, string mobile, UserService.MobileGetType get_type, UserService.ClinetType client_type, string content)
        {
            return base.Channel.FeedBackAsync(identity, uid, mobile, get_type, client_type, content);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAreaIsAllowAsync(Tgnet.Api.OAuth2ClientIdentity identity, string areaNo, string ip, string username)
        {
            return base.Channel.CheckUserAreaIsAllowAsync(identity, areaNo, ip, username);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAreaIsLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] area_nos, string ip, string username, UserService.AreaMatchType typ)
        {
            return base.Channel.CheckUserAreaIsLimitAsync(identity, area_nos, ip, username, typ);
        }
        
        public System.Threading.Tasks.Task<UserService.UserAreaInfo> GetAreaNoInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, string ip, long uid)
        {
            return base.Channel.GetAreaNoInfoAsync(identity, ip, uid);
        }
        
        public System.Threading.Tasks.Task<bool> LoginPresenterAsync(Tgnet.Api.OAuth2Identity identity, int count)
        {
            return base.Channel.LoginPresenterAsync(identity, count);
        }
        
        public System.Threading.Tasks.Task<string> WdRegisterAsync(Tgnet.Api.OAuth2ClientIdentity identity, string code, string email, string sex, string password, string ip, string nickname, string native_area_no, string registerFrom)
        {
            return base.Channel.WdRegisterAsync(identity, code, email, sex, password, ip, nickname, native_area_no, registerFrom);
        }
        
        public System.Threading.Tasks.Task<UserService.ValidateCode> GetValidateCodeAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile, UserService.ValidateType type)
        {
            return base.Channel.GetValidateCodeAsync(identity, mobile, type);
        }
        
        public System.Threading.Tasks.Task AddLoginHistoryAsync(Tgnet.Api.OAuth2Identity identity, string ip, string login_msg)
        {
            return base.Channel.AddLoginHistoryAsync(identity, ip, login_msg);
        }
        
        public System.Threading.Tasks.Task<bool> PresentAsync(Tgnet.Api.OAuth2Identity identity, byte present_type)
        {
            return base.Channel.PresentAsync(identity, present_type);
        }
        
        public System.Threading.Tasks.Task<UserService.ProductClass[]> GetProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name)
        {
            return base.Channel.GetProductClassAsync(identity, name);
        }
        
        public System.Threading.Tasks.Task<UserService.ProductClassStatistics[]> GetProductClassStatisticsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] classNos)
        {
            return base.Channel.GetProductClassStatisticsAsync(identity, classNos);
        }
        
        public System.Threading.Tasks.Task<UserService.Product[]> GetProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo)
        {
            return base.Channel.GetProductsAsync(identity, classNo);
        }
        
        public System.Threading.Tasks.Task<UserService.ProductEntity[]> GetNewProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.GetNewProductsAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<UserService.ProductEntity[]> GetNewProductsBatchAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetNewProductsBatchAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleProductEntity[]> GetSimpleProductsBatchAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetSimpleProductsBatchAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<UserService.ProductEntity[]> GetProductsByPidsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] pids)
        {
            return base.Channel.GetProductsByPidsAsync(identity, pids);
        }
        
        public System.Threading.Tasks.Task AddProjectRegisterPresentAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userNo)
        {
            return base.Channel.AddProjectRegisterPresentAsync(identity, userNo);
        }
        
        public System.Threading.Tasks.Task<UserService.ExternalUser> GetExternalUserByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long euid)
        {
            return base.Channel.GetExternalUserByIdAsync(identity, euid);
        }
        
        public System.Threading.Tasks.Task<UserService.ExternalUser> AddExternalUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string fromId, UserService.UserType type, string nickname, UserService.ExternalUserSex sex, string province, string city, string headimgurl, string mobile)
        {
            return base.Channel.AddExternalUserAsync(identity, fromId, type, nickname, sex, province, city, headimgurl, mobile);
        }
        
        public System.Threading.Tasks.Task<UserService.ExternalUser> AddOrUpdateExternalUserAsync(Tgnet.Api.OAuth2Identity identity, string fromId, UserService.UserType type, string nickname, System.Nullable<UserService.ExternalUserSex> sex, string province, string city, string headimgurl, string mobile)
        {
            return base.Channel.AddOrUpdateExternalUserAsync(identity, fromId, type, nickname, sex, province, city, headimgurl, mobile);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.ExternalUser>> GetExternalUserListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string fromId, System.Nullable<UserService.UserType> type, string nickname, System.Nullable<UserService.ExternalUserSex> sex, string province, string city, string mobile, System.Nullable<int> start, System.Nullable<int> limit)
        {
            return base.Channel.GetExternalUserListAsync(identity, fromId, type, nickname, sex, province, city, mobile, start, limit);
        }
        
        public System.Threading.Tasks.Task UpdateExternalUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long euid, string nickname, System.Nullable<UserService.ExternalUserSex> sex, string province, string city, string headimgurl, string mobile)
        {
            return base.Channel.UpdateExternalUserAsync(identity, euid, nickname, sex, province, city, headimgurl, mobile);
        }
        
        public System.Threading.Tasks.Task<UserService.ExternalUser> GetExternalUserByFromIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string fromId, UserService.UserType type)
        {
            return base.Channel.GetExternalUserByFromIdAsync(identity, fromId, type);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, System.DateTime>> GetUserLastLoginDateAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserLastLoginDateAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<long> CreateUserByAdminAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserArgsWrapper arg)
        {
            return base.Channel.CreateUserByAdminAsync(identity, arg);
        }
        
        public System.Threading.Tasks.Task<UserService.GetLimitListResponse> GetLimitListAsync(UserService.GetLimitListRequest request)
        {
            return base.Channel.GetLimitListAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserService.UserLimit> AddLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long adminUid, long uid, UserService.LimitKinds kind, string remark)
        {
            return base.Channel.AddLimitAsync(identity, adminUid, uid, kind, remark);
        }
        
        public System.Threading.Tasks.Task RemoveLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long ulid, long adimUid)
        {
            return base.Channel.RemoveLimitAsync(identity, ulid, adimUid);
        }
        
        public System.Threading.Tasks.Task RemoveUserLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long adminUid, UserService.LimitKinds kind)
        {
            return base.Channel.RemoveUserLimitAsync(identity, uid, adminUid, kind);
        }
        
        public System.Threading.Tasks.Task<bool> CheckBeLimitAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, UserService.LimitKinds kind)
        {
            return base.Channel.CheckBeLimitAsync(identity, uid, kind);
        }
        
        public System.Threading.Tasks.Task<UserService.AllowResetPasswordResult> AllowResetPasswordAsync(long uid, long operatorUid)
        {
            return base.Channel.AllowResetPasswordAsync(uid, operatorUid);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.UserCollect>> GetCollectUsersAsync(Tgnet.Api.OAuth2ClientIdentity identit, UserService.UserCollectKinds[] kinds, int start, int limit)
        {
            return base.Channel.GetCollectUsersAsync(identit, kinds, start, limit);
        }
        
        public System.Threading.Tasks.Task<bool> CheckCollectUsersExistAsync(Tgnet.Api.OAuth2ClientIdentity identit, long uid, UserService.UserCollectKinds kind)
        {
            return base.Channel.CheckCollectUsersExistAsync(identit, uid, kind);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleUserAuthority> GetSimpleUserAuthorityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.GetSimpleUserAuthorityAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<bool> IsAllowMultipleClientsLoginAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.IsAllowMultipleClientsLoginAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpUserLocationRecord[]> GetUserLocationRecordAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserLocationRecordRequest request)
        {
            return base.Channel.GetUserLocationRecordAsync(identity, request);
        }
        
        public System.Threading.Tasks.Task<UserService.UserClientSimpleInfo[]> GetUserClientInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] rids)
        {
            return base.Channel.GetUserClientInfoAsync(identity, rids);
        }
        
        public System.Threading.Tasks.Task<int> GetUserNumberOfStartAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserLocationRecordRequest request)
        {
            return base.Channel.GetUserNumberOfStartAsync(identity, request);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleUserNumberOfStart[]> GetGetUserNumberOfStartByUserIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UserLocationRecordRequest request)
        {
            return base.Channel.GetGetUserNumberOfStartByUserIdAsync(identity, request);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Feedback>> GetFeedbackPageAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.FeedbackArgs arg)
        {
            return base.Channel.GetFeedbackPageAsync(identity, arg);
        }
        
        public System.Threading.Tasks.Task UpdateFeedBackOperateContentAsync(Tgnet.Api.OAuth2ClientIdentity identity, long fid, long operateId, string operateContent)
        {
            return base.Channel.UpdateFeedBackOperateContentAsync(identity, fid, operateId, operateContent);
        }
        
        public System.Threading.Tasks.Task DeleteFeedBacksAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] fids, long operater, string deleteReason)
        {
            return base.Channel.DeleteFeedBacksAsync(identity, fids, operater, deleteReason);
        }
        
        public System.Threading.Tasks.Task<UserService.UserPhoneNumber[]> GetPersonalServiceDateOutBeforeNDayUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.DateTime runTime, int day)
        {
            return base.Channel.GetPersonalServiceDateOutBeforeNDayUserAsync(identity, runTime, day);
        }
        
        public System.Threading.Tasks.Task<string> DecryptPwdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string id)
        {
            return base.Channel.DecryptPwdAsync(identity, id);
        }
        
        public System.Threading.Tasks.Task<string> GetPasswordAsync(Tgnet.Api.OAuth2ClientIdentity identity, string id)
        {
            return base.Channel.GetPasswordAsync(identity, id);
        }
        
        public System.Threading.Tasks.Task<UserService.UserSimpleInfo[]> GetUserSimpleInfoByCompanyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string company, int index, int limit)
        {
            return base.Channel.GetUserSimpleInfoByCompanyAsync(identity, company, index, limit);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IUserManagerService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IUserManagerService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.user.tgnet.com:18065/Services/UserService.svc/Manager");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserManagerServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IUserManagerService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserManagerServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IUserManagerService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IUserManagerService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.ICooperationUserService")]
    public interface ICooperationUserService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/UpdateDraftCooperatoinUser", ReplyAction="http://tempuri.org/ICooperationUserService/UpdateDraftCooperatoinUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/UpdateDraftCooperatoinUserErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateDraftCooperatoinUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string name, string job, string company, UserService.DraftProduct[] products, string email, string weChat, string areaNo, string projectType, string keyPeople);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/SearchDraftCooperatoinUser", ReplyAction="http://tempuri.org/ICooperationUserService/SearchDraftCooperatoinUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/SearchDraftCooperatoinUserErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.DraftCooperationProductUser>> SearchDraftCooperatoinUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, string mobile, string company, string areaNo, string job, string product, string brand, System.Nullable<bool> isCheck, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetDraftCooperationUserByMobile", ReplyAction="http://tempuri.org/ICooperationUserService/GetDraftCooperationUserByMobileRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetDraftCooperationUserByMobileErrorRe" +
            "sponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.DraftCooperationProductUser> GetDraftCooperationUserByMobileAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetDraftCooperationUserByUID", ReplyAction="http://tempuri.org/ICooperationUserService/GetDraftCooperationUserByUIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetDraftCooperationUserByUIDErrorRespo" +
            "nseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.DraftCooperationProductUser> GetDraftCooperationUserByUIDAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetDraftUserProductBrand", ReplyAction="http://tempuri.org/ICooperationUserService/GetDraftUserProductBrandResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetDraftUserProductBrandErrorResponseT" +
            "ypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.DraftProduct[]> GetDraftUserProductBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/DeleteDraftCooperatoinUser", ReplyAction="http://tempuri.org/ICooperationUserService/DeleteDraftCooperatoinUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/DeleteDraftCooperatoinUserErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteDraftCooperatoinUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetAreaDraftCooperatoinUserCount", ReplyAction="http://tempuri.org/ICooperationUserService/GetAreaDraftCooperatoinUserCountRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetAreaDraftCooperatoinUserCountErrorR" +
            "esponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetAreaDraftCooperatoinUserCountAsync(Tgnet.Api.OAuth2ClientIdentity identity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/AddCooperationUser", ReplyAction="http://tempuri.org/ICooperationUserService/AddCooperationUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/AddCooperationUserErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, string name, string job, string company, string mobile, byte saleModel, byte level, string remark, string[] productTypes, string[] projectStages, string[] keyPeoples, string[] mainProjectTypes, UserService.CooperationProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/UpdateCooperationUser", ReplyAction="http://tempuri.org/ICooperationUserService/UpdateCooperationUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/UpdateCooperationUserErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, string name, string job, string company, string mobile, byte saleModel, byte level, string remark, string[] productTypes, string[] projectStages, string[] keyPeoples, string[] mainProjectTypes, UserService.CooperationProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/Edit", ReplyAction="http://tempuri.org/ICooperationUserService/EditResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/EditErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task EditAsync(Tgnet.Api.OAuth2Identity identity, string name, string job, string company, string mobile, string areaNo, UserService.SimpleClassInfo[] productTypes, UserService.SimpleClassInfo[] projectStages, UserService.SimpleClassInfo[] keyPeoples, UserService.SimpleClassInfo[] contractors, string email, string weChat, byte saleModel, byte level, string remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/EditForAdmin", ReplyAction="http://tempuri.org/ICooperationUserService/EditForAdminResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/EditForAdminErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task EditForAdminAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleClassInfo[] productTypes, string[] projectStages, string[] keyPeoples);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/EditProduct", ReplyAction="http://tempuri.org/ICooperationUserService/EditProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/EditProductErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task EditProductAsync(Tgnet.Api.OAuth2Identity identity, UserService.SimpleCooperationProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/EditNewProduct", ReplyAction="http://tempuri.org/ICooperationUserService/EditNewProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/EditNewProductErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task EditNewProductAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleCooperationProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/AddOrUpdateProducts", ReplyAction="http://tempuri.org/ICooperationUserService/AddOrUpdateProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/AddOrUpdateProductsErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddOrUpdateProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleCooperationProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/AddOrUpdateAndDeleteProducts", ReplyAction="http://tempuri.org/ICooperationUserService/AddOrUpdateAndDeleteProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/AddOrUpdateAndDeleteProductsErrorRespo" +
            "nseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddOrUpdateAndDeleteProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleCooperationProduct[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/DeleteProducts", ReplyAction="http://tempuri.org/ICooperationUserService/DeleteProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/DeleteProductsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, long[] productIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/SearchCooperationUser", ReplyAction="http://tempuri.org/ICooperationUserService/SearchCooperationUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/SearchCooperationUserErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.CooperationProductUser>> SearchCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, string mobile, string company, string areaNo, string job, System.Nullable<byte> level, string[] stageNos, string[] classNos, string product, string brand, UserService.RangeOfNullableOfdateTime5F2dSckg created, string productClassNo, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetUserCooperationUsers", ReplyAction="http://tempuri.org/ICooperationUserService/GetUserCooperationUsersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetUserCooperationUsersErrorResponseTy" +
            "peFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.CooperationProductUser>> GetUserCooperationUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetCooperationUserByMobile", ReplyAction="http://tempuri.org/ICooperationUserService/GetCooperationUserByMobileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetCooperationUserByMobileErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.CooperationProductUser> GetCooperationUserByMobileAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetCooperationUserByUID", ReplyAction="http://tempuri.org/ICooperationUserService/GetCooperationUserByUIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetCooperationUserByUIDErrorResponseTy" +
            "peFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.CooperationProductUser> GetCooperationUserByUIDAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetCooperationUsers", ReplyAction="http://tempuri.org/ICooperationUserService/GetCooperationUsersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetCooperationUsersErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.CooperationProductUser[]> GetCooperationUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/SetCooperationUserLevel", ReplyAction="http://tempuri.org/ICooperationUserService/SetCooperationUserLevelResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/SetCooperationUserLevelErrorResponseTy" +
            "peFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task SetCooperationUserLevelAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, byte level);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetCooperationProducts", ReplyAction="http://tempuri.org/ICooperationUserService/GetCooperationProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetCooperationProductsErrorResponseTyp" +
            "eFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.CooperationProduct[]> GetCooperationProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetCooperationUserProducts", ReplyAction="http://tempuri.org/ICooperationUserService/GetCooperationUserProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetCooperationUserProductsErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.SimpleCooperationProduct[]> GetCooperationUserProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/DeleteCooperationUser", ReplyAction="http://tempuri.org/ICooperationUserService/DeleteCooperationUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/DeleteCooperationUserErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetUserCooperBussinessAreaNo", ReplyAction="http://tempuri.org/ICooperationUserService/GetUserCooperBussinessAreaNoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetUserCooperBussinessAreaNoErrorRespo" +
            "nseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string>> GetUserCooperBussinessAreaNoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/AddFromSaleCooperationUser", ReplyAction="http://tempuri.org/ICooperationUserService/AddFromSaleCooperationUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/AddFromSaleCooperationUserErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddFromSaleCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long userID, long custID, string adminNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/DeleteFromSaleCooperationUser", ReplyAction="http://tempuri.org/ICooperationUserService/DeleteFromSaleCooperationUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/DeleteFromSaleCooperationUserErrorResp" +
            "onseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteFromSaleCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/GetFromSaleCooperationUserByUserID", ReplyAction="http://tempuri.org/ICooperationUserService/GetFromSaleCooperationUserByUserIDResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/GetFromSaleCooperationUserByUserIDErro" +
            "rResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.FromSaleCooperationUser> GetFromSaleCooperationUserByUserIDAsync(Tgnet.Api.OAuth2ClientIdentity identity, long userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/SearchFromSaleCooperationUser", ReplyAction="http://tempuri.org/ICooperationUserService/SearchFromSaleCooperationUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/SearchFromSaleCooperationUserErrorResp" +
            "onseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.FromSaleCooperationUser>> SearchFromSaleCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.RangeOfNullableOfdateTime5F2dSckg created, string adminNo, System.Nullable<bool> isFill, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooperationUserService/AddOrUpdateUserFollowClass", ReplyAction="http://tempuri.org/ICooperationUserService/AddOrUpdateUserFollowClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ICooperationUserService/AddOrUpdateUserFollowClassErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddOrUpdateUserFollowClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long adminer, long uid, UserService.UserFollowClassUpEdiInfo editInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ICooperationUserServiceChannel : UserService.ICooperationUserService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class CooperationUserServiceClient : System.ServiceModel.ClientBase<UserService.ICooperationUserService>, UserService.ICooperationUserService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CooperationUserServiceClient() : 
                base(CooperationUserServiceClient.GetDefaultBinding(), CooperationUserServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_ICooperationUserService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooperationUserServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CooperationUserServiceClient.GetBindingForEndpoint(endpointConfiguration), CooperationUserServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooperationUserServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CooperationUserServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooperationUserServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CooperationUserServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CooperationUserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task UpdateDraftCooperatoinUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, string name, string job, string company, UserService.DraftProduct[] products, string email, string weChat, string areaNo, string projectType, string keyPeople)
        {
            return base.Channel.UpdateDraftCooperatoinUserAsync(identity, uid, name, job, company, products, email, weChat, areaNo, projectType, keyPeople);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.DraftCooperationProductUser>> SearchDraftCooperatoinUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, string mobile, string company, string areaNo, string job, string product, string brand, System.Nullable<bool> isCheck, int start, int limit)
        {
            return base.Channel.SearchDraftCooperatoinUserAsync(identity, name, mobile, company, areaNo, job, product, brand, isCheck, start, limit);
        }
        
        public System.Threading.Tasks.Task<UserService.DraftCooperationProductUser> GetDraftCooperationUserByMobileAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile)
        {
            return base.Channel.GetDraftCooperationUserByMobileAsync(identity, mobile);
        }
        
        public System.Threading.Tasks.Task<UserService.DraftCooperationProductUser> GetDraftCooperationUserByUIDAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.GetDraftCooperationUserByUIDAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<UserService.DraftProduct[]> GetDraftUserProductBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetDraftUserProductBrandAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task DeleteDraftCooperatoinUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.DeleteDraftCooperatoinUserAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetAreaDraftCooperatoinUserCountAsync(Tgnet.Api.OAuth2ClientIdentity identity)
        {
            return base.Channel.GetAreaDraftCooperatoinUserCountAsync(identity);
        }
        
        public System.Threading.Tasks.Task AddCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, string name, string job, string company, string mobile, byte saleModel, byte level, string remark, string[] productTypes, string[] projectStages, string[] keyPeoples, string[] mainProjectTypes, UserService.CooperationProduct[] products)
        {
            return base.Channel.AddCooperationUserAsync(identity, admin, uid, name, job, company, mobile, saleModel, level, remark, productTypes, projectStages, keyPeoples, mainProjectTypes, products);
        }
        
        public System.Threading.Tasks.Task UpdateCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, string name, string job, string company, string mobile, byte saleModel, byte level, string remark, string[] productTypes, string[] projectStages, string[] keyPeoples, string[] mainProjectTypes, UserService.CooperationProduct[] products)
        {
            return base.Channel.UpdateCooperationUserAsync(identity, admin, uid, name, job, company, mobile, saleModel, level, remark, productTypes, projectStages, keyPeoples, mainProjectTypes, products);
        }
        
        public System.Threading.Tasks.Task EditAsync(Tgnet.Api.OAuth2Identity identity, string name, string job, string company, string mobile, string areaNo, UserService.SimpleClassInfo[] productTypes, UserService.SimpleClassInfo[] projectStages, UserService.SimpleClassInfo[] keyPeoples, UserService.SimpleClassInfo[] contractors, string email, string weChat, byte saleModel, byte level, string remark)
        {
            return base.Channel.EditAsync(identity, name, job, company, mobile, areaNo, productTypes, projectStages, keyPeoples, contractors, email, weChat, saleModel, level, remark);
        }
        
        public System.Threading.Tasks.Task EditForAdminAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleClassInfo[] productTypes, string[] projectStages, string[] keyPeoples)
        {
            return base.Channel.EditForAdminAsync(identity, admin, uid, productTypes, projectStages, keyPeoples);
        }
        
        public System.Threading.Tasks.Task EditProductAsync(Tgnet.Api.OAuth2Identity identity, UserService.SimpleCooperationProduct[] products)
        {
            return base.Channel.EditProductAsync(identity, products);
        }
        
        public System.Threading.Tasks.Task EditNewProductAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleCooperationProduct[] products)
        {
            return base.Channel.EditNewProductAsync(identity, admin, uid, products);
        }
        
        public System.Threading.Tasks.Task AddOrUpdateProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleCooperationProduct[] products)
        {
            return base.Channel.AddOrUpdateProductsAsync(identity, admin, uid, products);
        }
        
        public System.Threading.Tasks.Task AddOrUpdateAndDeleteProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, UserService.SimpleCooperationProduct[] products)
        {
            return base.Channel.AddOrUpdateAndDeleteProductsAsync(identity, admin, uid, products);
        }
        
        public System.Threading.Tasks.Task DeleteProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long admin, long uid, long[] productIds)
        {
            return base.Channel.DeleteProductsAsync(identity, admin, uid, productIds);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.CooperationProductUser>> SearchCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, string mobile, string company, string areaNo, string job, System.Nullable<byte> level, string[] stageNos, string[] classNos, string product, string brand, UserService.RangeOfNullableOfdateTime5F2dSckg created, string productClassNo, int start, int limit)
        {
            return base.Channel.SearchCooperationUserAsync(identity, name, mobile, company, areaNo, job, level, stageNos, classNos, product, brand, created, productClassNo, start, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.CooperationProductUser>> GetUserCooperationUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, int start, int limit)
        {
            return base.Channel.GetUserCooperationUsersAsync(identity, uid, start, limit);
        }
        
        public System.Threading.Tasks.Task<UserService.CooperationProductUser> GetCooperationUserByMobileAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile)
        {
            return base.Channel.GetCooperationUserByMobileAsync(identity, mobile);
        }
        
        public System.Threading.Tasks.Task<UserService.CooperationProductUser> GetCooperationUserByUIDAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.GetCooperationUserByUIDAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<UserService.CooperationProductUser[]> GetCooperationUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetCooperationUsersAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task SetCooperationUserLevelAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, byte level)
        {
            return base.Channel.SetCooperationUserLevelAsync(identity, uid, level);
        }
        
        public System.Threading.Tasks.Task<UserService.CooperationProduct[]> GetCooperationProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetCooperationProductsAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task<UserService.SimpleCooperationProduct[]> GetCooperationUserProductsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetCooperationUserProductsAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task DeleteCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid)
        {
            return base.Channel.DeleteCooperationUserAsync(identity, uid);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, string>> GetUserCooperBussinessAreaNoAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] uids)
        {
            return base.Channel.GetUserCooperBussinessAreaNoAsync(identity, uids);
        }
        
        public System.Threading.Tasks.Task AddFromSaleCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long userID, long custID, string adminNo)
        {
            return base.Channel.AddFromSaleCooperationUserAsync(identity, userID, custID, adminNo);
        }
        
        public System.Threading.Tasks.Task DeleteFromSaleCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, long userID)
        {
            return base.Channel.DeleteFromSaleCooperationUserAsync(identity, userID);
        }
        
        public System.Threading.Tasks.Task<UserService.FromSaleCooperationUser> GetFromSaleCooperationUserByUserIDAsync(Tgnet.Api.OAuth2ClientIdentity identity, long userID)
        {
            return base.Channel.GetFromSaleCooperationUserByUserIDAsync(identity, userID);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.FromSaleCooperationUser>> SearchFromSaleCooperationUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.RangeOfNullableOfdateTime5F2dSckg created, string adminNo, System.Nullable<bool> isFill, int start, int limit)
        {
            return base.Channel.SearchFromSaleCooperationUserAsync(identity, created, adminNo, isFill, start, limit);
        }
        
        public System.Threading.Tasks.Task AddOrUpdateUserFollowClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long adminer, long uid, UserService.UserFollowClassUpEdiInfo editInfo)
        {
            return base.Channel.AddOrUpdateUserFollowClassAsync(identity, adminer, uid, editInfo);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_ICooperationUserService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_ICooperationUserService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.user.tgnet.com:18065/Services/UserService.svc/CooperationUser");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CooperationUserServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_ICooperationUserService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CooperationUserServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_ICooperationUserService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_ICooperationUserService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.ILotteryService")]
    public interface ILotteryService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetLotteryById", ReplyAction="http://tempuri.org/ILotteryService/GetLotteryByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetLotteryByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetLotteryByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.Lottery> GetLotteryByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, System.Nullable<long> uid, bool withPrizes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/RecordLotteryResult", ReplyAction="http://tempuri.org/ILotteryService/RecordLotteryResultResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/RecordLotteryResultErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/RecordLotteryResultErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task RecordLotteryResultAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, int subtractLotteryCount, UserService.LotteryPrizeResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetWonPrizes", ReplyAction="http://tempuri.org/ILotteryService/GetWonPrizesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetWonPrizesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetWonPrizesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.WonLotteryPrize[]> GetWonPrizesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long lotteryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/AddLotteryCount", ReplyAction="http://tempuri.org/ILotteryService/AddLotteryCountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/AddLotteryCountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/AddLotteryCountErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddLotteryCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long lotteryId, byte addCount, System.Nullable<System.DateTime> expired);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetNewestWonHistory", ReplyAction="http://tempuri.org/ILotteryService/GetNewestWonHistoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetNewestWonHistoryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetNewestWonHistoryErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WonLotteryPrize>> GetNewestWonHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, int start, int limit, string[] withoutPrizeNames);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetNewestWonHistoryByPrizeName", ReplyAction="http://tempuri.org/ILotteryService/GetNewestWonHistoryByPrizeNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetNewestWonHistoryByPrizeNameErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetNewestWonHistoryByPrizeNameErrorResponseTyp" +
            "eFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WonLotteryPrize>> GetNewestWonHistoryByPrizeNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string userNo, string prizeName, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/IsWonPrize", ReplyAction="http://tempuri.org/ILotteryService/IsWonPrizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/IsWonPrizeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/IsWonPrizeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> IsWonPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long lotteryId, string prizeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetLotteryList", ReplyAction="http://tempuri.org/ILotteryService/GetLotteryListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetLotteryListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetLotteryListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Lottery>> GetLotteryListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string lotName, System.Nullable<int> period, System.Nullable<long> stage, System.Nullable<bool> isEnd, UserService.RangeOfNullableOfdateTime5F2dSckg lotCreateDateRange, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/AddLottery", ReplyAction="http://tempuri.org/ILotteryService/AddLotteryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/AddLotteryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/AddLotteryErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddLotteryAsync(Tgnet.Api.OAuth2ClientIdentity identity, string lotName, System.Nullable<int> lotPeriod, System.Nullable<System.DateTime> lotEndDate, System.Nullable<long> lotStage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/AddLotteryPrizes", ReplyAction="http://tempuri.org/ILotteryService/AddLotteryPrizesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/AddLotteryPrizesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/AddLotteryPrizesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddLotteryPrizesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string name, string discription, int count, string img, int chance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/DrawLottery", ReplyAction="http://tempuri.org/ILotteryService/DrawLotteryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/DrawLotteryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/DrawLotteryErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DrawLotteryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string result, string memo, bool finish, string actionUser);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/LotteryWonPrize", ReplyAction="http://tempuri.org/ILotteryService/LotteryWonPrizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/LotteryWonPrizeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/LotteryWonPrizeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.LotteryWonPrizeResponse> LotteryWonPrizeAsync(UserService.LotteryWonPrizeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/AssignLotteryPrize", ReplyAction="http://tempuri.org/ILotteryService/AssignLotteryPrizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/AssignLotteryPrizeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/AssignLotteryPrizeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AssignLotteryPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long userId, int times, long lprId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/DeleteAssignPrizeByTimes", ReplyAction="http://tempuri.org/ILotteryService/DeleteAssignPrizeByTimesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/DeleteAssignPrizeByTimesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/DeleteAssignPrizeByTimesErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteAssignPrizeByTimesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long userId, int times);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/UpdateLotteryPrize", ReplyAction="http://tempuri.org/ILotteryService/UpdateLotteryPrizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/UpdateLotteryPrizeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/UpdateLotteryPrizeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateLotteryPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long prizeId, string prizeName, string prizeDesc, string img, System.Nullable<int> count, System.Nullable<int> change);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetLotteryPrizeById", ReplyAction="http://tempuri.org/ILotteryService/GetLotteryPrizeByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetLotteryPrizeByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetLotteryPrizeByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.LotteryPrize> GetLotteryPrizeByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long prizeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetUserLotteryHistory", ReplyAction="http://tempuri.org/ILotteryService/GetUserLotteryHistoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetUserLotteryHistoryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetUserLotteryHistoryErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.UserLotteryHistory>> GetUserLotteryHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, System.Nullable<long> uid, string userNo, string result, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetUserRemnantLotteryCount", ReplyAction="http://tempuri.org/ILotteryService/GetUserRemnantLotteryCountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetUserRemnantLotteryCountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetUserRemnantLotteryCountErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<int> GetUserRemnantLotteryCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetLotteryDoomedPrize", ReplyAction="http://tempuri.org/ILotteryService/GetLotteryDoomedPrizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetLotteryDoomedPrizeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetLotteryDoomedPrizeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.LotteryPrize[]> GetLotteryDoomedPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long uid, int times);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/GetLotteryResultByLotId", ReplyAction="http://tempuri.org/ILotteryService/GetLotteryResultByLotIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/GetLotteryResultByLotIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/GetLotteryResultByLotIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.LotteryResult[]> GetLotteryResultByLotIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/UpdateLottery", ReplyAction="http://tempuri.org/ILotteryService/UpdateLotteryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/UpdateLotteryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/UpdateLotteryErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateLotteryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string name, System.Nullable<int> period, System.Nullable<bool> isEnd, System.Nullable<System.DateTime> endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/DeleteLotteryPrize", ReplyAction="http://tempuri.org/ILotteryService/DeleteLotteryPrizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/DeleteLotteryPrizeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/DeleteLotteryPrizeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteLotteryPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long prizeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILotteryService/UpdateWonPrize", ReplyAction="http://tempuri.org/ILotteryService/UpdateWonPrizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/ILotteryService/UpdateWonPrizeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/ILotteryService/UpdateWonPrizeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateWonPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lpalId, string prizeName, string displayName, string describe, System.Nullable<bool> isAssign);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LotteryWonPrize", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LotteryWonPrizeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Tgnet.Api.OAuth2ClientIdentity identity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public long lotteryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public long userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public bool isAssign;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string memo;
        
        public LotteryWonPrizeRequest()
        {
        }
        
        public LotteryWonPrizeRequest(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long userId, bool isAssign, string memo)
        {
            this.identity = identity;
            this.lotteryId = lotteryId;
            this.userId = userId;
            this.isAssign = isAssign;
            this.memo = memo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LotteryWonPrizeResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LotteryWonPrizeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UserService.LotteryPrize LotteryWonPrizeResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string result;
        
        public LotteryWonPrizeResponse()
        {
        }
        
        public LotteryWonPrizeResponse(UserService.LotteryPrize LotteryWonPrizeResult, string result)
        {
            this.LotteryWonPrizeResult = LotteryWonPrizeResult;
            this.result = result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ILotteryServiceChannel : UserService.ILotteryService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class LotteryServiceClient : System.ServiceModel.ClientBase<UserService.ILotteryService>, UserService.ILotteryService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public LotteryServiceClient() : 
                base(LotteryServiceClient.GetDefaultBinding(), LotteryServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_ILotteryService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LotteryServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(LotteryServiceClient.GetBindingForEndpoint(endpointConfiguration), LotteryServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LotteryServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(LotteryServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LotteryServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(LotteryServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LotteryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<UserService.Lottery> GetLotteryByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, System.Nullable<long> uid, bool withPrizes)
        {
            return base.Channel.GetLotteryByIdAsync(identity, lotteryId, uid, withPrizes);
        }
        
        public System.Threading.Tasks.Task RecordLotteryResultAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, int subtractLotteryCount, UserService.LotteryPrizeResult result)
        {
            return base.Channel.RecordLotteryResultAsync(identity, uid, subtractLotteryCount, result);
        }
        
        public System.Threading.Tasks.Task<UserService.WonLotteryPrize[]> GetWonPrizesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long lotteryId)
        {
            return base.Channel.GetWonPrizesAsync(identity, uid, lotteryId);
        }
        
        public System.Threading.Tasks.Task AddLotteryCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long lotteryId, byte addCount, System.Nullable<System.DateTime> expired)
        {
            return base.Channel.AddLotteryCountAsync(identity, uid, lotteryId, addCount, expired);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WonLotteryPrize>> GetNewestWonHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, int start, int limit, string[] withoutPrizeNames)
        {
            return base.Channel.GetNewestWonHistoryAsync(identity, lotteryId, start, limit, withoutPrizeNames);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WonLotteryPrize>> GetNewestWonHistoryByPrizeNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string userNo, string prizeName, int start, int limit)
        {
            return base.Channel.GetNewestWonHistoryByPrizeNameAsync(identity, lotteryId, userNo, prizeName, start, limit);
        }
        
        public System.Threading.Tasks.Task<bool> IsWonPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long lotteryId, string prizeName)
        {
            return base.Channel.IsWonPrizeAsync(identity, uid, lotteryId, prizeName);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Lottery>> GetLotteryListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string lotName, System.Nullable<int> period, System.Nullable<long> stage, System.Nullable<bool> isEnd, UserService.RangeOfNullableOfdateTime5F2dSckg lotCreateDateRange, int start, int limit)
        {
            return base.Channel.GetLotteryListAsync(identity, lotName, period, stage, isEnd, lotCreateDateRange, start, limit);
        }
        
        public System.Threading.Tasks.Task AddLotteryAsync(Tgnet.Api.OAuth2ClientIdentity identity, string lotName, System.Nullable<int> lotPeriod, System.Nullable<System.DateTime> lotEndDate, System.Nullable<long> lotStage)
        {
            return base.Channel.AddLotteryAsync(identity, lotName, lotPeriod, lotEndDate, lotStage);
        }
        
        public System.Threading.Tasks.Task AddLotteryPrizesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string name, string discription, int count, string img, int chance)
        {
            return base.Channel.AddLotteryPrizesAsync(identity, lotteryId, name, discription, count, img, chance);
        }
        
        public System.Threading.Tasks.Task DrawLotteryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string result, string memo, bool finish, string actionUser)
        {
            return base.Channel.DrawLotteryAsync(identity, lotteryId, result, memo, finish, actionUser);
        }
        
        public System.Threading.Tasks.Task<UserService.LotteryWonPrizeResponse> LotteryWonPrizeAsync(UserService.LotteryWonPrizeRequest request)
        {
            return base.Channel.LotteryWonPrizeAsync(request);
        }
        
        public System.Threading.Tasks.Task AssignLotteryPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long userId, int times, long lprId)
        {
            return base.Channel.AssignLotteryPrizeAsync(identity, lotteryId, userId, times, lprId);
        }
        
        public System.Threading.Tasks.Task DeleteAssignPrizeByTimesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long userId, int times)
        {
            return base.Channel.DeleteAssignPrizeByTimesAsync(identity, lotteryId, userId, times);
        }
        
        public System.Threading.Tasks.Task UpdateLotteryPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long prizeId, string prizeName, string prizeDesc, string img, System.Nullable<int> count, System.Nullable<int> change)
        {
            return base.Channel.UpdateLotteryPrizeAsync(identity, prizeId, prizeName, prizeDesc, img, count, change);
        }
        
        public System.Threading.Tasks.Task<UserService.LotteryPrize> GetLotteryPrizeByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long prizeId)
        {
            return base.Channel.GetLotteryPrizeByIdAsync(identity, prizeId);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.UserLotteryHistory>> GetUserLotteryHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, System.Nullable<long> uid, string userNo, string result, int start, int limit)
        {
            return base.Channel.GetUserLotteryHistoryAsync(identity, lotteryId, uid, userNo, result, start, limit);
        }
        
        public System.Threading.Tasks.Task<int> GetUserRemnantLotteryCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long uid)
        {
            return base.Channel.GetUserRemnantLotteryCountAsync(identity, lotteryId, uid);
        }
        
        public System.Threading.Tasks.Task<UserService.LotteryPrize[]> GetLotteryDoomedPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, long uid, int times)
        {
            return base.Channel.GetLotteryDoomedPrizeAsync(identity, lotteryId, uid, times);
        }
        
        public System.Threading.Tasks.Task<UserService.LotteryResult[]> GetLotteryResultByLotIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId)
        {
            return base.Channel.GetLotteryResultByLotIdAsync(identity, lotteryId);
        }
        
        public System.Threading.Tasks.Task UpdateLotteryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lotteryId, string name, System.Nullable<int> period, System.Nullable<bool> isEnd, System.Nullable<System.DateTime> endDate)
        {
            return base.Channel.UpdateLotteryAsync(identity, lotteryId, name, period, isEnd, endDate);
        }
        
        public System.Threading.Tasks.Task DeleteLotteryPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long prizeId)
        {
            return base.Channel.DeleteLotteryPrizeAsync(identity, prizeId);
        }
        
        public System.Threading.Tasks.Task UpdateWonPrizeAsync(Tgnet.Api.OAuth2ClientIdentity identity, long lpalId, string prizeName, string displayName, string describe, System.Nullable<bool> isAssign)
        {
            return base.Channel.UpdateWonPrizeAsync(identity, lpalId, prizeName, displayName, describe, isAssign);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_ILotteryService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_ILotteryService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.user.tgnet.com:18065/Services/UserService.svc/Lottery");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return LotteryServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_ILotteryService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return LotteryServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_ILotteryService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_ILotteryService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IQuestionnaireService")]
    public interface IQuestionnaireService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryList", ReplyAction="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryListRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryListErrorR" +
            "esponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryListErrorC" +
            "odeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.QuestionnaireSubjectSource>> GetQuestionnaireSubjectLibraryListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> qaid, System.Nullable<long> creater, System.Nullable<long> operators, System.Nullable<bool> isEnable, string title, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryById", ReplyAction="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryByIdRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryByIdErrorR" +
            "esponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireSubjectLibraryByIdErrorC" +
            "odeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.QuestionnaireSubjectSource> GetQuestionnaireSubjectLibraryByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qssid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireSubjectLibrary", ReplyAction="http://tempuri.org/IQuestionnaireService/AddQuestionnaireSubjectLibraryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireSubjectLibraryErrorRespo" +
            "nseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireSubjectLibraryErrorCodeF" +
            "ault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.QuestionnaireSubjectSource> AddQuestionnaireSubjectLibraryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid, string title, bool isEnable, long createrUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireSubjectLibrary", ReplyAction="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireSubjectLibraryRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireSubjectLibraryErrorRe" +
            "sponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireSubjectLibraryErrorCo" +
            "deFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateQuestionnaireSubjectLibraryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qssid, string title, bool isEnable, long operatorsUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireOptions", ReplyAction="http://tempuri.org/IQuestionnaireService/AddQuestionnaireOptionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireOptionsErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireOptionsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.QuestionnaireOptions> AddQuestionnaireOptionsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string content, long qssid, long createrUid, bool isEnable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireOptions", ReplyAction="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireOptionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireOptionsErrorResponseT" +
            "ypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireOptionsErrorCodeFault" +
            "", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteQuestionnaireOptionsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qoid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireOptions", ReplyAction="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireOptionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireOptionsErrorResponseT" +
            "ypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireOptionsErrorCodeFault" +
            "", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateQuestionnaireOptionsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qoid, string content, bool isEnable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireOptionById", ReplyAction="http://tempuri.org/IQuestionnaireService/GetQuestionnaireOptionByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireOptionByIdErrorResponseT" +
            "ypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireOptionByIdErrorCodeFault" +
            "", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.QuestionnaireOptions> GetQuestionnaireOptionByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qoid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityList", ReplyAction="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityListErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityListErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.QuestionnairesActivity>> GetQuestionnaireActivityListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<int> qaid, string name, string shareFriendIntro, string shareGroupIntro, System.Nullable<int> uid, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityById", ReplyAction="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityByIdErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnaireActivityByIdErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.QuestionnairesActivity> GetQuestionnaireActivityByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireActivity", ReplyAction="http://tempuri.org/IQuestionnaireService/AddQuestionnaireActivityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireActivityErrorResponseTyp" +
            "eFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/AddQuestionnaireActivityErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.QuestionnairesActivity> AddQuestionnaireActivityAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, string shareFriendIntro, string shareGroupIntro, long createrUid, int maxSubjectCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireActivity", ReplyAction="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireActivityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireActivityErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/UpdateQuestionnaireActivityErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateQuestionnaireActivityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid, string name, string shareFriendIntro, string shareGroupIntro, long operatorsUid, int maxSubjectCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireActivity", ReplyAction="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireActivityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireActivityErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/DeleteQuestionnaireActivityErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteQuestionnaireActivityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetQuestionnairesSubjectList", ReplyAction="http://tempuri.org/IQuestionnaireService/GetQuestionnairesSubjectListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnairesSubjectListErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnairesSubjectListErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Questionnaires>> GetQuestionnairesSubjectListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> qid, System.Nullable<long> euid, System.Nullable<long> qaid, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetQuestionnairesAnswerList", ReplyAction="http://tempuri.org/IQuestionnaireService/GetQuestionnairesAnswerListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnairesAnswerListErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetQuestionnairesAnswerListErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.QuestionnaireAnswer>> GetQuestionnairesAnswerListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> qid, System.Nullable<long> qaid, System.Nullable<long> qsid, System.Nullable<long> euid, System.Nullable<long> qoid, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/BatchAddOrUpdateContent", ReplyAction="http://tempuri.org/IQuestionnaireService/BatchAddOrUpdateContentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/BatchAddOrUpdateContentErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/BatchAddOrUpdateContentErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.WeiXinContentModel[]> BatchAddOrUpdateContentAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userNo, UserService.WeixinContentEditInfo[] models);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/AddOrUpdateKeywordReply", ReplyAction="http://tempuri.org/IQuestionnaireService/AddOrUpdateKeywordReplyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/AddOrUpdateKeywordReplyErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/AddOrUpdateKeywordReplyErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddOrUpdateKeywordReplyAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, System.Nullable<long> kid, string keyword, UserService.WeixinContentEditInfo[] models);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/DeleteKeyword", ReplyAction="http://tempuri.org/IQuestionnaireService/DeleteKeywordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/DeleteKeywordErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/DeleteKeywordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteKeywordAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long[] kids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/DeleteContent", ReplyAction="http://tempuri.org/IQuestionnaireService/DeleteContentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/DeleteContentErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/DeleteContentErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteContentAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userNo, long[] cids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetReplyContents", ReplyAction="http://tempuri.org/IQuestionnaireService/GetReplyContentsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetReplyContentsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetReplyContentsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.WeiXinContentModel[]> GetReplyContentsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string keyword, System.Nullable<int> limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetWeixinKeywords", ReplyAction="http://tempuri.org/IQuestionnaireService/GetWeixinKeywordsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetWeixinKeywordsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetWeixinKeywordsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WeixinKeywordModel>> GetWeixinKeywordsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string keyword, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetWeiXinContents", ReplyAction="http://tempuri.org/IQuestionnaireService/GetWeiXinContentsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetWeiXinContentsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetWeiXinContentsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WeiXinContentModel>> GetWeiXinContentsAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UseKinds[] useKinds, UserService.ContentTypes[] contentTypes, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/GetWeixinPushIds", ReplyAction="http://tempuri.org/IQuestionnaireService/GetWeixinPushIdsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/GetWeixinPushIdsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/GetWeixinPushIdsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long[]> GetWeixinPushIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.PushKinds kind, string openId, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/AddOrUpdateSubscribe", ReplyAction="http://tempuri.org/IQuestionnaireService/AddOrUpdateSubscribeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/AddOrUpdateSubscribeErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/AddOrUpdateSubscribeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddOrUpdateSubscribeAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.WeiXinSubscribeEditInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionnaireService/UpdateContentMediaIdStatus", ReplyAction="http://tempuri.org/IQuestionnaireService/UpdateContentMediaIdStatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IQuestionnaireService/UpdateContentMediaIdStatusErrorResponseT" +
            "ypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IQuestionnaireService/UpdateContentMediaIdStatusErrorCodeFault" +
            "", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateContentMediaIdStatusAsync(Tgnet.Api.OAuth2ClientIdentity identit, long cid, string media_id, System.Nullable<System.DateTime> expired);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IQuestionnaireServiceChannel : UserService.IQuestionnaireService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class QuestionnaireServiceClient : System.ServiceModel.ClientBase<UserService.IQuestionnaireService>, UserService.IQuestionnaireService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public QuestionnaireServiceClient() : 
                base(QuestionnaireServiceClient.GetDefaultBinding(), QuestionnaireServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IQuestionnaireService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QuestionnaireServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(QuestionnaireServiceClient.GetBindingForEndpoint(endpointConfiguration), QuestionnaireServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QuestionnaireServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(QuestionnaireServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QuestionnaireServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(QuestionnaireServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QuestionnaireServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.QuestionnaireSubjectSource>> GetQuestionnaireSubjectLibraryListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> qaid, System.Nullable<long> creater, System.Nullable<long> operators, System.Nullable<bool> isEnable, string title, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit)
        {
            return base.Channel.GetQuestionnaireSubjectLibraryListAsync(identity, qaid, creater, operators, isEnable, title, dateTimeRange, start, limit);
        }
        
        public System.Threading.Tasks.Task<UserService.QuestionnaireSubjectSource> GetQuestionnaireSubjectLibraryByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qssid)
        {
            return base.Channel.GetQuestionnaireSubjectLibraryByIdAsync(identity, qssid);
        }
        
        public System.Threading.Tasks.Task<UserService.QuestionnaireSubjectSource> AddQuestionnaireSubjectLibraryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid, string title, bool isEnable, long createrUid)
        {
            return base.Channel.AddQuestionnaireSubjectLibraryAsync(identity, qaid, title, isEnable, createrUid);
        }
        
        public System.Threading.Tasks.Task UpdateQuestionnaireSubjectLibraryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qssid, string title, bool isEnable, long operatorsUid)
        {
            return base.Channel.UpdateQuestionnaireSubjectLibraryAsync(identity, qssid, title, isEnable, operatorsUid);
        }
        
        public System.Threading.Tasks.Task<UserService.QuestionnaireOptions> AddQuestionnaireOptionsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string content, long qssid, long createrUid, bool isEnable)
        {
            return base.Channel.AddQuestionnaireOptionsAsync(identity, content, qssid, createrUid, isEnable);
        }
        
        public System.Threading.Tasks.Task DeleteQuestionnaireOptionsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qoid)
        {
            return base.Channel.DeleteQuestionnaireOptionsAsync(identity, qoid);
        }
        
        public System.Threading.Tasks.Task UpdateQuestionnaireOptionsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qoid, string content, bool isEnable)
        {
            return base.Channel.UpdateQuestionnaireOptionsAsync(identity, qoid, content, isEnable);
        }
        
        public System.Threading.Tasks.Task<UserService.QuestionnaireOptions> GetQuestionnaireOptionByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qoid)
        {
            return base.Channel.GetQuestionnaireOptionByIdAsync(identity, qoid);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.QuestionnairesActivity>> GetQuestionnaireActivityListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<int> qaid, string name, string shareFriendIntro, string shareGroupIntro, System.Nullable<int> uid, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit)
        {
            return base.Channel.GetQuestionnaireActivityListAsync(identity, qaid, name, shareFriendIntro, shareGroupIntro, uid, dateTimeRange, start, limit);
        }
        
        public System.Threading.Tasks.Task<UserService.QuestionnairesActivity> GetQuestionnaireActivityByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid)
        {
            return base.Channel.GetQuestionnaireActivityByIdAsync(identity, qaid);
        }
        
        public System.Threading.Tasks.Task<UserService.QuestionnairesActivity> AddQuestionnaireActivityAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, string shareFriendIntro, string shareGroupIntro, long createrUid, int maxSubjectCount)
        {
            return base.Channel.AddQuestionnaireActivityAsync(identity, name, shareFriendIntro, shareGroupIntro, createrUid, maxSubjectCount);
        }
        
        public System.Threading.Tasks.Task UpdateQuestionnaireActivityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid, string name, string shareFriendIntro, string shareGroupIntro, long operatorsUid, int maxSubjectCount)
        {
            return base.Channel.UpdateQuestionnaireActivityAsync(identity, qaid, name, shareFriendIntro, shareGroupIntro, operatorsUid, maxSubjectCount);
        }
        
        public System.Threading.Tasks.Task DeleteQuestionnaireActivityAsync(Tgnet.Api.OAuth2ClientIdentity identity, long qaid)
        {
            return base.Channel.DeleteQuestionnaireActivityAsync(identity, qaid);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Questionnaires>> GetQuestionnairesSubjectListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> qid, System.Nullable<long> euid, System.Nullable<long> qaid, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit)
        {
            return base.Channel.GetQuestionnairesSubjectListAsync(identity, qid, euid, qaid, dateTimeRange, start, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.QuestionnaireAnswer>> GetQuestionnairesAnswerListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> qid, System.Nullable<long> qaid, System.Nullable<long> qsid, System.Nullable<long> euid, System.Nullable<long> qoid, UserService.RangeOfNullableOfdateTime5F2dSckg dateTimeRange, System.Nullable<int> start, System.Nullable<int> limit)
        {
            return base.Channel.GetQuestionnairesAnswerListAsync(identity, qid, qaid, qsid, euid, qoid, dateTimeRange, start, limit);
        }
        
        public System.Threading.Tasks.Task<UserService.WeiXinContentModel[]> BatchAddOrUpdateContentAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userNo, UserService.WeixinContentEditInfo[] models)
        {
            return base.Channel.BatchAddOrUpdateContentAsync(identity, userNo, models);
        }
        
        public System.Threading.Tasks.Task AddOrUpdateKeywordReplyAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, System.Nullable<long> kid, string keyword, UserService.WeixinContentEditInfo[] models)
        {
            return base.Channel.AddOrUpdateKeywordReplyAsync(identity, uid, kid, keyword, models);
        }
        
        public System.Threading.Tasks.Task DeleteKeywordAsync(Tgnet.Api.OAuth2ClientIdentity identity, long uid, long[] kids)
        {
            return base.Channel.DeleteKeywordAsync(identity, uid, kids);
        }
        
        public System.Threading.Tasks.Task DeleteContentAsync(Tgnet.Api.OAuth2ClientIdentity identity, string userNo, long[] cids)
        {
            return base.Channel.DeleteContentAsync(identity, userNo, cids);
        }
        
        public System.Threading.Tasks.Task<UserService.WeiXinContentModel[]> GetReplyContentsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string keyword, System.Nullable<int> limit)
        {
            return base.Channel.GetReplyContentsAsync(identity, keyword, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WeixinKeywordModel>> GetWeixinKeywordsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string keyword, int start, int limit)
        {
            return base.Channel.GetWeixinKeywordsAsync(identity, keyword, start, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.WeiXinContentModel>> GetWeiXinContentsAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.UseKinds[] useKinds, UserService.ContentTypes[] contentTypes, int start, int limit)
        {
            return base.Channel.GetWeiXinContentsAsync(identity, useKinds, contentTypes, start, limit);
        }
        
        public System.Threading.Tasks.Task<long[]> GetWeixinPushIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.PushKinds kind, string openId, int limit)
        {
            return base.Channel.GetWeixinPushIdsAsync(identity, kind, openId, limit);
        }
        
        public System.Threading.Tasks.Task AddOrUpdateSubscribeAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.WeiXinSubscribeEditInfo info)
        {
            return base.Channel.AddOrUpdateSubscribeAsync(identity, info);
        }
        
        public System.Threading.Tasks.Task UpdateContentMediaIdStatusAsync(Tgnet.Api.OAuth2ClientIdentity identit, long cid, string media_id, System.Nullable<System.DateTime> expired)
        {
            return base.Channel.UpdateContentMediaIdStatusAsync(identit, cid, media_id, expired);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IQuestionnaireService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IQuestionnaireService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.user.tgnet.com:18065/Services/UserService.svc/Questionnaire");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return QuestionnaireServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IQuestionnaireService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return QuestionnaireServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IQuestionnaireService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IQuestionnaireService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IVoteService")]
    public interface IVoteService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetVoteById", ReplyAction="http://tempuri.org/IVoteService/GetVoteByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetVoteByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetVoteByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.Vote> GetVoteByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/AddVote", ReplyAction="http://tempuri.org/IVoteService/AddVoteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/AddVoteErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/AddVoteErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, string title, int votenumLimit, int lotteryLimit, string prizeExplain, string joinConditionExplain, UserService.RangeOfdateTime dateRange, long @operator, System.Nullable<long> lotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/UpdateVote", ReplyAction="http://tempuri.org/IVoteService/UpdateVoteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/UpdateVoteErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/UpdateVoteErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string title, System.Nullable<int> votenumLimit, System.Nullable<int> lotteryLimit, string prizeExplain, string joinConditionExplain, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, System.Nullable<long> @operator, System.Nullable<long> lotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetVoteList", ReplyAction="http://tempuri.org/IVoteService/GetVoteListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetVoteListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetVoteListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteSys>> GetVoteListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string title, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetCurrentClientVoteHistory", ReplyAction="http://tempuri.org/IVoteService/GetCurrentClientVoteHistoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetCurrentClientVoteHistoryErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetCurrentClientVoteHistoryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteHistory>> GetCurrentClientVoteHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string voteIP, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetVoteHistoryList", ReplyAction="http://tempuri.org/IVoteService/GetVoteHistoryListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetVoteHistoryListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetVoteHistoryListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteHistory>> GetVoteHistoryListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string voteIP, UserService.RangeOfNullableOfdateTime5F2dSckg voteDateRange, System.Nullable<long> @void, System.Nullable<long> vid, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetVoteCountByIP", ReplyAction="http://tempuri.org/IVoteService/GetVoteCountByIPResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetVoteCountByIPErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetVoteCountByIPErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<int> GetVoteCountByIPAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, long vid, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/JoinVote", ReplyAction="http://tempuri.org/IVoteService/JoinVoteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/JoinVoteErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/JoinVoteErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task JoinVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string name, string icon, string manifesto, string character, string hobby, string testimonials, UserService.Kinds kind, long key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetVoteOptionList", ReplyAction="http://tempuri.org/IVoteService/GetVoteOptionListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetVoteOptionListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetVoteOptionListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteOption>> GetVoteOptionListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, System.Nullable<bool> isEnable, System.Nullable<long> vid, System.Nullable<long> key, System.Nullable<UserService.Kinds> kind, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/UpdateVoteOption", ReplyAction="http://tempuri.org/IVoteService/UpdateVoteOptionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/UpdateVoteOptionErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/UpdateVoteOptionErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateVoteOptionAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void, string name, System.Nullable<int> votenum, string icon, string manifesto, string character, string hobby, string testimonials, System.Nullable<bool> isEnable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetVoteOptionById", ReplyAction="http://tempuri.org/IVoteService/GetVoteOptionByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetVoteOptionByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetVoteOptionByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<UserService.VoteOption> GetVoteOptionByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/Voting", ReplyAction="http://tempuri.org/IVoteService/VotingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/VotingErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/VotingErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task VotingAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void, string voteIP, System.Nullable<long> userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/TodayIsVote", ReplyAction="http://tempuri.org/IVoteService/TodayIsVoteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/TodayIsVoteErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/TodayIsVoteErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> TodayIsVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string voteIp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/DeleteVoteHistory", ReplyAction="http://tempuri.org/IVoteService/DeleteVoteHistoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/DeleteVoteHistoryErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/DeleteVoteHistoryErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteVoteHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/IsJoin", ReplyAction="http://tempuri.org/IVoteService/IsJoinResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/IsJoinErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/IsJoinErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<bool> IsJoinAsync(Tgnet.Api.OAuth2ClientIdentity identity, long key, long vid, UserService.Kinds kind);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/GetVoteReplyList", ReplyAction="http://tempuri.org/IVoteService/GetVoteReplyListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/GetVoteReplyListErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/GetVoteReplyListErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Reply>> GetVoteReplyListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> euId, System.Nullable<long> optionId, string optionName, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/DeleteVoteReply", ReplyAction="http://tempuri.org/IVoteService/DeleteVoteReplyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/DeleteVoteReplyErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/DeleteVoteReplyErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteVoteReplyAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] vrIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVoteService/ReplyVoteOption", ReplyAction="http://tempuri.org/IVoteService/ReplyVoteOptionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserService.ErrorResponseType), Action="http://tempuri.org/IVoteService/ReplyVoteOptionErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IVoteService/ReplyVoteOptionErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task ReplyVoteOptionAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void, long euid, string content);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IVoteServiceChannel : UserService.IVoteService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class VoteServiceClient : System.ServiceModel.ClientBase<UserService.IVoteService>, UserService.IVoteService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public VoteServiceClient() : 
                base(VoteServiceClient.GetDefaultBinding(), VoteServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IVoteService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoteServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(VoteServiceClient.GetBindingForEndpoint(endpointConfiguration), VoteServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoteServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(VoteServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoteServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(VoteServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<UserService.Vote> GetVoteByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid)
        {
            return base.Channel.GetVoteByIdAsync(identity, vid);
        }
        
        public System.Threading.Tasks.Task AddVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, string title, int votenumLimit, int lotteryLimit, string prizeExplain, string joinConditionExplain, UserService.RangeOfdateTime dateRange, long @operator, System.Nullable<long> lotId)
        {
            return base.Channel.AddVoteAsync(identity, title, votenumLimit, lotteryLimit, prizeExplain, joinConditionExplain, dateRange, @operator, lotId);
        }
        
        public System.Threading.Tasks.Task UpdateVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string title, System.Nullable<int> votenumLimit, System.Nullable<int> lotteryLimit, string prizeExplain, string joinConditionExplain, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, System.Nullable<long> @operator, System.Nullable<long> lotId)
        {
            return base.Channel.UpdateVoteAsync(identity, vid, title, votenumLimit, lotteryLimit, prizeExplain, joinConditionExplain, dateRange, @operator, lotId);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteSys>> GetVoteListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string title, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, int start, int limit)
        {
            return base.Channel.GetVoteListAsync(identity, title, dateRange, start, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteHistory>> GetCurrentClientVoteHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string voteIP, int start, int limit)
        {
            return base.Channel.GetCurrentClientVoteHistoryAsync(identity, vid, voteIP, start, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteHistory>> GetVoteHistoryListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string voteIP, UserService.RangeOfNullableOfdateTime5F2dSckg voteDateRange, System.Nullable<long> @void, System.Nullable<long> vid, int start, int limit)
        {
            return base.Channel.GetVoteHistoryListAsync(identity, voteIP, voteDateRange, @void, vid, start, limit);
        }
        
        public System.Threading.Tasks.Task<int> GetVoteCountByIPAsync(Tgnet.Api.OAuth2ClientIdentity identity, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, long vid, string ip)
        {
            return base.Channel.GetVoteCountByIPAsync(identity, dateRange, vid, ip);
        }
        
        public System.Threading.Tasks.Task JoinVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string name, string icon, string manifesto, string character, string hobby, string testimonials, UserService.Kinds kind, long key)
        {
            return base.Channel.JoinVoteAsync(identity, vid, name, icon, manifesto, character, hobby, testimonials, kind, key);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.VoteOption>> GetVoteOptionListAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, System.Nullable<bool> isEnable, System.Nullable<long> vid, System.Nullable<long> key, System.Nullable<UserService.Kinds> kind, UserService.RangeOfNullableOfdateTime5F2dSckg dateRange, int start, int limit)
        {
            return base.Channel.GetVoteOptionListAsync(identity, name, isEnable, vid, key, kind, dateRange, start, limit);
        }
        
        public System.Threading.Tasks.Task UpdateVoteOptionAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void, string name, System.Nullable<int> votenum, string icon, string manifesto, string character, string hobby, string testimonials, System.Nullable<bool> isEnable)
        {
            return base.Channel.UpdateVoteOptionAsync(identity, @void, name, votenum, icon, manifesto, character, hobby, testimonials, isEnable);
        }
        
        public System.Threading.Tasks.Task<UserService.VoteOption> GetVoteOptionByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void)
        {
            return base.Channel.GetVoteOptionByIdAsync(identity, @void);
        }
        
        public System.Threading.Tasks.Task VotingAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void, string voteIP, System.Nullable<long> userID)
        {
            return base.Channel.VotingAsync(identity, @void, voteIP, userID);
        }
        
        public System.Threading.Tasks.Task<bool> TodayIsVoteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long vid, string voteIp)
        {
            return base.Channel.TodayIsVoteAsync(identity, vid, voteIp);
        }
        
        public System.Threading.Tasks.Task DeleteVoteHistoryAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] ids)
        {
            return base.Channel.DeleteVoteHistoryAsync(identity, ids);
        }
        
        public System.Threading.Tasks.Task<bool> IsJoinAsync(Tgnet.Api.OAuth2ClientIdentity identity, long key, long vid, UserService.Kinds kind)
        {
            return base.Channel.IsJoinAsync(identity, key, vid, kind);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<UserService.Reply>> GetVoteReplyListAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<long> euId, System.Nullable<long> optionId, string optionName, int start, int limit)
        {
            return base.Channel.GetVoteReplyListAsync(identity, euId, optionId, optionName, start, limit);
        }
        
        public System.Threading.Tasks.Task DeleteVoteReplyAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] vrIds)
        {
            return base.Channel.DeleteVoteReplyAsync(identity, vrIds);
        }
        
        public System.Threading.Tasks.Task ReplyVoteOptionAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @void, long euid, string content)
        {
            return base.Channel.ReplyVoteOptionAsync(identity, @void, euid, content);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IVoteService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IVoteService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.user.tgnet.com:18065/Services/UserService.svc/Vote");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return VoteServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IVoteService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return VoteServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IVoteService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IVoteService,
        }
    }
}
