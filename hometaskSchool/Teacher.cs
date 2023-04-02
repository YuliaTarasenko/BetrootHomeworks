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
        public List<SchoolClass> Classes { get; set; }

        public Teacher(string firstName, string lastName, Subjects subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
        }
        public Teacher()
        {
            Lessons = new List<Lesson>();
            Classes = new List<SchoolClass>();
        }
        public void AddLesson (Lesson lesson) 
        { 
            Lessons.Add(lesson);
        }    

        public void RemoveLesson(Lesson lesson)
        {
            Lessons.Remove(lesson);
        }
        
        public void AddClass (SchoolClass schoolclass) 
        {
            Classes.Add(schoolclass);
        }
    }
}
