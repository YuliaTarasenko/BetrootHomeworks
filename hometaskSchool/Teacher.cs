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
        private Subjects subject;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subjects Subject { get; set; }
        public int Id { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Class> Classes { get; set; }

        public Teacher(string firstName,string lastName, Subjects subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public void AddLesson (Lesson lesson) 
        { 
            Lessons.Add(lesson);
        }    
        
        public void AddClass (Class c) 
        {
            Classes.Add(c);
        }

        public void PrintInfo ()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Teacher {firstName} {lastName},");
            sb.Append($"who teaches {subject},");
            sb.Append($"will be in class  at the lesson");
        }
    }
}
