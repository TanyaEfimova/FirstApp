using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список напитков в продаже
            string[] drinks = { "Вода", "Кока-кола", "Лимонад", "Вино" };
            // Алкогольные напитки
            string[] alcohol = { "Вино", "Пиво", "Сидр" };

            // Убираем алкоголь из ассортимента
            var drinksForKids = drinks.Except(alcohol);

            foreach (string drink in drinksForKids)
                Console.WriteLine(drink);
        }
    }
}








