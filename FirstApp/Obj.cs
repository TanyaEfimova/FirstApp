using System;

namespace FirstApp
{
    class Obj
    {
        public string name;
        public bool isAlive;
        public int weight;

        public Obj()
        {
            Console.WriteLine("Вызван конструктор без параметров");
            isAlive = true;
        }

        public Obj(string name, int weight) : this()
        {
            this.name = name;
            this.weight = weight;
        }
    }
}
