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

    public interface ICalculator
    {
        void Solve(int number);
        void Solve(int numberOne, int numberTwo);
    }

    public class BaseCalculator : ICalculator
    {
        void ICalculator.Solve(int number)
        {
            
        }

        public void Solve(int numberOne, int numberTwo)
        {
            throw new NotImplementedException();
        }
    }
}
