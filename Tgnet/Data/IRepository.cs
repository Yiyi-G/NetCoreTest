using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Tgnet.Data
{
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// 脏读
        /// </summary>
        T[] ReadUncommittedEntities<T>(Func<IQueryable<TEntity>, IQueryable<T>> func);
        TEntity Add(TEntity newEntity);
        void AddRange(IEnumerable<TEntity> newEntitys);
        TEntity Delete(TEntity deleteEntity);
        void DeleteRange(IEnumerable<TEntity> deleteEntitys);
        IQueryable<TEntity> NoTrackingEntities { get; }
        IQueryable<TEntity> NoTrackingEntitiesWith(params string[] includes);
        IQueryable<TEntity> Entities { get; }
        IQueryable<TEntity> EntitiesWith(params string[] includes);
        IQueryable<TEntity> EntitiesWith<TProperty>(params Expression<Func<TEntity, TProperty>>[] includes);
        void SaveChanges();
        /// <summary>
        /// 如果 filter 能命中则更新，否则创建一条记录并更新。
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        int Merger(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> update);
        /// <summary>
        /// 如果 filter 能命中则更新，否则创建一条记录并更新。
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="update"></param>
        /// <param name="insert">是否插入了新记录</param>
        /// <returns></returns>
        int Merger(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> update, out bool insert);
    }
}
