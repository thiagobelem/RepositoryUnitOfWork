using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryUnitOfWork.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Remove(T obj);
        void Update(T obj);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
