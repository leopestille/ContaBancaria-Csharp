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
            }            
        }

        public void Sacar(double valor) {
            if (valor > 0 && valor <= Saldo) {
                Saldo -= valor;                
            }
        }

        public double ConsultarSaldo() {
            return Saldo;
        }
    }
}
