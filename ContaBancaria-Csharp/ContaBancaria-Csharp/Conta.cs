namespace ContaBancaria_Csharp
{
    class Conta
    {
        public string Titular { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get;private set; }

        public Conta(string titular, int numeroDaConta)
        {
            Titular = titular;
            NumeroDaConta = numeroDaConta;
            Saldo = 0;
        }

        public void Depositar(double valor) { 
        if (valor > 0) {
                Saldo += valor;
                Console.WriteLine("Depósito Realizado com Sucesso!");
            }
            else {
                Console.WriteLine("Valor Inválido para depósito");
            }
        }

        public void Sacar(double valor) {
            if (valor > 0 && valor <= Saldo) {
                Saldo -= valor;
                Console.WriteLine("Saque Realizado com Sucesso");
            }else {
                Console.WriteLine("Saldo insuficiente para Saque.");
            }
        }

        public double ConsultarSaldo() {
            return Saldo;
        }
    }
}
