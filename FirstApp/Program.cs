using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass("Name", "Description");
            obj.Display();
        }

    }
}

