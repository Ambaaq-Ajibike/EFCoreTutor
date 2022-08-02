using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace EfCoreTuto
{
    public class PublisherRepository
    {
        private readonly ApplicationContext context;
        public PublisherRepository(ApplicationContext Context)
        {
            context = Context;
        }
        public void CreatePublisher()
        {
            System.Console.WriteLine("Enter the publishers name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the publishers Address ");
            string address = Console.ReadLine();
            System.Console.WriteLine("Enter the publishers id ");
            var publisher = new Publisher()
            {
                Name = name,
                Address = address,
            };
            context.Publishers.Add(publisher);
            context.SaveChanges();
        }
        public void PrintPublisher()
        {
            var publisher = context.Publishers.Select(x => new Publisher
            {
                Id = x.Id,
                Name = x.Name,
                books = x.books
            });
            foreach(var item in publisher)
            {
                System.Console.WriteLine(item.Name);
                System.Console.WriteLine("==============");
                foreach (var b in item.books)
                {
                    System.Console.WriteLine($"{b.Name}\t");
                }
            }
        }
    }
}