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
        private int age;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Class Class { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Lesson> Lessons { get; set; }
        


        public Student(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}
