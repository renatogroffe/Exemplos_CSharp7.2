using System;

namespace ExemploSpan
{
    class Program
    {
        private static void ExibirValores(double[] valores)
        {
            Console.Write("{ ");

            for (int i = 0; i < valores.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(valores[i]);
            }

            Console.WriteLine(" }");
        }

        private static void Arredondar(Span<double> valores)
        {
            for (int i = 0; i < valores.Length; i++)
                valores[i] = Math.Round(valores[i], 2);
        }

        static void Main(string[] args)
        {
            double[] arrayMemory = new double[10]
                { 10.56768, 5.376936, 8.6, 7.2,
                  6.728, 7.7251, 10.59, 20.7769,
                  2.57874, 3.5 };
            var arraySpan = new Span<double>(arrayMemory);

            ExibirValores(arrayMemory);

            Arredondar(arraySpan.Slice(0, 5));
            ExibirValores(arrayMemory);

            Arredondar(arraySpan.Slice(5));
            ExibirValores(arrayMemory);

            // Não é possível utilizar foreach com Span<T>

            double total = 0;
            for (int i = 0; i < arraySpan.Length; i++)
                total += arraySpan[i];
            Console.WriteLine($"Total: {total}");

            Console.ReadKey();
        }
    }
}