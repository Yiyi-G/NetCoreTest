using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet;
using Tgnet.Api;
using Tgnet.Data;
using Tgnet.FootChat.Events;
using Tgnet.FootChat.Push;
using Tgnet.FootChat.User;
using Tgnet.FootChat.YwqWcfService;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Relation
{
    public interface IUserRelationService
    {
        long Sender { get; }
        long Receiver { get; }
        RelationType RelationType { get; }
        /// <summary>
        /// 申请添加好友
        /// </summary>
        void Apply();
        /// <summary>
        /// 通过好友申请
        /// </summary>
        void Pass();
        /// <summary>
        /// 忽略好友申请
        /// </summary>
        void Ignore();
        /// <summary>
        /// 删除好友
        /// </summary>
        void Delete();
        void Update(string remark);
        bool IsConnection { get; }
        /// <summary>
        /// 是否申请添加好友
        /// </summary>
        bool IsApply { get; }
        /// <summary>
        /// 是否被申请添加好友
        /// </summary>
        bool IsBeApply { get; }
        bool InSession { get; set; }
        bool SessionTop { get; set; }
        bool IsNotNotify { get; set; }
        string Messae { get; }
        string Remark { get; }
        void MoveToBlacklist();
        void RemoveFromBlacklist();
        void SetConnectionFrom(ConnectionFrom from);
        Tgnet.FootChat.Push.Data.IDBMessage SendMessage(string contentType, string content, string clientMessageId, Dictionary<string, string> extensions = null);
    }

    internal class UserRelationService : IUserRelationService
    {
        private readonly Data.IRelationRepository _RelationRepository;
        private readonly Tgnet.FootChat.Push.INotifyServiceProxy _NotifyServiceProxy;
        private readonly IRelationEventFactory _RelationEventFactory;
        private readonly IUserManager _UserManager;
        private readonly IUserService _User;
        private Lazy<Data.Relation> _LazySenderRelation;
        private Lazy<Data.Relation> _LazyReceiverRelation;
        public UserRelationService(IUserService user, long receiver,
            Data.IRelationRepository relationRepository,
            Tgnet.FootChat.Push.INotifyServiceProxy notifyServiceProxy,
            IRelationEventFactory relationEventFactory,
            IUserManager userManager)
        {
            ExceptionHelper.ThrowIfNull(user, "user");
            ExceptionHelper.ThrowIfNotId(receiver, "receiver");
            Receiver = receiver;
            Sender = user.Uid;
            _User = user;
            _UserManager = userManager;
            _RelationEventFactory = relationEventFactory;
            _NotifyServiceProxy = notifyServiceProxy;
            _RelationRepository = relationRepository;
            _LazySenderRelation = new Lazy<Data.Relation>(() =>
            {
                return _RelationRepository.Entities.FirstOrDefault(r => r.sender == Sender && r.receiver == Receiver);
            });
            _LazyReceiverRelation = new Lazy<Data.Relation>(() =>
             {
                 return _RelationRepository.Entities.FirstOrDefault(r => r.sender == Receiver && r.receiver == Sender);
             });
        }

        public long Sender { get; private set; }
        public long Receiver { get; private set; }

        public RelationType RelationType
        {
            get
            {
                return _LazySenderRelation.Value == null ? RelationType.None
                        : _LazySenderRelation.Value.rType;
            }
        }
        public bool IsConnection
        {
            get
            {
                return _LazySenderRelation.Value != null
                    && _LazySenderRelation.Value.rType == RelationType.Connection
                    && !_LazySenderRelation.Value.inSenderBlack
                    && !_LazySenderRelation.Value.inReceiverBlack;
            }
        }
        public bool IsApply
        {
            get
            {
                return _LazySenderRelation.Value != null
                    && _LazySenderRelation.Value.rType == RelationType.Apply;
            }
        }

        public bool IsBeApply
        {
            get
            {
                return _LazySenderRelation.Value != null
                    && _LazySenderRelation.Value.rType == RelationType.BeApply;
            }
        }
        public bool InSession
        {
            get
            {
                if (_LazySenderRelation.Value == null)
                    return false;
                else
                    return _LazySenderRelation.Value.inSession;
            }
            set
            {
                if (_LazySenderRelation.Value == null)
                    CreateRelation();
                if (value != _LazySenderRelation.Value.inSession)
                {
                    _LazySenderRelation.Value.inSession = value;
                    UpdateVersion(_LazySenderRelation.Value);
                    _RelationRepository.SaveChanges();
                }
            }
        }
        public bool SessionTop
        {
            get
            {
                if (_LazySenderRelation.Value == null)
                    return false;
                else
                    return _LazySenderRelation.Value.sessionTop;
            }
            set
            {
                if (_LazySenderRelation.Value == null)
                    CreateRelation();
                if (value != _LazySenderRelation.Value.sessionTop)
                {
                    _LazySenderRelation.Value.sessionTop = value;
                    UpdateVersion(_LazySenderRelation.Value);
                    _RelationRepository.SaveChanges();
                }
            }
        }
        public bool IsNotNotify
        {
            get
            {
                if (_LazySenderRelation.Value == null)
                    return false;
                else
                    return _LazySenderRelation.Value.isNotNotiry;
            }
            set
            {
                if (_LazySenderRelation.Value == null)
                    CreateRelation();
                if (value != _LazySenderRelation.Value.isNotNotiry)
                {
                    _LazySenderRelation.Value.isNotNotiry = value;
                    UpdateVersion(_LazySenderRelation.Value);
                    _RelationRepository.SaveChanges();
                }
            }
        }
        public void MoveToBlacklist()
        {
            CreateRelation();

            if (_LazySenderRelation.Value.inSenderBlack) return;


            using (var scope = new System.Transactions.TransactionScope())
            {
                _LazySenderRelation.Value.inSenderBlack = true;
                _LazySenderRelation.Value.updateDate = DateTime.Now;
                _LazyReceiverRelation.Value.inReceiverBlack = true;
                _LazyReceiverRelation.Value.updateDate = DateTime.Now;
                UpdateVersion(_LazySenderRelation.Value);
                UpdateVersion(_LazyReceiverRelation.Value);
                _RelationRepository.SaveChanges();
                _RelationEventFactory.CreateEvent(this).MoveToBlacklist();
                scope.Complete();
            }
        }

        public void RemoveFromBlacklist()
        {
            if (_LazySenderRelation.Value == null || !_LazySenderRelation.Value.inSenderBlack)
                return;

            using (var scope = new System.Transactions.TransactionScope())
            {
                _LazySenderRelation.Value.inSenderBlack = false;
                _LazySenderRelation.Value.updateDate = DateTime.Now;
                _LazyReceiverRelation.Value.inReceiverBlack = false;
                _LazyReceiverRelation.Value.updateDate = DateTime.Now;
                _RelationRepository.SaveChanges();
                UpdateVersion(_LazySenderRelation.Value);
                UpdateVersion(_LazyReceiverRelation.Value);
                _RelationRepository.SaveChanges();
                _RelationEventFactory.CreateEvent(this).OnRemoveFromBlackList();
                scope.Complete();
            }
        }
        private void SetRelationInSession()
        {
            Apply();
            var update = false;
            if (!_LazySenderRelation.Value.inSession)
            {
                _LazySenderRelation.Value.inSession = true;
                UpdateVersion(_LazySenderRelation.Value);
                update = true;
            }
            if (!_LazyReceiverRelation.Value.inSession)
            {
                _LazyReceiverRelation.Value.inSession = true;
                UpdateVersion(_LazyReceiverRelation.Value);
                update = true;
            }
            if (update)
            {
                _RelationRepository.SaveChanges();
            }
        }
        public void SetConnectionFrom(ConnectionFrom from)
        {
            Apply();
            if (_LazySenderRelation.Value.from!=from.To<byte>())
            {
                _LazyReceiverRelation.Value.from = from.To<byte>();
                _LazySenderRelation.Value.from = from.To<byte>();
                _RelationRepository.SaveChanges();
            }
        }
        private bool CreateRelation()
        {
            var add = _LazySenderRelation.Value == null || _LazyReceiverRelation.Value == null;
            if (!add) return false;
            if (Sender == Receiver)
                throw new Tgnet.Api.ExceptionWithErrorCode(Api.ErrorCode.非法的操作, "关系创建失败！");
            using (var scope = new System.Transactions.TransactionScope())
            {
                if (_LazySenderRelation.Value == null)
                {
                    var entity = _RelationRepository.Add(CreateRelationNoneEntity(Sender, Receiver));
                    _LazySenderRelation = new Lazy<Data.Relation>(() => entity);
                }
                if (_LazyReceiverRelation.Value == null)
                {
                    var entity = _RelationRepository.Add(CreateRelationNoneEntity(Receiver, Sender));
                    _LazyReceiverRelation = new Lazy<Data.Relation>(() => entity);
                }
                if (add)
                {
                    _RelationRepository.SaveChanges();
                }
                scope.Complete();
                return add;
            }
        }
        private Data.Relation CreateRelationNoneEntity(long sender, long receiver)
        {
            return new Data.Relation
            {
                createDate = DateTime.Now,
                dateVersion = 0,
                receiver = receiver,
                rType = RelationType.None,
                sender = sender,
                updateDate = DateTime.Now,
                inSession = false,
            };
        }
        private void UpdateVersion(Data.Relation relation)
        {
            relation.dateVersion = (long)DateTime.Now.ToTimestamp().TotalMilliseconds;
        }
        private void ThrowIfNotFriend()
        {
            if (!IsConnection)
                throw new Api.ExceptionWithErrorCode(Api.ErrorCode.不是好友关系);
        }
        public Tgnet.FootChat.Push.Data.IDBMessage SendMessage(string contentType, string content, string clientMessageId, Dictionary<string, string> extensions = null)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(contentType, "contentType");
            ExceptionHelper.ThrowIfNullOrWhiteSpace(content, "内容不能为空");
            SetRelationInSession();
            var exts = (extensions ?? new Dictionary<string, string>()).ToDictionary(e => e.Key, e => (object)e.Value);
            var request = new NotifyMessageRequest(ActionType.SINGLE_MESSAGE, Receiver, Sender, new long[] { Receiver }, contentType, content, false, null, null, exts);
            MessageExtensions.ClientMessageId.SetValue(request.Extension, clientMessageId);
            var result = _NotifyServiceProxy.Notify(request);
            return result[Receiver];
        }
        public bool IsInBlacklist
        {
            get
            {
                return _LazySenderRelation.Value != null && _LazySenderRelation.Value.inReceiverBlack;
            }
        }
        public string Remark
        {
            get
            {
                return _LazySenderRelation.Value == null ? String.Empty
                       : _LazySenderRelation.Value.remark;
            }
        }
        public string Messae
        {
            get
            {
                return _LazyReceiverRelation.Value == null ? String.Empty
                      : _LazyReceiverRelation.Value.message;
            }
        }

        public void Apply()
        {
            CreateRelation();
            if (IsInBlacklist) return;
            if (IsConnection) return;

            using (var scope = new System.Transactions.TransactionScope())
            {
                if (_LazySenderRelation.Value.inSenderBlack)
                {
                    _LazySenderRelation.Value.inSenderBlack = false;
                    _LazyReceiverRelation.Value.inReceiverBlack = false;
                }
                var oldType = _LazySenderRelation.Value.rType;
                if (oldType != RelationType.Apply)
                {
                    if (oldType == RelationType.None)
                    {
                        _LazySenderRelation.Value.rType = RelationType.Apply;
                        _LazyReceiverRelation.Value.rType = RelationType.BeApply;
                    }
                    else
                    {
                        _LazySenderRelation.Value.rType = RelationType.Connection;
                        _LazySenderRelation.Value.inSession = true;
                        UpdateVersion(_LazySenderRelation.Value);
                        _LazyReceiverRelation.Value.rType = RelationType.Connection;
                        _LazyReceiverRelation.Value.inSession = true;
                        UpdateVersion(_LazyReceiverRelation.Value);
                    }
                    _LazySenderRelation.Value.updateDate = DateTime.Now;
                    _LazyReceiverRelation.Value.updateDate = DateTime.Now;
                    _RelationRepository.SaveChanges();
                }
                scope.Complete();
            }
        }

        public void Pass()
        {
            if (IsConnection) return;
            if (IsInBlacklist || _LazySenderRelation.Value == null || _LazySenderRelation.Value.rType != RelationType.BeApply)
                throw new Api.ExceptionWithErrorCode(Api.ErrorCode.好友申请不存在);
            using (var scope = new System.Transactions.TransactionScope())
            {
                if (_LazySenderRelation.Value.inSenderBlack)
                {
                    _LazySenderRelation.Value.inSenderBlack = false;
                    _LazyReceiverRelation.Value.inReceiverBlack = false;
                }
                _LazySenderRelation.Value.rType = RelationType.Connection;
                _LazySenderRelation.Value.inSession = true;
                _LazySenderRelation.Value.updateDate = DateTime.Now;
                UpdateVersion(_LazySenderRelation.Value);
                _LazyReceiverRelation.Value.rType = RelationType.Connection;
                _LazyReceiverRelation.Value.inSession = true;
                _LazyReceiverRelation.Value.updateDate = DateTime.Now;
                UpdateVersion(_LazyReceiverRelation.Value);

                _RelationRepository.SaveChanges();

                scope.Complete();
            }
        }

        public void Ignore()
        {
            if (IsConnection) return;
            if (IsInBlacklist || _LazySenderRelation.Value == null || _LazySenderRelation.Value.rType != RelationType.BeApply)
                return;

            using (var scope = new System.Transactions.TransactionScope())
            {
                _LazySenderRelation.Value.rType = RelationType.None;
                _LazySenderRelation.Value.updateDate = DateTime.Now;
                _LazyReceiverRelation.Value.rType = RelationType.None;
                _LazyReceiverRelation.Value.updateDate = DateTime.Now;

                _RelationRepository.SaveChanges();

                scope.Complete();
            }
        }
        public void Update(string remark)
        {
            remark = (remark ?? String.Empty).Trim();
            if (_LazySenderRelation == null || _LazySenderRelation.Value == null)
            {
                throw new ExceptionWithErrorCode(ErrorCode.好友不存在, "不存在对应的好友关系");
            }
            _LazySenderRelation.Value.remark = remark;
            _LazySenderRelation.Value.updateDate = DateTime.Now;
            _RelationRepository.SaveChanges();
        }
        public void Delete()
        {
            if (_LazySenderRelation.Value == null || _LazySenderRelation.Value.rType != RelationType.Connection)
            {
                return;
            }
            using (var scope = new System.Transactions.TransactionScope())
            {
                var notify = IsConnection;
                _LazySenderRelation.Value.rType = RelationType.None;
                _LazySenderRelation.Value.updateDate = DateTime.Now;
                _LazySenderRelation.Value.inSession = false;
                UpdateVersion(_LazySenderRelation.Value);
                _LazyReceiverRelation.Value.rType = RelationType.None;
                _LazyReceiverRelation.Value.updateDate = DateTime.Now;
                _LazyReceiverRelation.Value.inSession = false;
                UpdateVersion(_LazyReceiverRelation.Value);
                _RelationRepository.SaveChanges();

                scope.Complete();
            }
        }
    }
}
