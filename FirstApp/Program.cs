using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сохраняем предложение в строку
            var str ="Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            // сохраняем в массив char
            var chars = str.ToCharArray();

            var symbols = new HashSet<char>();

            foreach (var symbol in chars)
                symbols.Add(symbol);

            Console.WriteLine(symbols.Count);
        }
    }
}








