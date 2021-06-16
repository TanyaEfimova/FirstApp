using System;

namespace FirstApp
{
    [Serializable]
    class Contact
    {
        public Contact() // метод-конструктор
        {
            Name = "";
            LastName = "";
            PhoneNumber = 0;
            Email = "";
        }
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; set; }
        public String LastName { get; }
        public long PhoneNumber { get; set; }
        public String Email { get; }
    }
}
