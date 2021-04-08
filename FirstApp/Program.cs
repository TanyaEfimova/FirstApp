using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeDelivery homeDelivery = new HomeDelivery();

            var array = new Product[]
  {
    new Product
    {
      Artikul="AS009",
      Name="Pen",
      Description="Subject for writing"
    },
    new Product
    {
      Artikul="AYU1356",
      Name="Book",
      Description="Subject for reading"
    },
  };
            ProductSet collection = new ProductSet(array);

            Order<HomeDelivery, DaysOfWeek> order1 = new Order<HomeDelivery, DaysOfWeek>(homeDelivery, collection);
        }

    }
}

