using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine(Car.MinPrice);

            Console.WriteLine(Car.MaxPrice);

            Console.ReadKey();
        }

    }
}

