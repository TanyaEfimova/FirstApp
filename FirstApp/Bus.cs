﻿using System;

namespace FirstApp
{
    class Bus
    {
        public int? Load;
        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
        }
    }
}
