using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Exception except = new Exception("Wait please...");

            except.HelpLink = "https://docs.microsoft.com/ru-ru/dotnet/api/system.exception?view=netframework-4.8";
        }
    }
}
