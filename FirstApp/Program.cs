using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подготовим данные
            List<Student> students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            // выборка имен в строки
            var names = students.Select(u => u.Name);

            // проекция в анонимный тип
            var applications = students.Select(u => new
            {
                FirstName = u.Name,
                YearOfBirth = DateTime.Now.Year - u.Age
            });

            // проекция в другой тип
            //var applications1 = students.Select(u => new Application()
            //{
            //    FirstName = u.Name,
            //    YearOfBirth = DateTime.Now.Year - u.Age
            //});


            // Выведем результат
            foreach (var application in applications)
                Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }
}








