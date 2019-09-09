using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Runtime.Serialization;
using System.Text;
using System.Transactions;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.User;
using Tgnet.Linq;
namespace Tgnet.FootChat.FootPrint
{
    public interface IImportFootPrintManager
    {
        bool Import(Models.ImportFootChatModel model);
        bool PushUserToNoqlDataBase(int start, int limit);
        bool PushFootPrintToNoqlDataBase(int start, int limit);
        bool RePushDeleteFootPrints(int start, int limit);
        bool RePushUserContactToNoqlDataBase(int start, int limit);
        PageModel<PushContactModel> GetPushUserContactToNoqlDataBaseData(int start, int limit);
    }
    public class ImportFootPrintManager : IImportFootPrintManager
    {
        private readonly Tgnet.FootChat.Project.IProjectManager _ProjectManager;
        private readonly Tgnet.FootChat.User.UserManager _UserManager;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IFootChatUserRepository _FootChatUserRepository;
        private readonly FCRMAPI.IPushManager _PushManager;
        private readonly IStaticResourceManager _StaticResourceManager;
        private readonly IUserServiceFactory _UserServiceFactory;
        private readonly IRepository<Data.ImportUserRecord> _ImportUserRecordRepository;
        private readonly IRepository<Data.ImportFootPrintRecord> _ImportFootPrintRecordRepository;
        private readonly IFootPrintServiceFactory  _FootPrintServiceFactory;
        private readonly ITagSourceRepository _TagSourceRepository;
        private readonly IRepository<Data.FootPrintTag> _FootPrintTagRepository;
        private readonly Data.IAddressBookMobileRepository _AddressBookMobileRepository;
        public ImportFootPrintManager(
            Tgnet.FootChat.Project.IProjectManager projectManager,
            Tgnet.FootChat.User.UserManager userManager,
            IFootPrintRepository footPrintRepository,
            IFootChatUserRepository footChatUserRepository,
            FCRMAPI.IPushManager pushManager,
            IStaticResourceManager staticResourceManager,
            IUserServiceFactory userServiceFactory,
            Tgnet.Data.IRepository<Data.ImportUserRecord> importUserRecordRepository,
            IRepository<Data.ImportFootPrintRecord> importFootPrintRecordRepository,
            ITagSourceRepository tagSourceRepository,
            IRepository<Data.FootPrintTag> footPrintTagRepository,
            Data.IAddressBookMobileRepository addressBookMobileRepository,
            IFootPrintServiceFactory footPrintServiceFactory)
        {
            _ProjectManager = projectManager;
            _UserManager = userManager;
            _FootPrintRepository = footPrintRepository;
            _FootChatUserRepository = footChatUserRepository;
            _PushManager = pushManager;
            _StaticResourceManager = staticResourceManager;
            _UserServiceFactory = userServiceFactory;
            _ImportUserRecordRepository = importUserRecordRepository;
            _ImportFootPrintRecordRepository = importFootPrintRecordRepository;
            _TagSourceRepository = tagSourceRepository;
            _FootPrintTagRepository = footPrintTagRepository;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _FootPrintServiceFactory = footPrintServiceFactory;

        }
        public bool Import(Models.ImportFootChatModel model)
        {
            var error = "";
            try
            {
                model.CheckIsValid();
                var tgTagNames = model.TgTags.Select(p => p.TName).Distinct().ToArray();
                var tids = _TagSourceRepository.Entities.Where(p => tgTagNames.Contains(p.name) && p.isEnable).Select(p => p.tid).Distinct().ToArray();
                ExceptionHelper.ThrowIfTrue(!tids.Any(), nameof(tids), "足迹标签不能为空");
                var tgFid = model.TgFid;
                var uid = model.Uid;
                try
                {
                    AddUser(uid);
                }
                catch (System.Exception e)
                {
                    error = string.Format("添加用户失败：{0}", e.Message);
                    throw new Tgnet.Exception(error);
                }

                try
                {
                    AddFootPrint(model, tids);
                }
                catch (System.Exception e)
                {
                    error = string.Format("添加足迹失败：{0}", e.Message);
                    throw new Tgnet.Exception(error);
                }
                return true;
            }
            catch (System.Exception E)
            {
                error = E.Message;
                _ImportFootPrintRecordRepository.Add(new ImportFootPrintRecord()
                {
                    tgFid = model.TgFid,
                    fid = 0,
                    isSuccess = false,
                    uid = model.Uid,
                    unSuccessReason = error
                });
                _ImportFootPrintRecordRepository.SaveChanges();
                return false;
            }

        }
        public bool PushUserToNoqlDataBase(int start, int limit)
        {
            bool end = false;
            var source = _FootChatUserRepository.Entities;
            var count = source.Count();
            if (start + limit >= count)
                end = true;
            var users = source.Select(p => new
            {
                uid = p.uid,
                mobile = p.mobile,
                created = p.created
            });
            users = users.OrderBy(p => p.created).Take(start, limit);
            foreach (var user in users.ToArray())
            {
                _PushManager.AddUser(user.uid, user.mobile);
            }
            return end;
        }

