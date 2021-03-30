using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        {
            return a * b;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public Rectangle(int c)
        {
            a = c;
            b = c;
        }
        public Rectangle(int c, int d)
        {
            a = c;
            b = d;
        }
    }
}
