using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Api;
using Tgnet.Linq;
using Tgnet.Data;
using Tgnet.FootChat;
using Tgnet.FootChat.YwqWcfService;
using Tgnet.ServiceModel;
using Tgnet.FootChat.User;
using Tgnet.FootChat.Data;
using Tgnet.FootChat.Events;

namespace Tgnet.FootChat.Relation
{
    public interface IRelationManager
    {
        IUserRelationManager CreateUserRelationManager(IUserService user);
    }
    class RelationManager : IRelationManager
    {
        private readonly Data.IRelationRepository _RelationRepository;
        private readonly Tgnet.FootChat.Push.INotifyServiceProxy _NotifyServiceProxy;
        private readonly Tgnet.FootChat.Push.IMessageService _MessageService;
        private readonly IRelationEventFactory _RelationEventFactory;
        private readonly IUserManager _UserManager;

        public RelationManager(Data.IRelationRepository relationRepository,
            Tgnet.FootChat.Push.INotifyServiceProxy notifyServiceProxy,
            Tgnet.FootChat.Push.IMessageService messageService,
            IRelationEventFactory relationEventFactory,
            IUserManager userManager)
        {
            _UserManager = userManager;
            _MessageService = messageService;
            _RelationEventFactory = relationEventFactory;
            _NotifyServiceProxy = notifyServiceProxy;
            _RelationRepository = relationRepository;
        }
        public IUserRelationManager CreateUserRelationManager(IUserService user)
        {
            return new UserRelationManager(user, _RelationRepository, _NotifyServiceProxy, _MessageService, _RelationEventFactory, _UserManager);
        }
    }
    public interface IUserRelationManager
    {
        IUserRelationService GetService(long receiver);
        long[] DockedIds { get; }
        Dictionary<long, RelationType> GetRelationTypes(IEnumerable<long> uids);
        Dictionary<long, ConnectionFrom> GetConnectionFrom(IEnumerable<long> uids);
        IQueryable<Data.Relation> GetChanged(long minRelationVersion);
        IQueryable<Data.Relation> GetRemoved(long minRelationVersion);
        IQueryable<Data.Relation> GetMutualConnections(long uid);
        IQueryable<Data.Relation> BeApplys { get; }
        IQueryable<Data.Relation> Dockeds { get; }
        IQueryable<Data.Relation> Blacklist { get; }
        IQueryable<Data.Relation> Enableds { get; }
        IQueryable<Data.Relation> InSessions { get; }
        long[] InSessionIds { get; }
        Dictionary<long, int> GetMutualConnections();
        Dictionary<long, int> GetMutualConnections(long[] uids);
        PageModel<FriendInfo> GetMyDockeds(int? start, int? limit);
    }

    internal class UserRelationManager : IUserRelationManager
    {
        private readonly Data.IRelationRepository _RelationRepository;
        private readonly Tgnet.FootChat.Push.INotifyServiceProxy _NotifyServiceProxy;

        private readonly Tgnet.FootChat.Push.IMessageService _MessageService;
        private readonly IRelationEventFactory _RelationEventFactory;
        private readonly IUserManager _UserManager;
        private readonly IUserService _User;
        private long[] _Connections;
        public UserRelationManager(IUserService user,
            Data.IRelationRepository relationRepository,
            Tgnet.FootChat.Push.INotifyServiceProxy notifyServiceProxy,
            Tgnet.FootChat.Push.IMessageService messageService,
            IRelationEventFactory relationEventFactory,
            IUserManager userManager)
        {
            ExceptionHelper.ThrowIfNull(user, "user");
            _UserManager = userManager;
            _User = user;
            _MessageService = messageService;
            _RelationEventFactory = relationEventFactory;
            _NotifyServiceProxy = notifyServiceProxy;
            _RelationRepository = relationRepository;
        }
        public IUserRelationService GetService(long receiver)
        {
            ExceptionHelper.ThrowIfNotId(receiver, "receiver");
            return new UserRelationService(_User, receiver, _RelationRepository, _NotifyServiceProxy, _RelationEventFactory, _UserManager);
        }