        public bool RePushUserContactToNoqlDataBase(int start, int limit)
        {
            bool end = false;
            var source = _FootChatUserRepository.Entities;
            var count = source.Count();
            if (start + limit >= count)
                end = true;
            var users = source.Select(p => new
            {
                uid = p.uid,
                mobile = p.mobile,
                created = p.created
            });
            var userArr = users.OrderBy(p => p.created).Take(start, limit).ToArray();
            var uids = userArr.Select(p => p.uid).ToArray();
            var addressBooks = _AddressBookMobileRepository.Entities.AsNoTracking().Where(p => uids.Contains(p.uid)).GroupBy(p => p.uid)
                .ToDictionary(p => p.Key, p => p.Select(a => new
                {
                    aid = a.id,
                    mobile = a.mobile
                }));
            foreach (var user in userArr)
            {
                if (addressBooks.ContainsKey(user.uid))
                {
                    _PushManager.GenContact(user.uid, user.mobile, addressBooks[user.uid].Select(b => new FCRMAPI.Request.Contact() { Aid = b.aid, Mobile = b.mobile }).ToArray());
                }
            }
            return end;
        }

        public PageModel<PushContactModel> GetPushUserContactToNoqlDataBaseData(int start, int limit)
        {
            Tgnet.Log.LoggerResolver.Current.Debug("start RePushUserContactToNoqlDataBase2");
            var source = from f in _FootChatUserRepository.Entities.AsNoTracking()
                         join a in _AddressBookMobileRepository.Entities.AsNoTracking()
                         on f.uid equals a.uid
                         group new { f, a } by f.uid into fa
                         select new
                         {
                             uid = fa.Key,
                             mobile = fa.FirstOrDefault().f.mobile,
                             created = fa.FirstOrDefault().f.created,
                             contacts = fa.Select(p => new
                             {
                                 aid = p.a.id,
                                 mobile = p.a.mobile
                             })
                         };
            var count = source.Count();
            var addressBooks = source.OrderBy(p => p.created).Take(start, limit).ToArray();
            List<PushContactModel> result = new List<PushContactModel>();
            foreach (var addressBook in addressBooks)
            {
                result.Add(new PushContactModel()
                {
                    Uid = addressBook.uid,
                    Mobile = addressBook.mobile,
                    Contacts = addressBook.contacts.Select(b => new PushContact() { Aid = b.aid, Mobile = b.mobile }).ToArray()
                });
            }
            Tgnet.Log.LoggerResolver.Current.Debug("start RePushUserContactToNoqlDataBase3");

            return new PageModel<PushContactModel>(result, count);
        }
        public bool PushFootPrintToNoqlDataBase(int start, int limit)
        {
            bool end = false;
            var source = _FootPrintRepository.Entities.Where(p => p.isEnable && p.state == FootPrintState.Pass);
            var count = source.Count();
            if (start + limit >= count)
                end = true;
            var footPrints = source.OrderBy(p => p.created).Select(p => new
            {
                Pid = p.pid,
                Uid = p.uid,
                Fid = p.fid,
                AreaNo = p.areaNo,
                OrderUpdated = p.orderUpdated
            }).Take(start, limit).ToArray();
            var fids = footPrints.Select(p => p.Fid).ToArray();
            var bonusTagId = new long[] { 5, 12, 30 };
            var tagids = _FootPrintTagRepository.Entities.Where(p => fids.Contains(p.fid) && bonusTagId.Contains(p.tid))
                .GroupBy(p => p.fid).ToDictionary(p => p.Key, p => p.Any());
            foreach (var footPrint in footPrints.ToArray())
            {
                var request = new FCRMAPI.Request.PushFootPrintRequest()
                {
                    Pid = footPrint.Pid,
                    Fid = footPrint.Fid,
                    Uid = footPrint.Uid,
                };
                var areaNo = footPrint.AreaNo;
                var areaLength = !string.IsNullOrWhiteSpace(areaNo) ? areaNo.Length : 0;
                request.CountryNo = areaLength >= 4 ? areaNo.Left(4) : "";
                request.ProvinceNo = areaLength >= 8 ? areaNo.Left(8) : "";
                request.CityNo = areaLength >= 12 ? areaNo.Left(12) : "";
                request.AreaNo = areaLength >= 16 ? areaNo.Left(16) : "";
                request.ScopeType = (tagids.ContainsKey(footPrint.Fid) ? tagids[footPrint.Fid] : false) ? 20 : 0;
                request.Created = footPrint.OrderUpdated;
                _PushManager.PublisSingleFootPrint(request);
            }
            return end;
        }
        public bool RePushDeleteFootPrints(int start, int limit)
        {
            bool end = false;
            var source = _FootPrintRepository.Entities.Where(p => p.isEnable == false);
            var count = source.Count();
            if (start + limit >= count)
                end = true;
            var fids = source.OrderBy(p => p.created).Select(p => p.fid).Take(start, limit).ToArray();
            foreach (var fid in fids)
            {
                _PushManager.DeleteFootPrint(fid);
            }
            return end;
        }
        private void AddUser(long uid)
        {
            var now = DateTime.Now;
            var verifiedlockDate = new DateTime(1900, 1, 1);
            var uids = new long[] { uid };
            var user = _UserManager.GetTgUserInfos(uids).FirstOrDefault();
            if (user != null)
                ExceptionHelper.ThrowIfNullOrWhiteSpace(nameof(user), "查询不到用户资料");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(nameof(user.mobile), "用户手机号为空");
            string[] businesAreaNos = null;
            string[] products = null;
            string[] brands = null;
            var businessAreasDic = _UserManager.GetTgUserBusinessAreas(uids);
            if (businessAreasDic.ContainsKey(uid))
                businesAreaNos = businessAreasDic[uid];
            var tgProducts = _UserManager.GetTgUserProducts(uid);
            if (tgProducts != null && tgProducts.Count() > 0)
            {
                products = tgProducts.Where(p => !string.IsNullOrWhiteSpace(p.Name) && p.Name.Length < 50).Select(p => p.Name).Distinct().ToArray();
                brands = tgProducts.SelectMany(p => p.Brands).Where(p => !string.IsNullOrWhiteSpace(p) && p.Length < 50).Distinct().ToArray();
            }
            var password = GetRandomPsw();
            var areaNo = _StaticResourceManager.GetAreaByAreaName(user.area_province, user.area_city, user.area_county);
            using (var scope = new TransactionScope())
            {
                if (!CheckExistFootUser(uid))
                {
                    _FootChatUserRepository.Add(new FootUser()
                    {
                        mobile = user.mobile,
                        uid = uid,
                        password = password,
                        areaNo = areaNo,
                        isInner = false,
                        isLocked = false,
                        loginCount = 0,
                        lastLogin = now,
                        created = now,
                        verifyImage = String.Empty,
                        verifyStatus = VerifyStatus.None,
                        cover = "",
                        name = user.name,
                        company = user.company,
                        sex = user.sex == "男" ? UserSex.Man : user.sex == "女" ? UserSex.Woman : new UserSex?(),
                        job = user.job,
                    });
                    _FootChatUserRepository.SaveChanges();
                    var userService = _UserServiceFactory.GetService(uid);
                    userService.UpdateBusinessAreaNos(businesAreaNos);
                    userService.UpdateProducts(products);
                    userService.UpdateBrands(brands);
                    _ImportUserRecordRepository.Add(new ImportUserRecord()
                    {
                        importTime = now,
                        uid = uid
                    });
                    _ImportUserRecordRepository.SaveChanges();
                    //推送到图数据库
                    _PushManager.AddUser(uid, user.mobile, true);
                }
                scope.Complete();
            }
        }
        private void AddFootPrint(Models.ImportFootChatModel model, long[] tids)
        {
            var tgFid = model.TgFid;
            var now = DateTime.Now;
            using (var scope = new TransactionScope())
            {
                if (!CheckExistFootPrint(tgFid))
                {
                    var entity = _FootPrintRepository.Add(new Data.FootPrint()
                    {
                        uid = model.Uid,
                        pid = model.Pid,
                        address = model.Adddress,
                        areaNo = model.AreaNo,
                        content = model.Content,
                        latitude = model.Latitude,
                        longitude = model.Longitude,
                        created = now,
                        isEnable = true,
                        state = FootPrintState.None,
                        orderUpdated = now,
                        tgFid = tgFid,
                        updated = now,
                    });
                    _FootPrintRepository.Add(entity);
                    _FootPrintRepository.SaveChanges();
                    var fid = entity.fid;
                    var service = _FootPrintServiceFactory.GetService(entity.fid);
                    var imags = (model.Imags ?? new Models.ImportFootPrintImg[0]).Where(p => !string.IsNullOrWhiteSpace(p.Imag));
                    if (imags.Count() > 0)
                        service.UpdateImages(imags.Select(p => (Model.FootImageInfo)p).ToArray());
                    service.UpdateTags(tids);
                    _ImportFootPrintRecordRepository.Add(new ImportFootPrintRecord()
                    {
                        fid = entity.fid,
                        tgFid = tgFid,
                        isSuccess = true,
                        uid = model.Uid,
                        unSuccessReason = ""
                    });
                    _ImportFootPrintRecordRepository.SaveChanges();
                }
                scope.Complete();
            }
        }
        private string GetRandomPsw()
        {
            string words = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var Psw = "";
            Random rnd = new Random();
            int randonIndex;
            for (int i = 0; i < 8; i++)
            {
                randonIndex = rnd.Next(words.Length);
                Psw += words[randonIndex];
            }
            return Psw;
        }
        private bool CheckExistFootPrint(long fid)
        {
            return _FootPrintRepository.Entities.Any(p => p.tgFid == fid);
        }
        private bool CheckExistFootUser(long uid)
        {
            return _FootChatUserRepository.Entities.Any(p => p.uid == uid);
        }

        private long[] GetNoExistTgFid(long[] tgFids)
        {
            tgFids = (tgFids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (tgFids.Length == 0) return tgFids;
            var existTgpids = _FootPrintRepository.Entities.Where(p => tgFids.Contains(p.tgFid)).Select(p => p.tgFid).ToArray();
            return tgFids.Except(existTgpids).ToArray();
        }


    }
    [DataContract]
    public class PushContactModel
    {
        [DataMember]
        public long Uid { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public PushContact[] Contacts { get; set; }
    }
    [DataContract]
    public class PushContact
    {
        [DataMember]
        public long Aid { get; set; }
        [DataMember]
        public string Mobile { get; set; }
    }
}
