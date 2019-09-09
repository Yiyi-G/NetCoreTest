using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Events;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Mobile
{
    public interface IUserAddressBookManager
    {
        IEnumerable<AddressBookMobile> Change(IEnumerable<AddressBookItem> items);
        IQueryable<Data.AddressBookMobile> UserAddressBooks { get; }
        IQueryable<Data.AddressBookMobile> GetAddressBookRegisterUser();
        IQueryable<Data.AddressBookMobile> GetAddressBookMobile(String[] mobiles);
        PageModel<Model.UserAddressBookMobileModel> GetUserAddressBooks(string keyword, bool? isAttention, int? start, int? limit);
        void Attention(string mobile, bool attention);
        /// <summary>
        /// 返回我的的通讯录好友
        /// </summary>
        /// <param name="uids"></param>
        /// <returns></returns>
        Dictionary<long, Models.AddressBookFriend> GetUserAddressFriend(long[] uids);
        
    }
    public class UserAddressBookManager : IUserAddressBookManager
    {
        private readonly Data.IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IFootChatUserRepository _UserRepository;
        private readonly IUserEventFactory _UserEventFactory;
        private readonly FCRMAPI.IPushManager _PushManager;
        private readonly IUserService _User;
        private readonly object _Locker = new object();

        public UserAddressBookManager(IUserService user,
            Data.IAddressBookMobileRepository addressBookMobileRepository,
            IFootChatUserRepository userRepository,
            IUserEventFactory userEventFactory,
            FCRMAPI.IPushManager pushManager)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            _User = user;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _UserRepository = userRepository;
            _UserEventFactory = userEventFactory;
            _PushManager = pushManager;
        }

        public IEnumerable<AddressBookMobile> Change(IEnumerable<AddressBookItem> items)
        {
            List<AddressBookMobile> result = new List<AddressBookMobile>();
            if (items == null) return Enumerable.Empty<AddressBookMobile>().ToArray();
            var books = items.Where(b => StringRule.VerifyMobile(b.Mobile) && (b.TgUid == null || b.TgUid != _User.Uid)).ToArray();
            if (books.Length == 0) return Enumerable.Empty<AddressBookMobile>().ToArray();
            foreach (var item in books)
            {
                item.Mobile = (item.Mobile ?? String.Empty).Trim();
                item.Name = (item.Name ?? String.Empty).Trim().Left(50);
                item.Company = (item.Company ?? String.Empty).Trim().Left(100);
            }

            var mobiles = books.Select(b => b.Mobile).Distinct().ToArray();
            lock (_Locker)
            {
                var exist = _AddressBookMobileRepository.Entities.Where(m => m.uid == _User.Uid && mobiles.Contains(m.mobile)).Select(m => m.mobile).ToArray();
                if (exist.Length > 0)
                    mobiles = mobiles.Except(exist).ToArray();
                if (mobiles.Length > 0)
                {
                    result.AddRange(mobiles.Select(m => new Data.AddressBookMobile
                    {
                        mobile = m,
                        createDate = DateTime.Now,
                        uid = _User.Uid,
                        tguid = books.Where(b => b.Mobile == m).Select(b => b.TgUid).FirstOrDefault(),
                        company = books.Where(b => b.Mobile == m).Select(b => b.Company).FirstOrDefault(),
                        name = books.Where(b => b.Mobile == m).Select(b => b.Name).FirstOrDefault()
                    }));
                    _AddressBookMobileRepository.AddRange(result);
                    _AddressBookMobileRepository.SaveChanges();
                }
                _PushManager.GenContact(_User.Uid, _User.Mobile, result.Select(b => new FCRMAPI.Request.Contact() { Aid = b.id, Mobile = b.mobile }).ToArray());
            }
            return result;
        }
        public IQueryable<Data.AddressBookMobile> UserAddressBooks
        {
            get
            {
                return _AddressBookMobileRepository.Entities.Where(a => a.uid == _User.Uid);
            }
        }
        public IQueryable<Data.AddressBookMobile> GetAddressBookRegisterUser()
        {
            return _AddressBookMobileRepository.Entities.Where(a => a.uid == _User.Uid && a.tguid != null && a.tguid > 0);
        }
        public IQueryable<AddressBookMobile> GetAddressBookMobile(string[] mobiles)
        {
            mobiles = (mobiles ?? Enumerable.Empty<string>().ToArray()).Where(m => !String.IsNullOrWhiteSpace(m)).ToArray();
            if (mobiles == null || mobiles.Length == 0)
                return Enumerable.Empty<Data.AddressBookMobile>().AsQueryable();
            var source = _AddressBookMobileRepository.Entities.Where(a => a.uid == _User.Uid && mobiles.Contains(a.mobile));
            return source;
        }
        public PageModel<Model.UserAddressBookMobileModel> GetUserAddressBooks(string keyword, bool? isAttention, int? start, int? limit)
        {
            var source = _AddressBookMobileRepository.Entities.Where(a => a.uid == _User.Uid);
            if (!String.IsNullOrWhiteSpace(keyword))
            {
                source = source.Where(a => a.name.Contains(keyword));
            }
            if (isAttention.HasValue)
            {
                source = source.Where(a => a.isAttention == isAttention);
            }
            var count = source.Count();
            if (count == 0)
            {
                return new PageModel<Model.UserAddressBookMobileModel>(Enumerable.Empty<Model.UserAddressBookMobileModel>(), count);
            }
            start = start ?? 0;
            limit = limit ?? 20;
            var models = _AddressBookMobileRepository.GetUserAddressBooks(_User.Uid, keyword, isAttention, start.Value, limit.Value);
            return new PageModel<Model.UserAddressBookMobileModel>(models, count);
        }
        public void Attention(string mobile, bool attention)
        {
            ExceptionHelper.ThrowIfNullOrEmpty(mobile, nameof(mobile));
            var entity = _AddressBookMobileRepository.Entities.Where(a => a.uid == _User.Uid && a.mobile == mobile).FirstOrDefault();
            if (entity == null)
            {
                throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目);
            }
            if (entity.isAttention != attention)
            {
                entity.isAttention = attention;
                entity.attentionDate = DateTime.Now;
                _AddressBookMobileRepository.SaveChanges();
                if (attention)
                {
                    _UserEventFactory.CreateEvent(_User).OnAttention(mobile);
                }
            }
        }

        public Dictionary<long, AddressBookFriend> GetUserAddressFriend(long[] uids)
        {
            uids = uids ?? Enumerable.Empty<long>().Where(id => id > 0).Distinct().ToArray();
            if (uids.Length == 0)
                return new Dictionary<long, AddressBookFriend>();
            var users = _UserRepository.Entities.Where(p=>uids.Contains(p.uid)).Select(u => new { uid = u.uid, mobile = u.mobile }).ToArray();
            return  GetAddressBookMobile(users.Select(u => u.mobile).ToArray()).ToArray().Select(a => new {
                Uid = users.FirstOrDefault(u => u.mobile == a.mobile).uid,
                AddressBookFriend = new AddressBookFriend()
                {
                    Name = a.name,
                    Mobile = a.mobile
                }
            }).GroupBy(p => p.Uid).ToDictionary(p => p.Key, p => p.FirstOrDefault().AddressBookFriend);
            
        }

       
    }
}
