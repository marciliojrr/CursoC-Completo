using Example1.Entities;
using System;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount b1 = new BusinessAccount(1010, "Marcilio Junior", 100.00, 50.00);
            Console.WriteLine(b1.Ballance);
        }
    }
}
