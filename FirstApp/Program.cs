using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

            // поищем машины, которые можно считать микроавтобусами
            var microBuses = cars.Intersect(buses);

            foreach (string mb in microBuses)
                Console.WriteLine(mb);
        }
    }
}








