using System;

namespace FirstApp
{
    class Cat : FourLeggedAnimal
    {
        public override string Name
        {
            get;
            set;
        }
        public override void Describe()
        {
            Console.WriteLine("Это животное - кошка");
        }
    }
}
