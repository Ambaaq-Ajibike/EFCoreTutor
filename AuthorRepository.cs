using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace EfCoreTuto
{
    public class AuthorRepository
    {
         private readonly ApplicationContext _context;
        public AuthorRepository(ApplicationContext context)
        {
            _context = context;
        }
        public bool CreateAuthor()
        {
            System.Console.WriteLine("Enter the Author name");
            string name = Console.ReadLine();
            var author = new Author()
            {
                Name = name
            };
            _context.Authors.Add(author);
            _context.SaveChanges();
            return true;
        }
        public List<Author> GetSelectedAuthor(List<int> ids)
        {
            var authors = _context.Authors.Where(e => ids.Contains(e.Id)).ToList();
            return authors;
        }
    }
}