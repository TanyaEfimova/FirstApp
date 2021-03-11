using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age= checked((byte)int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            var howItall = 166;
            var myshoe = 37.5;

            Console.WriteLine("What is my grouth? {0} sm", howItall);
            Console.WriteLine("What is my shoe size? {0}", myshoe);

            Console.ReadKey();
        }
    }
}

