using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
            phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

            var contact = new Contact("John", 79990000002, "john@example.com");

            AddUnique(contact, phoneBook);
        }

        static void AddUnique(Contact contact, List<Contact> phoneBook)
        {
            if (phoneBook.IndexOf(contact) < 0)
            {
                phoneBook.Add(contact);
            }

            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Name + ": " + item.PhoneNumber);
            }
        }
    }
}


