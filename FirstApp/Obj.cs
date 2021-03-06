using System;

namespace FirstApp
{
    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;
        public int Value;
        public static int MaxValue;
        public static string Parent;
        public static int DaysInWeek;


        static Obj()
        {
            MaxValue = 2000;
            Parent = "System.Object";
            DaysInWeek = 7;
        }

        public Obj()
        {
            Value = 0;
        }

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }

        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
}
