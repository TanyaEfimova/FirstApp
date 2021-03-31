namespace FirstApp
{
    class TrafficLight
    {
        private string Color;
        private void ChangeColor(string color)
        {
            Color = color;
        }

        public string GetColor()
        {
            return Color;
        }
    }
}
