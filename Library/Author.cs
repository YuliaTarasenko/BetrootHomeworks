using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Author
    {
        public string Name;
        public int ID { get; set; }
        public List<Book> Books { get; set; }
        public List<Publisher> Publisher { get; set; }
    }
}
