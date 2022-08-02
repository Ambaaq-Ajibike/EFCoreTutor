using System;
using Microsoft.EntityFrameworkCore;
namespace EfCoreTuto
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=EFCoreTutorial;port=3306;password=ajibikeabdulqayyumambaaq");
        }
        public DbSet<Book> Book{get; set;}
        public DbSet<Publisher> Publishers{get; set;}
        public DbSet<BookAuthor> BookAuthors{get; set;}
        public DbSet<Author> Authors{get; set;}
    }
}