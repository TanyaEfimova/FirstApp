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
		// Конструктор 1
		public Human()
		{
			name = "Неизвестно";
			age = 20;
		}
		// Конструктор 2
		public Human(string n)
		{
			name = n;
			age = 20;
		}
		// Конструктор 3
		public Human(string n, int a)
		{
			name = n;
			age = a;
        }
	}
}
