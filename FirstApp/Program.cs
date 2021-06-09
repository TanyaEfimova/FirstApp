using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            List<string> persons = new List<string>();

            foreach (var item in people)
            {
                if (item.ToUpper().StartsWith('А'))
                {
                    persons.Add(item);
                }
            }

            persons.Sort();

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}








