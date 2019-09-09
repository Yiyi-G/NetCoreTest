using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Events;
using Tgnet.FootChat.Model;

namespace Tgnet.FootChat.FootPrint
{
    public interface IFootPrintServiceFactory
    {
        IFootPrintService GetService(long fid);
    }
    public class FootPrintServiceFactory : IFootPrintServiceFactory
    {
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IRepository<Data.FootPrintImg> _FootPrintImgRepository;
        private readonly IRepository<Data.FootPrintTag> _FootPrintTagRepository;
        private readonly FCRMAPI.IPushManager _EventPushManager;
        private readonly Project.IProjSourceManager _ProjSourceManager;
        private readonly IStaticResourceManager _StaticResourceManager;


        public FootPrintServiceFactory(
            IFootPrintRepository footPrintRepository,
            IRepository<Data.FootPrintImg> footPrintImgRepository,
            IRepository<Data.FootPrintTag> footPrintTagRepository,
            FCRMAPI.IPushManager eventPushManager,
            Project.IProjSourceManager projSourceManager,
            IStaticResourceManager staticResourceManager
            )
        {
            _FootPrintRepository = footPrintRepository;
            _FootPrintImgRepository = footPrintImgRepository;
            _FootPrintTagRepository = footPrintTagRepository;
            _EventPushManager = eventPushManager;
            _ProjSourceManager = projSourceManager;
            _StaticResourceManager = staticResourceManager;

        }

        public IFootPrintService GetService(long fid)
        {
            return new FootPrintService(fid, this, _FootPrintRepository, _FootPrintImgRepository, _FootPrintTagRepository,
                _EventPushManager, _ProjSourceManager, _StaticResourceManager);
        }
    }
    public interface IFootPrintService
    {
        #region 属性
        long Uid { get; }
        long Pid { get; }
        long Fid { get; }
        string Address { get; }
        DateTime Created { get; }
        DateTime Updated { get; }
        double? Longitude { get; }
        double? Latitude { get; }
        string Content { get; }
        string ExamineRemark { get; }
        FootPrintState State { get; }
        long[] TagIds { get; }
        IQueryable<Data.FootPrintImg> Imgs { get; }
        string AreaNo { get; }
        string ProjectName { get; }
        DateTime OrderUpdated { get; }
        #endregion
        void UpdateImages(FootImageInfo[] imgs);
        void UpdateTags(long[] tags);
        bool CheckExistImportImag();
        IQueryable<Data.FootPrintImg> SetFootPrintImgOrder(long imgId, int order);
        IQueryable<Data.FootPrintImg> UpdateFootPrintRotatedImage(long imgId, string imageKey);
        IQueryable<Data.FootPrintImg> SetFootPrintImageIsEnabled(long operatorId, long imgId, bool isEnabled);
        void VerifiedLock();
        void VerifiedUnLock();
        void ShieldFootPrint(long operatorId, string reason);
        void ApproveFootPrint(long operatorId, TransferScales scale);
        void UpdateTransferState(long operatorId, TransferState state);
        void UpdateRemark(User.IUserService user, string remark);
        IQueryable<Data.FootPrintImg> UpdateImgImageKey(long imgId, string imageKey);
        void OnlyUpdateFootPrintAddress(string address);
        void InitFootPrintAddress(User.IUserService user);
        void UpdateProjBind(long pid);
    }
    public class FootPrintService : IFootPrintService
    {
        private readonly long _Fid;
        private readonly Lazy<Data.FootPrint> _LazyEntity;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IRepository<Data.FootPrintImg> _FootPrintImgRepository;
        private readonly IRepository<Data.FootPrintTag> _FootPrintTagRepository;
        private readonly FCRMAPI.IPushManager _EventPushManager;
        private readonly Project.IProjSourceManager _ProjSourceManager;
        private readonly IStaticResourceManager _StaticResourceManager;
        private readonly IFootPrintServiceFactory _FootPrintServiceFactory;


