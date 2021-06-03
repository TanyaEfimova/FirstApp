using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = new List<String>()
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep"
            };

            months.Add("Oct");
            months.AddRange(new[] { "Nov", "Dec" });
            Console.WriteLine(months.Count);

            months.Sort();
            int result = months.BinarySearch("Jul");
            Console.WriteLine(result);

            int index = months.IndexOf("Feb");
            Console.WriteLine(result);

            months.Insert(0, "example");
            Console.WriteLine(months.Count);

            var removeResult = months.Remove("Feb");
            Console.WriteLine(months.Count);

            months.RemoveAt(1);
            Console.WriteLine(months.Count);

            foreach (var item in months)
            {
                Console.WriteLine(item);
            }
        }
    }
}


