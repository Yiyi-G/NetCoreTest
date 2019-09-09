using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using Tgnet.FootChat.CloudFileStoreService;

namespace Tgnet.FootChat.File
{
    public interface IFileManager
    {
        bool UploadFile(string uploadFilename, Stream stream, long uid, string path, out string fid);
        bool UploaGlobaldFile(string uploadFilename, Stream stream, long uid, string path, out string fid);
        Stream GetGlobalFile(string fid);
        Stream GetFile(string fid);
        DateTime? GetLastModified(string fid);
        DateTime? GetGlobalFileLastModified(string fid);
        void DeleteGlobalFile(string fid);
        string GetImageUrl(string fid);
        string SaveTempFile(string path, long uid, string fid);
        string GetFileDownloadSign(string fid);

        string UploadTempFile(string uploadFilename, Stream stream, long uid);

        string CreateZipFile(long uid, Dictionary<string, string> fids);

        string GetFileDownloadSign(string fid, DateTime exprireln);
        string AddWatermark(CloudFileStoreService.CloudFileWaterMarkRequest request);
        void DeleteImg(string oldFid);
    }
    class FileManager : IFileManager
    {
        public bool UploadFile(string uploadFilename, Stream stream, long uid, string path, out string fid)
        {
            try
            {
                using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
                {
                    var result = provider.Channel.UploadFile(new CloudFileStoreService.CloudFileRequest
                    {
                        Identity = new Api.OAuth2ClientIdentity(),
                        UID = uid,
                        Stream = stream,
                        Path = path,
                        VirtualFilename = uploadFilename,
                    });
                    fid = result.VirtualFilename;
                    return true;
                }
            }
            catch (Exception)
            {
                fid = String.Empty;
                return false;
            }
        }        

        public bool UploaGlobaldFile(string uploadFilename, Stream stream, long uid, string path, out string fid)
        {
            try
            {
                using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
                {
                    var result = provider.Channel.UploadGlobalFile(new CloudFileStoreService.CloudFileRequest
                    {
                        Identity = new Api.OAuth2ClientIdentity(),
                        UID = uid,
                        Stream = stream,
                        Path = path,
                        VirtualFilename = uploadFilename,
                        Upset = true,
                    });
                    fid = result.VirtualFilename;
                    return true;
                }
            }
            catch (Exception)
            {
                fid = String.Empty;
                return false;
            }
        }
        public Stream GetGlobalFile(string fid)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(fid, nameof(fid));
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                var result = provider.Channel.GetGlobalFile(new CloudFileStoreService.GlobalFileRequest
                {
                    Identity = new Api.OAuth2ClientIdentity(),
                    Key = fid,
                });
                return result.Stream;
            }
        }
        public Stream GetFile(string fid)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(fid, nameof(fid));
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                var result = provider.Channel.GetFile(new  CloudFileStoreService.CacheFileRequest
                {
                    Identity = new Api.OAuth2ClientIdentity(),
                    Key = fid,
                });
                return result.Stream;
            }
        }
        public DateTime? GetLastModified(string fid)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                return provider.Channel.GetLastModified(new Api.OAuth2ClientIdentity(), fid);
            }
        }
        public void DeleteGlobalFile(string fid)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                provider.Channel.DeleteGlobalFile(new Api.OAuth2ClientIdentity(), fid);
            }
        }
        public string GetFileDownloadSign(string fid)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
              return  provider.Channel.GetFileDownloadSign(new Api.OAuth2ClientIdentity(), fid,DateTime.Now.AddDays(1));
            }
        }
        public string SaveTempFile(string path, long uid, string fid)
        {
            if (!IsTempFile(fid))
                return fid;
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                var result = provider.Channel.SaveTempFile(new CloudFileStoreService.SaveTempFileRequest
                {
                    Identity = new Api.OAuth2ClientIdentity(),
                    UID = uid,
                    Key = fid,
                    Path = path,
                });
                return result.VirtualFilename;
            }
        }
        private bool IsTempFile(string fid)
        {
            if (String.IsNullOrWhiteSpace(fid))
                return false;
            return fid.StartsWith("cache/");
        }
        public DateTime? GetGlobalFileLastModified(string fid)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                return provider.Channel.GetGlobalFileLastModified(new Api.OAuth2ClientIdentity(), fid);
            }
        }

        public string UploadTempFile(string uploadFilename, Stream stream, long uid)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                return provider.Channel.UploadTempFile(new CloudFileStoreService.TempFileUploadRequest()
                {
                    Identity = new Api.OAuth2ClientIdentity(),
                    UID = uid,
                    Filename = uploadFilename,
                    Stream = stream,
                }).Key;
            }
        }



        public string CreateZipFile(long uid, Dictionary<string, string> fids)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                return provider.Channel.CreateZipFile(new Api.OAuth2ClientIdentity(), uid, fids.Select(f => new CloudFileStoreService.ZipEntry()
                {
                    Fid = f.Key,
                    Filename = f.Value,
                }).ToArray());
            }
        }
        public string AddWatermark(CloudFileStoreService.CloudFileWaterMarkRequest request)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                var result = provider.Channel.AddWatermark(request);
                return result.VirtualFilename;
            }
        }
        public string GetImageUrl(string fid)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(fid, nameof(fid));
            return String.Format("http://file.tgimg.cn/Image/Show?fid={0}", fid);
        }
        public string GetFileDownloadSign(string fid, DateTime exprireln)
        {
            using (var provide = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                return provide.Channel.GetFileDownloadSign(new Api.OAuth2ClientIdentity(), fid, exprireln);
            }
        }

        //删除图片
        public void DeleteImg(string oldFid)
        {
            using (var provider = new Tgnet.ServiceModel.ChannelProviderService<CloudFileStoreService.ICloudFileStoreService>().NewChannelProvider())
            {
                //删除掉原来图片
                provider.Channel.DeleteImage(new Api.OAuth2ClientIdentity(), oldFid);
            }
        }
    }
}