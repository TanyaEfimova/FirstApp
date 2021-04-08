using System;

namespace FirstApp
{
    abstract class Delivery
    {
        public string Address;

        public void DisplayAddress()
        {
            Console.WriteLine(Address);
        }
    }
}
