using System;

namespace FirstApp
{
    class Program
    {
        public delegate int DiffDelegate(int a, int b);
        static void Main(string[] args)
        {
            DiffDelegate deleg = IntExtensions.GetDifference;
            Console.WriteLine(deleg.Invoke(30, 21));
            Console.WriteLine(deleg(30, 21));
            Console.ReadKey();
        }
    }
}
