using System;

namespace ExemploReadonlyStruct
{
    public readonly struct Temperatura
    {
        public double Celsius { get; }
        public double Fahrenheit { get; }
        public double Kelvin { get; }

        public Temperatura(double tempCelsius)
        {
            Celsius = tempCelsius;
            Fahrenheit = Math.Round((tempCelsius * 9 / 5) + 32, 2);
            Kelvin = tempCelsius + 273.15;
        }
    }
}