using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Татьяна";
            Console.WriteLine("Привет, Мир");
            Console.WriteLine();
            Console.WriteLine("Меня зовут {0}", MyName);
            //0 — позиция нашей переменной. То есть переменная будет на позиции 0.

            //Также мы можем вставить в строку не переменную, а строковый литерал:
            Console.WriteLine("Меня зовут {0}", "Танюшка");

            //И, естественно, мы можем использовать несколько переменных при выводе. В этом случае располагаем их в порядке нумерации «мест».
            var age = 42;
            var weight = 70;
            Console.WriteLine("Возраст {0} \n Вес {1}", age, weight);
            Console.ReadKey();
        }
    }
}
