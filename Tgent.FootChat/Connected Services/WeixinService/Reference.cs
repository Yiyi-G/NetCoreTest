//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace WeixinService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JsConfig", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class JsConfig : object
    {
        
        private string AppIdField;
        
        private string NonceStrField;
        
        private string SignatureField;
        
        private string TimestampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AppId
        {
            get
            {
                return this.AppIdField;
            }
            set
            {
                this.AppIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NonceStr
        {
            get
            {
                return this.NonceStrField;
            }
            set
            {
                this.NonceStrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Signature
        {
            get
            {
                return this.SignatureField;
            }
            set
            {
                this.SignatureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RangeOfNullableOfdateTime5F2dSckg", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Data")]
    public partial class RangeOfNullableOfdateTime5F2dSckg : object
    {
        
        private bool _IsCanComparableField;
        
        private bool _IsEqualsField;
        
        private System.Nullable<System.DateTime> _MaxField;
        
        private System.Nullable<System.DateTime> _MinField;
        
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TrainOrderType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.BusinessTrain")]
    public enum TrainOrderType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NewCreated = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        StartTime_DESC = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.BusinessTrain")]
    public enum ActivityType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectTrain = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        YWQTrain = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProjectVideoTrain = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BusinessTrain", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class BusinessTrain : object
    {
        
        private long ActIdField;
        
        private WeixinService.ActivityType ActivityTypeField;
        
        private string ArticleLinkField;
        
        private string ArticleSubTitleField;
        
        private string ArticleTitleField;
        
        private string ContentField;
        
        private string CoverImageField;
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private string DescriptionField;
        
        private System.Nullable<System.DateTime> EndTimeField;
        
        private string FileField;
        
        private System.Nullable<WeixinService.TrainFileType> FileTypeField;
        
        private bool IsOnlineField;
        
        private bool IsTopicField;
        
        private int JoinCountField;
        
        private string JumpLinkField;
        
        private string LecturerField;
        
        private string ListImageField;
        
        private System.Nullable<decimal> PriceField;
        
        private System.Nullable<System.DateTime> StartTimeField;
        
        private string SwfField;
        
        private System.Nullable<int> TimeCountField;
        
        private string TitleField;
        
        private System.Nullable<int> TotalPeriodsField;
        
        private System.Nullable<int> UpdatePeriodsField;
        
        private string VideoUrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ActId
        {
            get
            {
                return this.ActIdField;
            }
            set
            {
                this.ActIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.ActivityType ActivityType
        {
            get
            {
                return this.ActivityTypeField;
            }
            set
            {
                this.ActivityTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArticleLink
        {
            get
            {
                return this.ArticleLinkField;
            }
            set
            {
                this.ArticleLinkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArticleSubTitle
        {
            get
            {
                return this.ArticleSubTitleField;
            }
            set
            {
                this.ArticleSubTitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArticleTitle
        {
            get
            {
                return this.ArticleTitleField;
            }
            set
            {
                this.ArticleTitleField = value;
            }
        }
        
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
        public string CoverImage
        {
            get
            {
                return this.CoverImageField;
            }
            set
            {
                this.CoverImageField = value;
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
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EndTime
        {
            get
            {
                return this.EndTimeField;
            }
            set
            {
                this.EndTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<WeixinService.TrainFileType> FileType
        {
            get
            {
                return this.FileTypeField;
            }
            set
            {
                this.FileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOnline
        {
            get
            {
                return this.IsOnlineField;
            }
            set
            {
                this.IsOnlineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsTopic
        {
            get
            {
                return this.IsTopicField;
            }
            set
            {
                this.IsTopicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JoinCount
        {
            get
            {
                return this.JoinCountField;
            }
            set
            {
                this.JoinCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JumpLink
        {
            get
            {
                return this.JumpLinkField;
            }
            set
            {
                this.JumpLinkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lecturer
        {
            get
            {
                return this.LecturerField;
            }
            set
            {
                this.LecturerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ListImage
        {
            get
            {
                return this.ListImageField;
            }
            set
            {
                this.ListImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> StartTime
        {
            get
            {
                return this.StartTimeField;
            }
            set
            {
                this.StartTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Swf
        {
            get
            {
                return this.SwfField;
            }
            set
            {
                this.SwfField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TimeCount
        {
            get
            {
                return this.TimeCountField;
            }
            set
            {
                this.TimeCountField = value;
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
        public System.Nullable<int> TotalPeriods
        {
            get
            {
                return this.TotalPeriodsField;
            }
            set
            {
                this.TotalPeriodsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UpdatePeriods
        {
            get
            {
                return this.UpdatePeriodsField;
            }
            set
            {
                this.UpdatePeriodsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VideoUrl
        {
            get
            {
                return this.VideoUrlField;
            }
            set
            {
                this.VideoUrlField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TrainFileType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.BusinessTrain")]
    public enum TrainFileType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Audio = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Video = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EditBussinessTrainArgs", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.BusinessTrain")]
    public partial class EditBussinessTrainArgs : object
    {
        
        private string ArticleSubTitleField;
        
        private string ArticleTitleField;
        
        private bool IsTopicField;
        
        private string JumpLinkField;
        
        private System.Nullable<decimal> PriceField;
        
        private System.Nullable<int> TimeCountField;
        
        private System.Nullable<int> TotalPeriodsField;
        
        private System.Nullable<int> UpdatePeriodsField;
        
        private long actIdField;
        
        private WeixinService.ActivityType activityTypeField;
        
        private string articleLinkField;
        
        private string contentField;
        
        private string coverImageField;
        
        private System.Nullable<long> createrField;
        
        private string descriptionField;
        
        private System.Nullable<System.DateTime> endTimeField;
        
        private string fileField;
        
        private System.Nullable<WeixinService.TrainFileType> fileTypeField;
        
        private System.Nullable<bool> isOnlineField;
        
        private System.Nullable<int> joinCountField;
        
        private string lecturerField;
        
        private string listImageField;
        
        private System.Nullable<System.DateTime> startTimeField;
        
        private string swfField;
        
        private string titleField;
        
        private System.Nullable<long> updaterField;
        
        private string videoUrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArticleSubTitle
        {
            get
            {
                return this.ArticleSubTitleField;
            }
            set
            {
                this.ArticleSubTitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArticleTitle
        {
            get
            {
                return this.ArticleTitleField;
            }
            set
            {
                this.ArticleTitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsTopic
        {
            get
            {
                return this.IsTopicField;
            }
            set
            {
                this.IsTopicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JumpLink
        {
            get
            {
                return this.JumpLinkField;
            }
            set
            {
                this.JumpLinkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TimeCount
        {
            get
            {
                return this.TimeCountField;
            }
            set
            {
                this.TimeCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TotalPeriods
        {
            get
            {
                return this.TotalPeriodsField;
            }
            set
            {
                this.TotalPeriodsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UpdatePeriods
        {
            get
            {
                return this.UpdatePeriodsField;
            }
            set
            {
                this.UpdatePeriodsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long actId
        {
            get
            {
                return this.actIdField;
            }
            set
            {
                this.actIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.ActivityType activityType
        {
            get
            {
                return this.activityTypeField;
            }
            set
            {
                this.activityTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string articleLink
        {
            get
            {
                return this.articleLinkField;
            }
            set
            {
                this.articleLinkField = value;
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
        public string coverImage
        {
            get
            {
                return this.coverImageField;
            }
            set
            {
                this.coverImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> creater
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
        public System.Nullable<System.DateTime> endTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<WeixinService.TrainFileType> fileType
        {
            get
            {
                return this.fileTypeField;
            }
            set
            {
                this.fileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isOnline
        {
            get
            {
                return this.isOnlineField;
            }
            set
            {
                this.isOnlineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> joinCount
        {
            get
            {
                return this.joinCountField;
            }
            set
            {
                this.joinCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lecturer
        {
            get
            {
                return this.lecturerField;
            }
            set
            {
                this.lecturerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string listImage
        {
            get
            {
                return this.listImageField;
            }
            set
            {
                this.listImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> startTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string swf
        {
            get
            {
                return this.swfField;
            }
            set
            {
                this.swfField = value;
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
        public System.Nullable<long> updater
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string videoUrl
        {
            get
            {
                return this.videoUrlField;
            }
            set
            {
                this.videoUrlField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AcceptMessageType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.AutoReply")]
    public enum AcceptMessageType : byte
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
        Shortvideo = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Location = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Link = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Event = 8,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReplyEventType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.AutoReply")]
    public enum ReplyEventType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DefaultAutoReply = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Subscribe = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unsubscribe = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Click = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VIEW = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scancode_push = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scancode_waitmsg = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pic_sysphoto = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pic_photo_or_album = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pic_weixin = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Location_select = 11,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResourceType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin")]
    public enum ResourceType : byte
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Text = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Picture = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PicAndText = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Voice = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Music = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Video = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Template = 7,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReplyKeywordModel", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.AutoReply")]
    public partial class ReplyKeywordModel : object
    {
        
        private System.Nullable<WeixinService.AcceptMessageType> AcceptMessageTypeField;
        
        private string AppidField;
        
        private long CreaterField;
        
        private System.Nullable<WeixinService.ReplyEventType> EventTypeField;
        
        private long IdField;
        
        private System.Nullable<bool> IsActiveField;
        
        private string KeywordsField;
        
        private System.Nullable<WeixinService.ResourceType> MsgTypeField;
        
        private WeixinService.ResourceModel[] ResourceModelsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<WeixinService.AcceptMessageType> AcceptMessageType
        {
            get
            {
                return this.AcceptMessageTypeField;
            }
            set
            {
                this.AcceptMessageTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Appid
        {
            get
            {
                return this.AppidField;
            }
            set
            {
                this.AppidField = value;
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
        public System.Nullable<WeixinService.ReplyEventType> EventType
        {
            get
            {
                return this.EventTypeField;
            }
            set
            {
                this.EventTypeField = value;
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
        public System.Nullable<bool> IsActive
        {
            get
            {
                return this.IsActiveField;
            }
            set
            {
                this.IsActiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Keywords
        {
            get
            {
                return this.KeywordsField;
            }
            set
            {
                this.KeywordsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<WeixinService.ResourceType> MsgType
        {
            get
            {
                return this.MsgTypeField;
            }
            set
            {
                this.MsgTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.ResourceModel[] ResourceModels
        {
            get
            {
                return this.ResourceModelsField;
            }
            set
            {
                this.ResourceModelsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResourceModel", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Resource")]
    public partial class ResourceModel : object
    {
        
        private string AppidField;
        
        private string CoverImageField;
        
        private System.Nullable<System.DateTime> CreatedField;
        
        private System.Nullable<long> CreaterField;
        
        private string DescriptionField;
        
        private long IdField;
        
        private string MediaIdField;
        
        private string MediaIdURLField;
        
        private string TitleField;
        
        private System.Nullable<WeixinService.ResourceType> TypeField;
        
        private string UrlField;
        
        private System.Nullable<int> WeightField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Appid
        {
            get
            {
                return this.AppidField;
            }
            set
            {
                this.AppidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoverImage
        {
            get
            {
                return this.CoverImageField;
            }
            set
            {
                this.CoverImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Created
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
        public System.Nullable<long> Creater
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
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
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
        public string MediaId
        {
            get
            {
                return this.MediaIdField;
            }
            set
            {
                this.MediaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MediaIdURL
        {
            get
            {
                return this.MediaIdURLField;
            }
            set
            {
                this.MediaIdURLField = value;
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
        public System.Nullable<WeixinService.ResourceType> Type
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
        public string Url
        {
            get
            {
                return this.UrlField;
            }
            set
            {
                this.UrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Weight
        {
            get
            {
                return this.WeightField;
            }
            set
            {
                this.WeightField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OfficialAccountModel", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class OfficialAccountModel : object
    {
        
        private string AppidField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Appid
        {
            get
            {
                return this.AppidField;
            }
            set
            {
                this.AppidField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityFile", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class ActivityFile : object
    {
        
        private long ActIdField;
        
        private System.DateTime CreatedField;
        
        private long CreaterField;
        
        private string FidField;
        
        private long IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ActId
        {
            get
            {
                return this.ActIdField;
            }
            set
            {
                this.ActIdField = value;
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
        public string Fid
        {
            get
            {
                return this.FidField;
            }
            set
            {
                this.FidField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TemplateMessageRequest", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class TemplateMessageRequest : object
    {
        
        private string AliasField;
        
        private string AppIdField;
        
        private System.Collections.Generic.Dictionary<string, WeixinService.TemplateMessageModelDataValue> DatasField;
        
        private string[] OpenIdsField;
        
        private WeixinService.TemplateMessageModelMiniProgram ProgramField;
        
        private string TemplateIdField;
        
        private long[] UidsField;
        
        private string UrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Alias
        {
            get
            {
                return this.AliasField;
            }
            set
            {
                this.AliasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AppId
        {
            get
            {
                return this.AppIdField;
            }
            set
            {
                this.AppIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, WeixinService.TemplateMessageModelDataValue> Datas
        {
            get
            {
                return this.DatasField;
            }
            set
            {
                this.DatasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] OpenIds
        {
            get
            {
                return this.OpenIdsField;
            }
            set
            {
                this.OpenIdsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.TemplateMessageModelMiniProgram Program
        {
            get
            {
                return this.ProgramField;
            }
            set
            {
                this.ProgramField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TemplateId
        {
            get
            {
                return this.TemplateIdField;
            }
            set
            {
                this.TemplateIdField = value;
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
        public string Url
        {
            get
            {
                return this.UrlField;
            }
            set
            {
                this.UrlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TemplateMessageModel.MiniProgram", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Models")]
    public partial class TemplateMessageModelMiniProgram : object
    {
        
        private string AppIdField;
        
        private string PagePathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AppId
        {
            get
            {
                return this.AppIdField;
            }
            set
            {
                this.AppIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PagePath
        {
            get
            {
                return this.PagePathField;
            }
            set
            {
                this.PagePathField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TemplateMessageModel.DataValue", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Models")]
    public partial class TemplateMessageModelDataValue : object
    {
        
        private string ColorField;
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color
        {
            get
            {
                return this.ColorField;
            }
            set
            {
                this.ColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WXUser", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class WXUser : object
    {
        
        private string AreaNoField;
        
        private string HeadImgUrlField;
        
        private bool IsNotifyCustomizationField;
        
        private string NicknameField;
        
        private string OpenIdField;
        
        private bool SubscribeField;
        
        private long TgUidField;
        
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
        public string HeadImgUrl
        {
            get
            {
                return this.HeadImgUrlField;
            }
            set
            {
                this.HeadImgUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsNotifyCustomization
        {
            get
            {
                return this.IsNotifyCustomizationField;
            }
            set
            {
                this.IsNotifyCustomizationField = value;
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
        public string OpenId
        {
            get
            {
                return this.OpenIdField;
            }
            set
            {
                this.OpenIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Subscribe
        {
            get
            {
                return this.SubscribeField;
            }
            set
            {
                this.SubscribeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long TgUid
        {
            get
            {
                return this.TgUidField;
            }
            set
            {
                this.TgUidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateUserNotifyArgs", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class UpdateUserNotifyArgs : object
    {
        
        private System.Nullable<bool> isNotifyCustomizationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> isNotifyCustomization
        {
            get
            {
                return this.isNotifyCustomizationField;
            }
            set
            {
                this.isNotifyCustomizationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountBindingResult", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class AccountBindingResult : object
    {
        
        private Tgnet.Api.ErrorCode ErrorCodeField;
        
        private string ExistNickNameField;
        
        private bool IsExistField;
        
        private bool IsSucceedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Tgnet.Api.ErrorCode ErrorCode
        {
            get
            {
                return this.ErrorCodeField;
            }
            set
            {
                this.ErrorCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExistNickName
        {
            get
            {
                return this.ExistNickNameField;
            }
            set
            {
                this.ExistNickNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsExist
        {
            get
            {
                return this.IsExistField;
            }
            set
            {
                this.IsExistField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSucceed
        {
            get
            {
                return this.IsSucceedField;
            }
            set
            {
                this.IsSucceedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Menu", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Menu")]
    public partial class Menu : object
    {
        
        private WeixinService.ConditionalMenu[] conditionalmenuField;
        
        private WeixinService.SelfMenu menuField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.ConditionalMenu[] conditionalmenu
        {
            get
            {
                return this.conditionalmenuField;
            }
            set
            {
                this.conditionalmenuField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.SelfMenu menu
        {
            get
            {
                return this.menuField;
            }
            set
            {
                this.menuField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelfMenu", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Menu")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WeixinService.ConditionalMenu))]
    public partial class SelfMenu : object
    {
        
        private WeixinService.MenuItem[] buttonField;
        
        private string menuidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.MenuItem[] button
        {
            get
            {
                return this.buttonField;
            }
            set
            {
                this.buttonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string menuid
        {
            get
            {
                return this.menuidField;
            }
            set
            {
                this.menuidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConditionalMenu", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Menu")]
    public partial class ConditionalMenu : WeixinService.SelfMenu
    {
        
        private WeixinService.Matchrule matchruleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.Matchrule matchrule
        {
            get
            {
                return this.matchruleField;
            }
            set
            {
                this.matchruleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MenuItem", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Menu")]
    public partial class MenuItem : object
    {
        
        private string appidField;
        
        private string descriptionField;
        
        private string keyField;
        
        private string media_idField;
        
        private string nameField;
        
        private string pagepathField;
        
        private System.Nullable<long> ridField;
        
        private WeixinService.MenuItem[] sub_buttonField;
        
        private string typeField;
        
        private string urlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string appid
        {
            get
            {
                return this.appidField;
            }
            set
            {
                this.appidField = value;
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
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
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
        public string pagepath
        {
            get
            {
                return this.pagepathField;
            }
            set
            {
                this.pagepathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> rid
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
        public WeixinService.MenuItem[] sub_button
        {
            get
            {
                return this.sub_buttonField;
            }
            set
            {
                this.sub_buttonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Matchrule", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Menu")]
    public partial class Matchrule : object
    {
        
        private string cityField;
        
        private string client_platform_typeField;
        
        private string countryField;
        
        private string group_idField;
        
        private string provinceField;
        
        private string sexField;
        
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
        public string client_platform_type
        {
            get
            {
                return this.client_platform_typeField;
            }
            set
            {
                this.client_platform_typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string group_id
        {
            get
            {
                return this.group_idField;
            }
            set
            {
                this.group_idField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeixinResponse", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WeixinService.WXMemuResponse))]
    public partial class WeixinResponse : object
    {
        
        private string errcodeField;
        
        private string errmsgField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string errcode
        {
            get
            {
                return this.errcodeField;
            }
            set
            {
                this.errcodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string errmsg
        {
            get
            {
                return this.errmsgField;
            }
            set
            {
                this.errmsgField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WXMemuResponse", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Weixin.Menu")]
    public partial class WXMemuResponse : WeixinService.WeixinResponse
    {
        
        private string menuidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string menuid
        {
            get
            {
                return this.menuidField;
            }
            set
            {
                this.menuidField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WXTempleMessageEditRequest", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WeixinService.WXTempleMessageResponse))]
    public partial class WXTempleMessageEditRequest : object
    {
        
        private long createrField;
        
        private System.Collections.Generic.Dictionary<string, WeixinService.TemplateMessageModelDataValue> datasField;
        
        private System.DateTime delayField;
        
        private WeixinService.TemplateMessageModelMiniProgram miniprogramField;
        
        private bool onlyRegisterField;
        
        private long tidField;
        
        private long[] uidsField;
        
        private string urlField;
        
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
        public System.Collections.Generic.Dictionary<string, WeixinService.TemplateMessageModelDataValue> datas
        {
            get
            {
                return this.datasField;
            }
            set
            {
                this.datasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime delay
        {
            get
            {
                return this.delayField;
            }
            set
            {
                this.delayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeixinService.TemplateMessageModelMiniProgram miniprogram
        {
            get
            {
                return this.miniprogramField;
            }
            set
            {
                this.miniprogramField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool onlyRegister
        {
            get
            {
                return this.onlyRegisterField;
            }
            set
            {
                this.onlyRegisterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long tid
        {
            get
            {
                return this.tidField;
            }
            set
            {
                this.tidField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WXTempleMessageResponse", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class WXTempleMessageResponse : WeixinService.WXTempleMessageEditRequest
    {
        
        private string appIdField;
        
        private System.DateTime createdField;
        
        private System.Nullable<System.DateTime> finishDateField;
        
        private bool isEnabledField;
        
        private long mgidField;
        
        private int sendCountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string appId
        {
            get
            {
                return this.appIdField;
            }
            set
            {
                this.appIdField = value;
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
        public System.Nullable<System.DateTime> finishDate
        {
            get
            {
                return this.finishDateField;
            }
            set
            {
                this.finishDateField = value;
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
        public long mgid
        {
            get
            {
                return this.mgidField;
            }
            set
            {
                this.mgidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sendCount
        {
            get
            {
                return this.sendCountField;
            }
            set
            {
                this.sendCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TempleModel", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class TempleModel : object
    {
        
        private string appIdField;
        
        private string contentField;
        
        private string deputy_industryField;
        
        private string primary_industryField;
        
        private string template_idField;
        
        private long tidField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string appId
        {
            get
            {
                return this.appIdField;
            }
            set
            {
                this.appIdField = value;
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
        public string deputy_industry
        {
            get
            {
                return this.deputy_industryField;
            }
            set
            {
                this.deputy_industryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string primary_industry
        {
            get
            {
                return this.primary_industryField;
            }
            set
            {
                this.primary_industryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string template_id
        {
            get
            {
                return this.template_idField;
            }
            set
            {
                this.template_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long tid
        {
            get
            {
                return this.tidField;
            }
            set
            {
                this.tidField = value;
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QQUser", Namespace="http://schemas.datacontract.org/2004/07/api.weixin.tgnet.com.wcf.Models")]
    public partial class QQUser : object
    {
        
        private string appIdField;
        
        private string areaNoField;
        
        private System.Nullable<System.DateTime> createdField;
        
        private string headImgUrlField;
        
        private System.Nullable<System.DateTime> last_msg_dateField;
        
        private string nicknameField;
        
        private string openIdField;
        
        private System.Nullable<long> tg_uidField;
        
        private string unionIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string appId
        {
            get
            {
                return this.appIdField;
            }
            set
            {
                this.appIdField = value;
            }
        }
        
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
        public string headImgUrl
        {
            get
            {
                return this.headImgUrlField;
            }
            set
            {
                this.headImgUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> last_msg_date
        {
            get
            {
                return this.last_msg_dateField;
            }
            set
            {
                this.last_msg_dateField = value;
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
        public System.Nullable<long> tg_uid
        {
            get
            {
                return this.tg_uidField;
            }
            set
            {
                this.tg_uidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unionID
        {
            get
            {
                return this.unionIDField;
            }
            set
            {
                this.unionIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeixinService.IWeixinService")]
    public interface IWeixinService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetJsConfig", ReplyAction="http://tempuri.org/IWeixinService/GetJsConfigResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetJsConfigErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetJsConfigErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.JsConfig> GetJsConfigAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId, string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/SearchBusinessTrains", ReplyAction="http://tempuri.org/IWeixinService/SearchBusinessTrainsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/SearchBusinessTrainsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/SearchBusinessTrainsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.BusinessTrain>> SearchBusinessTrainsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string title, WeixinService.RangeOfNullableOfdateTime5F2dSckg timeRange, System.Nullable<long> creater, WeixinService.TrainOrderType orderType, WeixinService.ActivityType trainType, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetBusinessTrainByActId", ReplyAction="http://tempuri.org/IWeixinService/GetBusinessTrainByActIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetBusinessTrainByActIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetBusinessTrainByActIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.BusinessTrain> GetBusinessTrainByActIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AddBusinessTrain", ReplyAction="http://tempuri.org/IWeixinService/AddBusinessTrainResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AddBusinessTrainErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AddBusinessTrainErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddBusinessTrainAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.EditBussinessTrainArgs args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UpdateBusinessTrain", ReplyAction="http://tempuri.org/IWeixinService/UpdateBusinessTrainResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UpdateBusinessTrainErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UpdateBusinessTrainErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateBusinessTrainAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.EditBussinessTrainArgs args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetTrailTotalCount", ReplyAction="http://tempuri.org/IWeixinService/GetTrailTotalCountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetTrailTotalCountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetTrailTotalCountErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<int> GetTrailTotalCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.ActivityType trainType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetNewTrailCount", ReplyAction="http://tempuri.org/IWeixinService/GetNewTrailCountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetNewTrailCountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetNewTrailCountErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<int> GetNewTrailCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.RangeOfNullableOfdateTime5F2dSckg created, WeixinService.RangeOfNullableOfdateTime5F2dSckg startTime, WeixinService.RangeOfNullableOfdateTime5F2dSckg endTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetBusinessTrains", ReplyAction="http://tempuri.org/IWeixinService/GetBusinessTrainsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetBusinessTrainsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetBusinessTrainsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.BusinessTrain>> GetBusinessTrainsAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.RangeOfNullableOfdateTime5F2dSckg created, WeixinService.RangeOfNullableOfdateTime5F2dSckg startTime, WeixinService.RangeOfNullableOfdateTime5F2dSckg endTime, System.Nullable<bool> isOnline, WeixinService.ActivityType trainType, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/DeleteTrainsByIds", ReplyAction="http://tempuri.org/IWeixinService/DeleteTrainsByIdsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/DeleteTrainsByIdsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/DeleteTrainsByIdsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteTrainsByIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] Ids, long update);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/SearchAutoReply", ReplyAction="http://tempuri.org/IWeixinService/SearchAutoReplyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/SearchAutoReplyErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/SearchAutoReplyErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ReplyKeywordModel>> SearchAutoReplyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string keyword, System.Nullable<bool> isActive, WeixinService.AcceptMessageType[] acceptMsgTypes, WeixinService.ReplyEventType[] eventTypes, WeixinService.ResourceType[] msgTypes, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/SearchAutoReplyBykw", ReplyAction="http://tempuri.org/IWeixinService/SearchAutoReplyBykwResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/SearchAutoReplyBykwErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/SearchAutoReplyBykwErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ReplyKeywordModel>> SearchAutoReplyBykwAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string[] keywords, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetAutoReplyById", ReplyAction="http://tempuri.org/IWeixinService/GetAutoReplyByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetAutoReplyByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetAutoReplyByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.ReplyKeywordModel> GetAutoReplyByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/DeleteAutoReplyByIds", ReplyAction="http://tempuri.org/IWeixinService/DeleteAutoReplyByIdsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/DeleteAutoReplyByIdsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/DeleteAutoReplyByIdsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteAutoReplyByIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] Ids, long admin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UpdateAutoReplyKeyword", ReplyAction="http://tempuri.org/IWeixinService/UpdateAutoReplyKeywordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UpdateAutoReplyKeywordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UpdateAutoReplyKeywordErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateAutoReplyKeywordAsync(Tgnet.Api.OAuth2ClientIdentity identity, long rid, long update, WeixinService.ReplyKeywordModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AddAutoReplyKeyword", ReplyAction="http://tempuri.org/IWeixinService/AddAutoReplyKeywordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AddAutoReplyKeywordErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AddAutoReplyKeywordErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddAutoReplyKeywordAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.ReplyKeywordModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/SearchResources", ReplyAction="http://tempuri.org/IWeixinService/SearchResourcesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/SearchResourcesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/SearchResourcesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ResourceModel>> SearchResourcesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string keyword, WeixinService.ResourceType[] types, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/SearchResourcesByMidiaId", ReplyAction="http://tempuri.org/IWeixinService/SearchResourcesByMidiaIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/SearchResourcesByMidiaIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/SearchResourcesByMidiaIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ResourceModel>> SearchResourcesByMidiaIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string[] midiaIds, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UpdateResource", ReplyAction="http://tempuri.org/IWeixinService/UpdateResourceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UpdateResourceErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UpdateResourceErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateResourceAsync(Tgnet.Api.OAuth2ClientIdentity identity, long rid, long admin, WeixinService.ResourceModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/DeleteResourceByIds", ReplyAction="http://tempuri.org/IWeixinService/DeleteResourceByIdsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/DeleteResourceByIdsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/DeleteResourceByIdsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteResourceByIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] ids, long admin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AddResource", ReplyAction="http://tempuri.org/IWeixinService/AddResourceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AddResourceErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AddResourceErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddResourceAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.ResourceModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetResourceById", ReplyAction="http://tempuri.org/IWeixinService/GetResourceByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetResourceByIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetResourceByIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.ResourceModel> GetResourceByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long rid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetOfficialAccounts", ReplyAction="http://tempuri.org/IWeixinService/GetOfficialAccountsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetOfficialAccountsErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetOfficialAccountsErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.OfficialAccountModel[]> GetOfficialAccountsAsync(Tgnet.Api.OAuth2ClientIdentity identity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetActivityFileCount", ReplyAction="http://tempuri.org/IWeixinService/GetActivityFileCountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetActivityFileCountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetActivityFileCountErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, int>> GetActivityFileCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] actIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UploadActivityFiles", ReplyAction="http://tempuri.org/IWeixinService/UploadActivityFilesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UploadActivityFilesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UploadActivityFilesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UploadActivityFilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId, WeixinService.ActivityFile[] files, long uploader);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/SendTempleMessage", ReplyAction="http://tempuri.org/IWeixinService/SendTempleMessageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/SendTempleMessageErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/SendTempleMessageErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task SendTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.TemplateMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/DeleteActivityFiles", ReplyAction="http://tempuri.org/IWeixinService/DeleteActivityFilesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/DeleteActivityFilesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/DeleteActivityFilesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteActivityFilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId, long[] ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetActivityFiles", ReplyAction="http://tempuri.org/IWeixinService/GetActivityFilesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetActivityFilesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetActivityFilesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ActivityFile>> GetActivityFilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId, int start, int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetWXUserInfo", ReplyAction="http://tempuri.org/IWeixinService/GetWXUserInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetWXUserInfoErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetWXUserInfoErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXUser> GetWXUserInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long tgUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UpdateUserNotify", ReplyAction="http://tempuri.org/IWeixinService/UpdateUserNotifyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UpdateUserNotifyErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UpdateUserNotifyErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateUserNotifyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long tgUid, WeixinService.UpdateUserNotifyArgs args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AccountBinding", ReplyAction="http://tempuri.org/IWeixinService/AccountBindingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AccountBindingErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AccountBindingErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.AccountBindingResult> AccountBindingAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid, string accessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AccountBindingQQ", ReplyAction="http://tempuri.org/IWeixinService/AccountBindingQQResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AccountBindingQQErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AccountBindingQQErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.AccountBindingResult> AccountBindingQQAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid, string accessToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AccountUnBinding", ReplyAction="http://tempuri.org/IWeixinService/AccountUnBindingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AccountUnBindingErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AccountUnBindingErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AccountUnBindingAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AccountUnBindingQQ", ReplyAction="http://tempuri.org/IWeixinService/AccountUnBindingQQResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AccountUnBindingQQErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AccountUnBindingQQErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AccountUnBindingQQAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UpdatePushRefusedState", ReplyAction="http://tempuri.org/IWeixinService/UpdatePushRefusedStateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UpdatePushRefusedStateErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UpdatePushRefusedStateErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdatePushRefusedStateAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, bool refusedPush);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetBindingAccountcUsers", ReplyAction="http://tempuri.org/IWeixinService/GetBindingAccountcUsersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetBindingAccountcUsersErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetBindingAccountcUsersErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<long[]> GetBindingAccountcUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetWeixinUsers", ReplyAction="http://tempuri.org/IWeixinService/GetWeixinUsersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetWeixinUsersErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetWeixinUsersErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXUser[]> GetWeixinUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long[] uids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetWeixinUsersByOpenId", ReplyAction="http://tempuri.org/IWeixinService/GetWeixinUsersByOpenIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetWeixinUsersByOpenIdErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetWeixinUsersByOpenIdErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXUser[]> GetWeixinUsersByOpenIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetMenu", ReplyAction="http://tempuri.org/IWeixinService/GetMenuResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetMenuErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetMenuErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.Menu> GetMenuAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/SubmitMenu", ReplyAction="http://tempuri.org/IWeixinService/SubmitMenuResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/SubmitMenuErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/SubmitMenuErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXMemuResponse> SubmitMenuAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.SelfMenu m, string appId, long oprater);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/DeleteAll", ReplyAction="http://tempuri.org/IWeixinService/DeleteAllResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/DeleteAllErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/DeleteAllErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXMemuResponse> DeleteAllAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId, long oprater);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/DeletCondictionMenu", ReplyAction="http://tempuri.org/IWeixinService/DeletCondictionMenuResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/DeletCondictionMenuErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/DeletCondictionMenuErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXMemuResponse> DeletCondictionMenuAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId, string menuid, long oprater);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UpdateTemplate", ReplyAction="http://tempuri.org/IWeixinService/UpdateTemplateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UpdateTemplateErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UpdateTemplateErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateTemplateAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/UpdateTempleMessage", ReplyAction="http://tempuri.org/IWeixinService/UpdateTempleMessageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/UpdateTempleMessageErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/UpdateTempleMessageErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task UpdateTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long mgId, WeixinService.WXTempleMessageEditRequest model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/AddTempleMessage", ReplyAction="http://tempuri.org/IWeixinService/AddTempleMessageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/AddTempleMessageErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/AddTempleMessageErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task AddTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long tid, WeixinService.WXTempleMessageEditRequest model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/Delete", ReplyAction="http://tempuri.org/IWeixinService/DeleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/DeleteErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/DeleteErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task DeleteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long mgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetTempleMessage", ReplyAction="http://tempuri.org/IWeixinService/GetTempleMessageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetTempleMessageErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetTempleMessageErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXTempleMessageResponse> GetTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long mgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetTempleMessages", ReplyAction="http://tempuri.org/IWeixinService/GetTempleMessagesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetTempleMessagesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetTempleMessagesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.WXTempleMessageResponse>> GetTempleMessagesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long tid, string keyword, System.Nullable<bool> finished, System.Nullable<int> start, System.Nullable<int> limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetTemples", ReplyAction="http://tempuri.org/IWeixinService/GetTemplesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetTemplesErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetTemplesErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.TempleModel[]> GetTemplesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetTempleDetail", ReplyAction="http://tempuri.org/IWeixinService/GetTempleDetailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetTempleDetailErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetTempleDetailErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.TempleModel> GetTempleDetailAsync(Tgnet.Api.OAuth2ClientIdentity identity, long tid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetThirdpartyAccount", ReplyAction="http://tempuri.org/IWeixinService/GetThirdpartyAccountResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetThirdpartyAccountErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetThirdpartyAccountErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.QQUser[]> GetThirdpartyAccountAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinService/GetQQBindingUser", ReplyAction="http://tempuri.org/IWeixinService/GetQQBindingUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinService/GetQQBindingUserErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinService/GetQQBindingUserErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.QQUser[]> GetQQBindingUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long[] tgUids);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IWeixinServiceChannel : WeixinService.IWeixinService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class WeixinServiceClient : System.ServiceModel.ClientBase<WeixinService.IWeixinService>, WeixinService.IWeixinService
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WeixinServiceClient() : 
                base(WeixinServiceClient.GetDefaultBinding(), WeixinServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IWeixinService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WeixinServiceClient.GetBindingForEndpoint(endpointConfiguration), WeixinServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WeixinServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WeixinServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<WeixinService.JsConfig> GetJsConfigAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId, string url)
        {
            return base.Channel.GetJsConfigAsync(identity, appId, url);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.BusinessTrain>> SearchBusinessTrainsAsync(Tgnet.Api.OAuth2ClientIdentity identity, string title, WeixinService.RangeOfNullableOfdateTime5F2dSckg timeRange, System.Nullable<long> creater, WeixinService.TrainOrderType orderType, WeixinService.ActivityType trainType, int start, int limit)
        {
            return base.Channel.SearchBusinessTrainsAsync(identity, title, timeRange, creater, orderType, trainType, start, limit);
        }
        
        public System.Threading.Tasks.Task<WeixinService.BusinessTrain> GetBusinessTrainByActIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId)
        {
            return base.Channel.GetBusinessTrainByActIdAsync(identity, actId);
        }
        
        public System.Threading.Tasks.Task AddBusinessTrainAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.EditBussinessTrainArgs args)
        {
            return base.Channel.AddBusinessTrainAsync(identity, args);
        }
        
        public System.Threading.Tasks.Task UpdateBusinessTrainAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.EditBussinessTrainArgs args)
        {
            return base.Channel.UpdateBusinessTrainAsync(identity, args);
        }
        
        public System.Threading.Tasks.Task<int> GetTrailTotalCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.ActivityType trainType)
        {
            return base.Channel.GetTrailTotalCountAsync(identity, trainType);
        }
        
        public System.Threading.Tasks.Task<int> GetNewTrailCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.RangeOfNullableOfdateTime5F2dSckg created, WeixinService.RangeOfNullableOfdateTime5F2dSckg startTime, WeixinService.RangeOfNullableOfdateTime5F2dSckg endTime)
        {
            return base.Channel.GetNewTrailCountAsync(identity, created, startTime, endTime);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.BusinessTrain>> GetBusinessTrainsAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.RangeOfNullableOfdateTime5F2dSckg created, WeixinService.RangeOfNullableOfdateTime5F2dSckg startTime, WeixinService.RangeOfNullableOfdateTime5F2dSckg endTime, System.Nullable<bool> isOnline, WeixinService.ActivityType trainType, int start, int limit)
        {
            return base.Channel.GetBusinessTrainsAsync(identity, created, startTime, endTime, isOnline, trainType, start, limit);
        }
        
        public System.Threading.Tasks.Task DeleteTrainsByIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] Ids, long update)
        {
            return base.Channel.DeleteTrainsByIdsAsync(identity, Ids, update);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ReplyKeywordModel>> SearchAutoReplyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string keyword, System.Nullable<bool> isActive, WeixinService.AcceptMessageType[] acceptMsgTypes, WeixinService.ReplyEventType[] eventTypes, WeixinService.ResourceType[] msgTypes, int start, int limit)
        {
            return base.Channel.SearchAutoReplyAsync(identity, appid, keyword, isActive, acceptMsgTypes, eventTypes, msgTypes, start, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ReplyKeywordModel>> SearchAutoReplyBykwAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string[] keywords, int start, int limit)
        {
            return base.Channel.SearchAutoReplyBykwAsync(identity, appid, keywords, start, limit);
        }
        
        public System.Threading.Tasks.Task<WeixinService.ReplyKeywordModel> GetAutoReplyByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long Id)
        {
            return base.Channel.GetAutoReplyByIdAsync(identity, Id);
        }
        
        public System.Threading.Tasks.Task DeleteAutoReplyByIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] Ids, long admin)
        {
            return base.Channel.DeleteAutoReplyByIdsAsync(identity, Ids, admin);
        }
        
        public System.Threading.Tasks.Task UpdateAutoReplyKeywordAsync(Tgnet.Api.OAuth2ClientIdentity identity, long rid, long update, WeixinService.ReplyKeywordModel model)
        {
            return base.Channel.UpdateAutoReplyKeywordAsync(identity, rid, update, model);
        }
        
        public System.Threading.Tasks.Task AddAutoReplyKeywordAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.ReplyKeywordModel model)
        {
            return base.Channel.AddAutoReplyKeywordAsync(identity, model);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ResourceModel>> SearchResourcesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string keyword, WeixinService.ResourceType[] types, int start, int limit)
        {
            return base.Channel.SearchResourcesAsync(identity, appid, keyword, types, start, limit);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ResourceModel>> SearchResourcesByMidiaIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appid, string[] midiaIds, int start, int limit)
        {
            return base.Channel.SearchResourcesByMidiaIdAsync(identity, appid, midiaIds, start, limit);
        }
        
        public System.Threading.Tasks.Task UpdateResourceAsync(Tgnet.Api.OAuth2ClientIdentity identity, long rid, long admin, WeixinService.ResourceModel model)
        {
            return base.Channel.UpdateResourceAsync(identity, rid, admin, model);
        }
        
        public System.Threading.Tasks.Task DeleteResourceByIdsAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] ids, long admin)
        {
            return base.Channel.DeleteResourceByIdsAsync(identity, ids, admin);
        }
        
        public System.Threading.Tasks.Task AddResourceAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.ResourceModel model)
        {
            return base.Channel.AddResourceAsync(identity, model);
        }
        
        public System.Threading.Tasks.Task<WeixinService.ResourceModel> GetResourceByIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, long rid)
        {
            return base.Channel.GetResourceByIdAsync(identity, rid);
        }
        
        public System.Threading.Tasks.Task<WeixinService.OfficialAccountModel[]> GetOfficialAccountsAsync(Tgnet.Api.OAuth2ClientIdentity identity)
        {
            return base.Channel.GetOfficialAccountsAsync(identity);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<long, int>> GetActivityFileCountAsync(Tgnet.Api.OAuth2ClientIdentity identity, long[] actIds)
        {
            return base.Channel.GetActivityFileCountAsync(identity, actIds);
        }
        
        public System.Threading.Tasks.Task UploadActivityFilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId, WeixinService.ActivityFile[] files, long uploader)
        {
            return base.Channel.UploadActivityFilesAsync(identity, actId, files, uploader);
        }
        
        public System.Threading.Tasks.Task SendTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.TemplateMessageRequest request)
        {
            return base.Channel.SendTempleMessageAsync(identity, request);
        }
        
        public System.Threading.Tasks.Task DeleteActivityFilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId, long[] ids)
        {
            return base.Channel.DeleteActivityFilesAsync(identity, actId, ids);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.ActivityFile>> GetActivityFilesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long actId, int start, int limit)
        {
            return base.Channel.GetActivityFilesAsync(identity, actId, start, limit);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXUser> GetWXUserInfoAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long tgUid)
        {
            return base.Channel.GetWXUserInfoAsync(identity, app, tgUid);
        }
        
        public System.Threading.Tasks.Task UpdateUserNotifyAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long tgUid, WeixinService.UpdateUserNotifyArgs args)
        {
            return base.Channel.UpdateUserNotifyAsync(identity, app, tgUid, args);
        }
        
        public System.Threading.Tasks.Task<WeixinService.AccountBindingResult> AccountBindingAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid, string accessToken)
        {
            return base.Channel.AccountBindingAsync(identity, app, openId, tgUid, accessToken);
        }
        
        public System.Threading.Tasks.Task<WeixinService.AccountBindingResult> AccountBindingQQAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid, string accessToken)
        {
            return base.Channel.AccountBindingQQAsync(identity, app, openId, tgUid, accessToken);
        }
        
        public System.Threading.Tasks.Task AccountUnBindingAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid)
        {
            return base.Channel.AccountUnBindingAsync(identity, app, openId, tgUid);
        }
        
        public System.Threading.Tasks.Task AccountUnBindingQQAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, long tgUid)
        {
            return base.Channel.AccountUnBindingQQAsync(identity, app, openId, tgUid);
        }
        
        public System.Threading.Tasks.Task UpdatePushRefusedStateAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId, bool refusedPush)
        {
            return base.Channel.UpdatePushRefusedStateAsync(identity, app, openId, refusedPush);
        }
        
        public System.Threading.Tasks.Task<long[]> GetBindingAccountcUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long[] uids)
        {
            return base.Channel.GetBindingAccountcUsersAsync(identity, app, uids);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXUser[]> GetWeixinUsersAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long[] uids)
        {
            return base.Channel.GetWeixinUsersAsync(identity, app, uids);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXUser[]> GetWeixinUsersByOpenIdAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId)
        {
            return base.Channel.GetWeixinUsersByOpenIdAsync(identity, app, openId);
        }
        
        public System.Threading.Tasks.Task<WeixinService.Menu> GetMenuAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId)
        {
            return base.Channel.GetMenuAsync(identity, appId);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXMemuResponse> SubmitMenuAsync(Tgnet.Api.OAuth2ClientIdentity identity, WeixinService.SelfMenu m, string appId, long oprater)
        {
            return base.Channel.SubmitMenuAsync(identity, m, appId, oprater);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXMemuResponse> DeleteAllAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId, long oprater)
        {
            return base.Channel.DeleteAllAsync(identity, appId, oprater);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXMemuResponse> DeletCondictionMenuAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId, string menuid, long oprater)
        {
            return base.Channel.DeletCondictionMenuAsync(identity, appId, menuid, oprater);
        }
        
        public System.Threading.Tasks.Task UpdateTemplateAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId)
        {
            return base.Channel.UpdateTemplateAsync(identity, appId);
        }
        
        public System.Threading.Tasks.Task UpdateTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long mgId, WeixinService.WXTempleMessageEditRequest model)
        {
            return base.Channel.UpdateTempleMessageAsync(identity, mgId, model);
        }
        
        public System.Threading.Tasks.Task AddTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long tid, WeixinService.WXTempleMessageEditRequest model)
        {
            return base.Channel.AddTempleMessageAsync(identity, tid, model);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(Tgnet.Api.OAuth2ClientIdentity identity, long mgId)
        {
            return base.Channel.DeleteAsync(identity, mgId);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXTempleMessageResponse> GetTempleMessageAsync(Tgnet.Api.OAuth2ClientIdentity identity, long mgId)
        {
            return base.Channel.GetTempleMessageAsync(identity, mgId);
        }
        
        public System.Threading.Tasks.Task<Tgnet.Data.PageModel<WeixinService.WXTempleMessageResponse>> GetTempleMessagesAsync(Tgnet.Api.OAuth2ClientIdentity identity, long tid, string keyword, System.Nullable<bool> finished, System.Nullable<int> start, System.Nullable<int> limit)
        {
            return base.Channel.GetTempleMessagesAsync(identity, tid, keyword, finished, start, limit);
        }
        
        public System.Threading.Tasks.Task<WeixinService.TempleModel[]> GetTemplesAsync(Tgnet.Api.OAuth2ClientIdentity identity, string appId)
        {
            return base.Channel.GetTemplesAsync(identity, appId);
        }
        
        public System.Threading.Tasks.Task<WeixinService.TempleModel> GetTempleDetailAsync(Tgnet.Api.OAuth2ClientIdentity identity, long tid)
        {
            return base.Channel.GetTempleDetailAsync(identity, tid);
        }
        
        public System.Threading.Tasks.Task<WeixinService.QQUser[]> GetThirdpartyAccountAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, string openId)
        {
            return base.Channel.GetThirdpartyAccountAsync(identity, app, openId);
        }
        
        public System.Threading.Tasks.Task<WeixinService.QQUser[]> GetQQBindingUserAsync(Tgnet.Api.OAuth2ClientIdentity identity, string app, long[] tgUids)
        {
            return base.Channel.GetQQBindingUserAsync(identity, app, tgUids);
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
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IWeixinService))
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
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IWeixinService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.weixin.t.tgnet.com:10210/Services/WeixinService.svc");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WeixinServiceClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IWeixinService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WeixinServiceClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IWeixinService);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IWeixinService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeixinService.IWeixinAutoReplyManager")]
    public interface IWeixinAutoReplyManager
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeixinAutoReplyManager/WXUploadMedia", ReplyAction="http://tempuri.org/IWeixinAutoReplyManager/WXUploadMediaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Tgnet.Api.ErrorCode), Action="http://tempuri.org/IWeixinAutoReplyManager/WXUploadMediaErrorCodeFault", Name="ErrorCode", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeixinService.ErrorResponseType), Action="http://tempuri.org/IWeixinAutoReplyManager/WXUploadMediaErrorResponseTypeFault", Name="ErrorResponseType", Namespace="http://schemas.datacontract.org/2004/07/Tgnet.Api")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Tgnet.Api.OAuth2Identity))]
        System.Threading.Tasks.Task<WeixinService.WXUploadResponse> WXUploadMediaAsync(WeixinService.WXUploadMediaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WXUploadMediaRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class WXUploadMediaRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Appid;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileType;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Tgnet.Api.OAuth2ClientIdentity Identity;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Introduction;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Title;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public byte[] FileStream;
        
        public WXUploadMediaRequest()
        {
        }
        
        public WXUploadMediaRequest(string Appid, string FileName, string FileType, Tgnet.Api.OAuth2ClientIdentity Identity, string Introduction, string Title, byte[] FileStream)
        {
            this.Appid = Appid;
            this.FileName = FileName;
            this.FileType = FileType;
            this.Identity = Identity;
            this.Introduction = Introduction;
            this.Title = Title;
            this.FileStream = FileStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WXUploadResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class WXUploadResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string errcode;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string errmsg;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string media_id;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string url;
        
        public WXUploadResponse()
        {
        }
        
        public WXUploadResponse(string errcode, string errmsg, string media_id, string url)
        {
            this.errcode = errcode;
            this.errmsg = errmsg;
            this.media_id = media_id;
            this.url = url;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IWeixinAutoReplyManagerChannel : WeixinService.IWeixinAutoReplyManager, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class WeixinAutoReplyManagerClient : System.ServiceModel.ClientBase<WeixinService.IWeixinAutoReplyManager>, WeixinService.IWeixinAutoReplyManager
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WeixinAutoReplyManagerClient() : 
                base(WeixinAutoReplyManagerClient.GetDefaultBinding(), WeixinAutoReplyManagerClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.NetTcpBinding_IWeixinAutoReplyManager.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinAutoReplyManagerClient(EndpointConfiguration endpointConfiguration) : 
                base(WeixinAutoReplyManagerClient.GetBindingForEndpoint(endpointConfiguration), WeixinAutoReplyManagerClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinAutoReplyManagerClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WeixinAutoReplyManagerClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinAutoReplyManagerClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WeixinAutoReplyManagerClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WeixinAutoReplyManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WeixinService.WXUploadResponse> WeixinService.IWeixinAutoReplyManager.WXUploadMediaAsync(WeixinService.WXUploadMediaRequest request)
        {
            return base.Channel.WXUploadMediaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WeixinService.WXUploadResponse> WXUploadMediaAsync(string Appid, string FileName, string FileType, Tgnet.Api.OAuth2ClientIdentity Identity, string Introduction, string Title, byte[] FileStream)
        {
            WeixinService.WXUploadMediaRequest inValue = new WeixinService.WXUploadMediaRequest();
            inValue.Appid = Appid;
            inValue.FileName = FileName;
            inValue.FileType = FileType;
            inValue.Identity = Identity;
            inValue.Introduction = Introduction;
            inValue.Title = Title;
            inValue.FileStream = FileStream;
            return ((WeixinService.IWeixinAutoReplyManager)(this)).WXUploadMediaAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IWeixinAutoReplyManager))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.TransferMode = System.ServiceModel.TransferMode.Streamed;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IWeixinAutoReplyManager))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://api.weixin.t.tgnet.com:10210/Services/WeixinService.svc/AutoReply");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WeixinAutoReplyManagerClient.GetBindingForEndpoint(EndpointConfiguration.NetTcpBinding_IWeixinAutoReplyManager);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WeixinAutoReplyManagerClient.GetEndpointAddress(EndpointConfiguration.NetTcpBinding_IWeixinAutoReplyManager);
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IWeixinAutoReplyManager,
        }
    }
}
