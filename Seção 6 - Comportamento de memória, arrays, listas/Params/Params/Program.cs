using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sobrecarga
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            // Vetor
            int s3 = Calculator.Sum2(new int[] { 2, 4, 3 });
            Console.WriteLine(s3);

            // Params
            int s4 = Calculator.Sum3(2, 4, 3);
            Console.WriteLine(s4);
        }
    }
}
