using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Func<int, int, int> Addition = AddNumbers;
            int result = Addition(10, 20);
            Console.WriteLine(result);

            Action<string> action = new Action<string>(Display);
            action("Привет разработчик!");

            Predicate<string> CheckIfApple = IsApple;
            bool res = CheckIfApple("IPhone X");
            if (res) Console.WriteLine("Это IPhone X");

            Console.ReadKey();
        }

        private static int AddNumbers(int param1, int param2)
        {
            return param1 + param2;
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }

        private static bool IsApple(string modelName)
        {
            if (modelName == "IPhone X") return true;
            else return false;
        }
    }
}
