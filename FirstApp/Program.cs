using System;
using System.Collections;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var months = new[]
            {
                "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
           };

            var numbers = new[]
            {
                1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
           };

            // Объявим ArrayList с элементами разных типов
            var arrayList = new ArrayList();

            arrayList.AddRange(months);

            arrayList.Sort();

            arrayList.AddRange(numbers);

            foreach (var el in arrayList)
            {
                Console.WriteLine(el);
            }

            arrayList.Clear();
            Console.WriteLine("----------------------------------------------------------");

            arrayList.Add(2);
            arrayList.Add("lol");
            arrayList.Add(new Contact("Павел", 799900000000, "pavel@example.com"));

            var cont = arrayList.Contains(2);
            Console.WriteLine(cont);
            Console.WriteLine("----------------------------------------------------------");

            arrayList.SetRange(1, new string[] { "smart" });

            foreach (var elem in arrayList)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("----------------------------------------------------------");

            var list = new ArrayList()
            {
                "Снежный человек",
                "Чупакабра",
                2
            };

            var creatures = list.GetRange(0, 2);

            foreach (var VARIABLE in creatures)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine(creatures.IndexOf("Чупакабра"));
            Console.WriteLine("----------------------------------------------------------");

            list.Insert(1, "Обезьяна");

            list.Reverse();

            list.Remove(2);
            list.RemoveAt(2);
            list.RemoveRange(1, 1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------------");

            var arlist = new ArrayList()
            {
               1,
               "Андрей",
               300,
               4.5f
            };

            // Получим первый элемент по индексу
            int firstElement = (int)arlist[0];
            Console.WriteLine(firstElement);

            string secondElement = (string)arlist[1];
            Console.WriteLine(secondElement);
            /* int secondElement = (int) arlist[1]; Ошибка (пытаемся привести строку к числу) */

            // используем ключевое слово var, чтобы не приводить к типу
            var firstElementVar = arlist[0]; // получим запакованный объект
            var secondElementVar = arlist[1];
            /* var fifthElement = arlist[5]; Error: Index out of range (обращение по несуществующему индексу) */

            // Обновление элементов по индексу
            arlist[0] = "Диана";
            arlist[1] = 100;
        }
    }
}


