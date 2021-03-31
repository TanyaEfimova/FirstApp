using System;

namespace FirstApp
{
    class User
    {
        private int age;
        private string login;
        private string email;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("логин должен быть не меньше 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (value.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Почтовый адрес не корректный!");
                }
            }
        }
    }
}
