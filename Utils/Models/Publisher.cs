using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class Publisher
    {
        public Publisher()
        {
            Authors = new List<Author>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }

        public List<Author> Authors { get; set; }
    }
}
