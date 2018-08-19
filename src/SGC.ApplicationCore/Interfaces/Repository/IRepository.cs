using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC.ApplicationCore.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetTodos();
        TEntity GetById(int id);
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> Predicate);
        void Remove(TEntity entity);
    }
}
