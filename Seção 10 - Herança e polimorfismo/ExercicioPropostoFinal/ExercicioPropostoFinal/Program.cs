using ExercicioPropostoFinal.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<TaxPayer> taxPayersList = new List<TaxPayer>();

            for (int i = 0; i < taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.WriteLine("-----------------");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpends = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayersList.Add(new Individual(name, anualIncome, healthExpends));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numEmployees = int.Parse(Console.ReadLine());
                    taxPayersList.Add(new Company(name, anualIncome, numEmployees));
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double sumTaxes = 0;

            Console.WriteLine("TAXES PAID:");
            Console.WriteLine("----------");
            foreach (TaxPayer taxPayer in taxPayersList)
            {
                sumTaxes += taxPayer.Taxes();
                Console.WriteLine(taxPayer.ShowTaxes());
            }
            Console.WriteLine();

            Console.WriteLine($"TOTAL TAXES: ${sumTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-----------");
        }
    }
}
