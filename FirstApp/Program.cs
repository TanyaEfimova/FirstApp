using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        public static List<int> listNumbers = new List<int>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите целое число:");
                bool res = Int32.TryParse(Console.ReadLine(), out int number);

                if (!res)
                {
                    Console.WriteLine("Это не число!");
                }

                else
                {
                    listNumbers.Add(number);
                    Console.WriteLine("Количество чисел в списке: {0}", listNumbers.Count());
                    Console.WriteLine("Сумма всех чисел списка: {0}", listNumbers.Sum());
                    Console.WriteLine("Наибольшее число списка: {0}", listNumbers.Max());
                    Console.WriteLine("Наименьшее число списка: {0}", listNumbers.Min());
                    Console.WriteLine("Среднее значение чисел списка: {0}", listNumbers.Average());
                }
            }
        }
    }
}


