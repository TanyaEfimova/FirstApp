using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                throw new RankException();
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
