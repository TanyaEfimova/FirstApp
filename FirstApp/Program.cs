using System;

namespace FirstApp
{
    class Program
    {
        public delegate int DiffDelegate(int a, int b);
        static void Main(string[] args)
        {
            DiffDelegate deleg = IntExtensions.GetDifference;
            deleg += IntExtensions.GetSum;

            Console.WriteLine("До удаления второго метода:");
            deleg.Invoke(30, 21);

            deleg -= IntExtensions.GetSum;

            Console.WriteLine("После удаления второго метода:");
            deleg.Invoke(30, 21);
            Console.ReadKey();
        }
    }
}
