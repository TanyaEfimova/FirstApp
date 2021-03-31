using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            // Setter
            user.Age = 23;

            // Getter
            Console.WriteLine(user.Age);

        }

    }
}

