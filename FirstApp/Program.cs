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

            //инициализаторы
            Human human2 = new Human { name = "Дима", age = 18 };
            human2.Greetings();

            Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
            animal.Info();

            Console.ReadKey();
        }
    }
}

