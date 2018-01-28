using System;

namespace ExemploIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = 0;
            Console.WriteLine(
                $"{numero}! = {Fatorial.Calcular(numero)}");

            numero = 1;
            Console.WriteLine(
                $"{numero}! = {Fatorial.Calcular(numero)}");

            Console.WriteLine(
                $"2! = {Fatorial.Calcular(1 + 1)}");

            numero = 3;
            Console.WriteLine(
                $"{numero}! = {Fatorial.Calcular(in numero)}");

            numero = 4;
            Console.WriteLine(
                $"{numero}! = {Fatorial.Calcular(in numero)}");

            Console.WriteLine(
                $"5! = {Fatorial.Calcular(5)}");

            Console.ReadKey();
        }
    }
}