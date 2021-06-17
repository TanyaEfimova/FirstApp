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

            var depsWithEmployees = departments.GroupJoin(
                                    employees, // первый набор данных
                                    d => d.Id, // общее свойство второго набора
                                    e => e.DepartmentId, // общее свойство первого набора
                                    (d, emps) => new  // результат выборки
                                    {
                                        Name = d.Name,
                                        Employees = emps.Select(e => e.Name)
                                    });

            // Пробегаемся по каждому отделу
            foreach (var dep in depsWithEmployees)
            {
                Console.WriteLine(dep.Name + ":");

                // Выводим сотрудников
                foreach (string emp in dep.Employees)
                    Console.WriteLine(emp);

                Console.WriteLine();
            }
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


