using System;

namespace FirstApp
{
    class Guest : Person
    {
        // Дата и время прибытия гостя
        public DateTime ArrivalDate;

        public Guest(string name, DateTime arrivalDate) : base(name)
        {
            ArrivalDate = arrivalDate;
        }
    }
}
