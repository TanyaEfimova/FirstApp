using System;

namespace FirstApp
{
    class Citizen //гражданин
    {
        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }
}
