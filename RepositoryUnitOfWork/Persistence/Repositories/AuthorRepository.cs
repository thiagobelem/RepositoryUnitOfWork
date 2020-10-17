using RepositoryUnitOfWork.Core.Domain;
using RepositoryUnitOfWork.Core.Repositories;
using System.Data.Entity;
using System.Linq;

namespace RepositoryUnitOfWork.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppContext context) : base(context)
        {
        }

        public AppContext AppContext { get { return context as AppContext; } }

        public Author GetAuthorWithBooks(int id)
        {
            return AppContext.Authors.Include(a => a.Books).SingleOrDefault(a => a.Id == id);
        }
    }
}
