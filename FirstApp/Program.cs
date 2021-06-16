using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список студентов
            var students = new List<Student>
            {
               new Student {Name="Андрей", Age=23 },
               new Student {Name="Сергей", Age=27 },
               new Student {Name="Дмитрий", Age=29 }
            };

            // получим тех кто младше 25
            var youngStudentsAmount1 =
               (from student in students
                where student.Age < 25
                select student).Count();

            // выведет 1
            Console.WriteLine(youngStudentsAmount1);

            // получим тех, кто младше 25
            var youngStudentsAmount2 = students.Count(s => s.Age < 25);

            // тоже выведет 1
            Console.WriteLine(youngStudentsAmount2);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }
}








