using System;

namespace FirstApp
{
    class CivilServant : Citizen   //госслужащий
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
