namespace FirstApp
{
    class Сar
    {
            public string Manufacturer { get; set; }
            public string CountryCode { get; set; }

            public Сar(string manufacturer, string countryCode)
            {
                Manufacturer = manufacturer;
                CountryCode = countryCode;
            }
    }
}
