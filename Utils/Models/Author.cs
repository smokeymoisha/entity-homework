using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int AuthorId { get; set; }

        public string Name { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<Book> Books { get; set; }
    }
}
