using System;

namespace FirstApp
{
    class C : B
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса C");
        }
    }
}
