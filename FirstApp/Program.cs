using System;
using System.Diagnostics;
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

        static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static int GetIndex(int[] array, int element)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > element)
                    return index;
            }

            return index;
        }

        static void CreateMatrix(int n)
        {
            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = i + j;
                }
            }
        }

        static void Estimate(int n)
        {
            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                timer.Restart();

                CreateMatrix(10000);

                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);
            }
        }

    }
}


