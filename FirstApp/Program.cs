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
               new Contact() { Name = "Андрей", PhoneNumber = 79994500508 },
               new Contact() { Name = "Сергей", PhoneNumber = 799990455 },
               new Contact() { Name = "Иван", PhoneNumber = 79999675334 },
               new Contact() { Name = "Игорь", PhoneNumber = 8884994 },
               new Contact() { Name = "Анна", PhoneNumber = 665565656 },
               new Contact() { Name = "Василий", PhoneNumber = 3434 }
            };

            //I способ
            var youngContactsAmount = contacts.Count(s => s.PhoneNumber.ToString().Length != 11 || !s.PhoneNumber.ToString().StartsWith("7"));
            Console.WriteLine(youngContactsAmount);

            //II способ
            var invalidContacts = (from contact in contacts // пробегаемся по контактам
                                   let phoneString = contact.PhoneNumber.ToString() // сохраняем в промежуточную переменную строку номера телефона
                                   where !phoneString.StartsWith('7') || phoneString.Length != 11 // выполняем выборку по условиям
                                   select contact) // добавляем объект в выборку
                                .Count(); // считаем количество объектов в выборке
            Console.WriteLine(invalidContacts);
        }
    }
}


