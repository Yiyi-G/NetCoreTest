using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.InstitudeOfGrowth
{
    public interface IInstitudeOfGrowthManager
    {
        IInsitudeOfGrowthUserService GetService(IUserService user);
        Dictionary<long, StudentInfo> GetStudentInfoDict(long[] stuIds);
        PageModel<SearchStudentResult> SearchStudent(SearchStudentArgs args, int start, int limit);
        Dictionary<long, InsOfGrowthPayState> GetStuPayState(long[] stuIds);
        int GetPaidUserNum();
        int GetWaitingToBeDividedNum();
        bool CheckStuIsExist(long uid);
    }
    public class InstitudeOfGrowthManager : IInstitudeOfGrowthManager
    {
        private readonly IRepository<Data.InstitudeOfGrowthTrade> _InstitudeOfGrowthTradeRepository;
        private readonly IStudentRepository _StudentRepository;
        private readonly IRepository<Data.Class> _ClassRepository;
        private readonly IRepository<Data.ClassStuRelation> _ClassStuRelationRepository;

        public InstitudeOfGrowthManager(
        IRepository<Data.InstitudeOfGrowthTrade> institudeOfGrowthTradeRepository,
        IStudentRepository studentRepository,
        IRepository<Data.Class> classRepository,
        IRepository<Data.ClassStuRelation> classStuRelationRepository
            )
        {
            _InstitudeOfGrowthTradeRepository = institudeOfGrowthTradeRepository;
            _StudentRepository = studentRepository;
            _ClassRepository = classRepository;
            _ClassStuRelationRepository = classStuRelationRepository;
        }
        public IInsitudeOfGrowthUserService GetService(IUserService user)
        {
           return new InsitudeOfGrowthUserService(user, _InstitudeOfGrowthTradeRepository, _StudentRepository, _ClassRepository, _ClassStuRelationRepository);
        }

        public Dictionary<long, StudentInfo> GetStudentInfoDict(long[] stuIds)
        {
            var result = new Dictionary<long, StudentInfo>();
            stuIds = (stuIds ?? new long[0]).Where(id => id > 0).Distinct().ToArray();
            if (stuIds.Length <= 0) return result;
            var source = _StudentRepository.Entities.AsNoTracking().Where(p => stuIds.Contains(p.uid)).ToArray();
            if (source.Any())
            {
                var studentInfo = source.Select(p => new StudentInfo(p)).ToArray();
                result = studentInfo.GroupBy(p => p.Uid).ToDictionary(p => p.Key, p => p.FirstOrDefault());
            }
            return result;
        }

        public bool CheckStuIsExist(long uid)
        {
            return _StudentRepository.Entities.AsNoTracking().Any(p => p.uid==uid);
        }


        public PageModel<SearchStudentResult> SearchStudent(SearchStudentArgs args, int start, int limit)
        {
            return _StudentRepository.SearchStudent(args, start, limit);
        }

        public Dictionary<long, InsOfGrowthPayState> GetStuPayState(long[] stuIds)
        {
            var result = new Dictionary<long, InsOfGrowthPayState>();
            stuIds = (stuIds ?? new long[0]).Where(id => id > 0).Distinct().ToArray();
            if (stuIds.Length <= 0) return result;           
            //在trade表里已支付
            var paidDict = _InstitudeOfGrowthTradeRepository.Entities.AsNoTracking().Where(p => stuIds.Contains(p.uid) && p.isPaied)
                .GroupBy(p=>p.uid).ToDictionary(p=>p.Key,p=> InsOfGrowthPayState.Paid);
            //在trade表里未支付
            var unPaidDict = _InstitudeOfGrowthTradeRepository.Entities.AsNoTracking().Where(p => stuIds.Contains(p.uid) && !p.isPaied)
                .GroupBy(p => p.uid).ToDictionary(p => p.Key, p => InsOfGrowthPayState.Unpaid);

            //不在trade表的未支付
            List<long> tradeUids = new List<long>();
            var paidUid = paidDict.Select(p => p.Key).Distinct().ToArray();
            var unPaidUid = unPaidDict.Select(p => p.Key).Distinct().ToArray();
            tradeUids.AddRange(paidUid);
            tradeUids.AddRange(unPaidUid);
            var inTradeUids = tradeUids.Distinct().ToArray();
            var notInTradeTable= stuIds.Where(p => !inTradeUids.Contains(p)).GroupBy(p => p).ToDictionary(p => p.Key, p => InsOfGrowthPayState.Unpaid);
            //已退款


            result = MergeDictionary(paidDict, unPaidDict);
            result= MergeDictionary(result, notInTradeTable);
            return result;
        }

        /// <summary>
        /// 获取已付费多少人
        /// </summary>
        /// <returns></returns>
        public int GetPaidUserNum()
        {
            return _InstitudeOfGrowthTradeRepository.Entities.AsNoTracking().Where(p => p.isPaied&&p.buySuccess&&!p.isDelete).Select(p=>p.uid).Distinct().Count();
        }

        /// <summary>
        /// 获取待分班人数
        /// </summary>
        /// <returns></returns>
        public int GetWaitingToBeDividedNum()
        {
            return _StudentRepository.GetWaitingToBeDividedNum();
        }

        /// <summary>
        /// 合并字典
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private Dictionary<long, InsOfGrowthPayState> MergeDictionary(Dictionary<long, InsOfGrowthPayState> first, Dictionary<long, InsOfGrowthPayState> second)
        {
            if (first == null) first = new Dictionary<long, InsOfGrowthPayState>();
            if (second == null) return first;
            foreach (var item in second)
            {
                if (!first.ContainsKey(item.Key))
                {
                    first.Add(item.Key, item.Value);
                }
            }
            return first;
        }
    }
}
