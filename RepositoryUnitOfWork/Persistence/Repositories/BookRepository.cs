using RepositoryUnitOfWork.Core.Domain;
using RepositoryUnitOfWork.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryUnitOfWork.Persistence.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(AppContext context) : base(context)
        {
        }

        public AppContext AppContext { get { return context as AppContext; } }

        public IEnumerable<Book> GetBooksByYear(int year)
        {
            return AppContext.Books.Where(b => b.Year == year);
        }
    }
}
