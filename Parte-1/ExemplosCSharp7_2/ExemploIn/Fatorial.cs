namespace ExemploIn
{
    public static class Fatorial
    {
        public static int Calcular(in int numero)
        {
            int resultado = 1;
            for (int i = numero; i > 1; i--)
                resultado *= i;

            return resultado;
        }
    }
}