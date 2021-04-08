using System;

namespace FirstApp
{
    abstract class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
}
