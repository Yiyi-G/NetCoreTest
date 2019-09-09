using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Mobile;
using Tgnet.FootChat.Models;
using Tgnet.FootChat.Relation;

namespace Tgnet.FootChat.User
{
    public interface IUserProjectRelationManager
    {
        Models.UserProjectRelationTag[] GetRelationTag(IUserService user, long[] uids);
    }
    class UserProjectRelationManager : IUserProjectRelationManager
    {
        private readonly IFootChatUserRepository _UserRepository;
        private readonly IAddressBookMobileRepository _AddressBookMobileRepository;
        private readonly IRelationManager _RelationManager;
        private readonly IFootPrintRepository _FootPrintRepository;
        private readonly IUserManager _UserManager;
        private readonly IAddressBookManager _AddressBookManager;
        private readonly IRepository<Data.ClassStuRelation> _ClassStuRelationRepository;
        private readonly IRepository<Data.Class> _ClassRepository;
        public UserProjectRelationManager(
            IFootChatUserRepository userRepository,
            IAddressBookMobileRepository addressBookMobileRepository,
            IRelationManager relationManager,
            IFootPrintRepository footPrintRepository,
            IUserManager userManager,
            IAddressBookManager addressBookManager,
            IRepository<Data.ClassStuRelation> classStuRelationRepository,
            IRepository<Data.Class> classRepository)
        {
            _RelationManager = relationManager;
            _UserRepository = userRepository;
            _FootPrintRepository = footPrintRepository;
            _UserManager = userManager;
            _AddressBookManager = addressBookManager;
            _AddressBookMobileRepository = addressBookMobileRepository;
            _ClassStuRelationRepository = classStuRelationRepository;
            _ClassRepository = classRepository;
        }
        public Models.UserProjectRelationTag[] GetRelationTag(IUserService user, long[] uids)
        {
            List<UserProjectRelationTag> result = new List<UserProjectRelationTag>();
            uids = uids ?? Enumerable.Empty<long>().Where(id => id > 0).Distinct().ToArray();
            if (uids.Length == 0)
                return result.ToArray();
            var users = _UserManager.GetUsers(uids).Select(u => new { uid = u.uid, mobile = u.mobile }).ToArray();
            var addressBooks = _AddressBookManager.GetUserAddressBookManager(user).GetAddressBookMobile(users.Select(u => u.mobile).ToArray()).ToArray();
            if (addressBooks.Length > 0)
            {
                foreach (var a in addressBooks)
                {
                    result.Add(new UserProjectRelationTag
                    {
                        Uid = users.First(u => u.mobile == a.mobile).uid,
                        Kind = UserProjectRelationTagKinds.AddressBook,
                        Tag = "通讯录好友",
                        AddressBookFriend = new AddressBookFriend() {
                            Name = a.name,
                            Mobile = a.mobile
                        }
                    });
                }
                uids = uids.Except(result.Select(r => r.Uid)).ToArray();
            }
            if (uids.Length > 0)
            {
                var uid = user.Uid;
                var classMates = from myclass in _ClassStuRelationRepository.Entities
                                 join classes in _ClassRepository.Entities on myclass.classId equals classes.classId
                                 join otherClass in _ClassStuRelationRepository.Entities
                                 on myclass.classId equals otherClass.classId
                                 where myclass.uid == uid && classes.isEnable && uids.Contains(otherClass.uid)
                                 select otherClass.uid;
                var classMateIds = classMates.ToArray().Distinct();
                foreach (var a in classMateIds)
                {
                    result.Add(new UserProjectRelationTag
                    {
                        Uid = a,
                        Kind = UserProjectRelationTagKinds.ClassMate,
                        Tag = "同学",
                    });
                }
                uids = uids.Except(result.Select(r => r.Uid)).ToArray();

            }
            if (uids.Length > 0)
            {
                var addressBookRelation = _AddressBookMobileRepository.GetUserAddressBookRelation(user.Uid, uids);
                if (addressBookRelation.Length > 0)
                {

                    var abs = addressBookRelation.GroupBy(a => a.uid).Select(a => new { uid = a.Key, name = a.OrderBy(p=>p.id).First().name });
                    foreach (var a in abs)
                    {
                        result.Add(new UserProjectRelationTag
                        {
                            Uid = a.uid,
                            Kind = UserProjectRelationTagKinds.Indirect,
                            Tag = String.Format("与{0}是好友", a.name)
                        });
                    }
                }
                uids = uids.Except(result.Select(r => r.Uid)).ToArray();
            }
            if (uids.Length > 0)
            {
                var mutual = _FootPrintRepository.GetMutualUids(user.Uid,uids);
                if (mutual.Length > 0)
                {
                    foreach (var u in mutual)
                    {
                        result.Add(new UserProjectRelationTag
                        {
                            Uid = u,
                            Kind = UserProjectRelationTagKinds.Mutual,
                            Tag = "同跟人"
                        });
                    }
                }
                uids = uids.Except(result.Select(r => r.Uid)).ToArray();
            }
            //if (uids.Length > 0)
            //{
            //    uids = _RelationManager.CreateUserRelationManager(user).DockedIds.Where(p=>uids.Contains(p)).ToArray();
            //    if (uids.Length > 0)
            //    {
            //        foreach (var u in uids)
            //        {
            //            result.Add(new UserProjectRelationTag
            //            {
            //                Uid = u,
            //                Kind = UserProjectRelationTagKinds.Docked,
            //                Tag = "对接人"
            //            });
            //        }
            //    }
            //}
            return result.ToArray();
        }
    }
}
