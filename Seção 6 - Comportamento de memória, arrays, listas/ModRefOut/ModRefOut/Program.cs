using System;

namespace ModRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utilizando primeira funcao
            int a = 10;
            Calculator.Triple(a); // Nao funciona.
            Console.WriteLine(a);

            // Utilizando funcao com ref 
            int b = 10;
            Calculator.Triple2(ref b);
            Console.WriteLine(b);

            // Utilizando o out
            int c = 20;
            // int triple;
            // Calculator.Triple3(a, out triple);
            Calculator.Triple3(c, out int triple);
            Console.WriteLine(triple);
        }
    }
}
