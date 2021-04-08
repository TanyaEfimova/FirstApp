﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class BookCollection
    {
        // Закрытое поле, хранящее книги в виде массива
        private Book[] collection;

        // Конструктор с добавлением массива книг
        public BookCollection(Book[] collection)
        {
            this.collection = collection;
        }

        // Индексатор по массиву
        public Book this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }

        public Book this[string name]
        {
            get
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i].Name == name)
                    {
                        return collection[i];
                    }
                }

                return null;
            }
        }
    }
}
