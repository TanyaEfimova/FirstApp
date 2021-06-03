using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив строк
            string[] names =  {
               "Игорь",   // повторяющееся значение
               "Андрей",
               "Василий",
               "София",
               "Елена",
               "Анна",
               "Игорь"  //  повторяющееся значение
           };

            // Выведем длину массива в консоль
            Console.WriteLine("Длина массива " + names.Length);
            Console.WriteLine();
            Console.WriteLine("Данные в массиве");
            foreach (var n in names)
                Console.WriteLine(n);
            Console.WriteLine();

            // Создаем хэш-сет, передавая в конструктор наш массив
            HashSet<string> hSet = new HashSet<string>(names);

            // Посчитаем объекты в массиве
            Console.WriteLine("Длина хэш-сета " + hSet.Count);
            Console.WriteLine();
            // Выведем все элементы в консоль и посмотрим, есть ли дубликаты
            Console.WriteLine("Элементы в хэшсете:");
            foreach (var n in hSet)
                Console.WriteLine(n);
        }
    }
}


