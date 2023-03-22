using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string Name;
        public int Pages;
        public Author Author;
        public int Id { get; set; }
        public Genre Genre { get; set; }
        public Publisher Publisher { get; set; }     
        
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Pages);
            Console.WriteLine(Author.Name);
            Console.WriteLine(Genre.Name);
            Console.WriteLine(Publisher.Name);
        }
    }
}