        public FootPrintService(long fid,
            IFootPrintServiceFactory footPrintServiceFactory,
            IFootPrintRepository footPrintRepository,
            IRepository<Data.FootPrintImg> footPrintImgRepository,
            IRepository<Data.FootPrintTag> footPrintTagRepository,
            FCRMAPI.IPushManager eventPushManager,
            Project.IProjSourceManager projSourceManager,
            IStaticResourceManager staticResourceManager

            )
        {
            ExceptionHelper.ThrowIfNotId(fid, nameof(fid));
            _Fid = fid;
            _FootPrintRepository = footPrintRepository;
            _FootPrintImgRepository = footPrintImgRepository;
            _FootPrintTagRepository = footPrintTagRepository;
            _EventPushManager = eventPushManager;
            _ProjSourceManager = projSourceManager;
            _StaticResourceManager = staticResourceManager;
            _FootPrintServiceFactory = footPrintServiceFactory;

            _LazyEntity = new Lazy<Data.FootPrint>(() =>
            {
                var entity = _FootPrintRepository.Entities.FirstOrDefault(p => p.fid == fid);
                if (entity == null)
                    throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目);
                return entity;
            });
        }

        public string Address
        {
            get
            {
                return _LazyEntity.Value.address;
            }
        }

        public long Fid
        {
            get
            {
                return _LazyEntity.Value.fid;
            }
        }

        public IQueryable<Data.FootPrintImg> Imgs
        {
            get
            {
                return _FootPrintImgRepository.Entities.Where(p => p.fid == _Fid);
            }
        }

        public double? Latitude
        {
            get
            {
                return _LazyEntity.Value.latitude;
            }
        }

        public double? Longitude
        {
            get
            {
                return _LazyEntity.Value.longitude;
            }
        }

        public long Pid
        {
            get
            {
                return _LazyEntity.Value.pid;
            }
        }

        public long Uid
        {
            get
            {
                return _LazyEntity.Value.uid;
            }
        }

        public DateTime Created
        {
            get
            {
                return _LazyEntity.Value.created;
            }
        }

        public DateTime Updated
        {
            get
            {
                return _LazyEntity.Value.updated;
            }
        }

        public string Content
        {
            get
            {
                return _LazyEntity.Value.content;
            }
        }

        public long[] TagIds
        {
            get
            {
                return _FootPrintTagRepository.Entities.Where(p => p.fid == _Fid).Select(p => p.tid).ToArray();
            }
        }

        public FootPrintState State
        {
            get
            {
                return _LazyEntity.Value.state;
            }
        }

        public string ExamineRemark => _LazyEntity.Value.examinRemarks;

        public string AreaNo => _LazyEntity.Value.areaNo;

        public DateTime OrderUpdated => _LazyEntity.Value.orderUpdated;

        public string ProjectName
        {
            get
            {
                var project = _ProjSourceManager.GetSource(Pid);
                if (project != null)
                {
                    return project.name;
                }
                return String.Empty;
            }
        }

        public void UpdateImages(FootImageInfo[] imgs)
        {
            imgs = (imgs ?? new FootImageInfo[0]).Where(p => !string.IsNullOrWhiteSpace(p.ImageKey)).ToArray();
            ExceptionHelper.ThrowIfNull(imgs, nameof(imgs));
            ExceptionHelper.ThrowIfTrue(!imgs.Any(), "足聊图片不能为空");
            var now = DateTime.Now;
            _FootPrintImgRepository.AddAndDeleteExcept(
                p => p.fid == _Fid,
                imgs,
                (u, v) =>
                {
                    return u.imageKey == v.ImageKey;
                },
                (u, v) => { },
                u => { return true; },
                v => new Data.FootPrintImg()
                {
                    fid = _Fid,
                    created = now,
                    imageKey = v.ImageKey,
                    isEnabled = true,
                    longitude = v.Longitude,
                    latitude = v.Latitude,
                    isComfirm = false,
                    order = null,
                    photoTime = v.PhotoTime,
                    address = v.Address,

                }
                );
        }

        public void UpdateTags(long[] tags)
        {
            var now = DateTime.Now;
            tags = (tags ?? new long[0].Where(p => p > 0)).ToArray();
            ExceptionHelper.ThrowIfTrue(!tags.Any(), "标签不能为空");
            _FootPrintTagRepository.AddAndDeleteExcept(
                p => p.fid == _Fid,
                tags,
                (u, v) =>
                {
                    return u.tid == v;
                },
                (u, v) => { },
                u => { return true; },
                v => new Data.FootPrintTag()
                {
                    fid = _Fid,
                    tid = v,
                    updated = now
                });

        }