        public long[] DockedIds
        {
            get
            {
                if (_Connections == null)
                {
                    _Connections = Dockeds.Select(f => f.receiver).ToArray();
                }
                return _Connections;
            }
        }
        public IQueryable<Data.Relation> Dockeds
        {
            get
            {
                return _RelationRepository.Dockeds.Where(r => r.sender == _User.Uid);
            }
        }
        public IQueryable<Data.Relation> Enableds
        {
            get
            {
                return _RelationRepository.Enableds.Where(r => r.sender == _User.Uid);
            }
        }
        public IQueryable<Data.Relation> InSessions
        {
            get
            {
                return _RelationRepository.InSessions.Where(r => r.sender == _User.Uid);
            }
        }
        public Dictionary<long, RelationType> GetRelationTypes(IEnumerable<long> receivers)
        {
            if (receivers == null) return new Dictionary<long, RelationType>();
            var ids = receivers.Where(id => id > 0).Distinct().ToArray();
            if (ids.Length == 0) return new Dictionary<long, RelationType>();
            var entites = _RelationRepository.Entities.Where(r => r.sender == _User.Uid && ids.Contains(r.receiver))
                                .Select(r => new { uid = r.receiver, type = r.rType, inAnyBlacklist = r.inReceiverBlack || r.inSenderBlack })
                                .ToArray();

            return ids.ToDictionary(id => id, id =>
            {
                var entity = entites.FirstOrDefault(e => e.uid == id);
                if (entity != null)
                {
                    return entity.inAnyBlacklist ? RelationType.None : entity.type;
                }
                else
                {
                    return RelationType.None;
                }
            });
        }
        public IQueryable<Data.Relation> GetChanged(long minRelationVersion)
        {
            if (minRelationVersion <= 0)
                return Enableds.Where(r => r.inSession);
            else
            {
                return Enableds.Where(r => r.inSession && r.dateVersion > minRelationVersion);
            }
        }
        public IQueryable<Data.Relation> GetMutualConnections(long uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, nameof(uid));
            return _RelationRepository.Dockeds.Where(f => f.sender == uid && DockedIds.Contains(f.receiver));
        }
        public Dictionary<long, int> GetMutualConnections()
        {
            var Connections = DockedIds;
            Connections = (DockedIds ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            if (Connections.Length == 0)
            {
                return new Dictionary<long, int>();
            }
            return _RelationRepository.Dockeds.Where(f => Connections.Contains(f.receiver))
                .GroupBy(f => f.sender)
                .ToDictionary(f => f.Key, f => f.Count());
        }
        public Dictionary<long, int> GetMutualConnections(long[] uids)
        {
            uids = (uids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            if (uids.Length == 0)
            {
                return new Dictionary<long, int>();
            }
            return GetMutualConnections().Where(f => uids.Contains(f.Key)).ToDictionary(f => f.Key, f => f.Value);
        }
        public IQueryable<Data.Relation> GetRemoved(long minRelationVersion)
        {
            if (minRelationVersion <= 0)
                return Enumerable.Empty<Data.Relation>().AsQueryable();
            else
            {
                return _RelationRepository.Entities.Where(r => r.dateVersion > minRelationVersion
                    && r.sender == _User.Uid
                    && (r.inSenderBlack || r.inReceiverBlack || !r.inSession));
            }
        }

        public FriendInfo[] GetNewConnections()
        {
            var result = new List<FriendInfo>();
            var applys = _RelationRepository.BeApplys.Where(r => r.sender == _User.Uid).ToArray();
            var uids = applys.Select(r => r.receiver).ToArray();
            if (uids != null && uids.Length > 0)
            {
                result.AddRange(applys
                   .Where(r => uids.Contains(r.receiver))
                   .OrderByDescending(r => r.updateDate)
                   .Select(r => new FriendInfo
                   {
                       Uid = r.receiver,
                       Relation = r.rType.To<byte>(),
                       Message = r.message,
                       UpdateDate = r.updateDate,
                   }));
            }
            return result.ToArray();
        }
        public IQueryable<Data.Relation> BeApplys
        {
            get
            {
                return _RelationRepository.BeApplys.Where(r => r.sender == _User.Uid);
            }
        }

        public IQueryable<Data.Relation> Blacklist
        {
            get
            {
                return _RelationRepository.BlackList.Where(r => r.sender == _User.Uid);
            }
        }
        public long[] InSessionIds
        {
            get
            {
                if (_Connections == null)
                {
                    _Connections = InSessions.Select(f => f.receiver).ToArray();
                }
                return _Connections;
            }
        }
        public PageModel<FriendInfo> GetMyDockeds(int? start, int? limit)
        {
            var result = new List<FriendInfo>();
            var connections = Dockeds.OrderByDescending(f => f.updateDate).Take(start, limit).ToArray();
            if (connections != null && connections.Count() > 0)
            {
                result.AddRange(connections
                   .Select(f => new FriendInfo
                   {
                       Uid = f.receiver,
                       Relation = f.rType.To<byte>(),
                       UpdateDate = f.updateDate,
                       Description = f.description,
                       IsStar = f.isStar,
                       Nick = f.remark,
                   }).ToArray());
            }
            return new PageModel<FriendInfo>(result, Dockeds.Count());
        }

        public Dictionary<long, ConnectionFrom> GetConnectionFrom(IEnumerable<long> uids)
        {
            var ids = uids.Where(id => id > 0).Distinct().ToArray();
            if (ids.Length == 0)
            {
                return new Dictionary<long, ConnectionFrom>();
            }
            return _RelationRepository.Entities
                .Where(r => r.sender == _User.Uid && ids.Contains(r.receiver))
                .Select(r => new { uid = r.receiver, from = r.from })
                .ToArray()
                .ToDictionary(r => r.uid, r => (ConnectionFrom)r.from);
        }
    }
}
