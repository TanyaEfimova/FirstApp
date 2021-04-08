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
    }
}
