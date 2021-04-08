using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Book[]{
    new Book{
      Name = "Мастер и Маргарита",
      Author = "М.А. Булгаков"
            },
    new Book{
      Name = "Отцы и дети",
      Author = "И.С. Тургенев"
            },
                                   };
            BookCollection collection = new BookCollection(array);

            Book book = collection[1];
            book = collection[-1];
            book = collection[4];

            book = collection["Мастер и Маргарита"];

            Console.ReadKey();
        }

    }
}