        public bool CheckExistImportImag()
        {
            return _FootPrintImgRepository.Entities.Where(p => p.order == 1 && p.isEnabled).Any();
        }

        public IQueryable<Data.FootPrintImg> SetFootPrintImgOrder(long imgId, int order)
        {
            ExceptionHelper.ThrowIfNotId(imgId, nameof(imgId));
            ExceptionHelper.ThrowIfTrue(order <= 0, nameof(order));
            using (var scope = new TransactionScope())
            {
                var oldCover = Imgs.FirstOrDefault(p => p.order == order);
                if (oldCover != null)
                {
                    oldCover.order = null;
                }
                var img = Imgs.FirstOrDefault(p => p.id == imgId);
                ExceptionHelper.ThrowIfTrue(img == null, nameof(img), "该图片不存在");
                ExceptionHelper.ThrowIfTrue(img.isEnabled != true, nameof(img), "该图片审核不通过，不可设置为封面");
                img.order = order;
                _FootPrintImgRepository.SaveChanges();
                scope.Complete();
                return Imgs;
            }
        }

        public IQueryable<Data.FootPrintImg> UpdateFootPrintRotatedImage(long imgId, string imageKey)
        {
            ExceptionHelper.ThrowIfNotId(imgId, nameof(imgId));
            ExceptionHelper.ThrowIfNullOrWhiteSpace(imageKey, nameof(imageKey));
            var img = Imgs.FirstOrDefault(p => p.id == imgId);
            ExceptionHelper.ThrowIfTrue(img == null, nameof(img), "该图片不存在");
            ExceptionHelper.ThrowIfTrue(img.isEnabled != true, nameof(img), "该图片审核不通过，不可进行旋转后保存操作");
            img.imageKey = imageKey;
            _FootPrintImgRepository.SaveChanges();
            return Imgs;
        }

        public IQueryable<Data.FootPrintImg> SetFootPrintImageIsEnabled(long operatorId, long imgId, bool isEnabled)
        {
            ExceptionHelper.ThrowIfNotId(imgId, nameof(imgId));
            using (var scope = new TransactionScope())
            {
                var img = Imgs.FirstOrDefault(p => p.id == imgId);
                ExceptionHelper.ThrowIfTrue(img == null, nameof(img), "该图片不存在");
                img.isEnabled = isEnabled;
                img.isComfirm = true;
                img.comfirmDate = DateTime.Now;
                img.comfirmer = operatorId;
                _FootPrintImgRepository.SaveChanges();
                scope.Complete();
                return Imgs;
            }
        }

        //审核足迹时锁定
        public void VerifiedLock()
        {
            _LazyEntity.Value.isVerifiedLocked = true;
            _LazyEntity.Value.verifiedlockDate = DateTime.Now;
            _FootPrintRepository.SaveChanges();
        }

        //审核完足迹时解锁
        public void VerifiedUnLock()
        {
            var minTime = "1900-01-01".To<DateTime>();
            _LazyEntity.Value.isVerifiedLocked = false;
            _LazyEntity.Value.verifiedlockDate = minTime;
            _FootPrintRepository.SaveChanges();
        }

        //屏蔽
        public void ShieldFootPrint(long operatorId, string reason)
        {
            ExceptionHelper.ThrowIfNotId(operatorId, nameof(operatorId));
            ExceptionHelper.ThrowIfNullOrWhiteSpace(reason, nameof(reason));
            using (var scope = new TransactionScope())
            {
                _LazyEntity.Value.state = FootPrintState.UnPass;
                _LazyEntity.Value.examiner = operatorId;
                _LazyEntity.Value.examineDate = DateTime.Now;
                _LazyEntity.Value.examinRemarks = reason;
                _FootPrintRepository.SaveChanges();
                //图片设置
                _FootPrintImgRepository.Update(p => p.fid == _Fid, p => new Data.FootPrintImg { isComfirm = true, comfirmDate = DateTime.Now, comfirmer = operatorId });
                scope.Complete();
            }
        }

