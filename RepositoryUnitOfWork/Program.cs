using System;
using System.Linq;
using RepositoryUnitOfWork.Persistence;
using RepositoryUnitOfWork.Core.Domain;

namespace RepositoryUnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var uow = new UnitOfWork())
            {
                var authors = uow.AuthorRepository.GetAll();
                Console.WriteLine("List of Authors:\n");
                foreach(var author in authors)
                {
                    Console.WriteLine($"{author.Id} - {author.Name}");
                }

                var author1 = uow.AuthorRepository.GetAuthorWithBooks(1);
                Console.WriteLine($"\nAuthor: {author1.Name} has {author1.Books.Count()} books..\n");
                foreach(var book in author1.Books)
                {
                    Console.WriteLine($"- {book.Title} - {book.Year} - {book.Price:c}");
                }

                Console.ReadKey();

                // add
                Author author2 = new Author() { Name = "Carl Sagan", 
                                                Books = { new Book { Title = "Contact", Year = 1985, Genre = "Sci-fi", Price = 10}, 
                                                          new Book { Title = "Pale Blue Dot", Year = 1994, Genre = "Astronomy", Price = 15}}};
                uow.AuthorRepository.Add(author2);

                //update
                Author author3 = uow.AuthorRepository.GetAll().First();
                author3.Name = "JANE AUSTEN";
                uow.AuthorRepository.Update(author3);

                //remove
                Book book1 = uow.BookRepository.Get(1);
                uow.BookRepository.Remove(book1);

                // Unit of Work save changes 
                uow.Commit();

                Console.ReadKey();
            }
        }
    }
}
