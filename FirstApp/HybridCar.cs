namespace FirstApp
{
    class HybridCar : Car
    {
        public FuelType FuelType;

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }
}
