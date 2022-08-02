using System;
namespace EfCoreTuto
{
    public class BookAuthor
    {
        public int Id{get; set;}
        public int Bookid{get; set;}
        public int AuthorId{get; set;}
        public Book Book{get; set;}
        public Author Author{get; set;}
    }
}