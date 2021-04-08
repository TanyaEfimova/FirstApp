using System;

namespace FirstApp
{
    class InheritedClass : BaseClass
    {
        private int newValue;

        public InheritedClass(int newValue) : base("100")
        {
            this.newValue = newValue;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса InheritedClass");
        }
    }
}
