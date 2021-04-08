namespace FirstApp
{
    class Counter
    {
        private static int increasingCounter;
        public static int IncreasingCounter
        {
            get
            {
                return increasingCounter;
            }
            set
            {
                if (value > increasingCounter)
                {
                    increasingCounter = value;
                }
            }
        }
    }
}
