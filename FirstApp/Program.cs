﻿using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            byte age= checked((byte)int.Parse(Console.ReadLine()));
            int intage = age;
            Console.WriteLine("Your name is {0} and age is {1} ", name, intage);

            Console.ReadKey();
        }
    }
}
