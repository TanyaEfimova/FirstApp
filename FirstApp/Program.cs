using System;
using System.Linq;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var array = Enumerable.Range(1, 4).ToArray();
            Console.WriteLine(BinarySearch(5, array, 0, 3));
        }

        static int BinarySearch(int value, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;

                var midElement = array[middle];

                if (midElement == value)
                {
                    return middle;
                }
                else if (value < midElement)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }

            }
            return -1;

        }
    }
}


