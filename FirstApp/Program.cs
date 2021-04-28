using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            viberInPhone.GetDeviceInfo(new Phone());

            IMessenger<ChildPhone> viberInIPhone = new Viber<Phone>();
            viberInIPhone.GetDeviceInfo(new ChildPhone());

            Console.Read();
        }
    }

    public interface IMessenger<in T>
    {
        void GetDeviceInfo(T device);
    }

    public class Phone { }
    public class ChildPhone : Phone { }
    public class Computer { }
    public class Viber<T> : IMessenger<T> where T : Phone, new()
    {
        public void GetDeviceInfo(T device)
        {
            Console.WriteLine(device);
        }
    }

}
