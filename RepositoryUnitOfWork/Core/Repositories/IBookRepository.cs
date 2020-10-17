using RepositoryUnitOfWork.Core.Domain;
using System.Collections.Generic;

namespace RepositoryUnitOfWork.Core.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBooksByYear(int year);
    }
}
