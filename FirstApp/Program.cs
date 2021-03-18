using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
            int minValue = 100000,
            minIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Наименьший элемент массива имеет индекс {0}, значение этого элемента = {1}", minIndex, numbers[minIndex]);

            Console.ReadKey();
        }
	}
    
}

