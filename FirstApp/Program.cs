using System;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var sorted = from word in words
                         orderby word.Length
                         select new
                         {
                             Name = word,
                             Size = word.Length
                         };
            foreach (var item in sorted)
            {
                Console.WriteLine("Животное:{0}, длина слова:{1}", item.Name, item.Size);
            }

            //---------------------------------------------------------
            //с помощью методов расширения:
            var wordsInfo = words.Select(w =>
              new
              {  // Выборка в анонимный тип
                  Name = w,
                  Length = w.Length // Длину слова сохраняем сразу в свойство нового анонимного типа
              })
               .OrderBy(word => word.Length); //  сортируем коллекцию по длине


            // выводим
            foreach (var word in wordsInfo)
                Console.WriteLine($"{word.Name} - {word.Length} букв");

            //---------------------------------------------------------
        }
    }
}








