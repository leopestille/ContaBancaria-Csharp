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
                        try {
                            double ValorDeposito = double.Parse(Console.ReadLine());
                            if (ValorDeposito <= 0) {
                                throw new ValorInvalidoException();
                            }
                            else {
                                conta.Depositar(ValorDeposito);
                                Console.WriteLine("Depósito realizado com sucesso!");
                            }
                        }
                        catch (ValorInvalidoException ex) {
                            Console.WriteLine(ex.Message); // Exibe a mensagem da exceção personalizada
                        }
                        catch (FormatException) {
                            Console.WriteLine("Por Favor, digite um número. ");
                        }
                        catch (Exception ex) // Captura exceções genéricas não tratadas anteriormente
                        {
                            Console.WriteLine("Erro inesperado: " + ex.Message);
                        }
                        break;                            
                    case 2:
                        Console.Write("Digite o valor a ser sacado: ");
                        try {
                            double valorSaque = double.Parse(Console.ReadLine());
                            if (valorSaque <= 0) {
                                throw new ValorInvalidoException();
                            }
                            else if (valorSaque > conta.ConsultarSaldo()) {
                                throw new SaldoInsuficienteException();
                            }
                            else {
                                conta.Sacar(valorSaque);
                                Console.WriteLine("Saque realizado com sucesso!");
                            }
                        }
                        catch (FormatException) {
                            Console.WriteLine("Por Favor, digite um número. ");
                        }
                        catch (SaldoInsuficienteException ex) {
                            Console.WriteLine(ex.Message); // Exibe a mensagem da exceção personalizada
                        }
                        catch (ValorInvalidoException ex) {
                            Console.WriteLine(ex.Message); // Exibe a mensagem da exceção personalizada
                        }
                        catch (Exception ex) // Captura exceções genéricas não tratadas anteriormente
                        {
                            Console.WriteLine("Erro inesperado: " + ex.Message);
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
