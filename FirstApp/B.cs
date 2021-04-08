using System;

namespace FirstApp
{
    class B : A
    {
        public override void Display()
        {
            Console.WriteLine("Вызван метод класса B");
        }
    }
}
