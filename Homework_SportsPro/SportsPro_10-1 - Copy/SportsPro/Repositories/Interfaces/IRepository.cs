using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SportsPro.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);


        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);



    }
}
