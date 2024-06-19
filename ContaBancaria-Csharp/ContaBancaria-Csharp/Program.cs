namespace ContaBancaria_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Programa de Gerenciamento de Contas Bancárias DataInsight");
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Conta conta = new Conta(titular, numeroConta);
        }
    }
}
