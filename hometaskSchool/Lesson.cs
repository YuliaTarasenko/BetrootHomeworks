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
        public string Name { get; set; }
        public List<Class> Classes { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Lesson(string name)
        {
            Name = name;
        }

        public void AddClass(Class c)
        {
            Classes.Add(c);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
    }
}
