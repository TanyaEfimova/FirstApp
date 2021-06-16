using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Простое сложение:

            var simpleNumbers = new[] { 3, 5, 7, 2 };

            double averageNumber = Average(simpleNumbers);

            Console.WriteLine(averageNumber);
        }

        static double Average(int[] numbers)
        {
            double result = numbers.Sum() / (double)numbers.Count();
            return result;
        }
    }
}


