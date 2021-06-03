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
            Console.WriteLine();

            hSet.UnionWith(new[] { "Дмитрий", "Сергей", "Игорь" });

            Console.WriteLine("Элементы после объединения с новой коллекцией:");

            foreach (var n in hSet)
                Console.WriteLine(n);

            Console.WriteLine();

            hSet.SymmetricExceptWith(new[] { "Дмитрий", "Сергей", "Игорь" });

            Console.WriteLine("Элементы после объединения с новой коллекцией:");

            foreach (var n in hSet)
                Console.WriteLine(n);

            Console.WriteLine();

            // Создадим два множества
            SortedSet<char> lettersOne = new SortedSet<char>();
            SortedSet<char> lettersTwo = new SortedSet<char>();

            //  Добавим элементы в первую
            lettersOne.Add('A');
            lettersOne.Add('B');
            lettersOne.Add('C');
            lettersOne.Add('Z');

            // выведем
            PrintCollection(lettersOne, "Первая коллекция: ");

            // Добавим элементы во вторую
            lettersTwo.Add('X');
            lettersTwo.Add('Y');
            lettersTwo.Add('Z');

            // выведем
            PrintCollection(lettersTwo, "Вторая коллекция");

            //  Выполним вычитание множеств
            lettersOne.ExceptWith(lettersTwo);

            // Выведем результат
            PrintCollection(lettersOne, "Результат вычитания");
        }

        static void PrintCollection(SortedSet<char> ss, string s)
        {
            Console.WriteLine(s);
            foreach (char ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
    }
}



