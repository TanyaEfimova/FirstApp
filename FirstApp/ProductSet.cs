namespace FirstApp
{
    class ProductSet
    {
        // Закрытое поле, хранящее продуктовый набор в виде массива
        private Product[] set;

        // Конструктор с добавлением массива продуктов
        public ProductSet(Product[] set)
        {
            this.set = set;
        }

        // Индексатор по массиву
        public Product this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < set.Length)
                {
                    return set[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < set.Length)
                {
                    set[index] = value;
                }
            }
        }

        public Product this[string name]
        {
            get
            {
                for (int i = 0; i < set.Length; i++)
                {
                    if (set[i].Name == name)
                    {
                        return set[i];
                    }
                }

                return null;
            }
        }
    }
}
