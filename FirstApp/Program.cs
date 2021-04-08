using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Николай", true);
            Guest guest = new Guest("Андрей", new DateTime(2020, 11, 05));

            Person person = employee;
            person = guest;
        }

    }
}

