using System;
using System.Globalization;
using Exercise.Entities;
using Exercise.Entities.Exceptions;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter de account data:");
                Console.WriteLine("---------------------");

                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holderAccount = Console.ReadLine();

                Console.Write("Initial balance: $");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: $");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(numberAccount, holderAccount, initialBalance, withdrawLimit);
                Console.WriteLine();

                Console.WriteLine("Account information");
                Console.WriteLine("-------------------");
                Console.WriteLine(acc);
                Console.WriteLine();

                Console.Write("Enter amount for withdraw: $");
                double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(withdrawValue);
                Console.WriteLine();

                Console.WriteLine("Updated account information");
                Console.WriteLine("---------------------------");
                Console.WriteLine(acc);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
