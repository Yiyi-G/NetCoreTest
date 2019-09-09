using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.Core.Data;
using Tgnet.Data;
using Tgnet.Data.Entity;
using Tgnet.FootChat.Relation;

namespace Tgnet.FootChat.Data
{
    public interface IRelationRepository : IRepository<Relation>
    {
        IQueryable<Data.Relation> Dockeds { get; }
        IQueryable<Data.Relation> BeApplys { get; }
        IQueryable<Data.Relation> ConnectionAndBeApplys { get; }
        IQueryable<Data.Relation> ApplyAndBeApplys { get; }
        IQueryable<Relation> Enableds { get; }
        IQueryable<Relation> InSessions { get; }
        IQueryable<Data.Relation> BlackList { get; }
        IQueryable<Data.Relation> HasNicks { get; }
    }

    public class RelationRepository : DbSetRepository<FootChatContext, Relation>, IRelationRepository
    {
        public RelationRepository(FootChatContext context)
            : base(context) { }

        protected override DbSet<Relation> DbSet
        {
            get { return Context.Relation; }
        }

        public IQueryable<Relation> Dockeds
        {
            get
            {
                return Entities.Where(r => (r.rType == RelationType.Connection) && !r.inSenderBlack && !r.inReceiverBlack);
            }
        }
        public IQueryable<Relation> Enableds
        {
            get
            {
                return Entities.Where(r => !r.inSenderBlack && !r.inReceiverBlack);
            }
        }
        public IQueryable<Relation> ApplyAndBeApplys
        {
            get
            {
                return Entities.Where(r => (r.rType == RelationType.Apply || r.rType == RelationType.BeApply) && !r.inReceiverBlack && !r.inSenderBlack);
            }
        }
        public IQueryable<Relation> BeApplys
        {
            get
            {
                return Entities.Where(r => r.rType == RelationType.BeApply && !r.inReceiverBlack && !r.inSenderBlack);
            }
        }
        public IQueryable<Relation> BlackList
        {
            get
            {
                return Entities.Where(r => r.inSenderBlack);
            }
        }
        public IQueryable<Relation> HasNicks
        {
            get
            {
                return Entities.Where(r => !String.IsNullOrEmpty(r.remark));
            }
        }

        public IQueryable<Relation> InSessions
        {
            get
            {
                return Entities.Where(r => !r.inSenderBlack && !r.inReceiverBlack && r.inSession);
            }
        }

        public IQueryable<Relation> ConnectionAndBeApplys
        {
            get
            {
                return Entities.Where(r => (r.rType == RelationType.Connection|| r.rType == RelationType.BeApply) && !r.inReceiverBlack && !r.inSenderBlack);
            }
        }
    }
}
