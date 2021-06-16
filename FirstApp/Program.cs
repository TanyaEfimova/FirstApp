using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Простое сложение:

            var simpleNumbers = new[] { 3, 5, 7 };

            // Вернет 15
            Console.WriteLine(simpleNumbers.Sum());
            //-------------------------------------------------------

            //Сложный тип данных, сложение свойств:

            // Список студентов
            var students = new List<Student>
            {
               new Student {Name="Андрей", Age=23 },
               new Student {Name="Сергей", Age=27 },
               new Student {Name="Дмитрий", Age=29 }
            };

            // сумма возрастов всех студентов
            var totalAge = students.Sum(s => s.Age);

            // Вернет 79
            Console.WriteLine(totalAge);
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }
}


