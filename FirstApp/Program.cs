using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            Int32.TryParse(Console.ReadLine(), out int number);
            long result = Factorial(number);
            Console.WriteLine("Факториал этого числа равен: {0}", result);
        }

        static long Factorial(int number)
        {
            // Коллекция для хранения чисел
            var numbers = new List<int>();

            // Добавляем все числа от 1 до n в коллекцию
            for (int i = 1; i <= number; i++)
                numbers.Add(i);

            // Выполняем агрегацию
            return numbers.Aggregate((x, y) => x * y);
        }
    }
}








