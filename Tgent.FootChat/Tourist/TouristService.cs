using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;

namespace Tgnet.FootChat.Tourist
{
    public interface ITouristServiceFactory
    {
        ITouristService GetService(string deviceId);
    }
    public class TouristServiceFactory : ITouristServiceFactory
    {
        private readonly IRepository<Data.TouristViewFootPrintRecord> _TouristViewFootPrintRecordRepository;
        public TouristServiceFactory(
            IRepository<Data.TouristViewFootPrintRecord> touristViewFootPrintRecordRepository)
        {
            _TouristViewFootPrintRecordRepository = touristViewFootPrintRecordRepository;
        }
        public ITouristService GetService(string deviceId)
        {
            ExceptionHelper.ThrowIfNullOrWhiteSpace(deviceId, nameof(deviceId));
            return new TouristService(deviceId, _TouristViewFootPrintRecordRepository);
        }
    }
    public interface ITouristService
    {
        void AddViewFootPrintRecord(long fid);
        void AddViewFootPrintRecord(long[] fids);
    }
    public class TouristService: ITouristService
    {
        private readonly string _DeviceId;
        private readonly IRepository<Data.TouristViewFootPrintRecord> _TouristViewFootPrintRecordRepository;
        public TouristService(string deviceId,
            IRepository<Data.TouristViewFootPrintRecord> touristViewFootPrintRecordRepository)
        {
            _DeviceId = deviceId;
            _TouristViewFootPrintRecordRepository = touristViewFootPrintRecordRepository;
        }

        public void AddViewFootPrintRecord(long fid)
        {
            ExceptionHelper.ThrowIfNotId(fid, nameof(fid));
            var fids = new long[] { fid };
            var now = DateTime.Now;
            _TouristViewFootPrintRecordRepository.AddAndDeleteExcept(p => p.devieceId == _DeviceId && p.fid == fid,
                fids,
                (u, v) => u.fid == v,
                (u, v) =>
                {
                    u.count = u.count + 1;
                    u.updated = now;
                },
                u => { return false; },
                v => new Data.TouristViewFootPrintRecord()
                {
                    fid = fid,
                    devieceId  = _DeviceId,
                    count = 1,
                    updated = now
                });
        }

        public void AddViewFootPrintRecord(long[] fids)
        {
            fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (fids.Length == 0) return;
            var now = DateTime.Now;
            _TouristViewFootPrintRecordRepository.AddAndDeleteExcept(p => p.devieceId == _DeviceId && fids.Contains(p.fid),
                fids,
                (u, v) => u.fid == v,
                (u, v) =>
                {
                    u.count = u.count + 1;
                    u.updated = now;
                },
                u => { return false; },
                v => new Data.TouristViewFootPrintRecord()
                {
                    fid = v,
                    devieceId  = _DeviceId,
                    count = 1,
                    updated = now
                });
        }
    }
}
