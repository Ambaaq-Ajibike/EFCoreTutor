using System;
namespace EfCoreTuto
{
    class Program
    {
           public static void Main(string[] args)
        {
            ApplicationContext context = new();
             AuthorRepository authorRepository = new AuthorRepository(context);
            // authorRepository.CreateAuthor();
            BookRepository bookRepository = new BookRepository(context, authorRepository);
            bookRepository.Create();
            
        }
    }
}