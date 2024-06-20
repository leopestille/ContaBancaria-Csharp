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

            bool continuar = true;
            while (continuar) {
                Console.WriteLine("\nMenu de Opções:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Consultar Saldo");
                Console.WriteLine("4 - Sair");

                Console.Write("Digite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.Write("Digite o Valor a ser Depositado: ");
                        while (true) {
                            try {
                                double valorDeposito = double.Parse(Console.ReadLine());
                                if(valorDeposito > 0) {
                                    conta.Depositar(valorDeposito);
                                    Console.WriteLine("Depósito realizado com sucesso!");
                                    break;
                                }
                                else {
                                    Console.WriteLine("Valor Inválido para Depósito. Digite um valor maior que zero.");
                                }
                            }
                            catch (FormatException) {
                                Console.WriteLine("Valor Inválido para Depósito. Digite um valor numérico.");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Digite o Valor a ser Sacado: ");
                        while (true) {
                            try {
                                double valorSaque = double.Parse(Console.ReadLine());
                                if(valorSaque > 0 && valorSaque <= conta.ConsultarSaldo()) {
                                    conta.Sacar(valorSaque);
                                    Console.WriteLine("Saque Realizado com Sucesso!");
                                    break;
                                }
                                else {
                                    Console.WriteLine("Valor inválido para saque. Digite um valor positivo menor ou igual ao saldo:");
                                }
                            }
                            catch(FormatException) {
                                Console.WriteLine("Formato de valor inválido. Digite um número:");
                            }
                        }
                        break;
                    case 3:
                        double saldoAtual = conta.ConsultarSaldo();
                        Console.WriteLine("Seu saldo atual é de: R$ {0:F2}", saldoAtual);
                        break;
                    case 4:
                        Console.WriteLine("Obrigado por utilizar os nossos serviços. Até mais!");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
