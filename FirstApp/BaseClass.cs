using System;

namespace FirstApp
{
    class BaseClass
    {
        protected string Name;

        public virtual int Counter
        {
            get;
            set;
        }

        public BaseClass(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }
}
