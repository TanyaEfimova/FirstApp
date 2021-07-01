namespace FirstApp
{
    /// <summary>
    ///  Вторая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory2 : IAbstractFactory
    {
        // Конкретная реализация метода для создания продукта  A
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        // Конкретная реализация метода для создания продукта  B
        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
