using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.User
{
    public interface IUserProductManager
    {
        Dictionary<long, string> GetUserProductNameByUid(long[] uids);
    }
    class UserProductManager: IUserProductManager
    {
        private readonly IRepository<UserProduct> _UserProductRepository;

        public UserProductManager(IRepository<UserProduct> userProductRepository)
        {
            _UserProductRepository = userProductRepository;
        }

        public Dictionary<long, string> GetUserProductNameByUid(long[] uids)
        {
            var result = new Dictionary<long, string>();
            if (uids.Length <= 0) return result;
            result = _UserProductRepository.NoTrackingEntities.Where(p => uids.Contains(p.uid))
                .GroupBy(p => p.uid).ToDictionary(p => p.Key, p => string.Join(",", p.Select(d => d.name).ToArray()));
            return result;
        }
    }
}
