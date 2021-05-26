using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            var count = Convert.ToInt32(Console.ReadLine());
            var array = new string[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Все элементы записаны");
        }
    }
}

   
