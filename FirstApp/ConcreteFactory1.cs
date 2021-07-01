namespace FirstApp
{
    /// <summary>
    ///  Первая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory1 : IAbstractFactory
    {
        // Конкретная реализация метода для создания продукта  A
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        // Конкретная реализация метода для создания продукта  B
        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
