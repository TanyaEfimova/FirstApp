using System;

namespace FirstApp
{
    class Program
    {
		static void Main(string[] args)
		{
			var anketa = (name: "Jane", age: 27);

			Console.WriteLine("Ваше имя: {0}", anketa.name);
			Console.WriteLine("Ваш возраст: {0}", anketa.age);
		}
	}
    
}

