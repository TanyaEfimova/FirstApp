using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
               new Student {Name="Андрей", Age=23 },
               new Student {Name="Сергей", Age=27 },
               new Student {Name="Дмитрий", Age=29 }
            };

            var youngStudents = from s in students where s.Age < 25 select s;

            // Добавим нового студента уже после инициализанции LINQ-запроса
            students.Add(new Student { Name = "Анна", Age = 21 });

            foreach (var stud in youngStudents)
                Console.WriteLine(stud.Name);
        }
    }


}


