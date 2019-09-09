using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet;
using Tgnet.Api;
using Tgnet.Core;
using Tgnet.FootChat.Events;
using Tgnet.FootChat.FootPrint;
using Tgnet.FootChat.User;

namespace Tgnet.FootChat.Docked
{
    public interface IUserDockedServiceFactory
    {
        IUserDockedService CreateService(long rid, Tgnet.FootChat.User.IUserService user);
    }
    class UserDockedServiceFactory : IUserDockedServiceFactory
    {
        private readonly Data.IDockedRecordRepository _DockedRecordRepository;
        private readonly IFootPrintDockedEventFactory _FootPrintDockedEventFactory;
        private readonly IFootPrintServiceFactory _FootPrintServiceFactory;
        public UserDockedServiceFactory(
            Data.IDockedRecordRepository dockedRecordRepository, 
            IFootPrintDockedEventFactory footPrintDockedEventFactory,
            IFootPrintServiceFactory footPrintServiceFactory)
        {
            _DockedRecordRepository = dockedRecordRepository;
            _FootPrintDockedEventFactory = footPrintDockedEventFactory;
            _FootPrintServiceFactory = footPrintServiceFactory;
        }

        public IUserDockedService CreateService(long rid, IUserService user)
        {
            return new UserDockedService(rid, user, _DockedRecordRepository, _FootPrintDockedEventFactory, _FootPrintServiceFactory);
        }
    }
    public interface IUserDockedService
    {
        long Rid { get; }
        long Fid { get; }
        long Sender { get; }
        long Receiver { get; }
        Tgnet.FootChat.Docked.DockedStatus Status { get; }
        string Message { get; }
        void DockedPass();
        void DockedUnPass();
    }
    class UserDockedService : IUserDockedService
    {
        private readonly Tgnet.FootChat.User.IUserService _User;
        private readonly long _Rid;
        private Lazy<Data.DockedRecord> _LazyDockedRecord;
        private readonly Data.IDockedRecordRepository _DockedRecordRepository;
        private readonly IFootPrintDockedEventFactory _FootPrintDockedEventFactory;
        private readonly IFootPrintServiceFactory _FootPrintServiceFactory;

        public UserDockedService(long rid,
            Tgnet.FootChat.User.IUserService user,
             Data.IDockedRecordRepository dockedRecordRepository,
            IFootPrintDockedEventFactory footPrintDockedEventFactory,
            IFootPrintServiceFactory footPrintServiceFactory)
        {
            ExceptionHelper.ThrowIfNotId(rid, nameof(rid));
            ExceptionHelper.ThrowIfNull(user, nameof(user));
            _Rid = rid;
            _User = user;
            _DockedRecordRepository = dockedRecordRepository;
            _FootPrintDockedEventFactory = footPrintDockedEventFactory;
            _FootPrintServiceFactory = footPrintServiceFactory;
            _LazyDockedRecord = new Lazy<Data.DockedRecord>(() =>
            {
                var entity = _DockedRecordRepository.Entities.Where(r => r.rid == rid).FirstOrDefault();
                if (entity == null)
                {
                    throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目, "对接不存在");
                }
                return entity;
            });
        }
        public long Rid
        {
            get
            {
                return _Rid;
            }
        }

        public long Fid
        {
            get
            {
                return _LazyDockedRecord.Value.fid;
            }
        }

        public long Sender
        {
            get
            {
                return _LazyDockedRecord.Value.sender;
            }
        }

        public long Receiver
        {
            get
            {
                return _LazyDockedRecord.Value.receiver;
            }
        }

        public DockedStatus Status
        {
            get
            {
                return _LazyDockedRecord.Value.status;
            }
        }

        public string Message
        {
            get
            {
                return (_LazyDockedRecord.Value.message ?? String.Empty).Trim();
            }
        }

        
        public void DockedPass()
        {
            if (Status == DockedStatus.Apply)
            {
                ThrowIfNoPermissions();
                using (var scope = new System.Transactions.TransactionScope())
                {
                    _LazyDockedRecord.Value.status = DockedStatus.Pass;
                    _LazyDockedRecord.Value.updated = DateTime.Now;
                    _DockedRecordRepository.SaveChanges();

                    //推送
                    var footprint = _FootPrintServiceFactory.GetService(Fid);
                    _FootPrintDockedEventFactory.CreateEvent().OnDockedPass(this, footprint.Pid, footprint.ProjectName);
                    scope.Complete();
                }
            }
        }
        public void DockedUnPass()
        {
            if (Status == DockedStatus.Apply)
            {
                ThrowIfNoPermissions();
                using (var scope = new System.Transactions.TransactionScope())
                {
                    _LazyDockedRecord.Value.status = DockedStatus.UnPass;
                    _LazyDockedRecord.Value.updated = DateTime.Now;
                    _DockedRecordRepository.SaveChanges();

                    //推送
                    var footprint = _FootPrintServiceFactory.GetService(Fid);
                    _FootPrintDockedEventFactory.CreateEvent().OnDockedUnPass(this, footprint.ProjectName);
                    scope.Complete();
                }
            }
        }

        public void DockIgnore()
        {
            throw new NotImplementedException();
        }

        private void ThrowIfNoPermissions()
        {
            if (_User.Uid != Receiver)
            {
                throw new ExceptionWithErrorCode(ErrorCode.没有操作权限);
            }
        }
    }
}
