using System;

namespace FirstApp
{
    class PickPointDelivery : Delivery
    {
        public override void GetTypeDelivery()
        {
            Console.WriteLine("Самовывоз из пункта выдачи");
        }
    }
}
