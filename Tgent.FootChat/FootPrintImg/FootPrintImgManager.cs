using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;

namespace Tgnet.FootChat.FootPrintImg
{
    public interface IFootPrintImgManager
    {
        Dictionary<long, Data.FootPrintImg[]> GetFootPrintImgByFids(long[] fids, bool isOnlyEnabled);
        Data.FootPrintImg[] GetFootPrintImgByFid(long fid);
    }
    public class FootPrintImgManager: IFootPrintImgManager
    {
        private readonly IRepository<Data.FootPrintImg> _FootPrintImgRepository;

        public FootPrintImgManager(IRepository<Data.FootPrintImg> footPrintImgRepository)
        {
            _FootPrintImgRepository = footPrintImgRepository;
        }


        public Dictionary<long, Data.FootPrintImg[]> GetFootPrintImgByFids(long[] fids,bool isOnlyEnabled)
        {
            fids = (fids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            var result = new Dictionary<long, Data.FootPrintImg[]>();
            if (fids.Length <= 0) return result;
            var source = _FootPrintImgRepository.Entities.AsNoTracking().Where(p => fids.Contains(p.fid));
            if (isOnlyEnabled)
            {
                source = source.Where(p => p.isEnabled);
            }            
            result = source.GroupBy(p => p.fid).ToDictionary(p => p.Key, p => p.Select(d => d).ToArray());
            return result;
        }

        public Data.FootPrintImg[] GetFootPrintImgByFid(long fid)
        {
            ExceptionHelper.ThrowIfNotId(fid,nameof(fid));
            var source = _FootPrintImgRepository.Entities.AsNoTracking().Where(p =>p.fid==fid).ToArray();
            return source;
        }
    }
}
