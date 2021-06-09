using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            var selectedPeople = (from p in people
                                  where p.ToUpper().StartsWith("А")
                                  orderby p
                                  select p).Count();

            Console.WriteLine($"В выборке {selectedPeople} чел");
        }
    }
}








