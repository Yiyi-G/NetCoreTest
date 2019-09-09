using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.UserService;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Mobile
{
    public interface IMobileManager
    {
        void SendVerifyCode(string mobile, ValidateType validateType, long? uid, string signName, string ip, string from);
        string Verify(string code, string mobile, ValidateType validateType);
        /// <summary>
        /// 添加或修改设备
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="device_id"></param>
        /// <param name="resolution"></param>
        /// <param name="os"></param>
        /// <param name="trademark"></param>
        void DeviceRegister(long uid, string deviceId, string resolution, string os, string trademark, string clientVersion, string ip);
    }

    internal class MobileManager : IMobileManager
    {
        private readonly VerifyHelper _VerifyHelper;
        private readonly IRepository<Data.MobileInfo> _MobileInfoRepository;
        private readonly IChannelProviderService<PushService.IPushService> _PushServiceChannelProvider;
        private readonly IChannelProviderService<UserService.IUserManagerService> _UserManagerService;

        public MobileManager(
            IRepository<Data.MobileInfo> mobileInfoRepository,
            IChannelProviderService<PushService.IPushService> pushServiceChannelProvider,
            IChannelProviderService<UserService.IUserManagerService> userManagerService)
        {
            _PushServiceChannelProvider = pushServiceChannelProvider;
            _UserManagerService = userManagerService;
            _MobileInfoRepository = mobileInfoRepository;
            _VerifyHelper = new VerifyHelper(userManagerService);
        }
        public void SendVerifyCode(string mobile, ValidateType validateType, long? uid,string signName, string ip,string from )
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, "mobile");
            _VerifyHelper.SendVerifyCode(mobile, validateType, uid,signName, ip,from);
        }
        public string Verify(string code, string mobile, ValidateType verifyType)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(code, "code", "手机验证码不能为空");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(mobile, "mobile");
            ExceptionHelper.ThrowIfTrue(!StringRule.VerifyMobile(mobile), "mobile", "手机号码格式错误");

            var result = String.Empty;
            result = _VerifyHelper.Verify(mobile, code, verifyType);
            return result;
        }
        public void DeviceRegister(long uid, string deviceId, string resolution, string os, string trademark, string clientVersion, string ip)
        {
            ExceptionHelper.ThrowIfNotId(uid, "uid");
            if (String.IsNullOrWhiteSpace(deviceId))
                return;
            var create = false;
            var mobileInfo = _MobileInfoRepository.Entities.FirstOrDefault(mi => mi.uid == uid && mi.deviceId == deviceId);
            if (mobileInfo == null)
            {
                create = true;
                mobileInfo = new Data.MobileInfo
                {
                    uid = uid,
                    deviceId = deviceId,
                    updated = DateTime.Now,
                };
                _MobileInfoRepository.Add(mobileInfo);
            }
            if (create || !String.IsNullOrEmpty(resolution))
                mobileInfo.resolution = resolution ?? String.Empty;
            if (create || !String.IsNullOrEmpty(os))
                mobileInfo.os = os ?? String.Empty;
            if (create || !String.IsNullOrEmpty(trademark))
                mobileInfo.trademark = trademark ?? String.Empty;
            if (create || !String.IsNullOrEmpty(clientVersion))
                mobileInfo.clientVersion = clientVersion ?? String.Empty;
            if (create || !String.IsNullOrEmpty(ip))
                mobileInfo.ip = ip ?? String.Empty;
            mobileInfo.updated = DateTime.Now;
            _MobileInfoRepository.SaveChanges();
        }
    }
}
