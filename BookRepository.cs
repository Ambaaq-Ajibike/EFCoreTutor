using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using EfCoreTuto;
using Microsoft.EntityFrameworkCore;
namespace EfCoreTuto
{
    public class BookRepository
    {
        private readonly AuthorRepository _authorrepository;
        private readonly ApplicationContext _context;
        public BookRepository(ApplicationContext context, AuthorRepository authorrepository)
        {
            _context = context;
            _authorrepository = authorrepository;
        }
        public List<Author> SelectAuthor()
        {
            var ids = new List<int>();
            while (true)
            {
                System.Console.WriteLine("Enter Author id");
                int id = int.Parse(Console.ReadLine());
                ids.Add(id);
                System.Console.WriteLine("press Y to enter more author id and N to break");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "N")
                {
                    break;
                }                
            }
            return _authorrepository.GetSelectedAuthor(ids);
        }
        public bool Create()
        {
            System.Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the number of pages");
            int NumberOfpages = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the ISBN");
            int iSBN = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter author");
            string _author = Console.ReadLine();
            System.Console.WriteLine("Enter the publisherId");
            int publisherId = int.Parse(Console.ReadLine());
            var authors = SelectAuthor();
            var book = new Book
            {
                Name = name,
                NumberOfPages = NumberOfpages,
                Author = _author,
                PublisherId = publisherId
            };
            foreach (var author in authors)
            {
                var booksauthor = new BookAuthor
                {
                    Bookid = book.id,
                    AuthorId = author.Id,
                    Book = book,
                    Author = author
                };
            }
            _context.Book.Add(book);
            _context.SaveChanges();
            return true;
        }
        public bool CreateBook()
        {
            System.Console.WriteLine("Enter the book name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the book Number Of Pages");
            int numberOfpages = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the book ISBN");
            int ISBN = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Author");
            string author = Console.ReadLine();
            System.Console.WriteLine("Enter publisher id");
            int PublisherId = int.Parse(Console.ReadLine());            
            var book = new Book(name, numberOfpages, ISBN, author, PublisherId);
            _context.Book.Add(book);
            _context.SaveChanges();
            return true;
        }

        public void GetBook()
        {
            System.Console.WriteLine("Enter the book id");
            int Id = int.Parse(Console.ReadLine());        
           // var book = _context.Book.Find(id);
           var book = _context.Book.Where(x => x.id == Id).FirstOrDefault();
            System.Console.WriteLine(book.Name);
        }
        public void UpdateBook()
        {
            System.Console.WriteLine("Enter the book id");
            int Id = int.Parse(Console.ReadLine());
            var b = _context.Book.Find(Id);
            if (b == null)
            {
                System.Console.WriteLine("The book with this id does not exist");
            }
            else
            {
                System.Console.WriteLine("Enter the book name");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter the book Number Of Pages");
                int numberOfpages = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the book ISBN");
                int ISBN = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the Author");
                string author = Console.ReadLine();
                b.Name = name;
                b.NumberOfPages = numberOfpages;
                b.ISBN = ISBN;
                b.Author = author;
                _context.SaveChanges();
                _context.Book.Update(b);
            }
        }
        public bool DeleteBook()
        {
            System.Console.WriteLine("Enter the id of the book you want to delete");
            int id = int.Parse(Console.ReadLine());
            var book = _context.Book.Find(id);
             _context.SaveChanges();
                _context.Book.Remove(book);
                return true;
        }
        public void GetAll()
        {
            var book = _context.Book;//.ToList();
            foreach (var item in book)
            {
                System.Console.WriteLine($"{item.Name}\t{item.Author}");
            }
        }
        public void GetBookByPublisher()
        {
            System.Console.WriteLine("Enter the id of the publisher");
            int id = int.Parse(Console.ReadLine());
            var b = _context.Publishers.Find(id);
            if(b == null)
            {
                System.Console.WriteLine("The publisher with this id is not found");
            }
            else
            {
                var book = _context.Book.Where(x => x.PublisherId == id);
                foreach(var item in book)
                {
                    System.Console.WriteLine($"The publisher name is: {item.Publisher.Name}\nThe book name is: {item.Name}");
                }
            }
        }
    }
}