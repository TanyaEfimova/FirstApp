using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region неявные преобразования
            Apple ap = new Apple();
            Fruit fruit = ap;
            Food food = (Food)fruit;  //явное восходящее преобразование
            Food secondFood = new Vegetable();
            Vegetable vegetable = (Vegetable)secondFood; //явное нисходящее преобразование (может возникнуть исключение)
            #endregion

            #region проверка возможности преобразования
            if (secondFood is Vegetable)
            {
                Console.WriteLine("Экземпляр имеет тип Vegetable");
                Vegetable vegetable2 = (Vegetable)secondFood; //здесь снова будет проверка
                Vegetable vegetable3 = secondFood as Vegetable; //так оптимальнее
            }

            bool expression;
            expression = secondFood is Vegetable;  //true
            expression = secondFood is Food;    //true
            expression = secondFood is object;  //true
            expression = secondFood is Fruit;   //false
            #endregion

            #region проверка на null чтобы не получить NullReferenceException
            Vegetable vegetable4 = secondFood as Vegetable;

            if (vegetable4 != null) //нагромождение кода
            {
                // Использование значения vegetable4
            }
            #endregion

            #region сопоставление шаблонов
            if (secondFood is Vegetable vegetable5) //так оптимальнее если C#>=7.0
            {
                // Использование значения vegetable5
            }
            #endregion
        }

    }
}

