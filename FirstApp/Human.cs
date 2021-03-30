using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class Human
    {
		// Поля класса
		public string name;
		public int age;

		// Метод класса
		public void Greetings()
		{
			Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }
	}
}
