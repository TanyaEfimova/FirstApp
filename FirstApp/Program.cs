using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
                1,
                "Сергей ",
                "Андрей ",
                300,
            };

            var selectedobj = from p in objects where p is string orderby p select p;

            foreach (var item in selectedobj)
            {
                Console.WriteLine(item);
            }

            foreach (var selectedobj2 in objects.Where(p => p is string).OrderBy(p => p))
            {
                Console.WriteLine(selectedobj2);
            }
        }
    }
}








