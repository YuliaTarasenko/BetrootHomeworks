using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Publisher
    {
        public string Name;
        public int NumberOfBooks { get; set; }
        public List <Book> Books { get; set; }
        public List <Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
