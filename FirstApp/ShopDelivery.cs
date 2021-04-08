using System;

namespace FirstApp
{
    class ShopDelivery : Delivery
    {
        public override void GetTypeDelivery()
        {
            Console.WriteLine("Доставка логистической компанией");
        }
    }
}
