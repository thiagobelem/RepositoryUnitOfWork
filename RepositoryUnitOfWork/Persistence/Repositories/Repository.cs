using RepositoryUnitOfWork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryUnitOfWork.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        private DbSet<T> dbSet;

        public Repository(DbContext dbContext)
        {
            context = dbContext;
            dbSet = context.Set<T>();
        }

        public void Add(T obj)
        {
            dbSet.Add(obj);
        }

        public void Remove(T obj)
        {
            dbSet.Remove(obj);
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
        }
        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return dbSet.SingleOrDefault(predicate);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public T Get(int id)
        {
           return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

    }
}
