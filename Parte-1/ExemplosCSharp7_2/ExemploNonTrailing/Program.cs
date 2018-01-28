using System;

namespace ExemploNonTrailing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 ^ 3 = " + Math.Pow(x: 2, 3)); // Uso de non-trailing named argument
            Console.WriteLine("2 ^ 5 = " + Math.Pow(x: 2, y: 5));
            Console.WriteLine("2 ^ 10 = " + Math.Pow(2, y: 10));
            Console.ReadKey();
        }
    }
}