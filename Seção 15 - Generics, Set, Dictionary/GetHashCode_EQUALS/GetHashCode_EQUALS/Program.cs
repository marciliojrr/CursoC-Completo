using System;
using GetHashCode_EQUALS.Entities;

namespace GetHashCode_EQUALS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));

            Console.WriteLine(a == b); // FALSO! Compara a referencia do ponteiro de memoria do objeto

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            
        }
    }
}
