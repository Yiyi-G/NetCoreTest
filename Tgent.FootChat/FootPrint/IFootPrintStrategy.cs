using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Model;
using Tgnet.FootChat.YwqWcfService;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.FootPrint
{
    public interface IFootPrintStrategy
    {
        IFootPrintService SaveFootPrint();

        void InitFootPrintAddress();
    }
    public abstract class BaseFootPrintStrategy : IFootPrintStrategy
    {
        private readonly User.IUserService _User;
        protected readonly long _Uid;
        protected readonly long? _Fid;
        protected long[] _Tags;
        protected string _Content;
        protected double? _Longitude;
        protected double? _Latitude;
        protected string _Address;
        protected FootImageInfo[] _Image;
        protected UpdateFootPrintModel _Model;
        protected string _AreaNo;
        protected Tgnet.FootChat.YwqWcfService.ProjectSource _ProjSource = null;
        protected readonly IFootPrintServiceFactory _FootPrintServiceFactory;
        private readonly IFootPrintRepository _FootPrintRepository;
        protected readonly IStaticResourceManager _StaticResourceManager;
        private readonly IRepository<Data.FootPrintImg> _FootPrintImgRepository;

        public BaseFootPrintStrategy(User.IUserService user,
            UpdateFootPrintModel model,
           IFootPrintServiceFactory footPrintServiceFactory,
            IFootPrintRepository footPrintRepository,
            IStaticResourceManager staticResourceManager,
            IRepository<Data.FootPrintImg> footPrintImgRepository
            )
        {
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            _User = user;
            _Model = model;
            _Uid = user.Uid;
            _Fid = model.Fid;
            _Address = model.Address;
            _Content = model.Content;
            _Tags = model.TagId;
            _Image = model.Images;
            _FootPrintServiceFactory = footPrintServiceFactory;
            _FootPrintRepository = footPrintRepository;
            _StaticResourceManager = staticResourceManager;
            _FootPrintImgRepository = footPrintImgRepository;
        }

        public abstract ProjectSource ProjectSource { get; }



        public IFootPrintService SaveFootPrint()
        {
            //Init();
            InitFootLocation();
            InitAreaNo();
            if (string.IsNullOrWhiteSpace(_AreaNo))
                _AreaNo = "0001";
            var now = DateTime.Now;
            IFootPrintService service = null;
            using (var scope = new TransactionScope())
            {
                Data.FootPrint entity = null;
                if (_Fid > 0)
                {
                    entity = _FootPrintRepository.Entities.FirstOrDefault(p => p.fid == _Fid);
                    ExceptionHelper.ThrowIfTrue(entity.uid != _Uid, "uid", "用户不允许修改他人的足迹");
                    ExceptionHelper.ThrowIfTrue(entity.state == FootPrintState.Pass, "", "已通过的足迹不能修改");
                }
                if (entity == null)
                {
                    entity = _FootPrintRepository.Add(new Data.FootPrint()
                    {
                        uid = _Uid,
                        created = now,
                        isEnable = true,
                        state = FootPrintState.None,
                        orderUpdated = now,
                    });
                }
                if (entity.pid != ProjectSource.pid)
                    entity.pid = ProjectSource.pid;
                if (!string.IsNullOrWhiteSpace(_Address) && _Address != entity.address)
                    entity.address = _Address;
                if (!string.IsNullOrWhiteSpace(_Content))
                    entity.content = _Content;
                if (_Latitude > 0 && _Longitude > 0 && (_Latitude != entity.latitude || _Longitude != entity.longitude))
                {
                    entity.latitude = _Latitude;
                    entity.longitude = _Longitude;
                    if (!string.IsNullOrWhiteSpace(_AreaNo) && _AreaNo != "0001")
                        entity.areaNo = _AreaNo;
                }
                if (!string.IsNullOrWhiteSpace(_AreaNo)&&string.IsNullOrWhiteSpace(entity.areaNo))
                    entity.areaNo = _AreaNo;
                entity.updated = now;
                _FootPrintRepository.SaveChanges();
                service = _FootPrintServiceFactory.GetService(entity.fid);
                service.UpdateImages(_Image);
                service.UpdateTags(_Tags);
                if (entity.state == FootPrintState.UnPass)
                {
                    entity.state = FootPrintState.None;
                }
                _FootPrintRepository.SaveChanges();

              
                scope.Complete();
            }
            return service;
        }

        public void InitFootPrintAddress()
        {
            ExceptionHelper.ThrowIfTrue(!(_Fid > 0), nameof(_Fid));
            Init();
            var entity = _FootPrintRepository.Entities.FirstOrDefault(p => p.fid == _Fid);
            ExceptionHelper.ThrowIfNull(entity, nameof(entity));
            ExceptionHelper.ThrowIfTrue(entity.uid != _Uid, "uid", "用户不允许修改他人的足迹");
            var imageKeys = new string[0];
            if (_Image != null)
            {
                imageKeys = _Image.Where(p => !string.IsNullOrWhiteSpace(p.ImageKey) && !string.IsNullOrWhiteSpace(p.Address)).Select(p => p.ImageKey).Distinct().ToArray();
            }
            using (var scope = new TransactionScope())
            {
                if (_Latitude > 0 && _Longitude > 0 && (_Latitude != entity.latitude || _Longitude != entity.longitude))
                {
                    entity.latitude = _Latitude;
                    entity.longitude = _Longitude;
                }
                if (!string.IsNullOrWhiteSpace(_Address) && string.IsNullOrWhiteSpace(entity.address))
                {
                    entity.address = _Address;
                }
                _FootPrintRepository.SaveChanges();
                if (imageKeys.Any())
                {
                    var imagEntities = _FootPrintImgRepository.Entities.Where(p => imageKeys.Contains(p.imageKey));
                    foreach (var imagEntity in imagEntities)
                    {
                        if (string.IsNullOrWhiteSpace(imagEntity.address))
                            imagEntity.address = _Image.FirstOrDefault(p => p.ImageKey == imagEntity.imageKey).Address;
                    }
                    _FootPrintImgRepository.SaveChanges();
                }
                scope.Complete();
            }
        }
        private bool _IsInitFirstExistLocationImg;
        private FootImageInfo _FirstExistLocationImg;
        private FootImageInfo FirstExistLocationImg
        {
            get
            {
                if (!_IsInitFirstExistLocationImg)
                {
                    _FirstExistLocationImg = (_Image ?? new FootImageInfo[0]).FirstOrDefault(p => p.Longitude > 0 && p.Latitude > 0);
                    _IsInitFirstExistLocationImg = true;
                }
                return _FirstExistLocationImg;
            }
        }
        private bool _IsInitFirstExistAdressImg;
        private FootImageInfo _FirstExistAdressImg;
        private FootImageInfo FirstExistAdressImg
        {
            get
            {
                if (!_IsInitFirstExistAdressImg)
                {
                    _FirstExistAdressImg = (_Image ?? new FootImageInfo[0]).Where(p => !string.IsNullOrWhiteSpace(p.Address)).FirstOrDefault();
                    _IsInitFirstExistAdressImg = true;
                }
                return _FirstExistAdressImg;
            }
        }

        protected virtual void InitFootLocation()
        {
            if (FirstExistLocationImg != null)
            {
                _Latitude = FirstExistLocationImg.Latitude;
                _Longitude = FirstExistLocationImg.Longitude;
            }

        }
        protected virtual void InitImg()
        {
            try
            {
                if (_Image != null)
                {
                    _Image = ConverImageInfo(_Image ?? new FootImageInfo[0], _StaticResourceManager).ToArray();
                }
            }
            catch { }
        }
        protected virtual void InitFootAddress()
        {
            if (FirstExistAdressImg != null)
            {
                _Address = FirstExistAdressImg.Address;
            }

        }

        private IEnumerable<Tgnet.FootChat.Model.FootImageInfo> ConverImageInfo(Tgnet.FootChat.Model.FootImageInfo[] images, IStaticResourceManager staticResourceManager)
        {
            foreach (var item in images)
            {
                if (item != null && !string.IsNullOrWhiteSpace(item.ImageKey))
                {
                    var address = item.Address;
                    if (String.IsNullOrWhiteSpace(address) && item.Latitude > 0 && item.Longitude > 0)
                    {
                        var info = staticResourceManager.GetAddress(item.Longitude.Value, item.Latitude.Value);
                        if (info != null)
                            item.Address = info.FormattedAddress;
                    }
                }
                yield return item;
            }
        }



        protected virtual void Init()
        {
            InitImg();
            InitFootLocation();
            InitFootAddress();

        }
        protected virtual void InitAreaNo()
        {
            if (_Longitude > 0 && _Latitude > 0)
                _AreaNo = _StaticResourceManager.GetAreaNo(_Longitude.Value, _Latitude.Value);
                     

        }


    }

    public class ProjFootPrintWithNameStrategy : BaseFootPrintStrategy
    {
        private string _Name;
        private readonly Project.IProjSourceManager _ProjSourceManager;
        public ProjFootPrintWithNameStrategy(
            User.IUserService user,
            UpdateFootPrintModel model,
            IFootPrintServiceFactory footPrintServiceFactory,
            IFootPrintRepository footPrintRepository,
            IStaticResourceManager staticResourceManager,
            Project.IProjSourceManager projSourceManager,
            IRepository<Data.FootPrintImg> footPrintImgRepository
            ) : base(user,model, footPrintServiceFactory, footPrintRepository, staticResourceManager,footPrintImgRepository)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(model.ProjName, nameof(model.ProjName));
            _Name = model.ProjName;
            _ProjSourceManager = projSourceManager;
        }
        public override ProjectSource ProjectSource
        {
            get
            {
                if (_ProjSource == null)
                {
                    _ProjSource = _ProjSourceManager.AddProject(_Name, _AreaNo, null, null, "");
                }
                return _ProjSource;
            }
        }

        protected override void InitFootAddress()
        {
            base.InitFootAddress();
            if (string.IsNullOrWhiteSpace(_Address))
            {
                if (_Longitude > 0 && _Latitude > 0)
                {
                    var locationAddress = _StaticResourceManager.GetAddress(_Longitude.Value, _Latitude.Value);
                    if (locationAddress != null && !string.IsNullOrWhiteSpace(locationAddress.FormattedAddress))
                        _Address = locationAddress.FormattedAddress;
                }
            }

        }
        protected override void InitAreaNo()
        {
            base.InitAreaNo();
            if (!string.IsNullOrWhiteSpace(_AreaNo))
                return;
            if (_Model.Longitude > 0 || _Model.Latitude > 0)
                _AreaNo = _StaticResourceManager.GetAreaNo(_Model.Longitude.Value, _Model.Latitude.Value);
        }
    }
    public class ProjFootPrintWithPidStrategy : BaseFootPrintStrategy
    {
        private long _Pid;
        private readonly Project.IProjSourceManager _ProjSourceManager;
        public ProjFootPrintWithPidStrategy(
            User.IUserService user,
            UpdateFootPrintModel model,
            IFootPrintServiceFactory footPrintServiceFactory,
            IFootPrintRepository footPrintRepository,
            IStaticResourceManager staticResourceManager,
             Project.IProjSourceManager projSourceManager,
            IRepository<Data.FootPrintImg> footPrintImgRepository
            ) : base(user,model, footPrintServiceFactory, footPrintRepository, staticResourceManager,footPrintImgRepository)
        {
            ExceptionHelper.ThrowIfNotId(model.Pid, nameof(model.Pid));
            _Pid = model.Pid.Value;
            _ProjSourceManager = projSourceManager;
        }

        protected override void InitFootLocation()
        {
            base.InitFootLocation();
            if (!(_Latitude > 0 && _Longitude > 0))
            {
                _Latitude = ProjectSource.latitude;
                _Longitude = ProjectSource.longitude;
            }
        }

        protected override void InitFootAddress()
        {
            base.InitFootAddress();
            if (string.IsNullOrWhiteSpace(_Address))
            {
                _Address = ProjectSource.address;
                if (!string.IsNullOrWhiteSpace(_Address))
                    return;

                if (_Longitude > 0 && _Latitude > 0)
                {
                    var locationAddress = _StaticResourceManager.GetAddress(_Longitude.Value, _Latitude.Value);
                    if (locationAddress != null && !string.IsNullOrWhiteSpace(locationAddress.FormattedAddress))
                        _Address = locationAddress.FormattedAddress;
                }
            }

        }

        protected override void InitAreaNo()
        {
            base.InitAreaNo();
            if (string.IsNullOrWhiteSpace(_AreaNo))
                _AreaNo = _ProjSource.areaNo;
            if (!string.IsNullOrWhiteSpace(_AreaNo))
                return ;
            if (_Model.Longitude > 0 || _Model.Latitude > 0)
                _AreaNo = _StaticResourceManager.GetAreaNo(_Model.Longitude.Value, _Model.Latitude.Value);
        }

        public override ProjectSource ProjectSource
        {
            get
            {
                if (_ProjSource == null)
                {
                    _ProjSource = _ProjSourceManager.GetSource(_Pid);
                    if (_ProjSource == null)
                        throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目);
                }
                return _ProjSource;
            }
        }
    }
}
