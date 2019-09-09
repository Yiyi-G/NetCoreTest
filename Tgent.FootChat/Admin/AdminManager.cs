using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Models;

namespace Tgnet.FootChat.Admin
{
    public interface IAdminManager
    {
        AdminEntity Login(string userNo, string userPwd);
        //IAdminService Login(string userNo, string userPwd);
        IQueryable<AdminUser> GetAdmins(long[] adminIds);
        IQueryable<AdminUser> GetAdmins();
        IAdminService GetService(long uid);
        IAdminService GetService(string userNo);
        Dictionary<int, string> GetAdminName(int[] adminIds);
        string GetUserMobile(string account);
        IQueryable<AdminUser> GerAdminUserByName(string userName);
    }

    public class AdminManager : IAdminManager
    {
        private readonly IRepository<AdminUser> _AdminUserRepository;
        private readonly IRepository<ViewSysACLCache> _ViewSysACLCacheRepository;
        public AdminManager(IRepository<AdminUser> AdminUserRepository, IRepository<ViewSysACLCache> viewSysACLCacheRepository)
        {
            _AdminUserRepository = AdminUserRepository;
            _ViewSysACLCacheRepository = viewSysACLCacheRepository;
        }


        public AdminEntity Login(string userNo, string userPwd)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(userNo, "userNo", "账号不能为空");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(userPwd, "userPwd", "密码不能为空");
            var user = GetUserByUserNo(userNo);
            ExceptionHelper.ThrowIfNull(user, "user", "账号不存在");
            ExceptionHelper.ThrowIfTrue(!user.CheckPassword(userPwd), "userPwd", "密码错误");
            ExceptionHelper.ThrowIfTrue(user.Lock, "user", "账号被锁定");
            var aclModules = GetACLModules(user.UserID);
            var aclChackCode = EncryptACLModules(aclModules);
            user.ACLModules = aclModules;
            user.ACLChackCode = aclChackCode;
            return user;
        }

        private AdminEntity GetUserByUserNo(string userNo)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(userNo, "userNo", "账号不能为空");
            var result = _AdminUserRepository.Entities.Where(u => u.userNo == userNo)
                .Select(item => new
                {
                    AdminUser = new AdminEntity
                    {
                        UserID = item.userID,
                        UserNo = item.userNo,
                        UserName = item.userName,
                        Lock = item.userLocked.HasValue && item.userLocked.Value
                    },
                    UserPwd = item.userPwd
                }).FirstOrDefault();

            if (result == null)
            {
                return null;
            }

            var user = result.AdminUser;
            user.SetEncryptPassword(result.UserPwd);

            return user;
        }

        private string GetACLModules(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, "uid", "ID错误");
            var acl = _ViewSysACLCacheRepository.Entities.Where(i => i.userID == uid).Select(i => i.moduleNo);
            return String.Join("|", acl);
        }

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

        //public IAdminService Login(string userNo, string userPwd)
        //{
        //    ExceptionHelper.ThrowIfNullOrWhiteSpace(userNo, "userNo", "账号不能为空");
        //    ExceptionHelper.ThrowIfNullOrWhiteSpace(userPwd, "userPwd", "密码不能为空");
        //    var user = GetService(userNo);
        //    if (user == null) throw new Api.ExceptionWithErrorCode(Api.ErrorCode.帐号不存在);
        //    if (!user.CheckPassword(userPwd)) throw new Api.ExceptionWithErrorCode(Api.ErrorCode.帐号或密码不正确);

        //    ExceptionHelper.ThrowIfTrue(user.Lock, "user", "账号被锁定");
        //    return user;
        //}

        public IAdminService GetService(string userNo)
        {
            return new AdminService(userNo, _AdminUserRepository, _ViewSysACLCacheRepository);
        }

        public IQueryable<AdminUser> GetAdmins(long[] adminIds)
        {
            if (adminIds == null || (adminIds = adminIds.Where(id => id > 0).Distinct().ToArray()).Length == 0)
                return Enumerable.Empty<AdminUser>().AsQueryable();

            return _AdminUserRepository.Entities.Where(au => adminIds.Contains(au.userID));
        }

        public IAdminService GetService(long uid)
        {
            return new AdminService(uid, _AdminUserRepository, _ViewSysACLCacheRepository);
        }

        public IQueryable<AdminUser> GetAdmins()
        {
            return _AdminUserRepository.Entities.Where(au => !au.userLocked.HasValue || !au.userLocked.Value);
        }

        public Dictionary<int, string> GetAdminName(int[] adminIds)
        {
            adminIds = (adminIds ?? new int[0]).Where(id => id > 0).Distinct().ToArray();
            if (adminIds.Length == 0) return new Dictionary<int, string>();
            return _AdminUserRepository.Entities
                 .Where(a => adminIds.Contains(a.userID))
                 .Select(a => new { a.userID, a.userName })
                 .ToDictionary(a => a.userID, a => a.userName);
        }

        public void ResetPassword(string userNo, string userPwd, string newPsw)
        {
            throw new NotImplementedException();
        }

        public string GetUserMobile(string account)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(account, nameof(account));
            return _AdminUserRepository.Entities.Where(p => p.userNo == account).Select(p => p.userMobile).FirstOrDefault();
        }

        public IQueryable<AdminUser> GerAdminUserByName(string userName)
        {
            return _AdminUserRepository.Entities.Where(p => p.userName.StartsWith(userName.Trim()));
        }
    }
}
