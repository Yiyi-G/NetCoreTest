using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet.Core;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Trade;

namespace Tgnet.FootChat.User
{
    public interface IServiceStateService
    {
        DateTime Expired { get; }
        UserServiceLevel UserLevel { get; }
        long Uid { get; }
        void OpenTrail(int days);
        IUserService User { get; }
        void CreateTrade(string tradeNo, TradeType type, TradeExtension extension, decimal total, long? seller, Payment payment);
        void Confirm(string tradeNo);
        Data.Trade LastTradeRecord { get; }
        void AddServiceTime(int days);

    }
    public class ServiceStateService : IServiceStateService
    {
        private readonly IUserService _User;
        private readonly IUserServiceStateRepository _UserServiceStateRepository;
        private readonly IRepository<Data.Trade> _TradeRepository;
        private readonly IRepository<Data.UserServiceStateUpdateRecord> _UserServiceStateUpdateRecordRepository;
        private readonly Lazy<Data.FootCharUserServiceState> _LazyValue;


        public UserServiceLevel UserLevel
        {
            get
            {
                return _LazyValue.Value.level;
            }
        }

        public DateTime Expired
        {
            get
            {
                return _LazyValue.Value.expired;
            }
        }

        public long Uid
        {
            get
            {
                return _User.Uid;
            }
        }

        public IUserService User
        {
            get
            {
                return _User;
            }
        }

        public Data.Trade LastTradeRecord
        {
            get
            {
                return _TradeRepository.Entities.Where(t => t.uid == _User.Uid).OrderByDescending(t => t.created).FirstOrDefault();
            }
        }

        public ServiceStateService(
        IUserService user,
        IUserServiceStateRepository userServiceStateRepository,
        IRepository<Data.Trade> tradeRepository,
        IRepository<Data.UserServiceStateUpdateRecord> userServiceStateUpdateRecordRepository
        )
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user), "user不能为空");
            _User = user;
            _UserServiceStateRepository = userServiceStateRepository;
            _TradeRepository = tradeRepository;
            _UserServiceStateUpdateRecordRepository = userServiceStateUpdateRecordRepository;
            _LazyValue = new Lazy<Data.FootCharUserServiceState>(() =>
            {
                return GetOrCreate();
            });
        }
        public Data.FootCharUserServiceState GetOrCreate()
        {
            var now = DateTime.Now;
            var entity = _UserServiceStateRepository.Entities.Where(p => p.uid == _User.Uid).FirstOrDefault();
            if (entity == null)
            {
                entity = new FootCharUserServiceState
                {
                    uid = _User.Uid,
                    expired = now,
                    level = UserServiceLevel.Normal,
                    updated = now
                };
                _UserServiceStateRepository.Add(entity);
                _UserServiceStateRepository.SaveChanges();
            }
            return entity;
        }

        public void OpenTrail(int days)
        {
            ExceptionHelper.ThrowIfTrue(UserLevel != UserServiceLevel.Normal, "只有普通会员可以开通试用");
            ExceptionHelper.ThrowIfTrue(days <= 0, "赠送天数需要大于0");
            var addTime = TimeSpan.FromDays(days);
            var now = DateTime.Now;
            var max = _LazyValue.Value.expired > now ? _LazyValue.Value.expired : now;
            using (var scope = new TransactionScope())
            {
                _LazyValue.Value.level = UserServiceLevel.Trail;
                _LazyValue.Value.expired = max.Add(addTime);
                _UserServiceStateRepository.SaveChanges();
                AddServiceRecord(ServiceRecordType.OpenTrail, addTime, "");
                scope.Complete();
            }

        }

        public void CreateTrade(string tradeNo, TradeType type, TradeExtension extension, decimal total, long? seller, Payment payment)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(tradeNo, "tradeNo");
            ExceptionHelper.ThrowIfTrue(total < 0, "total");
            ExceptionHelper.ThrowIfNull(extension, "extension");

            var entity = new Data.Trade
            {
                created = DateTime.Now,
                isPaied = false,
                total = total,
                tradeNo = tradeNo.Trim(),
                type = type,
                uid = _User.Uid,
                isDelete = false,
                buySuccess = false,
                seller = seller,
                payment = payment,
                extension = Newtonsoft.Json.JsonConvert.SerializeObject(extension),
            };
            _TradeRepository.Add(entity);
            _TradeRepository.SaveChanges();
        }
        public void Confirm(string tradeNo)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(tradeNo, "tradeNo");
            tradeNo = tradeNo.Trim();

            var entity = _TradeRepository.Entities.FirstOrDefault(t => t.tradeNo == tradeNo);

            if (!entity.isPaied)
            {
                entity.isPaied = true;
                entity.paied = DateTime.Now;
                _TradeRepository.SaveChanges();
            }
            if (!entity.buySuccess)
            {
                using (var scope = new System.Transactions.TransactionScope())
                {
                    entity.buySuccess = true;
                    entity.successed = DateTime.Now;
                    _TradeRepository.SaveChanges();
                    var tradeExtension = Newtonsoft.Json.JsonConvert.DeserializeObject<TradeExtension>(entity.extension);
                    OpenService(tradeExtension.timeSpan, tradeNo);
                    scope.Complete();
                }
            }
        }
        private void OpenService(TimeSpan addTime, string tradeNo)
        {
            using (var scope = new System.Transactions.TransactionScope())
            {
                var now = DateTime.Now;
                _LazyValue.Value.level = UserServiceLevel.Official;
                _LazyValue.Value.updated = now;
                var expired = now > _LazyValue.Value.expired ? now : _LazyValue.Value.expired;
                _LazyValue.Value.expired = expired.Add(addTime);
                _UserServiceStateRepository.SaveChanges();
                AddServiceRecord(ServiceRecordType.BuyService, addTime, String.Format("购买服务{0}天", addTime.Days));
                scope.Complete();
            }
        }

        /// <summary>
        /// 添加服务时间
        /// </summary>
        /// <param name="days"></param>
        public void AddServiceTime(int days)
        {
            ExceptionHelper.ThrowIfTrue(days <= 0, "赠送天数需要大于0");
            var addTime = TimeSpan.FromDays(days);
            var now = DateTime.Now;
            var max = _LazyValue.Value.expired > now ? _LazyValue.Value.expired : now;
            _LazyValue.Value.expired = max.Add(addTime);
            _UserServiceStateRepository.SaveChanges();
        }

        private void AddServiceRecord(ServiceRecordType type, TimeSpan addTime, string remark)
        {
            var now = DateTime.Now;
            var uid = _User.Uid;
            var day = (int)Math.Ceiling(addTime.TotalDays);
            _UserServiceStateUpdateRecordRepository.Add(new UserServiceStateUpdateRecord()
            {
                uid = uid,
                creted = now,
                IncreaseDays = day,
                remark = remark,
                type = type
            });
            _UserServiceStateUpdateRecordRepository.SaveChanges();
        }

    }

}
