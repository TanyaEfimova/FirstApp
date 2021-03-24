using System;

namespace FirstApp
{
    class Program
    {
		static void Main(string[] args)
		{
            (string Name, string[] Dishes) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

                User.Dishes = new string[5];
                
                for (int i = 0; i < User.Dishes.Length; i++)
                {
                Console.WriteLine("Введите любимое блюдо");
                User.Dishes[i] = Console.ReadLine();
                }
            
        }
	}
    
}

