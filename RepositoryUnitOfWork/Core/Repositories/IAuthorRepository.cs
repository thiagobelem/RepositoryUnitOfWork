using RepositoryUnitOfWork.Core.Domain;

namespace RepositoryUnitOfWork.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithBooks(int id);
    }
}
