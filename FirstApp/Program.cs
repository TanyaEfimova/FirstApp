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

            // здесь запрос будет выполнен немедленно, и в переменную будет сохранено количество элементов выборки
            var youngStudents = (from s in students where s.Age < 25 select s).Count();

            // Добавим нового студента уже после инициализанции LINQ-запроса
            students.Add(new Student { Name = "Анна", Age = 21 });

                Console.WriteLine(youngStudents);

            var youngStudents2 = students
                               .Where(s => s.Age < 25) // на этом этапе происходит генерация LINQ-выражения
                               .ToList(); // А вот тут уже будет выполнение

        }
    }


}


