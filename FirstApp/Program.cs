using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", PhoneNumber = 7999945005 },
               new Contact() { Name = "Сергей", PhoneNumber = 799990455 },
               new Contact() { Name = "Иван", PhoneNumber = 79999675 },
               new Contact() { Name = "Игорь", PhoneNumber = 8884994 },
               new Contact() { Name = "Анна", PhoneNumber = 665565656 },
               new Contact() { Name = "Василий", PhoneNumber = 3434 }
            };

            // бесконечный цикл, ожидающий ввод с консоли
            while (true)
            {
                var keyChar = Console.ReadKey().KeyChar; // получаем символ с консоли
                Console.Clear();  //  очистка консоли от введенного текста

                if (!Char.IsDigit(keyChar))
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
                else
                {
                    IEnumerable<Contact> page = null;

                    switch (keyChar)
                    {
                        case '1':
                            page = contacts.Take(2);
                            break;
                        case '2':
                            page = contacts.Skip(2).Take(2);
                            break;
                        case '3':
                            page = contacts.Skip(4);
                            break;
                    }

                    //   проверим, что ввели существующий номер страницы
                    if (page == null)
                    {
                        Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
                        continue;
                    }

                    // вывод результата на консоль
                    foreach (var contact in page)
                        Console.WriteLine(contact.Name + " " + contact.PhoneNumber);
                }
            }
        }
    }
}








