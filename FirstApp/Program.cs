using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age;
            bool incorrect= int.TryParse(Console.ReadLine(),out age);
            Console.WriteLine("Your age is {0} ",age);

            Console.ReadKey();
        }
    }
}
