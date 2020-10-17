using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepositoryUnitOfWork.Core.Domain
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
