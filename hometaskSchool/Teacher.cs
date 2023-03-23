using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskSchool
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        private Subject subject;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject Subject { get; set; }
        public int Id { get; set; }
        public List<Student> Students { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Class> Classes { get; set; }

        public Teacher(string firstName,string lastName, Subject subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
    }
}
