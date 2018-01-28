using System;

namespace ExemploRefReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseExemplo exemplo = new ClasseExemplo();
            ref readonly int teste = ref exemplo.ObterContador();
            Console.WriteLine(teste);

            exemplo.Incrementar();
            Console.WriteLine(teste);

            exemplo.Incrementar();
            Console.WriteLine(teste);

            Console.ReadKey();
        }
    }
}