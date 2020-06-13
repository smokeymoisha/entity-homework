using BusinessLogic;
using System;
using Utils.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new BooksManager();

            //manager.AddPublisher(new Publisher { Name = "Ranok" });
            //manager.AddPublisher(new Publisher { Name = "Ababagalamaga" });

            //manager.AddAuthor(new Author { Name = "J.K. Rowling", PublisherId = 2 });
            //manager.AddAuthor(new Author { Name = "Jack London", PublisherId = 3 });
            //manager.AddAuthor(new Author { Name = "Charles Bukowski", PublisherId = 3 });

            //manager.AddBook(new Book { Name = "Harry Potter and C#", AuthorId = 2 });
            //manager.AddBook(new Book { Name = "White Fang", AuthorId = 3 });
            //manager.AddBook(new Book { Name = "Women", AuthorId = 4 });

            //manager.RemoveBookById(4);

            Console.ReadKey();
        }
    }
}
