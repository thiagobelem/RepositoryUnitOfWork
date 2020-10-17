using RepositoryUnitOfWork.Core.Domain;
using System.Data.Entity;

namespace RepositoryUnitOfWork.Persistence
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=AppContext")
        {}

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithRequired(a => a.Author)
                .HasForeignKey(a => a.AuthorId)
                .WillCascadeOnDelete(false);
        }
    }
}
