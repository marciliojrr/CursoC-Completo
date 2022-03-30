using System;
using System.Collections.Generic;
using Predicate1.Entities;
using System.Linq; // Para usar o Select

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
            //List<string> result = list.Select(NameUpper).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Modo 2
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Modo 3
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Modo 4
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        // Funcao auxiliar
        // Necessario para Modo 1 e Modo 2
        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}
