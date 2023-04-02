namespace hometaskSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher("John", "Doe", Subjects.Mathematic);
            Teacher teacher2 = new Teacher("Sam", "Smith", Subjects.Literature);
            Teacher teacher3 = new Teacher("Ola", "Snow", Subjects.English);

            Student student1 = new Student("Sam","Sid", 14);
            Student student2 = new Student("Aleksa", "Bob", 15);
            Student student3 = new Student("Joy", "Green", 13);
            Student student4 = new Student("Max", "Merth", 15);
            Student student5 = new Student("Micle", "Snow", 16);
            Student student6 = new Student("Lina", "Head", 13);

            SchoolClass schoolClass1 = new SchoolClass();
            schoolClass1.GradeLevel = 9;
            schoolClass1.AddStudentByAge(student6, 13);
            schoolClass1.AddStudentByAge(student3, 13);
            schoolClass1.AddStudentByAge(student1, 14);
            SchoolClass schoolClass2 = new SchoolClass();
            schoolClass2.GradeLevel = 10;
            schoolClass1.AddStudentByAge(student2, 15);
            schoolClass1.AddStudentByAge(student4, 15);
            schoolClass1.AddStudentByAge(student5, 16);

            Lesson lesson1 = new Lesson
                ("Math", 1, new DateTime(2023, 04, 01, 8, 15,00), schoolClass1, teacher1, Subjects.Mathematic);
            Lesson lesson2 = new Lesson
                ("Literature", 2, new DateTime(2023,04,01,9,30,00), schoolClass2, teacher2, Subjects.Literature);
            Lesson lesson3 = new Lesson
                ("English", 3, new DateTime(2023, 04, 01, 8, 15, 00), schoolClass2, teacher3, Subjects.English);

            schoolClass1.AddLesson(lesson1);
            schoolClass1.AddLesson(lesson3 );
            schoolClass2.AddLesson(lesson2);

            lesson1.MarkAttendance(student1);
            lesson1.MarkAttendance(student3);
        }
    }
}