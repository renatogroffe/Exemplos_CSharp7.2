namespace LibBase
{
    public class ClasseBase
    {
        //protected internal string Valor { get; set; }
        private protected string Valor { get; set; }

        public ClasseBase()
        {
            Valor = "ClasseBase";
        }

        public string GerarMensagem()
        {
            return Valor;
        }
    }

    public class ClasseDerivada : ClasseBase
    {
        public ClasseDerivada()
        {
            Valor = "ClasseDerivada";
        }
    }
}