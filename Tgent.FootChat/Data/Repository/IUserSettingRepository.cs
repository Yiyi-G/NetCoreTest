using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;

namespace Tgnet.FootChat.Data
{
    public interface IUserSettingRepository : IRepository<Data.UserSetting>
    {
        IQueryable<Data.UserSetting> UserSetting { get; }
    }

    public class UserSetttingRepository : Tgnet.Data.Entity.DbSetRepository<FootChatContext, Data.UserSetting>, IUserSettingRepository
    {
        public UserSetttingRepository(FootChatContext context)
            : base(context) { }

        protected override DbSet<UserSetting> DbSet
        {
            get { return Context.UserSetting; }
        }
        public IQueryable<UserSetting> UserSetting
        {
            get
            {
                return Entities;
            }
        }
    }
}
