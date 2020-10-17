using RepositoryUnitOfWork.Core;
using RepositoryUnitOfWork.Core.Repositories;
using RepositoryUnitOfWork.Persistence.Repositories;
using System;

namespace RepositoryUnitOfWork.Persistence
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly AppContext _context;

        public IAuthorRepository AuthorRepository { get; private set; }

        public IBookRepository BookRepository { get; private set; }

        private bool _disposed = false;

        public UnitOfWork()
        {
            _context = new AppContext();
            AuthorRepository = new AuthorRepository(_context);
            BookRepository = new BookRepository(_context);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    _context?.Dispose();
                }
            }

            _disposed = true;    
        }

        ~UnitOfWork() => Dispose(false);
    }
}
