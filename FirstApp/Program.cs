using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int result = numbers.Aggregate((x, y) => x - y);
            // вычислит 1-2-3-4-5 = -13
            Console.WriteLine(result);

            int sum = numbers.Aggregate((x, y) => x + y);
            Console.WriteLine(sum);
        }
    }
}








