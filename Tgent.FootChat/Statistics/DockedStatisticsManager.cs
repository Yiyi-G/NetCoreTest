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
    public interface IDockedStatisticsManager
    {
        void Add(AddDockedStatisticsArgs args);       
        DockedStatistics GetYesterdayDockedStatistics();
        IQueryable<DockedStatistics> GetDockedStatistics();
    }

    public class DockedStatisticsManager : IDockedStatisticsManager
    {
        private readonly IRepository<DockedStatistics> _DockedStatisticsRepository;

        public DockedStatisticsManager(IRepository<DockedStatistics> dockedStatisticsRepository)
        {
            _DockedStatisticsRepository = dockedStatisticsRepository;
        }

        public void Add(AddDockedStatisticsArgs args)
        {
            var isExist = _DockedStatisticsRepository.Entities.AsNoTracking().Any(p => p.date == args.date);
            if (!isExist)
            {
                _DockedStatisticsRepository.Add(new DockedStatistics()
                {
                    date = args.date,
                    dockedTotalNum = args.dockedTotalNum,
                    todayDockedNum = args.todayDockedNum,
                    todaySuccessfulDockedNum = args.todaySuccessfulDockedNum,
                    agreedDockedTotalNum = args.agreedDockedTotalNum,
                    todayAgreedDockedNum = args.todayAgreedDockedNum,
                    todayRejectedDockedNum = args.todayRejectedDockedNum
                });
            }
            else
            {
                _DockedStatisticsRepository.Update(p => p.date == args.date, p => new DockedStatistics
                {
                    dockedTotalNum = args.dockedTotalNum,
                    todayDockedNum = args.todayDockedNum,
                    todaySuccessfulDockedNum = args.todaySuccessfulDockedNum,
                    agreedDockedTotalNum = args.agreedDockedTotalNum,
                    todayAgreedDockedNum = args.todayAgreedDockedNum,
                    todayRejectedDockedNum = args.todayRejectedDockedNum
                });
            }
            _DockedStatisticsRepository.SaveChanges();
        }

        public DockedStatistics GetYesterdayDockedStatistics()
        {
            var yesterday = DateTime.Now.AddDays(-1).Date;
            return _DockedStatisticsRepository.Entities.AsNoTracking().Where(p => System.Data.Entity.DbFunctions.DiffDays(yesterday, p.date) == 0).FirstOrDefault();
        }

        public IQueryable<DockedStatistics> GetDockedStatistics()
        {
            return _DockedStatisticsRepository.Entities.AsNoTracking();
        }
    }

    public class AddDockedStatisticsArgs
    {
        public DateTime date { get; set; }
        public int dockedTotalNum { get; set; }//对接请求总数
        public int todayDockedNum { get; set; }//每日对接请求数
        public int todaySuccessfulDockedNum { get; set; }//每日成功对接请求数
        public int agreedDockedTotalNum { get; set; }//同意对接总数
        public int todayAgreedDockedNum { get; set; }//每日同意对接
        public int todayRejectedDockedNum { get; set; }//每日拒绝对接
    }
}
