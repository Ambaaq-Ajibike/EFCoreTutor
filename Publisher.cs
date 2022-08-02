using System.Collections.Generic;
using System.Collections;
using System;
namespace EfCoreTuto
{
    public class Publisher
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Address{get; set;}
        public virtual List<Book> books{get; set;} = new List<Book>();
    }
}