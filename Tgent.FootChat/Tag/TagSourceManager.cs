using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Tag
{
    public interface ITagSourceManager
    {
        Dictionary<long, string[]> GetFootPrintTagNameByFids(long[] fids);
    }

    public class TagSourceManager: ITagSourceManager
    {
        private readonly ITagSourceRepository _TagSourceRepository;

        public TagSourceManager(ITagSourceRepository tagSourceRepository)
        {
            _TagSourceRepository = tagSourceRepository;
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
