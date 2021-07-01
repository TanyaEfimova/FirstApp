namespace FirstApp
{
    /// <summary>
    /// Класс, в котором нам нужно предусмотреть создание объектов фабрикой
    /// </summary>
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        /// <summary>
        ///  Конструктор класса, в котором происходит создание объектов фабрики
        /// </summary>
        public Client(IAbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        /// <summary>
        ///  Метод с нашей бизнес-логикой, где будут использоваться создаваемые фабрикой объекты
        /// </summary>
        public void Run()
        { }
    }
}
