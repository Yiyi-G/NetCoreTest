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
    public interface IFootPrintStatisticsManager
    {
        void Add(AddFootPrintStatisticsArgs args);
        FootPrintStatistics GetYesterdayFootPrintStatistics();
        IQueryable<FootPrintStatistics> GetFootPrintStatistics();
    }
    public class FootPrintStatisticsManager : IFootPrintStatisticsManager
    {
        private readonly IRepository<FootPrintStatistics> _FootPrintStatisticsRepository;
        public FootPrintStatisticsManager(IRepository<FootPrintStatistics> footPrintStatisticsRepository)
        {
            _FootPrintStatisticsRepository = footPrintStatisticsRepository;
        }

        public void Add(AddFootPrintStatisticsArgs args)
        {
            var isExist = _FootPrintStatisticsRepository.Entities.AsNoTracking().Any(p => p.date == args.date);
            if (!isExist)
            {
                _FootPrintStatisticsRepository.Add(new FootPrintStatistics()
                {
                    date = args.date,
                    totalCount = args.totalCount,
                    totalPassFootPrintCount=args.totalPassFootPrintCount,
                    todayPassFootPrintCount = args.todayPassFootPrintCount,
                    todayUnPassFootPrintCount = args.todayUnPassFootPrintCount,
                    creatorCount = args.creatorCount,
                    todayCreatorCount = args.todayCreatorCount,
                    fpViewCount = args.fpViewCount,
                    totalViewUserCount = args.totalViewUserCount,
                    gt2FollowProjNum=args.gt2FollowProjNum,
                    gt2FollowUserNum=args.gt2FollowUserNum,
                });
            }
            else
            {
                _FootPrintStatisticsRepository.Update(p => p.date == args.date, p => new FootPrintStatistics
                {
                    totalCount = args.totalCount,
                    totalPassFootPrintCount = args.totalPassFootPrintCount,
                    todayPassFootPrintCount = args.todayPassFootPrintCount,
                    todayUnPassFootPrintCount = args.todayUnPassFootPrintCount,
                    creatorCount = args.creatorCount,
                    todayCreatorCount = args.todayCreatorCount,
                    fpViewCount = args.fpViewCount,
                    totalViewUserCount = args.totalViewUserCount,
                    gt2FollowProjNum = args.gt2FollowProjNum,
                    gt2FollowUserNum = args.gt2FollowUserNum,
                });
            }
            _FootPrintStatisticsRepository.SaveChanges();
        }

        public FootPrintStatistics GetYesterdayFootPrintStatistics()
        {
            var yesterday = DateTime.Now.AddDays(-1).Date;
            return _FootPrintStatisticsRepository.Entities.AsNoTracking().Where(p=> System.Data.Entity.DbFunctions.DiffDays(yesterday, p.date)==0).FirstOrDefault();
        }

        public IQueryable<FootPrintStatistics> GetFootPrintStatistics()
        {
            return _FootPrintStatisticsRepository.Entities.AsNoTracking();
        }
    }

    public class AddFootPrintStatisticsArgs
    {
        public DateTime date { get; set; }
        public int totalCount { get; set; }
        public int totalPassFootPrintCount { get; set; }
        public int todayPassFootPrintCount { get; set; }
        public int todayUnPassFootPrintCount { get; set; }
        public int creatorCount { get; set; }
        public int todayCreatorCount { get; set; }
        public int fpViewCount { get; set; }
        public int totalViewUserCount { get; set; }
        public int gt2FollowProjNum { get; set; }
        public int gt2FollowUserNum { get; set; }
    }
}
