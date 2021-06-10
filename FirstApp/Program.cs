using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три", "четыре пять шесть", "семь восемь девять" };

            var sequence = from str in text from word in str.Split(' ') select word;

            foreach (var word in sequence)
                Console.WriteLine(word);
        }
    }
}








