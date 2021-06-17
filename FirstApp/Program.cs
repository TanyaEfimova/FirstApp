using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //________________________________без Array()__________________________________
            //  Подготовим тестовые данные
            var names1 = new List<string>() { "Вася", "Вова", "Петя", "Андрей" };

            // Подготовим тестовую выборку (без ToArray())
            var experiment1 = names1.Where(name => name.StartsWith("В"));

            // уберем несколько элементов уже после выборки (если она выполняется отложено, то они в неё не попадут)
            names1.Remove("Вася");
            names1.Remove("Вова");

            Console.WriteLine("без Array():");
            // обратимся к выборке в цикле foreach
            foreach (var word in experiment1)
                Console.WriteLine(word);

            Console.WriteLine();

            //___________________________________с Array()______________________________________
            //  Снова возьмем те же тестовые данные
            var names2 = new List<string>() { "Вася", "Вова", "Петя", "Андрей" };

            // Теперь добавим ToArray() в конце того же самого LINQ-запроса
            var experiment2 = names2.Where(name => name.StartsWith("В")).ToArray();

            // Также уберем несколько элементов
            names2.Remove("Вася");
            names2.Remove("Вова");

            Console.WriteLine("c Array():");
            // обратимся к выборку в цикле foreach
            foreach (var word in experiment2)
                Console.WriteLine(word);
        }
    }
}


