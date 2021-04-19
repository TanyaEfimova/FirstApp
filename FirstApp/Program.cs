using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Exception except = new Exception();

            except.Data.Add("Дата создания исключения:", DateTime.Now);
        }
    }
}
