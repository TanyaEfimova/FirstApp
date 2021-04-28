using System;

namespace FirstApp
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();

            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);
            var worker3 = new Worker3(Logger);

            worker1.Work();
            worker2.Work();
            worker3.Work();

            Console.ReadKey();
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            //можем менять логику
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(message);
        }
    }

    public interface IWorker
    {
        void Work();
    }
}
