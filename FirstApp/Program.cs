using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            IGarageManager<Machine, Garage> garageManager1 = new GarageManagerBase();

            //контравариантность
            IGarageManager<Auto, Garage> garageManager2 = new GarageManagerBase();

            //ковариантность
            IGarageManager<Auto, House> garageManager3 = new GarageManagerBase();

            Console.Read();
        }
    }

    public class Machine
    {

    }

    public class Auto : Machine
    {

    }

    public class House
    {

    }

    public class Garage : House
    {

    }

    public interface IGarageManager<in T, out Z>
    {
        Z GetGarageInfo();

        void Add(T machine);
    }

    public class GarageManagerBase : IGarageManager<Machine, Garage>
    {
        public void Add(Machine machine)
        {
            throw new NotImplementedException();
        }

        public Garage GetGarageInfo()
        {
            throw new NotImplementedException();
        }
    }
}
