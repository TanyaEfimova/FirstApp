using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Сar>()
            {
               new Сar("Suzuki", "JP"),
               new Сar("Toyota", "JP"),
               new Сar("Opel", "DE"),
               new Сar("Kamaz", "RUS"),
               new Сar("Lada", "RUS"),
               new Сar("Honda", "JP"),
            };

            // Группировка по стране - производителю
            var carsByCountry = from car in cars
                                group car by car.CountryCode; //или так: var carsByCountry = cars.GroupBy(car => car.CountryCode);
                //с использованием проекции для создания объекта нового типа
                var carsByCountry1 = cars
                                   .GroupBy(car => car.CountryCode) // группируем по стране-производителю
                                   .Select(group => new
                                   { //  создаем новую сущность анонимного типа
                                       Name = group.Key,
                                       Amount = group.Count()
                                   });

            // Пробежимся по группам
            foreach (var grouping in carsByCountry)
            {
                Console.WriteLine(grouping.Key + ":");

                // внутри каждой группы пробежимся по элементам
                foreach (var car in grouping)
                    Console.WriteLine(car.Manufacturer);

                Console.WriteLine();
            }
            //__________________________________________________________________________
            // с вложенными запросами, используя ключевое слово into
            var carsByCountry2 = from car in cars
                                 group car by car.CountryCode into grouping // выборка в локальную переменную для вложенного запроса
                                 select new
                                 {
                                     Name = grouping.Key,
                                     Count = grouping.Count(),
                                     Cars = from p in grouping select p //  выполним подзапрос, чтобы заполнить список машин внутри нашего нового типа
                                 };  /* или так: var carsByCountry2 = cars
                                                                       .GroupBy(car => car.CountryCode)
                                                                       .Select(g => new
                                                                       {
                                                                           Name = g.Key,
                                                                           Count = g.Count(),
                                                                           Cars = g.Select(c =>c)
                                                                       });
                                     */

            // Выведем результат
            foreach (var group in carsByCountry2)
            {
                // Название группы и количество элементов
                Console.WriteLine($"{group.Name} : {group.Count} авто");

                foreach (Сar car in group.Cars)
                    Console.WriteLine(car.Manufacturer);

                Console.WriteLine();
            }
        }
    }
}


