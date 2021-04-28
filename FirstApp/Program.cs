using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            IMessenger<Phone> viberInIPhone = new Viber<ChildPhone>();

            viberInPhone.DeviceInfo();
            viberInIPhone.DeviceInfo();

            Console.Read();
        }
    }

    public interface IMessenger<out T>
    {
        T DeviceInfo();
    }

    public class Phone { }
    public class ChildPhone : Phone { }
    public class Computer { }
    public class Viber<T> : IMessenger<T> where T : Phone, new()
    {
        public T DeviceInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return new T();
        }
    }

}
