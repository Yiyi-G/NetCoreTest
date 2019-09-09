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
    public interface IAttentionStatisticsManager
    {
        void Add(AddAttentionStatisticsArgs args);
        AttentionStatistics GetYesterdayAttentionStatistics();
        IQueryable<AttentionStatistics> GetAttentionStatistics();
    }
    public class AttentionStatisticsManager: IAttentionStatisticsManager
    {
        private readonly IRepository<AttentionStatistics> _AttentionStatisticsRepository;

        public AttentionStatisticsManager(IRepository<AttentionStatistics> attentionStatisticsRepository)
        {
            _AttentionStatisticsRepository = attentionStatisticsRepository;
        }


        public void Add(AddAttentionStatisticsArgs args)
        {
            var isExist = _AttentionStatisticsRepository.Entities.AsNoTracking().Any(p => p.date == args.date);
            if (!isExist)
            {
                _AttentionStatisticsRepository.Add(new AttentionStatistics()
                {
                    date=args.date,
                    attentionCount=args.attentionCount,
                    todayAttentionCount=args.todayAttentionCount,
                    attentionUserCount=args.attentionUserCount,
                    todayAttentionUserCount=args.todayAttentionUserCount,
                    invitationCount=args.invitationCount,
                    todayInvitationCount=args.todayInvitationCount,
                    successRate=args.successRate
                });
            }
            else
            {
                _AttentionStatisticsRepository.Update(p => p.date == args.date, p => new AttentionStatistics
                {
                    attentionCount = args.attentionCount,
                    todayAttentionCount = args.todayAttentionCount,
                    attentionUserCount = args.attentionUserCount,
                    todayAttentionUserCount = args.todayAttentionUserCount,
                    invitationCount = args.invitationCount,
                    todayInvitationCount = args.todayInvitationCount,
                    successRate = args.successRate
                });
            }
            _AttentionStatisticsRepository.SaveChanges();
        }

        public AttentionStatistics GetYesterdayAttentionStatistics()
        {
            var yesterday = DateTime.Now.AddDays(-1).Date;
            return _AttentionStatisticsRepository.Entities.AsNoTracking().Where(p => System.Data.Entity.DbFunctions.DiffDays(yesterday, p.date) == 0).FirstOrDefault();
        }

        public IQueryable<AttentionStatistics> GetAttentionStatistics()
        {
            return _AttentionStatisticsRepository.Entities.AsNoTracking();
        }
    }

    public class AddAttentionStatisticsArgs
    {
        public DateTime date { get; set; }
        public int attentionCount { get; set; }
        public int todayAttentionCount { get; set; }
        public int attentionUserCount { get; set; }
        public int todayAttentionUserCount { get; set; }
        public int invitationCount { get; set; }
        public int todayInvitationCount { get; set; }
        public decimal successRate { get; set; }
    }
}
