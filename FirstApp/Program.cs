using System;

namespace FirstApp
{
    class Program
    {
		static void Main(string[] args)
		{
			(string name, int age) anketa;

			Console.Write("Введите имя: ");
			anketa.name = Console.ReadLine();
			Console.Write("Введите возраст с цифрами: ");
			anketa.age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ваше имя: {0}", anketa.name);
			Console.WriteLine("Ваш возраст: {0}", anketa.age);

			Console.ReadKey();
		}
	}
    
}

