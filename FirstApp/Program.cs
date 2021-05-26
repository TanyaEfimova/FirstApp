using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            var greeetings = "Привет, " + name;
            Console.WriteLine(greeetings);
        }
    }
}

   
