using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Models;
using Tgnet.Linq;

namespace Tgnet.FootChat.InstitudeOfGrowth
{
    public interface IClassManager
    {
        void AddClass(AddOrUpdateClassModel args);
        IQueryable<Data.Class> GetClass();
        Dictionary<long, Data.Class> GetClassInfoDict(long[] stuIds);
        Dictionary<long, string> GetStuClassStateDict(long[] stuIds);
    }

    public class ClassManager: IClassManager
    {
        private readonly IRepository<Data.Class> _ClassRepository;
        private readonly IRepository<Data.ClassStuRelation> _ClassStuRelationRepository;

        public ClassManager(IRepository<Data.Class> classRepository,
            IRepository<Data.ClassStuRelation> classStuRelationRepository)
        {
            _ClassRepository = classRepository;
            _ClassStuRelationRepository = classStuRelationRepository;
        }

        public void AddClass(AddOrUpdateClassModel args)
        {
            var isExist = _ClassRepository.Entities.AsNoTracking().Any(p => p.name== args.Name.Trim());
            ExceptionHelper.ThrowIfTrue(isExist,nameof(args.Name),"添加的班级已存在");
            if (!isExist)
            {
                _ClassRepository.Add(new Data.Class()
                {
                    name = args.Name,
                    startDate = args.StartDate,
                    endDate = args.EndDate,
                    property= args.Property,//班级属性
                    type=InsOfGrowthClassType.None,//班级类型（默认没类型）
                    isEnable=true
                });
                _ClassRepository.SaveChanges();
            }
        }

        public IQueryable<Data.Class> GetClass()
        {
            return _ClassRepository.Entities.AsNoTracking();
        }

        public Dictionary<long, Data.Class> GetClassInfoDict(long[] stuIds)
        {
            var result = new Dictionary<long, Data.Class>();
            stuIds = (stuIds ?? new long[0]).Where(id => id > 0).Distinct().ToArray();
            if (stuIds.Length <= 0) return result;
            var classStuRelation=_ClassStuRelationRepository.Entities.AsNoTracking().Where(p => stuIds.Contains(p.uid));
            if (classStuRelation.Any())
            {
                var source = from csr in classStuRelation
                             join classInfo in _ClassRepository.Entities.AsNoTracking()
                             on csr.classId equals classInfo.classId
                             select new
                             {
                                 uid = csr.uid,
                                 classinfo = classInfo
                             };
                result = source.GroupBy(p => p.uid).ToDictionary(p => p.Key, p => p.FirstOrDefault().classinfo);
            }
            return result;
        }

        public Dictionary<long, string> GetStuClassStateDict(long[] stuIds)
        {
            var result = new Dictionary<long, string>();
            stuIds = (stuIds ?? new long[0]).Where(id => id > 0).Distinct().ToArray();
            if (stuIds.Length <= 0) return result;
            var inClass=_ClassStuRelationRepository.Entities.AsNoTracking().Where(p => stuIds.Contains(p.uid)).GroupBy(p=>p.uid).ToDictionary(p=>p.Key,p=>"已分班");
            var inClassUid = inClass.Select(p => p.Key).Distinct().ToArray();
            var notInClass= stuIds.Where(p => !inClassUid.Contains(p)).GroupBy(p => p).ToDictionary(p => p.Key, p => "未分班");
            result=MergeDictionary(inClass, notInClass);
            return result;
        }

        private Dictionary<long, string> MergeDictionary(Dictionary<long, string> first, Dictionary<long, string> second)
        {
            if (first == null) first = new Dictionary<long, string>();
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
