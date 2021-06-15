using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

            var vehicles = cars.Union(buses);

            foreach (string v in vehicles)
                Console.WriteLine(v);
        }
    }
}








