using System;

namespace FirstApp
{
    class Order<TDelivery, TNumber> where TDelivery : Delivery
                                    where TNumber : new()
    {
        public TDelivery Delivery { get; set; }

        public TNumber Number { get; set; }

        public string Description { get; set; }

        private ProductSet ProductBasket;
        private HomeDelivery homeDelivery;
        private ProductSet collection;

        protected Order(TDelivery delivery, ProductSet productSet)
        {
            Delivery = delivery;
            ProductBasket = productSet;
        }

        public Order(HomeDelivery homeDelivery, ProductSet collection)
        {
            this.homeDelivery = homeDelivery;
            this.collection = collection;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}