        //审核通过
        public void ApproveFootPrint(long operatorId, TransferScales scale)
        {
            ExceptionHelper.ThrowIfNotId(operatorId, nameof(operatorId));
            ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(TransferScales), scale), "scale", "值不在范围内");
            var now = DateTime.Now;
            using (var scope = new TransactionScope())
            {
                _LazyEntity.Value.state = FootPrintState.Pass;
                _LazyEntity.Value.examiner = operatorId;
                _LazyEntity.Value.examineDate = now;
                _LazyEntity.Value.transferScales = scale;
                _LazyEntity.Value.orderUpdated = now;
                _FootPrintRepository.SaveChanges();
                //图片设置
                _FootPrintImgRepository.Update(p => p.fid == _Fid, p => new Data.FootPrintImg { isComfirm = true, comfirmDate = DateTime.Now, comfirmer = operatorId });
                scope.Complete();
            }


        }

        public void UpdateTransferState(long operatorId, TransferState state)
        {
            ExceptionHelper.ThrowIfNotId(operatorId, nameof(operatorId));
            ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(TransferState), state), "state", "值不在范围内");
            _LazyEntity.Value.transferState = (byte)state;
            _LazyEntity.Value.transferUpdated = DateTime.Now;
            _LazyEntity.Value.transferOperator = operatorId;
            _FootPrintRepository.SaveChanges();
        }

        public void UpdateRemark(User.IUserService user, string remark)
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            ExceptionHelper.ThrowIfTrue(_LazyEntity.Value.uid != user.Uid, "uid", "用户不允许修改他人的足迹");
            if (!string.IsNullOrWhiteSpace(remark))
            {
                _LazyEntity.Value.content = remark;
                _LazyEntity.Value.updated = DateTime.Now;
                _FootPrintRepository.SaveChanges();
            }
        }

        public IQueryable<Data.FootPrintImg> UpdateImgImageKey(long imgId, string imageKey)
        {
            ExceptionHelper.ThrowIfNotId(imgId, nameof(imgId));
            ExceptionHelper.ThrowIfNullOrWhiteSpace(imageKey, nameof(imageKey));
            _FootPrintImgRepository.Update(p => p.id == imgId, p => new Data.FootPrintImg { imageKey = imageKey });
            return Imgs;
        }

        //只更新足迹地址，经纬度先不改
        public void OnlyUpdateFootPrintAddress(string address)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(address, nameof(address));
            _LazyEntity.Value.address = address;
            _FootPrintRepository.SaveChanges();
        }

        public void InitFootPrintAddress(User.IUserService user)
        {
            var model = new UpdateFootPrintModel()
            {
                Fid = _LazyEntity.Value.fid,
                Pid = _LazyEntity.Value.pid,
                Address = _LazyEntity.Value.address,
                Latitude = _LazyEntity.Value.latitude,
                Longitude = _LazyEntity.Value.longitude,

            };
            model.Images = this.Imgs.Select(p => new FootImageInfo()
            {
                ImageKey = p.imageKey,
                Address = p.address,
                Latitude = p.latitude,
                Longitude = p.longitude,
            }).ToArray();
            var strategy = new ProjFootPrintWithPidStrategy(user,model, _FootPrintServiceFactory, _FootPrintRepository, _StaticResourceManager, _ProjSourceManager, _FootPrintImgRepository);
            strategy.InitFootPrintAddress();
        }

        public void UpdateProjBind(long pid)
        {
            if (pid != Pid)
            {
                using (var scope = new TransactionScope())
                {
                    _LazyEntity.Value.pid = pid;
                    _FootPrintRepository.SaveChanges();
                    scope.Complete();
                }
                if (_LazyEntity.Value.state == FootPrintState.Pass)
                {
                    _EventPushManager.UpdateFootPrintProj(_Fid, pid);
                }
            }

        }
    }

   
    public enum ExaminRemarks : byte
    {
        所传图片与项目无关 = 0,
        所传图片模糊不清 = 1,
        缺少公告牌或门头照 = 2,
        重复发布 = 3,
        其他 = 4,
    }

    //Tgnet.FootChat.FootPrint.TransferScales
   

    public enum TransferState : byte
    {
        未处理 = 0,
        已处理 = 1,
        无法采编 = 2,
    }
}
