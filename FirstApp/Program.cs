using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            Console.WriteLine("Value : {0} Increment: {1}", counter, ++counter);
            Console.WriteLine("Value : {0} Increment: {1}", counter, counter++);

            Console.WriteLine("Value : {0} Decrement: {1}", counter, ++counter);
            Console.WriteLine("Value : {0} Decrement: {1}", counter, counter++);

            Console.ReadKey();
        }
    }
}
