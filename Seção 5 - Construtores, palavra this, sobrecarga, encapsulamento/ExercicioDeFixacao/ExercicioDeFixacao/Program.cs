using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeConta = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            double valorDeposito;

            ContaBancaria c1;

            if (resp == 's')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(numConta, nomeConta, valorDeposito);
                Console.WriteLine("\nDados da conta:");
                Console.WriteLine($"{c1}");
            }
            else
            {
                c1 = new ContaBancaria(numConta, nomeConta);
                Console.WriteLine("\nDados da conta:");
                Console.WriteLine($"{c1}");
            }

            Console.Write("\nEntre um valor para deposito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c1.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

            Console.Write("\nEntre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c1.Saque(valorSaque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
        }
    }
}
