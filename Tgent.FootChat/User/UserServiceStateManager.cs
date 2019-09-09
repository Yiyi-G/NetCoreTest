using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Data;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.User
{
    public interface IUserServiceStateManager
    {
        Dictionary<long, Data.FootCharUserServiceState> GetUserServiceStateLevelByUids(long[] uids);
        UserServiceStateStatistics GetUserServiceStateStatistics(DateTime date);
    }
    class UserServiceStateManager: IUserServiceStateManager
    {
        private readonly IUserServiceStateRepository _UserServiceStateRepository;

        public UserServiceStateManager(IUserServiceStateRepository userServiceStateRepository)
        {
            _UserServiceStateRepository = userServiceStateRepository;
        }

        public Dictionary<long, Data.FootCharUserServiceState> GetUserServiceStateLevelByUids(long[] uids)
        {
            var result = new Dictionary<long, Data.FootCharUserServiceState>();
            if (uids.Length <= 0) return result;
            result = _UserServiceStateRepository.NoTrackingEntities.Where(p => uids.Contains(p.uid)).GroupBy(p => p.uid).ToDictionary(p=>p.Key,p=>p.FirstOrDefault());
            return result;
        }

        public UserServiceStateStatistics GetUserServiceStateStatistics(DateTime date)
        {
            return _UserServiceStateRepository.GetUserServiceStateStatistics(date);
        }
    }
}
