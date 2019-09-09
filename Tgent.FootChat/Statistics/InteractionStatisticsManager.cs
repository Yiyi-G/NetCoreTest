using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Statistics
{
    public interface IInteractionStatisticsManager
    {
        void Add(AddInteractionStatisticsArgs args);
        InteractionStatistics GetYesterdayInteractionStatistics();
        IQueryable<InteractionStatistics> GetInteractionStatistics();
    }

    public class InteractionStatisticsManager: IInteractionStatisticsManager
    {
        private readonly IRepository<InteractionStatistics> _Repository;

        public InteractionStatisticsManager(IRepository<InteractionStatistics> repository)
        {
            _Repository = repository;
        }

        public void Add(AddInteractionStatisticsArgs args)
        {
            var isExist = _Repository.Entities.AsNoTracking().Any(p => p.date == args.date);
            if (!isExist)
            {
                _Repository.Add(new InteractionStatistics()
                {
                    date = args.date,
                    callTotalNum=args.callTotalNum,
                    todayCallTotalNum=args.todayCallTotalNum,
                    callUserNum=args.callUserNum,
                    vipCallTotalNum=args.vipCallTotalNum,
                    vipTodayCallTotalNum=args.vipTodayCallTotalNum,
                    vipCallUserNum=args.vipCallUserNum,
                    todayVipCallUserNum=args.todayVipCallUserNum
                });
            }
            else
            {
                _Repository.Update(p => p.date == args.date, p => new InteractionStatistics
                {
                    callTotalNum = args.callTotalNum,
                    todayCallTotalNum = args.todayCallTotalNum,
                    callUserNum = args.callUserNum,
                    vipCallTotalNum = args.vipCallTotalNum,
                    vipTodayCallTotalNum = args.vipTodayCallTotalNum,
                    vipCallUserNum = args.vipCallUserNum,
                    todayVipCallUserNum = args.todayVipCallUserNum
                });
            }
            _Repository.SaveChanges();
        }

        public InteractionStatistics GetYesterdayInteractionStatistics()
        {
            var yesterday = DateTime.Now.AddDays(-1).Date;
            return _Repository.Entities.AsNoTracking().Where(p => System.Data.Entity.DbFunctions.DiffDays(yesterday, p.date) == 0).FirstOrDefault();
        }

        public IQueryable<InteractionStatistics> GetInteractionStatistics()
        {
            return _Repository.Entities.AsNoTracking();
        }
    }

    public class AddInteractionStatisticsArgs
    {
        public DateTime date { get; set; }
        public int callTotalNum { get; set; }
        public int todayCallTotalNum { get; set; }
        public int callUserNum { get; set; }
        public int vipCallTotalNum { get; set; }
        public int vipTodayCallTotalNum { get; set; }
        public int vipCallUserNum { get; set; }
        public int todayVipCallUserNum { get; set; }
    }
}
