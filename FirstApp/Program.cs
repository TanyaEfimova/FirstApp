using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Dеpartment>()
            {
               new Dеpartment() {Id = 1, Name = "Программирование"},
               new Dеpartment() {Id = 2, Name = "Продажи"},
               new Dеpartment() {Id = 3, Name = "Бухгалтерия"}
            };

            var employees = new List<Еmployee>()
            {
               new Еmployee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Еmployee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Еmployee() { DepartmentId = 2, Name = "Виктор", Id = 3},
               new Еmployee() { DepartmentId = 3, Name = "Альберт", Id = 4},
            };

            var result = from employee in employees
                         join department in departments on employee.DepartmentId equals department.Id
                         select new
                         {
                             Employee = employee.Name,
                             Department = department.Name
                         };

            // выведем результаты
            foreach (var item in result)
                Console.WriteLine($"{item.Employee} работает в отделе {item.Department}");
        }
    }

    public class Dеpartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Еmployee
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}


