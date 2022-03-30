using Comparison1.Entities;
using System;
using System.Collections.Generic;

namespace Comparison1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            /*
            list.Sort(CompareProducts);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            // OU
            Console.WriteLine("---");

            Comparison<Product> comp = CompareProducts;
            list.Sort(comp);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            */

            // Usando expressao lambda (funcao lambda = funcao anonima) em uma variavel
            //                         (param1, param2 [sem tipo, pois serao inferidos]) => funcao a ser executada
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort(comp);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("---");

            // Usando expressao lambda direto na funcao Sort()
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        // DELEGATE - Referencia para funcao com Type Safety
        // Necessario para rodar as linhas 17 e 26
        /*
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */
    }
}
