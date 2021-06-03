using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May"
            };

            var missing = new ArrayList()
            {
                 1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            Method(months, missing);
        }

        static void Method(List<string> col1, ArrayList col2)
        {
            // инициализируем массив для 7 нужных нам недостающих элементов
            var newColl = new string[7];

            // извлекаем эти элементы из ArrayList, и копируем в массив
            col2.GetRange(4, 7).CopyTo(newColl);

            // Добавляем наш массив в конец списка
            col1.AddRange(newColl);

            foreach (var item in col1)
            {
                Console.WriteLine(item);
            }
        }
    }
}


