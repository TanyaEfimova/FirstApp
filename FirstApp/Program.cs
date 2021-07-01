using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyAverage();
            WeeklyAverage();
            MonthlyAverage();
        }

        private static void DailyAverage()
        {
            /* заменяем на код ниже
            Console.WriteLine("Welcome to the daily forecast page");
            Console.WriteLine($"The average temperature expects to be around {new Random().Next(10, 30)} C");
            Console.WriteLine();
            */

            Console.WriteLine($"{Constants.WelcomeString} day {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }

        private static void WeeklyAverage()
        {
            /* заменяем на код ниже
            Console.WriteLine("Welcome to the weekly forecast page");
            Console.WriteLine($"The average temperature expects to be around {new Random().Next(10, 35)} C");
            Console.WriteLine();
            */

            Console.WriteLine($"{Constants.WelcomeString} week {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }

        private static void MonthlyAverage()
        {
            /* заменяем на код ниже
            Console.WriteLine("Welcome to the monthly forecast page");
            Console.WriteLine($"The average temperature expects to be around {new Random().Next(10, 40)} C");
            Console.WriteLine();
            */

            Console.WriteLine($"{Constants.WelcomeString} month {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }
    }

    public static class Constants
    {
        // Выносим повторяющийся код в константы
        public const string WelcomeString = "Welcome to the forecast page for the";
        public const string ForecastString = "The average temperature expects to be around ";
        public const string LineBreak = "\n"; // заменяем лишние вызовы Console.Writeline на символ переноса строки
    }
}


