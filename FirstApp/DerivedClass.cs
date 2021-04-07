using System;

namespace FirstApp
{
    class DerivedClass : BaseClass
    {
        public string Description;
        private int counter;
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение не должно быть отрицательным!");
                }
                else
                {
                    counter = value;
                }
            }
        }

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }

        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}
