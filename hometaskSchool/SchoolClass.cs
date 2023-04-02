using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskSchool
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public int GradeLevel { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Lesson> Lessons { get; set; }
        //public Subjects Subjects { get; set; }
        public SchoolClass() 
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Lessons = new List<Lesson>();
        }


        public void AddStudentByAge(Student student, int age)
        {
            if (student.Age == age)
            {
                Students.Add(student);
            }
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
        }

        public void AddLesson (Lesson lesson)
        {
            Lessons.Add(lesson);
        }

        public void RemoveLesson (Lesson lesson)
        {
            Lessons.Remove(lesson);
        }
    }
}
