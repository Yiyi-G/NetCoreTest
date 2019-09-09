using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Models;
using Tgnet.Linq;

namespace Tgnet.FootChat.InstitudeOfGrowth
{
    public interface IClassServiceFactory
    {
        IClassService GetService(long classId);
    }

    public class ClassServiceFactory : IClassServiceFactory
    {
        private readonly IRepository<Data.Class> _ClassRepository;
        private readonly IRepository<Data.ClassStuRelation> _ClassStuRelationRepository;
        public ClassServiceFactory(IRepository<Data.Class> classRepository,
            IRepository<Data.ClassStuRelation> classStuRelationRepository)
        {
            _ClassRepository = classRepository;
            _ClassStuRelationRepository = classStuRelationRepository;
        }

        public IClassService GetService(long classId)
        {
            return new ClassService(classId, _ClassRepository, _ClassStuRelationRepository);
        }
    }

    public interface IClassService
    {
        #region 属性
        long ClassId { get; }
        string Name { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        string Property { get; }
        InsOfGrowthClassType Type { get; }
        bool IsEnable { get; }
        #endregion
        bool UpdateClassInfo(AddOrUpdateClassModel model);
        void SetClassIsEnable(bool isEnable);
        int GetClassStuNum();
        IQueryable<long> GetClassUserId();
        Dictionary<long, ClassCommitteeType?> GetStuClassCommittee(long[] stuIds);
    }
    public class ClassService: IClassService
    {
        private readonly long _ClassId;
        private readonly Lazy<Data.Class> _LazyEntity;
        private readonly IRepository<Data.Class> _ClassRepository;
        private readonly IRepository<Data.ClassStuRelation> _ClassStuRelationRepository;
        public ClassService(long classId,
            IRepository<Data.Class> classRepository,
            IRepository<Data.ClassStuRelation> classStuRelationRepository
            )
        {
            ExceptionHelper.ThrowIfNotId(classId, nameof(classId));
            _ClassId = classId;
            _ClassRepository = classRepository;
            _ClassStuRelationRepository = classStuRelationRepository;
            _LazyEntity = new Lazy<Data.Class>(() =>
            {
                var entity = _ClassRepository.Entities.FirstOrDefault(p => p.classId == classId);
                if (entity == null)
                    throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目);
                return entity;
            });
        }

        public long ClassId
        {
            get
            {
                return _LazyEntity.Value.classId;
            }
        }

        public string Name
        {
            get
            {
                return _LazyEntity.Value.name;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _LazyEntity.Value.startDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _LazyEntity.Value.endDate;
            }
        }

        public string Property
        {
            get
            {
                return _LazyEntity.Value.property;
            }
        }

        public InsOfGrowthClassType Type
        {
            get
            {
                return _LazyEntity.Value.type;
            }
        }

        public bool IsEnable
        {
            get
            {
                return _LazyEntity.Value.isEnable;
            }
        }

        public bool UpdateClassInfo(AddOrUpdateClassModel model)
        {
            ExceptionHelper.ThrowIfNull(model, nameof(model));
            bool isUpdate = false;
            if (!string.IsNullOrWhiteSpace(model.Name))
            {
                _LazyEntity.Value.name = model.Name;
                isUpdate = true;
            }
            if (model.StartDate!= StartDate)
            {
                _LazyEntity.Value.startDate = model.StartDate;
                isUpdate = true;
            }
            if (model.EndDate != EndDate)
            {
                _LazyEntity.Value.endDate = model.EndDate;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.Property))
            {
                _LazyEntity.Value.property = model.Property;
                isUpdate = true;
            }
            if (isUpdate)
            {
                _ClassRepository.SaveChanges();
            }
            return isUpdate;
        }

        public void SetClassIsEnable(bool isEnable)
        {
            if (isEnable != IsEnable)
            {
                _LazyEntity.Value.isEnable = isEnable;
                _ClassRepository.SaveChanges();
            }
        }

        public int GetClassStuNum()
        {
            return _ClassStuRelationRepository.Entities.AsNoTracking().Where(p => p.classId == ClassId).Count();
        }

        public IQueryable<long> GetClassUserId()
        {
            return _ClassStuRelationRepository.Entities.AsNoTracking().Where(p => p.classId == ClassId).Select(p => p.uid).Distinct();
        }

        public Dictionary<long, ClassCommitteeType?> GetStuClassCommittee(long[] stuIds)
        {
            var result = new Dictionary<long, ClassCommitteeType?>();
            stuIds = (stuIds ?? new long[0]).Where(id => id > 0).Distinct().ToArray();
            if (stuIds.Length <= 0) return result;
            result = _ClassStuRelationRepository.Entities.AsNoTracking().Where(p => p.classId == ClassId && stuIds.Contains(p.uid))
                .GroupBy(p => p.uid).ToDictionary(p => p.Key, p => p.FirstOrDefault().committeeType);
            return result;
        }
    }
}
