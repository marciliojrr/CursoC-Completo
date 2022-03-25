using ExercicioDeFixacao.Entities;
using ExercicioDeFixacao.Services;
using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Coletando dados do contrato
            Console.WriteLine("-------------------");
            Console.WriteLine("ENTER CONTRACT DATA");
            Console.WriteLine("-------------------");
            
            Console.Write("- Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("- Date (dd/mm/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("- Contract value: $");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("- Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            // Criando o contrato
             Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            // Processando o contrato
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            // Mostrando valores das parcelas
            Console.WriteLine("\n------------");
            Console.WriteLine("INSTALLMENTS");
            Console.WriteLine("------------");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
