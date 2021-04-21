using System;

namespace FirstApp
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string _row);
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };

            showMessageDelegate.Invoke("Hello World!");

            Func<int, int, int, int> sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);

            RandomNumberDelegate randomNumberDelegate = delegate
            {
                return new Random().Next(0, 100);
            };

            int reslt = randomNumberDelegate.Invoke();
            Console.WriteLine(reslt);

            Console.ReadKey();
        }
        static int RandomNumber()
        {
            return new Random().Next(0, 100);
        }
        static void ShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
    }
}
