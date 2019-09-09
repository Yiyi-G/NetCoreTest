using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Admin
{
    public interface IAdminService
    {
        long UserID { get; }
        string UserName { get; }
        string UserNo { get; }
        bool Lock { get; }
        bool CheckPassword(string userPwd);
        string ACLModules { get; }
        string ACLChackCode { get; }
        string Pwd { get; }
        string GetACLModules();
        void ResetPassword(string oldpsw, string newpsw);
    }
    public class AdminService : IAdminService
    {
        private IRepository<Data.AdminUser> _AdminUserRepository;
        private Lazy<Data.AdminUser> _LazyAdminUser;
        private readonly IRepository<ViewSysACLCache> _ViewSysACLCacheRepository;

        public AdminService(long uid, IRepository<Data.AdminUser> adminUserRepository, IRepository<ViewSysACLCache> viewSysACLCacheRepository)
        {
            ExceptionHelper.ThrowIfNotId(uid, "uid");
            _AdminUserRepository = adminUserRepository;
            _ViewSysACLCacheRepository = viewSysACLCacheRepository;

            this._id = uid;

            _LazyAdminUser = new Lazy<Data.AdminUser>(() =>
            {
                var entity = _AdminUserRepository.Entities.Where(a => a.userID == uid).FirstOrDefault();
                ExceptionHelper.ThrowIfNull(entity, "uid");
                return entity;
            });

        }
        public AdminService(string userNo, IRepository<Data.AdminUser> adminUserRepository, IRepository<ViewSysACLCache> viewSysACLCacheRepository)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(userNo, "userNo", "userNo为空");
            _AdminUserRepository = adminUserRepository;
            _ViewSysACLCacheRepository = viewSysACLCacheRepository;

            this._userNo = userNo;

            _LazyAdminUser = new Lazy<Data.AdminUser>(() =>
            {
                var entity = _AdminUserRepository.Entities.Where(a => a.userNo == userNo).FirstOrDefault();
                ExceptionHelper.ThrowIfNull(entity, "uid");
                return entity;
            });

        }

        private long _id;
        public long UserID
        {
            get
            {
                if (_id <= 0)
                {
                    _id = _LazyAdminUser.Value.userID;
                }
                return _id;
            }
        }

        public string Pwd { get { return _LazyAdminUser.Value.userPwd; } }

        public string UserName
        {
            get
            {
                return _LazyAdminUser.Value.userName;
            }
        }

        private string _userNo;
        public string UserNo
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_userNo))
                {
                    _userNo = _LazyAdminUser.Value.userNo;
                }
                return _userNo;
            }
        }
        public bool Lock
        {
            get
            {
                var isLock = _LazyAdminUser.Value.userLocked;
                return isLock.HasValue && isLock.Value;
            }
        }

        public string ACLModules
        {
            get
            {
                var acl = _ViewSysACLCacheRepository.Entities.Where(i => i.userID == UserID).Select(i => i.moduleNo);
                return String.Join("|", acl);
            }
        }

        public string ACLChackCode
        {
            get
            {
                return EncryptACLModules(ACLModules);
            }
        }

        public bool CheckPassword(string userPwd)
        {
            if (String.IsNullOrWhiteSpace(UserNo) || String.IsNullOrWhiteSpace(userPwd))
            {
                return false;
            }
            var psw = GetSafePwd(UserNo, userPwd);
            return psw == _LazyAdminUser.Value.userPwd;
        }

        public void ResetPassword(string oldpsw,string newpsw)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(oldpsw, nameof(oldpsw),"请输入旧密码");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(newpsw,nameof(newpsw),"请输入新密码");
            if (!string.IsNullOrWhiteSpace(oldpsw) && !string.IsNullOrWhiteSpace(newpsw))
            {
                ExceptionHelper.ThrowIfTrue(!CheckPassword(oldpsw),nameof(oldpsw),"旧密码不正确");
                _LazyAdminUser.Value.userPwd = GetSafePwd(UserNo, newpsw);
                _AdminUserRepository.SaveChanges();
            }         
        }
        #region
        private string EncryptACLModules(string aclModules)
        {
            if (String.IsNullOrWhiteSpace(aclModules))
            {
                return String.Empty;
            }

            var desService = new Tgnet.Security.DES(sKey, sIV, Encoding.UTF8);
            return desService.Encrypt(aclModules);
        }
        private static byte[] sKey = { 15, 187, 62, 95, 155, 214, 99, 37 };
        private static byte[] sIV = { 32, 19, 91, 175, 245, 49, 6, 73 };

        private string GetSafePwd(string userNo, string userPwd)
        {
            return EncryptString(userNo.ToLower() + "/" + userPwd,
                sKey, sIV);
        }

        private static string EncryptString(byte[] byteArray, byte[] sKey, byte[] sIV)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            des.Key = sKey;
            des.IV = sIV;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(byteArray, 0, byteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }

        public static string EncryptString(string strToEncrypt, byte[] sKey, byte[] sIV)
        {
            byte[] inputByteArray = Encoding.Default.GetBytes(strToEncrypt);
            return EncryptString(inputByteArray, sKey, sIV);
        }
        #endregion


        public string GetACLModules()
        {
            var acl = _ViewSysACLCacheRepository.Entities.Where(i => i.userID == UserID).Select(i => i.moduleNo);
            return String.Join("|", acl);
        }
    }
}
