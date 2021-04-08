namespace FirstApp
{
    class Order<TDelivery, TStruct>
           where TDelivery : Delivery
           where TStruct : struct
    {
        public TDelivery Delivery;

        public TStruct Struct;
    }
}
