using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Project
{
    public interface IAssociatedProjRecordManager
    {
        void AddRecord(AddAssociatedProjRecordArgs args);
    }

    public class AssociatedProjRecordManager: IAssociatedProjRecordManager
    {
        private readonly IRepository<AssociatedProjRecord> _AssociatedProjRecordRepository;
        public AssociatedProjRecordManager(IRepository<AssociatedProjRecord> associatedProjRecordRepository)
        {
            _AssociatedProjRecordRepository = associatedProjRecordRepository;
        }

        public void AddRecord(AddAssociatedProjRecordArgs args)
        {            
            _AssociatedProjRecordRepository.Add(new AssociatedProjRecord
            {
                fid=args.fid,
                oldProjId=args.oldProjId,
                newProjId=args.newProjId,
                created=DateTime.Now,
                @operator=args.@operator,
            });
            _AssociatedProjRecordRepository.SaveChanges();
        }
    }

    public class AddAssociatedProjRecordArgs
    {
        public void VerifyAddRecordArgs()
        {
            ExceptionHelper.ThrowIfNotId(fid, nameof(fid));
            ExceptionHelper.ThrowIfNotId(oldProjId, nameof(oldProjId));
            ExceptionHelper.ThrowIfNotId(newProjId, nameof(newProjId));
            ExceptionHelper.ThrowIfNotId(@operator, nameof(@operator));
        }

        public long fid { get; set; }//足迹id
        public long oldProjId { get; set; }//关联前项目id
        public long newProjId { get; set; }//关联后项目id
        public long @operator { get; set; }//操作人员id
    }
}
