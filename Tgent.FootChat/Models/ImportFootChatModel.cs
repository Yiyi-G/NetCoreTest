using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core;

namespace Tgnet.FootChat.Models
{
    [DataContract]
    public class ImportFootChatModel
    {
        [DataMember]
        public long TgFid { get; set; }
        [DataMember]
        public long Uid { get; set; }
        [DataMember]
        public long Pid { get; set; }
        [DataMember]
        public double? Longitude { get; set; }
        [DataMember]
        public double? Latitude { get; set; }
        [DataMember]
        public string AreaNo { get; set; }
        [DataMember]
        public string Adddress { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public DateTime Updated { get; set; }
        [DataMember]
        public ImportFootPrintTag[] TgTags { get; set; }
        [DataMember]
        public ImportFootPrintImg[] Imags { get; set; }
        public void CheckIsValid()
        {
            ExceptionHelper.ThrowIfNotId(TgFid, nameof(TgFid));
            ExceptionHelper.ThrowIfNotId(TgFid, nameof(TgFid));
            ExceptionHelper.ThrowIfNotId(TgFid, nameof(TgFid));
            ExceptionHelper.ThrowIfTrue(Imags == null || !Imags.Any(p => !string.IsNullOrWhiteSpace(p.Imag)), nameof(Imags), "足迹图片不能为空");
            ExceptionHelper.ThrowIfTrue(TgTags == null||!TgTags.Any(p => !string.IsNullOrWhiteSpace(p.TName)), nameof(TgTags), "足迹标签不能为空");
        }
    }

    [DataContract]
    public class ImportFootPrintTag
    {
        [DataMember]
        public long Tid { get; set; }
        [DataMember]
        public string TName { get; set; }
    }

    [DataContract]
    public class ImportFootPrintImg
    {
        [DataMember]
        public string Imag { get; set; }
        [DataMember]
        public double? Longitude { get; set; }
        [DataMember]
        public double? Latitude { get; set; }
        [DataMember]
        public string Adddress { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public DateTime? PhotoTime { get; set; }

        public static explicit operator Model.FootImageInfo(ImportFootPrintImg importImgModel)
        {
            var model = new Model.FootImageInfo();
            model.Address = importImgModel.Adddress;
            model.ImageKey = importImgModel.Imag;
            model.Latitude = importImgModel.Latitude;
            model.Longitude = importImgModel.Longitude;
            model.PhotoTime = importImgModel.PhotoTime;
            return model;
        }
    }
}
