using DataAccess;
using Utils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BooksManager
    {
        public void AddBook(Book book)
        {
            using(var context = new BooksContext())
            {
                context.Books.Add(book);

                context.SaveChanges();
            }         
        }

        public void AddAuthor(Author author)
        {
            using (var context = new BooksContext())
            {
                context.Authors.Add(author);

                context.SaveChanges();
            }
        }

        public void AddPublisher(Publisher publisher)
        {
            using (var context = new BooksContext())
            {
                context.Publishers.Add(publisher);

                context.SaveChanges();
            }
        }

        public void RemoveBookById(int id)
        {
            using (var context = new BooksContext())
            {
                Book removedBook = context.Books.FirstOrDefault(book => book.BookId == id);

                context.Books.Remove(removedBook);

                context.SaveChanges();
            }       
        }

        public void RemoveAuthorById(int id)
        {
            using (var context = new BooksContext())
            {
                Author removedAuthor = context.Authors.FirstOrDefault(author => author.AuthorId == id);

                context.Authors.Remove(removedAuthor);

                context.SaveChanges();
            }
        }

        public void RemovePublisherById(int id)
        {
            using (var context = new BooksContext())
            {
                Publisher removedPublisher = context.Publishers.FirstOrDefault(pub => pub.PublisherId == id);

                context.Publishers.Remove(removedPublisher);

                context.SaveChanges();
            }
        }
    }
}
