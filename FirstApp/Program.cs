using System;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }
        static Department GetCurrentDepartment()
        {
            Department dep = new Department { Company = new Company { Type = "Банк", Name = "Уралсиб" }, City = new City { Name = "Санкт-Петербург" } };
            return dep;
        }
    }
}

