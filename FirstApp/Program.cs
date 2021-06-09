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

            var selectedPeople = people.Where(p => p.StartsWith("А")).OrderBy(p => p);

            foreach (string s in selectedPeople)
                Console.WriteLine(s);
        }
    }
}








