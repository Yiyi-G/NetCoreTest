using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat
{
    public interface ITagSourceManager
    {
        IQueryable<Data.TagSource> GetAllTag();
        Dictionary<long, string> GetTagName(long[] tids);
        Dictionary<long, string[]> GetFootPrintTagNameByFids(long[] fids);
    }
    public class TagSourceManager : ITagSourceManager
    {
        private readonly ITagSourceRepository _TagSourceRepository;
        public TagSourceManager(ITagSourceRepository tagSourceRepository)
        {
            _TagSourceRepository = tagSourceRepository;
        }
        public IQueryable<Data.TagSource> GetAllTag()
        {
           return _TagSourceRepository.Entities.OrderBy(P => P.order);
        }

        public Dictionary<long, string> GetTagName(long[] tids)
        {
            return _TagSourceRepository.GetTagName(tids);
        }

        public Dictionary<long, string[]> GetFootPrintTagNameByFids(long[] fids)
        {
            var result = new Dictionary<long, string[]>();
            if (fids.Length <= 0) return result;
            result = _TagSourceRepository.GetFootPrintTagNameByFids(fids);
            return result;
        }
    }
}
