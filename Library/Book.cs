using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private string Name;
        private int Pages;
        public string Description { get; set; }
        public List<Author> Author { get; set; }
        public int Id { get; set; }
        public List<Genre> Genre { get; set; }
        public List<Publisher> Publisher { get; set; }     
        
        public Book (string name)
        {
            Name = name;
        }
        public Book (string name, int pages)
        {
            Name = name;
            Pages = pages;
        }
    }
}
