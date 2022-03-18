using System.Globalization;

namespace ExercicioDeFixacao
{
    internal class ContaBancaria
    {
        // Atributos
        public int NumConta { get; private set; } // AutoProperties
        public string Nome { get; set; } // Pode ser consultado e alterado
        public double Saldo { get; private set; } // Pode ser apenas consultado diretamente

        // Construtores
        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumConta = numeroConta;
            Nome = nomeTitular;
        }
        public ContaBancaria(int numeroConta, string nomeTitular, double deposito) : this(numeroConta, nomeTitular)
        {
            Saldo = deposito;
        }

        // Metodos
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            double taxa = 5.0;
            Saldo -= valor + taxa;
        }

        public override string ToString()
        {
            return $"Conta: {NumConta}, Titular: {Nome}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}