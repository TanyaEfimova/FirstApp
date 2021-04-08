namespace FirstApp
{
    static class StringExtensions
    {
        public static char GetLastChar(this string source)
        {
            return source[source.Length - 1];
        }
    }
}
