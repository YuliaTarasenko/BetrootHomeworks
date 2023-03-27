namespace hometaskSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class firstClass = new Class(1);
            Student student1 = new Student("Dohn", "Jou",firstClass);
            Teacher teacher1 = new Teacher("Kile", "Johns", Subjects.Sport);
            Lesson lesson1 = new Lesson("Lesson 1");
            teacher1.AddLesson(lesson1);
            teacher1.AddClass(firstClass);
            teacher1.PrintInfo();
            //firstClass.AddStudent(student1);

        }
    }
}