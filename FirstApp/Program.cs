using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            HybridCar hybridCar = new HybridCar();

            car.Move();         // метод класса Car
            hybridCar.Move();       // метод класса HybridCar
            ((Car)hybridCar).Move();// метод класса HybridCar
        }

    }
}

