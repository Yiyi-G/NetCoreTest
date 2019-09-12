using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data;
using System.Transactions;
using Microsoft.EntityFrameworkCore;

namespace Tgnet.Data.Entity
{

    public class EFRepository<TContext, TEntity> : DbSetRepository<TContext, TEntity>
        where TContext : DbContext
        where TEntity : class
    {
        public EFRepository(TContext context)
            : base(context)
        {
        }

        protected override DbSet<TEntity> DbSet
        {
            get { return Context.Set<TEntity>(); }
        }
    }

    public abstract class DbSetRepository<TContext, TEntity> : IRepository<TEntity>
        where TContext : DbContext
        where TEntity : class
    {
        public readonly TContext Context;

        public DbSetRepository(TContext context)
        {
            this.Context = context;
        }

        public TEntity Add(TEntity newEntity)
        {
            return DbSet.Add(newEntity).Entity;
        }

        public void AddRange(IEnumerable<TEntity> newEntitys)
        {
            DbSet.AddRange(newEntitys);
        }

        public TEntity Delete(TEntity deleteEntity)
        {
            return DbSet.Remove(deleteEntity).Entity;
        }

        public void DeleteRange(IEnumerable<TEntity> deleteEntitys)
        {
            DbSet.RemoveRange(deleteEntitys);
        }

        public IQueryable<TEntity> NoTrackingEntities
        {
            get { return DbSet.AsNoTracking(); }
        }

        public IQueryable<TEntity> NoTrackingEntitiesWith(params string[] includes)
        {
            return DbSetWith(includes).AsNoTracking();
        }

        private IQueryable<TEntity> DbSetWith(params string[] includes)
        {
            if (includes == null || includes.Length == 0) return DbSet;
            IQueryable<TEntity> entities = DbSet;
            for (int i = 0; i < includes.Length; i++)
            {
                entities = entities.Include(includes[i]);
            }
            return entities;
        }

        public IQueryable<TEntity> Entities
        {
            get { return DbSet; }
        }

        public IQueryable<TEntity> EntitiesWith(params string[] includes)
        {
            return DbSetWith(includes);
        }

        public IQueryable<TEntity> EntitiesWith<TProperty>(params Expression<Func<TEntity, TProperty>>[] includes)
        {
            if (includes == null || includes.Length == 0) return Entities;
            IQueryable<TEntity> entities = DbSet;
            for (int i = 0; i < includes.Length; i++)
            {
                entities = entities.Include(includes[i]);
            }
            return entities;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        protected abstract DbSet<TEntity> DbSet { get; }

        public T[] ReadUncommittedEntities<T>(Func<IQueryable<TEntity>, IQueryable<T>> func)
        {
            T[] entities;
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted
            }))
            {
                entities = func(NoTrackingEntities).ToArray();
                scope.Complete();
            }
            return entities;
        }

        public int Merger(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> update)
        {
            throw new NotImplementedException();
        }

        public int Merger(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> update, out bool insert)
        {
            throw new NotImplementedException();
        }

        ~DbSetRepository()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}
