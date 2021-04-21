using System;

namespace FirstApp
{
    class Program
    {
        public delegate Car<GasEngine> CarMethods();
        static void Main(string[] args)
        {
            CarMethods deleg = CarMethod;
            deleg += LexusMethod;

            deleg.Invoke();
            Console.Read();
        }

        public static Car<GasEngine> CarMethod()
        {
            Console.WriteLine("CarMethod");
            return new Car<GasEngine>
            {
                Engine = null
            };
        }

        public static Lexus LexusMethod()
        {
            Console.WriteLine("LexusMethod");
            return new Lexus
            {
                Engine = null
            };
        }

    }
}
