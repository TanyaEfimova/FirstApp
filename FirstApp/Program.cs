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

            var middle = (left + right) / 2;

            var midElement = array[middle];

            if (midElement == value)
            {
                return middle;
            }
            else if (left < right)
            {
                if (value < midElement)
                {
                    return BinarySearch(value, array, left, middle - 1);
                }
                else
                {
                    return BinarySearch(value, array, middle + 1, right);
                }
            }
            else
            {
                return -1;
            }
        }
    }
}


