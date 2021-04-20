using System;

namespace FirstApp
{
    static class IntExtensions
    {
        public static int GetNegative(this int a)
        {
            return a > 0 ? -a : a;
        }

        public static int GetPositive(this int a)
        {
            return a < 0 ? -a : a;
        }

        public static int GetDifference(this int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
            return result;
        }

        public static int GetSum(this int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }
    }
}
