using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine(array[0, 0]);

            Console.ReadKey();
		}
	}
    
}

