using System;

namespace FirstApp
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get
            {
                return a;
            }

            set
            {
                if (value > 0 && b + c > value)
                {
                    a = value;
                }

                else
                {
                    Console.WriteLine("Сторона а задана не корректно!");
                }
            }
        }

        public int B
        {
            get
            {
                return b;
            }

            set
            {
                if (value > 0 && a + c > value)
                {
                    b = value;
                }

                else
                {
                    Console.WriteLine("Сторона b задана не корректно!");
                }
            }
        }

        public int C
        {
            get
            {
                return c;
            }

            set
            {
                if (value > 0 && a + b > value)
                {
                    c = value;
                }

                else
                {
                    Console.WriteLine("Сторона c задана не корректно!");
                }
            }
        }

    }
}
