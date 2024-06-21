namespace ContaBancaria_Csharp
{
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException() : base("Valor inválido. Digite um valor positivo.")
        {
        }
    }
}
