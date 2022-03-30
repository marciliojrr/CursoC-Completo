using System;
using Delegate1.Services;

namespace Delegate1
{
    // Declarando um Delegate
    delegate double BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);

            BinaryNumericOperation op = CalculationService.Sum;
            double result1 = op(a, b);
            Console.WriteLine(result1);
        }
    }
}
