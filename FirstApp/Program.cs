using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));
            phoneBook.Add(new Contact("Андрей", 7999000000532, "andrey@yandex.ru"));

            // Группировка по email
            var contactsByEmail = from contact in phoneBook
                                  group contact by contact.Email.Split("@").Last().Contains("example");

            // Пробежимся по группам
            foreach (var grouping in contactsByEmail)
            {
                if (grouping.Key)
                {
                    Console.WriteLine("Фейковые:");

                    // внутри каждой группы пробежимся по элементам
                    foreach (var contact in grouping)
                        Console.WriteLine(contact.Name + " " + contact.Email);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Реальные:");

                    // внутри каждой группы пробежимся по элементам
                    foreach (var contact in grouping)
                        Console.WriteLine(contact.Name + " " + contact.Email);
                    Console.WriteLine();
                }
            }
        }
    }
}


