using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskSchool
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName; 
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
