using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data;

namespace Tgnet.FootChat.User
{
    public interface IUserComplainManager
    {
        IQueryable<Data.UserComplain> GetUserComplain();
    }
    public class UserComplainManager: IUserComplainManager
    {
        private readonly IRepository<Data.UserComplain> _UserComplainRepository;
    
        public UserComplainManager(IRepository<Data.UserComplain> userComplainRepository)
        {
            _UserComplainRepository = userComplainRepository;
        }

        public IQueryable<Data.UserComplain> GetUserComplain()
        {
            return _UserComplainRepository.NoTrackingEntities;
        }
    }
}
