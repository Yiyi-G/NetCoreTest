using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.Trade;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.InstitudeOfGrowth
{
    public interface IInsitudeOfGrowthUserService
    {
        #region 属性
        string Name { get; }
        User.UserSex? Sex { get; }
        string WeChat { get; }
        string Products { get; }
        string Company { get; }
        string Job { get; }
        string BussinessAreas { get; }
        int? YearOfWorking { get; }
        string StageNos { get; }
        string NeedCustomSource { get; }
        string NeedCooperateProduct { get; }
        double? LastYearAchievement { get; }
        double? ThisYearGoal { get; }
        string NecessaryDoTypes { get; }
        bool IsBuy { get; }
        string Mobile { get; }
        DateTime Created { get; }
        IQueryable<Data.InstitudeOfGrowthTrade> Trades { get; }
        #endregion
        void CreateTrade(string tradeNo, TradeType type, TradeExtension extension, decimal total, long? seller, Payment payment, ProductType productType);
        void Confirm(string tradeNo);
        void UpdateInfo(UpdateStudentInfoModel model);
        StuClassInfo GetStuClassInfo();
        void ChangeUserClass(long? oldClassId, long? changeToClassId);
        void NominateClassCommittee(long classId, ClassCommitteeType? classCommittee);
    }
    public class InsitudeOfGrowthUserService : IInsitudeOfGrowthUserService
    {
        private readonly User.IUserService _User;
        private readonly Lazy<Data.Student> _LazyValue;
        private readonly IRepository<Data.InstitudeOfGrowthTrade> _InstitudeOfGrowthTradeRepository;
        private readonly IStudentRepository _StudentRepository;
        private readonly IRepository<Data.Class> _ClassRepository;
        private readonly IRepository<Data.ClassStuRelation> _ClassStuRelationRepository;

        public InsitudeOfGrowthUserService(User.IUserService user,
       IRepository<Data.InstitudeOfGrowthTrade> institudeOfGrowthTradeRepository,
       IStudentRepository studentRepository,
       IRepository<Data.Class> classRepository,
       IRepository<Data.ClassStuRelation> classStuRelationRepository)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            _User = user;
            _InstitudeOfGrowthTradeRepository = institudeOfGrowthTradeRepository;
            _StudentRepository = studentRepository;
            _ClassRepository = classRepository;
            _ClassStuRelationRepository = classStuRelationRepository;
            _LazyValue = new Lazy<Data.Student>(() => { return GetOrCreate(); });
        }
        public string Name => _LazyValue.Value.name;

        public UserSex? Sex => _LazyValue.Value.sex;

        public string WeChat => _LazyValue.Value.weChat;

        public string Products => _LazyValue.Value.products;

        public string Company => _LazyValue.Value.company;

        public string Job => _LazyValue.Value.job;

        public string BussinessAreas => _LazyValue.Value.bussinessAreas;

        public int? YearOfWorking => _LazyValue.Value.yearOfWorking;

        public string StageNos => _LazyValue.Value.stageNos;

        public string NeedCustomSource => _LazyValue.Value.needCustomSource;

        public string NeedCooperateProduct => _LazyValue.Value.needCooperateProduct;

        public double? LastYearAchievement => _LazyValue.Value.lastYearAchievement;

        public double? ThisYearGoal => _LazyValue.Value.thisYearGoal;

        public string NecessaryDoTypes => _LazyValue.Value.necessaryDoType;

        public bool IsBuy
        {
            get
            {
                return _LazyValue.Value.isBuy;
            }
        }

        public IQueryable<InstitudeOfGrowthTrade> Trades
        {
            get
            {
                var uid = _User.Uid;
                return _InstitudeOfGrowthTradeRepository.Entities.Where(p => p.uid == uid);
            }
        }

        public string Mobile
        {
            get
            {
                return _User.Mobile;
            }
        }

        public DateTime Created
        {
            get
            {
                return _LazyValue.Value.created;
            }
        }

        /// <summary>
        /// 获取学生班级信息
        /// </summary>
        /// <returns></returns>
        public StuClassInfo GetStuClassInfo()
        {
            var uid = _User.Uid;
            var classStuRelation = _ClassStuRelationRepository.Entities.AsNoTracking().Where(p => p.uid == uid).FirstOrDefault();
            var stuClassInfo = new StuClassInfo();
            if (classStuRelation != null)
            {
                var classId = classStuRelation.classId;
                var classInfo = _ClassRepository.Entities.AsNoTracking().Where(p => p.classId == classId).FirstOrDefault();
                if (classInfo != null)
                {
                    stuClassInfo.ClassId = classId;
                    stuClassInfo.ClassName = classInfo.name;
                    stuClassInfo.StartDate = classInfo.startDate;
                    stuClassInfo.EndDate = classInfo.endDate;
                    stuClassInfo.Property = classInfo.property;
                    stuClassInfo.IsEnable = classInfo.isEnable;
                    stuClassInfo.ClassCommittee = classStuRelation.committeeType;
                }
            }
            return stuClassInfo;
        }


        public Data.Student GetOrCreate()
        {
            var now = DateTime.Now;
            var entity = _StudentRepository.Entities.Where(p => p.uid == _User.Uid).FirstOrDefault();
            if (entity == null)
            {
                entity = new Data.Student
                {
                    uid = _User.Uid,
                    created = now,
                    updated = now
                };
                _StudentRepository.Add(entity);
                _StudentRepository.SaveChanges();
            }
            return entity;
        }
        public void Confirm(string tradeNo)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(tradeNo, "tradeNo");
            tradeNo = tradeNo.Trim();
            var now = DateTime.Now;
            using (var scope = new TransactionScope())
            {
                var entity = _InstitudeOfGrowthTradeRepository.Entities.FirstOrDefault(t => t.tradeNo == tradeNo);
                if (!entity.isPaied)
                {
                    entity.isPaied = true;
                    entity.paied = now;
                    entity.buySuccess = true;
                    entity.successed = now;
                    var tradeExtension = Newtonsoft.Json.JsonConvert.DeserializeObject<TradeExtension>(entity.extension);
                    _InstitudeOfGrowthTradeRepository.SaveChanges();
                }
                _LazyValue.Value.isBuy = true;
                _LazyValue.Value.buyDate = now;
                _StudentRepository.SaveChanges();
                scope.Complete();
            }

        }

        public void CreateTrade(string tradeNo, TradeType type, TradeExtension extension, decimal total, long? seller, Payment payment, ProductType productType)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(tradeNo, "tradeNo");
            ExceptionHelper.ThrowIfTrue(total < 0, "total");
            ExceptionHelper.ThrowIfNull(extension, "extension");

            var entity = new Data.InstitudeOfGrowthTrade
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
                pType = productType,
                extension = Newtonsoft.Json.JsonConvert.SerializeObject(extension),
            };
            _InstitudeOfGrowthTradeRepository.Add(entity);
            _InstitudeOfGrowthTradeRepository.SaveChanges();
        }

        public void UpdateInfo(UpdateStudentInfoModel model)
        {
            ExceptionHelper.ThrowIfNull(model, nameof(model));
            model.Convert();
            var uid = _User.Uid;
            var now = DateTime.Now;
            //using (var scope = new TransactionScope())
            //{
            bool isUpdate = false;
            if (!string.IsNullOrWhiteSpace(model.Name))
            {
                _LazyValue.Value.name = model.Name;
                isUpdate = true;
            }
            if (model.Sex.HasValue)
            {
                _LazyValue.Value.sex = model.Sex;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.WeChat))
            {
                _LazyValue.Value.weChat = model.WeChat;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.Products))
            {
                _LazyValue.Value.products = model.Products;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.Company))
            {
                _LazyValue.Value.company = model.Company;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.Job))
            {
                _LazyValue.Value.job = model.Job;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.BussinessAreas))
            {
                _LazyValue.Value.bussinessAreas = model.BussinessAreas;
                isUpdate = true;
            }
            if (model.YearOfWorking.HasValue)
            {
                _LazyValue.Value.yearOfWorking = model.YearOfWorking;
                isUpdate = true;
            }

            if (!string.IsNullOrWhiteSpace(model.StageNos))
            {
                _LazyValue.Value.stageNos = model.StageNos;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.NeedCustomSource))
            {
                _LazyValue.Value.needCustomSource = model.NeedCustomSource;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.NeedCooperateProduct))
            {
                _LazyValue.Value.needCooperateProduct = model.NeedCooperateProduct;
                isUpdate = true;
            }
            if (model.LastYearAchievement.HasValue)
            {
                _LazyValue.Value.lastYearAchievement = model.LastYearAchievement;
                isUpdate = true;
            }
            if (model.ThisYearGoal.HasValue)
            {
                _LazyValue.Value.thisYearGoal = model.ThisYearGoal;
                isUpdate = true;
            }
            if (!string.IsNullOrWhiteSpace(model.NecessaryDoTypes))
            {
                _LazyValue.Value.necessaryDoType = model.NecessaryDoTypes;
                isUpdate = true;
            }
            if (isUpdate)
            {
                _LazyValue.Value.updated = now;
                _StudentRepository.SaveChanges();
            }
            //    scope.Complete();
            //}

        }



        /// <summary>
        /// 更换班级
        /// </summary>
        /// <param name="oldClassId">旧班级id</param>
        /// <param name="changeToclassId">新班级id</param>
        public void ChangeUserClass(long? oldClassId, long? changeToClassId)
        {
            //判断是否付款
            var isPaid = Trades.Any(p => p.isPaied);
            ExceptionHelper.ThrowIfTrue(!isPaid, "isPaid", "该用户未付款，不能进行此操作");
            if (oldClassId.HasValue)
            {
                if (changeToClassId.HasValue)
                {
                    //修改班级
                    UpdateClass(oldClassId.Value, changeToClassId.Value);
                }
                else
                {
                    //将学生退出班级
                    ExitClass(oldClassId.Value);
                }
            }
            else
            {
                ExceptionHelper.ThrowIfTrue(!changeToClassId.HasValue, nameof(changeToClassId), "请选择班级");
                if (changeToClassId.HasValue)
                {
                    //分班
                    DivideIntoClasses(changeToClassId.Value);
                }
            }
        }

        /// <summary>
        /// 分班
        /// </summary>
        /// <param name="classId"></param>
        private void DivideIntoClasses(long classId)
        {
            ExceptionHelper.ThrowIfNotId(classId, nameof(classId));
            var isClassExist = _ClassRepository.Entities.AsNoTracking().Any(p => p.classId == classId);
            ExceptionHelper.ThrowIfTrue(!isClassExist, nameof(classId), "该班级不存在");
            var isDivided = _ClassStuRelationRepository.Entities.AsNoTracking().Any(p => p.uid == _User.Uid);
            ExceptionHelper.ThrowIfTrue(isDivided, nameof(_User.Uid), "该学员已分班");
            if (!isDivided)
            {
                _ClassStuRelationRepository.Add(new ClassStuRelation()
                {
                    classId = classId,
                    uid = _User.Uid,
                    payState = InsOfGrowthPayState.Paid,
                    committeeType = null,
                });
                _ClassStuRelationRepository.SaveChanges();
            }
        }

        /// <summary>
        /// 修改班级
        /// </summary>
        /// <param name="oldClassId"></param>
        /// <param name="changeToclassId"></param>
        private void UpdateClass(long oldClassId, long changeToclassId)
        {
            ExceptionHelper.ThrowIfNotId(oldClassId, nameof(oldClassId));
            ExceptionHelper.ThrowIfNotId(changeToclassId, nameof(changeToclassId));
            var isClassExist = _ClassRepository.Entities.AsNoTracking().Any(p => p.classId == changeToclassId);
            ExceptionHelper.ThrowIfTrue(!isClassExist, nameof(changeToclassId), "要更换到的班级不存在");
            var isInOldClass = _ClassStuRelationRepository.Entities.AsNoTracking().Any(p => p.uid == _User.Uid && p.classId == oldClassId);
            ExceptionHelper.ThrowIfTrue(!isInOldClass, nameof(_User.Uid), "该学员不在原班级，请确认学员的原班级信息");
            if (isInOldClass)
            {
                _ClassStuRelationRepository.Update(p => p.uid == _User.Uid && p.classId == oldClassId, p => new ClassStuRelation { classId = changeToclassId, committeeType = null });
            }
        }

        /// <summary>
        /// 将学员退出班级
        /// </summary>
        /// <param name="classId"></param>
        private void ExitClass(long classId)
        {
            ExceptionHelper.ThrowIfNotId(classId, nameof(classId));
            var isInClass = _ClassStuRelationRepository.Entities.AsNoTracking().Any(p => p.uid == _User.Uid && p.classId == classId);
            ExceptionHelper.ThrowIfTrue(!isInClass, nameof(_User.Uid), "该学员不在该班级，请确认学员的班级信息");
            if (isInClass)
            {
                _ClassStuRelationRepository.Delete(p => p.uid == _User.Uid && p.classId == classId);
            }
        }

        /// <summary>
        /// 任命班委
        /// </summary>
        /// <param name="classCommittee"></param>
        public void NominateClassCommittee(long classId, ClassCommitteeType? classCommittee)
        {
            ExceptionHelper.ThrowIfNotId(classId, nameof(classId));
            //判断是否付款
            var isPaid = Trades.Any(p => p.isPaied);
            ExceptionHelper.ThrowIfTrue(!isPaid, "isPaid", "该用户未付款，不能进行此操作");
            if (classCommittee.HasValue)
            {
                ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(ClassCommitteeType), classCommittee.Value), "classCommittee", "值不在范围内");
            }
            var isStuInThisClass = _ClassStuRelationRepository.Entities.AsNoTracking().Any(p => p.uid == _User.Uid && p.classId == classId);
            ExceptionHelper.ThrowIfTrue(!isStuInThisClass, nameof(classId), "该学员不在此班级,无法进行班委任命操作");
            if (isStuInThisClass)
            {
                if (classCommittee.HasValue)
                {
                    //将班级里存在职务相等的学员的职务先取消
                    _ClassStuRelationRepository.Update(p => p.classId == classId && p.committeeType == classCommittee, p => new ClassStuRelation { committeeType = null });
                }                
                _ClassStuRelationRepository.Update(p => p.uid == _User.Uid && p.classId == classId, p => new ClassStuRelation { committeeType = classCommittee });
            }
        }
    }
}
