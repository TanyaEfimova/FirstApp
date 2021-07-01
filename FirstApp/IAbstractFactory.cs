namespace FirstApp
{
    /// <summary>
    /// Базовый интерфейс абстрактной фабрики
    /// </summary>
    interface IAbstractFactory
    {
        // Абстрактный метод для создания продукта  A
        AbstractProductA CreateProductA();

        // Абстрактный метод для создания продукта  B
        AbstractProductB CreateProductB();
    }
}
