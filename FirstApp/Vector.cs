namespace FirstApp
{
    class Vector
    {
        public int X;
        public int Y;

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }

        public static Vector operator +(Vector a)
        {
            return new Vector
            {
                X = a.X,
                Y = a.Y
            };
        }
        public static Vector operator +(Vector a, (int X, int Y) b)
        {
            return new Vector
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }
    }
}
