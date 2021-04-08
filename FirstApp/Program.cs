using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
            //DCBA
        }

    }
}

