using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskSchool
{
    public class Student
    {
        private string name;
        private string lastName;
        public string Name { get; set; }
        public string LastName { get; set; }
        public Class Class { get; set; }
        
        public Student(string name, string lastName, Class c)
        {
            Name = name;
            LastName = lastName;
            Class = c;
        }
    }
}
