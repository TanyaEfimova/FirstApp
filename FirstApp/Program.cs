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

            var names = from s in students select s.Name;

            // Выведем результат
            foreach (var name in names)
                Console.WriteLine(name);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }
}








