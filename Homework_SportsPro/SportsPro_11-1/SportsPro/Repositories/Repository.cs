using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using SportsPro.Repositories.Interfaces;
using System.Linq.Expressions;

namespace SportsPro.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext ctx) => Context = ctx;

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return Context.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int id)
        {
            var found = Context.Set<TEntity>().Find(id);

            return found;
        }
    }
}
