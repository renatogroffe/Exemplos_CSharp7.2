using System;

namespace ExemploReadonlyStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura(30);
            Console.Write($"{temperatura.Celsius} graus Celsius = ");
            Console.Write($"{temperatura.Fahrenheit} graus Fahrenheit = ");
            Console.WriteLine($"{temperatura.Kelvin} graus Kelvin");
            Console.ReadKey();
        }
    }
}
