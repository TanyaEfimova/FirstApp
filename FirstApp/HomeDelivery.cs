using System;

namespace FirstApp
{
    class HomeDelivery : Delivery
    {
        public override void GetTypeDelivery()
        {
            Console.WriteLine("Курьерская доставка");
        }
    }
}
