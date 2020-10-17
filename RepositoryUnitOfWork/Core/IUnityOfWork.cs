using RepositoryUnitOfWork.Core.Repositories;
using System;

namespace RepositoryUnitOfWork.Core
{
    public interface IUnityOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }

        int Commit();
    }
}
