using System;

namespace FirstApp
{
    abstract class Delivery
    {
        public string Address { get; set; }

        public abstract void GetTypeDelivery();
    }
}
