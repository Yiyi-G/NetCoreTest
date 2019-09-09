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
    public interface IUserStatisticsManager
    {
        void Add(AddUserStatisticsArgs args);
        UserStatistics GetYesterdayUserStatistics();
        IQueryable<UserStatistics> GetUserStatistics();
    }
    public class UserStatisticsManager: IUserStatisticsManager
    {
        private readonly IRepository<UserStatistics> _UserStatisticsRepository;

        public UserStatisticsManager(IRepository<UserStatistics> userStatisticsRepository)
        {
            _UserStatisticsRepository = userStatisticsRepository;
        }

        public void Add(AddUserStatisticsArgs args)
        {
            var isExist=_UserStatisticsRepository.Entities.AsNoTracking().Any(p => p.date == args.date);
            if (!isExist)
            {
                _UserStatisticsRepository.Add(new UserStatistics()
                {
                    date = args.date,
                    totalCount = args.totalCount,
                    todayCreatedCount = args.todayCreatedCount,
                    verifiedCount = args.verifiedCount,
                    todayPassCount = args.todayPassCount,
                    todayUnPassCount = args.todayUnPassCount,
                    trailUserCount = args.trailUserCount,
                    officialUserCount = args.officialUserCount,
                    todayPaidUserCount = args.todayPaidUserCount,
                    paidRate = args.paidRate,
                });
            }
            else
            {
                _UserStatisticsRepository.Update(p=>p.date==args.date,p=>new UserStatistics
                {
                    totalCount = args.totalCount,
                    todayCreatedCount = args.todayCreatedCount,
                    verifiedCount = args.verifiedCount,
                    todayPassCount = args.todayPassCount,
                    todayUnPassCount = args.todayUnPassCount,
                    trailUserCount = args.trailUserCount,
                    officialUserCount = args.officialUserCount,
                    todayPaidUserCount = args.todayPaidUserCount,
                    paidRate = args.paidRate,
                });
            }
            _UserStatisticsRepository.SaveChanges();
        }

        public UserStatistics GetYesterdayUserStatistics()
        {
            var yesterday = DateTime.Now.AddDays(-1).Date;
            return _UserStatisticsRepository.Entities.AsNoTracking().Where(p => System.Data.Entity.DbFunctions.DiffDays(yesterday, p.date) == 0).FirstOrDefault();
        }

        public IQueryable<UserStatistics> GetUserStatistics()
        {
            return _UserStatisticsRepository.Entities.AsNoTracking();
        }
    }

    public class AddUserStatisticsArgs
    {
        public DateTime date { get; set; }
        public int totalCount { get; set; }
        public int todayCreatedCount { get; set; }
        public int verifiedCount { get; set; }
        public int todayPassCount { get; set; }
        public int todayUnPassCount { get; set; }
        public int trailUserCount { get; set; }
        public int officialUserCount { get; set; }
        public int todayPaidUserCount { get; set; }
        public decimal paidRate { get; set; }
    }
}
