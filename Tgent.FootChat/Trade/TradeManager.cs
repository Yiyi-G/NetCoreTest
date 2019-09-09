using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;

namespace Tgnet.FootChat.Trade
{
    public interface ITradeManager
    {
        int GetTheDayPaidUserCount(DateTime date);
        bool CheckLastTradeIsUnpaid(long uid,DateTime? min);
        bool CheckHasUnpaid(long uid, DateTime? min);
    }

    public class TradeManager : ITradeManager
    {
        private readonly IRepository<Data.Trade> _TradeRepository;

        public TradeManager(IRepository<Data.Trade> tradeRepository)
        {
            _TradeRepository = tradeRepository;
        }

        public int GetTheDayPaidUserCount(DateTime date)
        {
            var startTime = date.Date;
            var endTime = date.AddDays(1).Date;
            return _TradeRepository.Entities.AsNoTracking().Where(p => p.paied.HasValue && p.paied.Value >= startTime && p.paied.Value< endTime).GroupBy(p => p.uid).Count();
        }

        public bool CheckLastTradeIsUnpaid(long uid, DateTime? min)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            var source = _TradeRepository.Entities.AsNoTracking().Where(p=>p.uid==uid);
            if (min.HasValue)
                source = source.Where(p => p.created > min.Value);
            source = source.OrderByDescending(p => p.created);
            var lastTrade = source.FirstOrDefault();
            return lastTrade != null && !lastTrade.isPaied;
        }

        public bool CheckHasUnpaid(long uid, DateTime? min)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            var source = _TradeRepository.Entities.AsNoTracking().Where(p => p.uid == uid&&!p.isPaied);
            if (min.HasValue)
                source = source.Where(p => p.created > min.Value);
            return source.Any();
        }
    }
}
