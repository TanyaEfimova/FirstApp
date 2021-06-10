using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var courses = new List<Course>
            {
               new Course {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
               new Course {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };

            // добавим студентов в курсы
            var studentsWithCourses = from student in students
                                      from course in courses
                                      select new { Name = student.Name, CourseName = course.Name };

            // выведем результат
            foreach (var stud in studentsWithCourses)
                Console.WriteLine($"Студент {stud.Name} добавлен в курс {stud.CourseName}");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }

    class Course
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}








