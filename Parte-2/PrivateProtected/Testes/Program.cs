using System;
using LibBase;
using NovaLib;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new ClasseBase().GerarMensagem());
            Console.WriteLine(new ClasseDerivada().GerarMensagem());
            Console.WriteLine(new NovaClasseDerivada().GerarMensagem());
            Console.ReadKey();
        }
    }
}
