namespace FirstApp
{
    class Singleton
    {
        // Статическая переменная - ссылка на конкретный экземпляр объекта
        private static Singleton Instance;

        // Приватный конструктор
        private Singleton()
        { }

        // Конструктор вызывается для создания объекта, если он отсутствует 
        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();

            return Instance;
        }
    }
}
