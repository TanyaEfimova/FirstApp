using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
               new[] {2, 3, 7, 1},
               new[] {45, 17, 88, 0},
               new[] {23, 32, 44, -6},
            };

            var numbers = from sequence in numsList
                          from number in sequence
                          orderby number
                          select number;

            //или так: var numbers = numsList.SelectMany(s => s).OrderBy(s => s);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}








