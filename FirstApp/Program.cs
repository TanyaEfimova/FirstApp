using System;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human = new Human("Дмитрий");
            human.Greetings();

            human = new Human("Дмитрий", 23);
            human.Greetings();

            Console.ReadKey();
        }
    }
}

