using System;

namespace FirstApp
{
    class Dog : FourLeggedAnimal
    {
        public override void Describe()
        {
            Console.WriteLine("Это животное - собака");
        }
    }
}
