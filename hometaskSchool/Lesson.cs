using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskSchool
{
    public class Lesson
    {
        private string name;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public SchoolClass SchoolClass { get; set; }
        public Teacher Teacher { get; set; }
        public Subjects Subjects { get; set; }
        public List<Student> AttendedStudents { get; set; }

        public Lesson(string name, int id, DateTime date, SchoolClass schoolClass, Teacher teacher, Subjects subjects)
        {
            this.name = name;
            Id = id;
            Date = date;
            SchoolClass = schoolClass;
            Teacher = teacher;
            Subjects = subjects;
            AttendedStudents = new List<Student>();
        }

        public void MarkAttendance(Student student)
        {
            AttendedStudents.Add(student);
        }
    }
}
