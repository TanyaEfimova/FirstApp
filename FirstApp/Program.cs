using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запускаем бесконечный цикл
            while (true)
            {
                Console.WriteLine("Введите текст:");

                // Сохраняем предложение в строку
                var sentence = Console.ReadLine();
                // сохраняем в массив char
                var characters = sentence.ToCharArray();

                var symbols = new HashSet<char>();

                // добавляем во множество. Сохраняются только неповторяющиеся символы
                foreach (var symbol in characters)
                    symbols.Add(symbol);

                // Выводим результат
                Console.WriteLine($"Всего {symbols.Count} уникальных символов");

                // сохраняем знаки препинания в массив Char
                var signs = new[] { ',', ' ', '.' };

                // сохраняем числовые символы в массив Char
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                //  Проверяем, есть ли цифры
                bool containsNumbers = symbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                // Отбрасываем знаки препинания и заново считаем
                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");

                Console.WriteLine();
                Console.WriteLine();
            }

        }

    }

}








