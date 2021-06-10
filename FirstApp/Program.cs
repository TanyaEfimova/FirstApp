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
               new Student {Name="Алёна", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Яков", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            // Сортировка сначала по имени, а затем - по возрасту
            var sortedStuds = from s in students orderby s.Name, s.Age select s;

            foreach (var stud in sortedStuds)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            Console.WriteLine();

            // Сортировка по убыванию возраста
            var desortedStuds = from s in students orderby s.Age descending select s;

            foreach (var stud in desortedStuds)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            Console.WriteLine();

            // Сортировка по имени и возрасту (возрастание)
            var sortedStudentsAsc = students
               .OrderBy(s => s.Name)
               .ThenBy(s => s.Age);

            foreach (var stud in sortedStudentsAsc)
                Console.WriteLine(stud.Name + ", " + stud.Age);

            Console.WriteLine();

            // Сортировка по имени и возрасту (убывание)
            var sortedStudentsDesc = students
               .OrderByDescending(s => s.Name)
               .ThenByDescending(s => s.Age);

            foreach (var stud in sortedStudentsDesc)
                Console.WriteLine(stud.Name + ", " + stud.Age);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }
}








