namespace ContaBancaria_Csharp
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("Saldo insuficiente para saque.")
        {
        }
    }
}
