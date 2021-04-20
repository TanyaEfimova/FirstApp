using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
