using System;

namespace FirstApp
{
    class Dog : FourLeggedAnimal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Describe()
        {
            Console.WriteLine("Это животное - собака");
        }
    }
}
