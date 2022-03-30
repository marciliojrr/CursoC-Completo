using System;
using System.Collections.Generic;
using Predicate1.Entities;

namespace Predicate1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            // Modo 1
            //list.foreach (updateprice) ;
            //foreach (product p in list)
            //{
            //    console.writeline(p);
            //}

            // Modo 2
            //Action<Product> act = UpdatePrice;
            //list.ForEach(act);
            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}

            // Modo 3
            //Action<Product> act = p => { p.Price += p.Price * 0.1; }; // tem que ter chaves, pois tem corpo mas retorna void
            //list.ForEach(act);
            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}

            // Modo 4
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        // Funcao auxiliar
        // Necessario para Modo 1 e Modo 2
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
