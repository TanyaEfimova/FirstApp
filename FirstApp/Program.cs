using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слово:");
            var word1 = Console.ReadLine();

            Console.WriteLine("Введите второе слово:");
            var word2 = Console.ReadLine();

            var coll = CommonWords(word1, word2);

            Console.WriteLine("Найдены такие общие буквы/символы:");
            foreach (var item in coll)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<char> CommonWords(string word1, string word2)
        {
            var commonColl = word1.Intersect(word2);//   ищем пересечение

            return commonColl;
        }
    }
}








