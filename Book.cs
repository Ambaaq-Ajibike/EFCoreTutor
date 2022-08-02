using System;
using System.Collections.Generic;
using System.Collections;
namespace EfCoreTuto
{
    public class Book
    {
        public int id {get; set;}
        public string Name {get; set;}
        public int NumberOfPages {get; set;}
        public int ISBN {get; set;}
        public string Author {get; set;}
        public int PublisherId{get; set;}
        public Publisher Publisher{get; set;}
        List<BookAuthor> booksauthor{get; set;} = new List<BookAuthor>();

        public Book()
        {

        }
        public Book(string name, int NumberOfpages, int iSBN, string author, int publisherId)
        {
            Name = name;
            NumberOfPages = NumberOfpages;
            ISBN = iSBN;
            Author = author;
            PublisherId = publisherId;
        }
    }
}