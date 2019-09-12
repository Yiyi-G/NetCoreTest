//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace StaticResourceService
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterWordKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.StaticResource")]
    public enum FilterWordKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UserNo = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UserNick = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Text = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        All = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AreaInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class AreaInfo : object
    {
        
        private string area_noField;
        
        private string nameField;
        
        private int orderField;
        
        private StaticResourceService.AreaInfo[] subclassField;
        
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
        public int order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.AreaInfo[] subclass
        {
            get
            {
                return this.subclassField;
            }
            set
            {
                this.subclassField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AreaType", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public enum AreaType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Country = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Province = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        City = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Town = 16,
    }
    
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompleteAreaInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class CompleteAreaInfo : object
    {
        
        private string AreaNoField;
        
        private string CityField;
        
        private string CountryField;
        
        private string ProvinceField;
        
        private string TownField;
        
        private StaticResourceService.AreaType TypeField;
        
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
        public string Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
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
        public string Town
        {
            get
            {
                return this.TownField;
            }
            set
            {
                this.TownField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.AreaType Type
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MobileAreaInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class MobileAreaInfo : object
    {
        
        private string m_cityField;
        
        private long m_idField;
        
        private string m_numField;
        
        private string m_provinceField;
        
        private string m_service_typeField;
        
        private string m_tel_codeField;
        
        private string m_zip_codeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string m_city
        {
            get
            {
                return this.m_cityField;
            }
            set
            {
                this.m_cityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long m_id
        {
            get
            {
                return this.m_idField;
            }
            set
            {
                this.m_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string m_num
        {
            get
            {
                return this.m_numField;
            }
            set
            {
                this.m_numField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string m_province
        {
            get
            {
                return this.m_provinceField;
            }
            set
            {
                this.m_provinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string m_service_type
        {
            get
            {
                return this.m_service_typeField;
            }
            set
            {
                this.m_service_typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string m_tel_code
        {
            get
            {
                return this.m_tel_codeField;
            }
            set
            {
                this.m_tel_codeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string m_zip_code
        {
            get
            {
                return this.m_zip_codeField;
            }
            set
            {
                this.m_zip_codeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductClassTypes", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.StaticResource.ProductClass")]
    public enum ProductClassTypes : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NormalAndCost = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Normal = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cost = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductClassInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StaticResourceService.ProductClassCompleteInfo))]
    public partial class ProductClassInfo : StaticResourceService.ClassInfo
    {
        
        private bool IsDisplayField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDisplay
        {
            get
            {
                return this.IsDisplayField;
            }
            set
            {
                this.IsDisplayField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClassInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StaticResourceService.ProductClassInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StaticResourceService.ProductClassCompleteInfo))]
    public partial class ClassInfo : object
    {
        
        private string NameField;
        
        private string NoField;
        
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
        public string No
        {
            get
            {
                return this.NoField;
            }
            set
            {
                this.NoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductClassCompleteInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class ProductClassCompleteInfo : StaticResourceService.ProductClassInfo
    {
        
        private string FullNameField;
        
        private bool IsEnabledField;
        
        private StaticResourceService.ProductClassRelation[] ParentProjectKeymanRelationsField;
        
        private StaticResourceService.ProductClassRelation[] ParentProjectStageRelationsField;
        
        private StaticResourceService.ProductClassRelation[] ParentProjectTypeRelationsField;
        
        private StaticResourceService.ProductClassRelation[] ParentRelationsField;
        
        private StaticResourceService.ProductClassRelation[] ProjectKeymanRelationsField;
        
        private StaticResourceService.ProductClassRelation[] ProjectStageRelationsField;
        
        private StaticResourceService.ProductClassRelation[] ProjectTypeRelationsField;
        
        private StaticResourceService.ProductClassRelation[] RelationsField;
        
        private StaticResourceService.ProductClassInfo[] SubsField;
        
        private StaticResourceService.ProductClassTypes TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName
        {
            get
            {
                return this.FullNameField;
            }
            set
            {
                this.FullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnabled
        {
            get
            {
                return this.IsEnabledField;
            }
            set
            {
                this.IsEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] ParentProjectKeymanRelations
        {
            get
            {
                return this.ParentProjectKeymanRelationsField;
            }
            set
            {
                this.ParentProjectKeymanRelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] ParentProjectStageRelations
        {
            get
            {
                return this.ParentProjectStageRelationsField;
            }
            set
            {
                this.ParentProjectStageRelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] ParentProjectTypeRelations
        {
            get
            {
                return this.ParentProjectTypeRelationsField;
            }
            set
            {
                this.ParentProjectTypeRelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] ParentRelations
        {
            get
            {
                return this.ParentRelationsField;
            }
            set
            {
                this.ParentRelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] ProjectKeymanRelations
        {
            get
            {
                return this.ProjectKeymanRelationsField;
            }
            set
            {
                this.ProjectKeymanRelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] ProjectStageRelations
        {
            get
            {
                return this.ProjectStageRelationsField;
            }
            set
            {
                this.ProjectStageRelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] ProjectTypeRelations
        {
            get
            {
                return this.ProjectTypeRelationsField;
            }
            set
            {
                this.ProjectTypeRelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassRelation[] Relations
        {
            get
            {
                return this.RelationsField;
            }
            set
            {
                this.RelationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassInfo[] Subs
        {
            get
            {
                return this.SubsField;
            }
            set
            {
                this.SubsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ProductClassTypes Type
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductClassRelation", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class ProductClassRelation : object
    {
        
        private string ClassFullNameField;
        
        private string ClassNoField;
        
        private bool IsOptimalField;
        
        private string OriginalNoField;
        
        private byte RelationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClassFullName
        {
            get
            {
                return this.ClassFullNameField;
            }
            set
            {
                this.ClassFullNameField = value;
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
        public bool IsOptimal
        {
            get
            {
                return this.IsOptimalField;
            }
            set
            {
                this.IsOptimalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalNo
        {
            get
            {
                return this.OriginalNoField;
            }
            set
            {
                this.OriginalNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Relation
        {
            get
            {
                return this.RelationField;
            }
            set
            {
                this.RelationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RangeOfNullableOfint5F2dSckg", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Data")]
    public partial class RangeOfNullableOfint5F2dSckg : object
    {
        
        private bool _IsCanComparableField;
        
        private bool _IsEqualsField;
        
        private System.Nullable<int> _MaxField;
        
        private bool _MaxAssignedField;
        
        private System.Nullable<int> _MinField;
        
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
        public System.Nullable<int> _Max
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
        public System.Nullable<int> _Min
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BassClass", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class BassClass : object
    {
        
        private string MemoField;
        
        private string NameField;
        
        private string NoField;
        
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
        public string No
        {
            get
            {
                return this.NoField;
            }
            set
            {
                this.NoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BrandGrade", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public enum BrandGrade : byte
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BrandUpdateArgs", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class BrandUpdateArgs : object
    {
        
        private bool EnabledField;
        
        private StaticResourceService.BrandGrade GradeField;
        
        private string NameField;
        
        private string RemarkField;
        
        private long UpdaterField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Enabled
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
        public StaticResourceService.BrandGrade Grade
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
        public long Updater
        {
            get
            {
                return this.UpdaterField;
            }
            set
            {
                this.UpdaterField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BrandInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class BrandInfo : object
    {
        
        private long BidField;
        
        private bool EnabledField;
        
        private StaticResourceService.BrandGrade GradeField;
        
        private string NameField;
        
        private string RemarkField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Bid
        {
            get
            {
                return this.BidField;
            }
            set
            {
                this.BidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Enabled
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
        public StaticResourceService.BrandGrade Grade
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AreaLocation", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class AreaLocation : object
    {
        
        private string LatitudeField;
        
        private string LongitudeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Latitude
        {
            get
            {
                return this.LatitudeField;
            }
            set
            {
                this.LatitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Longitude
        {
            get
            {
                return this.LongitudeField;
            }
            set
            {
                this.LongitudeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClassKinds", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.StaticResource")]
    public enum ClassKinds : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectType = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Keyman = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectStage = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Area = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProductClass = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TopicProjectType = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectContactClass = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FootChatStage = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FootChatFollowCustomerType = 9,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommonClassInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class CommonClassInfo : object
    {
        
        private StaticResourceService.ClassTreeModel[] ItemsField;
        
        private string VersionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.ClassTreeModel[] Items
        {
            get
            {
                return this.ItemsField;
            }
            set
            {
                this.ItemsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version
        {
            get
            {
                return this.VersionField;
            }
            set
            {
                this.VersionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClassTreeModel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class ClassTreeModel : object
    {
        
        private string ClassNameField;
        
        private string ClassNoField;
        
        private string MemoField;
        
        private StaticResourceService.ClassTreeModel[] TgnetDataIClassModelcomtgnetapiwcfModelsClassTreeModelSubsField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Tgnet.Data.IClassModel<com.tgnet.api.wcf.Models.ClassTreeModel>.Subs")]
        public StaticResourceService.ClassTreeModel[] TgnetDataIClassModelcomtgnetapiwcfModelsClassTreeModelSubs
        {
            get
            {
                return this.TgnetDataIClassModelcomtgnetapiwcfModelsClassTreeModelSubsField;
            }
            set
            {
                this.TgnetDataIClassModelcomtgnetapiwcfModelsClassTreeModelSubsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StaticResourceService.AddressWithAreaNo))]
    public partial class Address : object
    {
        
        private string CityField;
        
        private string DistrictField;
        
        private string FormattedAddressField;
        
        private string ProvinceField;
        
        private string StreetField;
        
        private string StreetNumberField;
        
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
        public string District
        {
            get
            {
                return this.DistrictField;
            }
            set
            {
                this.DistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FormattedAddress
        {
            get
            {
                return this.FormattedAddressField;
            }
            set
            {
                this.FormattedAddressField = value;
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
        public string Street
        {
            get
            {
                return this.StreetField;
            }
            set
            {
                this.StreetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetNumber
        {
            get
            {
                return this.StreetNumberField;
            }
            set
            {
                this.StreetNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressWithAreaNo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class AddressWithAreaNo : StaticResourceService.Address
    {
        
        private string AreaNoField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleLocation", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StaticResourceService.LocationAreaInfo))]
    public partial class SimpleLocation : object
    {
        
        private int ConfidenceField;
        
        private double LatitudeField;
        
        private string LevelField;
        
        private double LongitudeField;
        
        private int PreciseField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Confidence
        {
            get
            {
                return this.ConfidenceField;
            }
            set
            {
                this.ConfidenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Latitude
        {
            get
            {
                return this.LatitudeField;
            }
            set
            {
                this.LatitudeField = value;
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
        public double Longitude
        {
            get
            {
                return this.LongitudeField;
            }
            set
            {
                this.LongitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Precise
        {
            get
            {
                return this.PreciseField;
            }
            set
            {
                this.PreciseField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LocationAreaInfo", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class LocationAreaInfo : StaticResourceService.SimpleLocation
    {
        
        private string AreaNoField;
        
        private string CityField;
        
        private string DistrictField;
        
        private string FormattedAddressField;
        
        private string ProvinceField;
        
        private string StreetField;
        
        private string StreetNumberField;
        
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
        public string District
        {
            get
            {
                return this.DistrictField;
            }
            set
            {
                this.DistrictField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FormattedAddress
        {
            get
            {
                return this.FormattedAddressField;
            }
            set
            {
                this.FormattedAddressField = value;
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
        public string Street
        {
            get
            {
                return this.StreetField;
            }
            set
            {
                this.StreetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetNumber
        {
            get
            {
                return this.StreetNumberField;
            }
            set
            {
                this.StreetNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShortUrlModel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class ShortUrlModel : object
    {
        
        private string KeyField;
        
        private string ShortUrlField;
        
        private string WithParameterShortUrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key
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
        public string ShortUrl
        {
            get
            {
                return this.ShortUrlField;
            }
            set
            {
                this.ShortUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WithParameterShortUrl
        {
            get
            {
                return this.WithParameterShortUrlField;
            }
            set
            {
                this.WithParameterShortUrlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EditCalendarModel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StaticResourceService.CalendarModel))]
    public partial class EditCalendarModel : object
    {
        
        private System.DateTime DateField;
        
        private bool IsEnabledField;
        
        private long OperationUidField;
        
        private StaticResourceService.CalendarType TypeField;
        
        private System.DateTime UpdateTimeField;
        
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
        public bool IsEnabled
        {
            get
            {
                return this.IsEnabledField;
            }
            set
            {
                this.IsEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long OperationUid
        {
            get
            {
                return this.OperationUidField;
            }
            set
            {
                this.OperationUidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaticResourceService.CalendarType Type
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
        public System.DateTime UpdateTime
        {
            get
            {
                return this.UpdateTimeField;
            }
            set
            {
                this.UpdateTimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalendarModel", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class CalendarModel : StaticResourceService.EditCalendarModel
    {
        
        private int CidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cid
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalendarType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.StaticResource")]
    public enum CalendarType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WorkingDay = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Playday = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Holiday = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalendarArg", Namespace="http://schemas.datacontract.org/2004/07/com.tgnet.api.wcf.Models")]
    public partial class CalendarArg : object
    {
        
        private System.Nullable<long> CidField;
        
        private System.Nullable<System.DateTime> DateField;
        
        private int LimitField;
        
        private int StartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> Cid
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
        public System.Nullable<System.DateTime> Date
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
        public int Limit
        {
            get
            {
                return this.LimitField;
            }
            set
            {
                this.LimitField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Start
        {
            get
            {
                return this.StartField;
            }
            set
            {
                this.StartField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StaticResourceService.IStaticResourceService")]
    public interface IStaticResourceService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/ContainFilterWord", ReplyAction="http://tempuri.org/IStaticResourceService/ContainFilterWordResponse")]
        System.Threading.Tasks.Task<bool> ContainFilterWordAsync(string text, StaticResourceService.FilterWordKinds[] kinds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAllAreaInfo", ReplyAction="http://tempuri.org/IStaticResourceService/GetAllAreaInfoResponse")]
        System.Threading.Tasks.Task<StaticResourceService.AreaInfo[]> GetAllAreaInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetRangeAreaInfo", ReplyAction="http://tempuri.org/IStaticResourceService/GetRangeAreaInfoResponse")]
        System.Threading.Tasks.Task<StaticResourceService.AreaInfo[]> GetRangeAreaInfoAsync(StaticResourceService.AreaType startType, StaticResourceService.AreaType endType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetRangeAreas", ReplyAction="http://tempuri.org/IStaticResourceService/GetRangeAreasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetRangeAreasErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetRangeAreasErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetRangeAreasAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.AreaType startType, StaticResourceService.AreaType endType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAreaNames", ReplyAction="http://tempuri.org/IStaticResourceService/GetAreaNamesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetAreaNamesAsync(string[] areaNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAreaFullNames", ReplyAction="http://tempuri.org/IStaticResourceService/GetAreaFullNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAreaFullNamesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAreaFullNamesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetAreaFullNamesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] areaNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetSubAreaNos", ReplyAction="http://tempuri.org/IStaticResourceService/GetSubAreaNosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetSubAreaNosErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetSubAreaNosErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string[]>> GetSubAreaNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] areaNos, StaticResourceService.AreaType startType, StaticResourceService.AreaType endType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetCompleteAreaInfos", ReplyAction="http://tempuri.org/IStaticResourceService/GetCompleteAreaInfosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetCompleteAreaInfosErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetCompleteAreaInfosErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.CompleteAreaInfo[]> GetCompleteAreaInfosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] areaNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAreaByAreaName", ReplyAction="http://tempuri.org/IStaticResourceService/GetAreaByAreaNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAreaByAreaNameErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAreaByAreaNameErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.AreaInfo> GetAreaByAreaNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, string province, string city, string town);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetMobileArea", ReplyAction="http://tempuri.org/IStaticResourceService/GetMobileAreaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetMobileAreaErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetMobileAreaErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.AreaInfo> GetMobileAreaAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetMobileAreaInfos", ReplyAction="http://tempuri.org/IStaticResourceService/GetMobileAreaInfosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetMobileAreaInfosErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetMobileAreaInfosErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.MobileAreaInfo[]> GetMobileAreaInfosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] mobiles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetIPArea", ReplyAction="http://tempuri.org/IStaticResourceService/GetIPAreaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetIPAreaErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetIPAreaErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.AreaInfo> GetIPAreaAsync(Tgnet.Api.OAuth2ClientIdentity identity, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/AddProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/AddProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/AddProductClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/AddProductClassErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> AddProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string parentClassNo, StaticResourceService.ProductClassTypes type, bool isEnabled, bool isDisplay, string[] classNames);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/SearchProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/SearchProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/SearchProductClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/SearchProductClassErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> SearchProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<bool> isEnabled, System.Nullable<bool> isDisplay, StaticResourceService.ProductClassTypes[] types, StaticResourceService.RangeOfNullableOfint5F2dSckg noLengthRange, string startWithNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetEqualProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/GetEqualProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetEqualProductClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetEqualProductClassErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string[]>> GetEqualProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] nos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetProductClassByNos", ReplyAction="http://tempuri.org/IStaticResourceService/GetProductClassByNosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetProductClassByNosErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetProductClassByNosErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> GetProductClassByNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] nos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/SearchCompleteInfoProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/SearchCompleteInfoProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/SearchCompleteInfoProductClassErrorCode" +
            "Fault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/SearchCompleteInfoProductClassErrorResp" +
            "onseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<StaticResourceService.ProductClassCompleteInfo>> SearchCompleteInfoProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string keyword, System.Nullable<bool> isEnabled, System.Nullable<bool> isDisplay, StaticResourceService.ProductClassTypes[] types, StaticResourceService.RangeOfNullableOfint5F2dSckg noLengthRange, string startWithNo, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetProductClassCompleteInfo", ReplyAction="http://tempuri.org/IStaticResourceService/GetProductClassCompleteInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetProductClassCompleteInfoErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetProductClassCompleteInfoErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ProductClassCompleteInfo> GetProductClassCompleteInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/UpdateProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/UpdateProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo, string name, bool isEnabled, bool isDisplay, StaticResourceService.ProductClassTypes type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/UpdateChildrenProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/UpdateChildrenProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/UpdateChildrenProductClassErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/UpdateChildrenProductClassErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateChildrenProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo, System.Nullable<bool> isEnabled, System.Nullable<bool> isDisplay);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/DeleteProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/DeleteProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/DeleteProductClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/DeleteProductClassErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/UpdateProductClassRelations", ReplyAction="http://tempuri.org/IStaticResourceService/UpdateProductClassRelationsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassRelationsErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassRelationsErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateProductClassRelationsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string classNo, System.Collections.Generic.Dictionary<string, bool> relations);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAllProjectTypes", ReplyAction="http://tempuri.org/IStaticResourceService/GetAllProjectTypesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAllProjectTypesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAllProjectTypesErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllProjectTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAllProjectKeymans", ReplyAction="http://tempuri.org/IStaticResourceService/GetAllProjectKeymansResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAllProjectKeymansErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAllProjectKeymansErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllProjectKeymansAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAllProjectStages", ReplyAction="http://tempuri.org/IStaticResourceService/GetAllProjectStagesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAllProjectStagesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAllProjectStagesErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllProjectStagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/UpdateProductClassProjectRelations", ReplyAction="http://tempuri.org/IStaticResourceService/UpdateProductClassProjectRelationsRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassProjectRelationsError" +
            "CodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassProjectRelationsError" +
            "ResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateProductClassProjectRelationsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string classNo, System.Collections.Generic.Dictionary<string, bool> stages, System.Collections.Generic.Dictionary<string, bool> types, System.Collections.Generic.Dictionary<string, bool> keymans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/UpdateProductClassRelationsExpand", ReplyAction="http://tempuri.org/IStaticResourceService/UpdateProductClassRelationsExpandRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassRelationsExpandErrorC" +
            "odeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/UpdateProductClassRelationsExpandErrorR" +
            "esponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateProductClassRelationsExpandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string classNo, StaticResourceService.ProductClassRelation[] relations);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAllOldProjectType", ReplyAction="http://tempuri.org/IStaticResourceService/GetAllOldProjectTypeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAllOldProjectTypeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAllOldProjectTypeErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllOldProjectTypeAsync(Tgnet.Api.OAuth2ClientIdentity identity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAllOldProjectStages", ReplyAction="http://tempuri.org/IStaticResourceService/GetAllOldProjectStagesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAllOldProjectStagesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAllOldProjectStagesErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllOldProjectStagesAsync(Tgnet.Api.OAuth2ClientIdentity identity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/ConvertOldProjectTypeToNew", ReplyAction="http://tempuri.org/IStaticResourceService/ConvertOldProjectTypeToNewResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/ConvertOldProjectTypeToNewErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/ConvertOldProjectTypeToNewErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string[]>> ConvertOldProjectTypeToNewAsync(string[] oldProjectTypeNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/ConvertNewProjectTypeToOld", ReplyAction="http://tempuri.org/IStaticResourceService/ConvertNewProjectTypeToOldResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/ConvertNewProjectTypeToOldErrorCodeFaul" +
            "t", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/ConvertNewProjectTypeToOldErrorResponse" +
            "TypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> ConvertNewProjectTypeToOldAsync(string[] newProjectTypeNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetBaseClassNames", ReplyAction="http://tempuri.org/IStaticResourceService/GetBaseClassNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetBaseClassNamesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetBaseClassNamesErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetBaseClassNamesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] classNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetBaseClasses", ReplyAction="http://tempuri.org/IStaticResourceService/GetBaseClassesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetBaseClassesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetBaseClassesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.BassClass[]> GetBaseClassesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] classNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/ConvertOldProjectStageToNew", ReplyAction="http://tempuri.org/IStaticResourceService/ConvertOldProjectStageToNewResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/ConvertOldProjectStageToNewErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/ConvertOldProjectStageToNewErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> ConvertOldProjectStageToNewAsync(Tgnet.Api.OAuth2ClientIdentity identity, int[] oldProjectStages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/ConvertNewProjectStageToOld", ReplyAction="http://tempuri.org/IStaticResourceService/ConvertNewProjectStageToOldResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/ConvertNewProjectStageToOldErrorCodeFau" +
            "lt", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/ConvertNewProjectStageToOldErrorRespons" +
            "eTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> ConvertNewProjectStageToOldAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] newProjectStageNos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/AddBrand", ReplyAction="http://tempuri.org/IStaticResourceService/AddBrandResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/AddBrandErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/AddBrandErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, StaticResourceService.BrandGrade grade, string remark, long creater);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/UpdateBrand", ReplyAction="http://tempuri.org/IStaticResourceService/UpdateBrandResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/UpdateBrandErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/UpdateBrandErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long id, StaticResourceService.BrandUpdateArgs args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/DeleteBrands", ReplyAction="http://tempuri.org/IStaticResourceService/DeleteBrandsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/DeleteBrandsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/DeleteBrandsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteBrandsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] bids, long admin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/SearchBrand", ReplyAction="http://tempuri.org/IStaticResourceService/SearchBrandResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/SearchBrandErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/SearchBrandErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<StaticResourceService.BrandInfo>> SearchBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, string brandName, System.Nullable<StaticResourceService.BrandGrade> grade, System.Nullable<bool> enabled, string classNo, int page, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetBrandsById", ReplyAction="http://tempuri.org/IStaticResourceService/GetBrandsByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetBrandsByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetBrandsByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.BrandInfo[]> GetBrandsByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] bids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetBrandsByName", ReplyAction="http://tempuri.org/IStaticResourceService/GetBrandsByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetBrandsByNameErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetBrandsByNameErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.BrandInfo[]> GetBrandsByNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] brandNames);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetBrandOfProductClass", ReplyAction="http://tempuri.org/IStaticResourceService/GetBrandOfProductClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetBrandOfProductClassErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetBrandOfProductClassErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.BrandInfo[]> GetBrandOfProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetProductClassOfBrand", ReplyAction="http://tempuri.org/IStaticResourceService/GetProductClassOfBrandResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetProductClassOfBrandErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetProductClassOfBrandErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> GetProductClassOfBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long bid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/SetBrandOfProductClassByName", ReplyAction="http://tempuri.org/IStaticResourceService/SetBrandOfProductClassByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/SetBrandOfProductClassByNameErrorCodeFa" +
            "ult", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/SetBrandOfProductClassByNameErrorRespon" +
            "seTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task SetBrandOfProductClassByNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo, string[] brandNames, StaticResourceService.BrandGrade grade, long creater);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/SetProductClassOfBrand", ReplyAction="http://tempuri.org/IStaticResourceService/SetProductClassOfBrandResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/SetProductClassOfBrandErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/SetProductClassOfBrandErrorResponseType" +
            "Fault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task SetProductClassOfBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long bid, string[] classNos, long creater);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAreaLocation", ReplyAction="http://tempuri.org/IStaticResourceService/GetAreaLocationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAreaLocationErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAreaLocationErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.AreaLocation> GetAreaLocationAsync(Tgnet.Api.OAuth2ClientIdentity identity, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetCommonClassInfo", ReplyAction="http://tempuri.org/IStaticResourceService/GetCommonClassInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetCommonClassInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetCommonClassInfoErrorResponseTypeFaul" +
            "t", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.CommonClassInfo> GetCommonClassInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.ClassKinds kind, System.Nullable<int> deep, string parent, string version);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/ConvertToNewest", ReplyAction="http://tempuri.org/IStaticResourceService/ConvertToNewestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/ConvertToNewestErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/ConvertToNewestErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<string[]> ConvertToNewestAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] oldNos, StaticResourceService.ClassKinds kind, string oldVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAddress", ReplyAction="http://tempuri.org/IStaticResourceService/GetAddressResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAddressErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAddressErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.Address> GetAddressAsync(Tgnet.Api.OAuth2ClientIdentity identity, double longitude, double latitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAddressWithAreaNo", ReplyAction="http://tempuri.org/IStaticResourceService/GetAddressWithAreaNoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAddressWithAreaNoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAddressWithAreaNoErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.AddressWithAreaNo> GetAddressWithAreaNoAsync(Tgnet.Api.OAuth2ClientIdentity identity, double longitude, double latitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetSimpleLocation", ReplyAction="http://tempuri.org/IStaticResourceService/GetSimpleLocationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetSimpleLocationErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetSimpleLocationErrorResponseTypeFault" +
            "", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.SimpleLocation> GetSimpleLocationAsync(Tgnet.Api.OAuth2ClientIdentity identity, string address, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetAreaInfoByAddress", ReplyAction="http://tempuri.org/IStaticResourceService/GetAreaInfoByAddressResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetAreaInfoByAddressErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetAreaInfoByAddressErrorResponseTypeFa" +
            "ult", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.LocationAreaInfo> GetAreaInfoByAddressAsync(Tgnet.Api.OAuth2ClientIdentity identity, string address, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/CreateShortUrl", ReplyAction="http://tempuri.org/IStaticResourceService/CreateShortUrlResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/CreateShortUrlErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/CreateShortUrlErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.ShortUrlModel> CreateShortUrlAsync(Tgnet.Api.OAuth2ClientIdentity identity, string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetTelCode", ReplyAction="http://tempuri.org/IStaticResourceService/GetTelCodeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetTelCodeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetTelCodeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        System.Threading.Tasks.Task<string> GetTelCodeAsync(string areaNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/AddOrUpdateCalendar", ReplyAction="http://tempuri.org/IStaticResourceService/AddOrUpdateCalendarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/AddOrUpdateCalendarErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/AddOrUpdateCalendarErrorResponseTypeFau" +
            "lt", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddOrUpdateCalendarAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.EditCalendarModel[] models);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetCalendarModel", ReplyAction="http://tempuri.org/IStaticResourceService/GetCalendarModelResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetCalendarModelErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetCalendarModelErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<StaticResourceService.CalendarModel>> GetCalendarModelAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.CalendarArg arg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaticResourceService/GetCalendarType", ReplyAction="http://tempuri.org/IStaticResourceService/GetCalendarTypeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IStaticResourceService/GetCalendarTypeErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(StaticResourceService.ErrorResponseType), Action="http://tempuri.org/IStaticResourceService/GetCalendarTypeErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<StaticResourceService.CalendarType> GetCalendarTypeAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IStaticResourceServiceChannel : StaticResourceService.IStaticResourceService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class StaticResourceServiceClient : System.ServiceModel.ClientBase<StaticResourceService.IStaticResourceService>, StaticResourceService.IStaticResourceService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StaticResourceServiceClient() : 
                base(StaticResourceServiceClient.GetDefaultBinding(), StaticResourceServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IStaticResourceService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaticResourceServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(StaticResourceServiceClient.GetBindingForEndpoint(endpointConfiguration), StaticResourceServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaticResourceServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StaticResourceServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaticResourceServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StaticResourceServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaticResourceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> ContainFilterWordAsync(string text, StaticResourceService.FilterWordKinds[] kinds)
        {
            return base.Channel.ContainFilterWordAsync(text, kinds);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.AreaInfo[]> GetAllAreaInfoAsync()
        {
            return base.Channel.GetAllAreaInfoAsync();
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.AreaInfo[]> GetRangeAreaInfoAsync(StaticResourceService.AreaType startType, StaticResourceService.AreaType endType)
        {
            return base.Channel.GetRangeAreaInfoAsync(startType, endType);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetRangeAreasAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.AreaType startType, StaticResourceService.AreaType endType)
        {
            return base.Channel.GetRangeAreasAsync(identity, startType, endType);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetAreaNamesAsync(string[] areaNos)
        {
            return base.Channel.GetAreaNamesAsync(areaNos);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetAreaFullNamesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] areaNos)
        {
            return base.Channel.GetAreaFullNamesAsync(identity, areaNos);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string[]>> GetSubAreaNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] areaNos, StaticResourceService.AreaType startType, StaticResourceService.AreaType endType)
        {
            return base.Channel.GetSubAreaNosAsync(identity, areaNos, startType, endType);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.CompleteAreaInfo[]> GetCompleteAreaInfosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] areaNos)
        {
            return base.Channel.GetCompleteAreaInfosAsync(identity, areaNos);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.AreaInfo> GetAreaByAreaNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, string province, string city, string town)
        {
            return base.Channel.GetAreaByAreaNameAsync(identity, province, city, town);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.AreaInfo> GetMobileAreaAsync(Tgnet.Api.OAuth2ClientIdentity identity, string mobile)
        {
            return base.Channel.GetMobileAreaAsync(identity, mobile);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.MobileAreaInfo[]> GetMobileAreaInfosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] mobiles)
        {
            return base.Channel.GetMobileAreaInfosAsync(identity, mobiles);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.AreaInfo> GetIPAreaAsync(Tgnet.Api.OAuth2ClientIdentity identity, string ip)
        {
            return base.Channel.GetIPAreaAsync(identity, ip);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> AddProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string parentClassNo, StaticResourceService.ProductClassTypes type, bool isEnabled, bool isDisplay, string[] classNames)
        {
            return base.Channel.AddProductClassAsync(identity, @operator, parentClassNo, type, isEnabled, isDisplay, classNames);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> SearchProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.Nullable<bool> isEnabled, System.Nullable<bool> isDisplay, StaticResourceService.ProductClassTypes[] types, StaticResourceService.RangeOfNullableOfint5F2dSckg noLengthRange, string startWithNo)
        {
            return base.Channel.SearchProductClassAsync(identity, isEnabled, isDisplay, types, noLengthRange, startWithNo);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string[]>> GetEqualProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] nos)
        {
            return base.Channel.GetEqualProductClassAsync(identity, nos);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> GetProductClassByNosAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] nos)
        {
            return base.Channel.GetProductClassByNosAsync(identity, nos);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<StaticResourceService.ProductClassCompleteInfo>> SearchCompleteInfoProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string keyword, System.Nullable<bool> isEnabled, System.Nullable<bool> isDisplay, StaticResourceService.ProductClassTypes[] types, StaticResourceService.RangeOfNullableOfint5F2dSckg noLengthRange, string startWithNo, int start, int limit)
        {
            return base.Channel.SearchCompleteInfoProductClassAsync(identity, keyword, isEnabled, isDisplay, types, noLengthRange, startWithNo, start, limit);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ProductClassCompleteInfo> GetProductClassCompleteInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo)
        {
            return base.Channel.GetProductClassCompleteInfoAsync(identity, classNo);
        }
        
        public System.Threading.Tasks.Task UpdateProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo, string name, bool isEnabled, bool isDisplay, StaticResourceService.ProductClassTypes type)
        {
            return base.Channel.UpdateProductClassAsync(identity, classNo, name, isEnabled, isDisplay, type);
        }
        
        public System.Threading.Tasks.Task UpdateChildrenProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo, System.Nullable<bool> isEnabled, System.Nullable<bool> isDisplay)
        {
            return base.Channel.UpdateChildrenProductClassAsync(identity, classNo, isEnabled, isDisplay);
        }
        
        public System.Threading.Tasks.Task DeleteProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo)
        {
            return base.Channel.DeleteProductClassAsync(identity, classNo);
        }
        
        public System.Threading.Tasks.Task UpdateProductClassRelationsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string classNo, System.Collections.Generic.Dictionary<string, bool> relations)
        {
            return base.Channel.UpdateProductClassRelationsAsync(identity, @operator, classNo, relations);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllProjectTypesAsync()
        {
            return base.Channel.GetAllProjectTypesAsync();
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllProjectKeymansAsync()
        {
            return base.Channel.GetAllProjectKeymansAsync();
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllProjectStagesAsync()
        {
            return base.Channel.GetAllProjectStagesAsync();
        }
        
        public System.Threading.Tasks.Task UpdateProductClassProjectRelationsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string classNo, System.Collections.Generic.Dictionary<string, bool> stages, System.Collections.Generic.Dictionary<string, bool> types, System.Collections.Generic.Dictionary<string, bool> keymans)
        {
            return base.Channel.UpdateProductClassProjectRelationsAsync(identity, @operator, classNo, stages, types, keymans);
        }
        
        public System.Threading.Tasks.Task UpdateProductClassRelationsExpandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long @operator, string classNo, StaticResourceService.ProductClassRelation[] relations)
        {
            return base.Channel.UpdateProductClassRelationsExpandAsync(identity, @operator, classNo, relations);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllOldProjectTypeAsync(Tgnet.Api.OAuth2ClientIdentity identity)
        {
            return base.Channel.GetAllOldProjectTypeAsync(identity);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ClassInfo[]> GetAllOldProjectStagesAsync(Tgnet.Api.OAuth2ClientIdentity identity)
        {
            return base.Channel.GetAllOldProjectStagesAsync(identity);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string[]>> ConvertOldProjectTypeToNewAsync(string[] oldProjectTypeNos)
        {
            return base.Channel.ConvertOldProjectTypeToNewAsync(oldProjectTypeNos);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> ConvertNewProjectTypeToOldAsync(string[] newProjectTypeNos)
        {
            return base.Channel.ConvertNewProjectTypeToOldAsync(newProjectTypeNos);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetBaseClassNamesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] classNos)
        {
            return base.Channel.GetBaseClassNamesAsync(identity, classNos);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.BassClass[]> GetBaseClassesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] classNos)
        {
            return base.Channel.GetBaseClassesAsync(identity, classNos);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> ConvertOldProjectStageToNewAsync(Tgnet.Api.OAuth2ClientIdentity identity, int[] oldProjectStages)
        {
            return base.Channel.ConvertOldProjectStageToNewAsync(identity, oldProjectStages);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> ConvertNewProjectStageToOldAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] newProjectStageNos)
        {
            return base.Channel.ConvertNewProjectStageToOldAsync(identity, newProjectStageNos);
        }
        
        public System.Threading.Tasks.Task AddBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, string name, StaticResourceService.BrandGrade grade, string remark, long creater)
        {
            return base.Channel.AddBrandAsync(identity, name, grade, remark, creater);
        }
        
        public System.Threading.Tasks.Task UpdateBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long id, StaticResourceService.BrandUpdateArgs args)
        {
            return base.Channel.UpdateBrandAsync(identity, id, args);
        }
        
        public System.Threading.Tasks.Task DeleteBrandsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] bids, long admin)
        {
            return base.Channel.DeleteBrandsAsync(identity, bids, admin);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<StaticResourceService.BrandInfo>> SearchBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, string brandName, System.Nullable<StaticResourceService.BrandGrade> grade, System.Nullable<bool> enabled, string classNo, int page, int pageSize)
        {
            return base.Channel.SearchBrandAsync(identity, brandName, grade, enabled, classNo, page, pageSize);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.BrandInfo[]> GetBrandsByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] bids)
        {
            return base.Channel.GetBrandsByIdAsync(identity, bids);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.BrandInfo[]> GetBrandsByNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] brandNames)
        {
            return base.Channel.GetBrandsByNameAsync(identity, brandNames);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.BrandInfo[]> GetBrandOfProductClassAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo)
        {
            return base.Channel.GetBrandOfProductClassAsync(identity, classNo);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ProductClassInfo[]> GetProductClassOfBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long bid)
        {
            return base.Channel.GetProductClassOfBrandAsync(identity, bid);
        }
        
        public System.Threading.Tasks.Task SetBrandOfProductClassByNameAsync(Tgnet.Api.OAuth2ClientIdentity identity, string classNo, string[] brandNames, StaticResourceService.BrandGrade grade, long creater)
        {
            return base.Channel.SetBrandOfProductClassByNameAsync(identity, classNo, brandNames, grade, creater);
        }
        
        public System.Threading.Tasks.Task SetProductClassOfBrandAsync(Tgnet.Api.OAuth2ClientIdentity identity, long bid, string[] classNos, long creater)
        {
            return base.Channel.SetProductClassOfBrandAsync(identity, bid, classNos, creater);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.AreaLocation> GetAreaLocationAsync(Tgnet.Api.OAuth2ClientIdentity identity, string ip)
        {
            return base.Channel.GetAreaLocationAsync(identity, ip);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.CommonClassInfo> GetCommonClassInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.ClassKinds kind, System.Nullable<int> deep, string parent, string version)
        {
            return base.Channel.GetCommonClassInfoAsync(identity, kind, deep, parent, version);
        }
        
        public System.Threading.Tasks.Task<string[]> ConvertToNewestAsync(Tgnet.Api.OAuth2ClientIdentity identity, string[] oldNos, StaticResourceService.ClassKinds kind, string oldVersion)
        {
            return base.Channel.ConvertToNewestAsync(identity, oldNos, kind, oldVersion);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.Address> GetAddressAsync(Tgnet.Api.OAuth2ClientIdentity identity, double longitude, double latitude)
        {
            return base.Channel.GetAddressAsync(identity, longitude, latitude);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.AddressWithAreaNo> GetAddressWithAreaNoAsync(Tgnet.Api.OAuth2ClientIdentity identity, double longitude, double latitude)
        {
            return base.Channel.GetAddressWithAreaNoAsync(identity, longitude, latitude);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.SimpleLocation> GetSimpleLocationAsync(Tgnet.Api.OAuth2ClientIdentity identity, string address, string city)
        {
            return base.Channel.GetSimpleLocationAsync(identity, address, city);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.LocationAreaInfo> GetAreaInfoByAddressAsync(Tgnet.Api.OAuth2ClientIdentity identity, string address, string city)
        {
            return base.Channel.GetAreaInfoByAddressAsync(identity, address, city);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.ShortUrlModel> CreateShortUrlAsync(Tgnet.Api.OAuth2ClientIdentity identity, string url)
        {
            return base.Channel.CreateShortUrlAsync(identity, url);
        }
        
        public System.Threading.Tasks.Task<string> GetTelCodeAsync(string areaNo)
        {
            return base.Channel.GetTelCodeAsync(areaNo);
        }
        
        public System.Threading.Tasks.Task AddOrUpdateCalendarAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.EditCalendarModel[] models)
        {
            return base.Channel.AddOrUpdateCalendarAsync(identity, models);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<StaticResourceService.CalendarModel>> GetCalendarModelAsync(Tgnet.Api.OAuth2ClientIdentity identity, StaticResourceService.CalendarArg arg)
        {
            return base.Channel.GetCalendarModelAsync(identity, arg);
        }
        
        public System.Threading.Tasks.Task<StaticResourceService.CalendarType> GetCalendarTypeAsync(Tgnet.Api.OAuth2ClientIdentity identity, System.DateTime date)
        {
            return base.Channel.GetCalendarTypeAsync(identity, date);
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
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IStaticResourceService))
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
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IStaticResourceService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.tgnet.com:18061/Services/StaticResourceService.svc/StaticResource");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return StaticResourceServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IStaticResourceService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return StaticResourceServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IStaticResourceService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IStaticResourceService,
        }
    }
}
