using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {

                    Console.WriteLine("Введено некорректное значение");
                }
            }


            Console.Read();
        }

        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Введено значение 1");
                    break;
                case 2:
                    Console.WriteLine("Введено значение 2");
                    break;
            }
        }


    }
}
