using System;

namespace FirstApp
{
    class Program
    {
        public delegate int DiffDelegate(int a, int b);
        static void Main(string[] args)
        {
            DiffDelegate deleg1 = IntExtensions.GetDifference;
            deleg1 += IntExtensions.GetSum;
            Console.WriteLine("Методы первого делегата:");
            deleg1.Invoke(30, 21);

            DiffDelegate deleg2 = IntExtensions.GetSum;
            Console.WriteLine("Методы второго делегата:");
            deleg2.Invoke(30, 21);

            DiffDelegate deleg3 = deleg1 + deleg2;
            Console.WriteLine("Методы третьего делегата:");
            deleg3.Invoke(30, 21);

            Console.ReadKey();
        }
    }
}
