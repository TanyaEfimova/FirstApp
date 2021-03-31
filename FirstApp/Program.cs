using System;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data { Name = "Запись", Length = 10, Version = 1, Array = new int[] { 15, 30 } };
            Obj obj = new Obj { Name = "Стол", IsAlive = false, Weight = 15 };

            var dataCopy = data;
            var objCopy = obj;

            data.Name = "Значение";
            data.Length = 35;
            data.Version = 2;
            data.Array[0] = 0;

            //если закомментируем, то будет 2 ссылки на один и тот же объект
            objCopy = new Obj { Name = obj.Name, IsAlive = obj.IsAlive, Weight = obj.Weight };

            obj.Name = "Кот";
            obj.IsAlive = true;
            obj.Weight = 3;

            Console.ReadKey();
        }
    }
}

