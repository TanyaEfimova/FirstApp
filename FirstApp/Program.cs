using System;

namespace FirstApp
{
    class Program
    {
        public delegate Car<GasEngine> CarMethods();
        public delegate void ChildMethods(Child child);
        static void Main(string[] args)
        {
            CarMethods deleg = CarMethod;
            deleg += LexusMethod;
            deleg.Invoke();

            ChildMethods delegat = ChildMethod;
            delegat += ParentMethod;
            delegat.Invoke(new Child("Family"));

            Console.Read();
        }
        public static void ParentMethod(Parent parent)
        {
            Console.WriteLine(parent.Name);
        }

        public static void ChildMethod(Child child)
        {
            Console.WriteLine(child.Name);
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
