using System;

namespace FirstApp
{
    class Car
    {
        private double Fuel;

        public int Mileage;

        private string color;

        private TurnDirection turn;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            color = "White";
        }

        public virtual void Move()
        {
            // Move a kilometer
            Mileage++;
            Fuel -= 0.5;
            Console.WriteLine("Вызван метод Move класса Car");
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }

        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }

        public string GetColor()
        {
            return color;
        }

        public void ChangeColor(string newColor)
        {
            if (color != newColor)
                color = newColor;
        }

        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }

        public bool IsTurningRight()
        {
            return turn == TurnDirection.Right;
        }
    }
}
