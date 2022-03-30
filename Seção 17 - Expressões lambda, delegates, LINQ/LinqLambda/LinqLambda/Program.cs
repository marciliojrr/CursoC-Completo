using System;
using System.Linq;
using System.Collections.Generic;
using LinqLambda.Entities;

namespace LinqLambda
{
    internal class Program
    {
        // Funcao auxiliar
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1}
            };

            // Mostrar todos os produtos Tier 1 e preco abaixo de 900.00
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900.00:", r1);

            // Mostrar somente o nome dos produtos da categoria tools
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            // Produtos comecados pela letra 'c'
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            // Produtos com TIER 1
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            // Skip e Take
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            // Operacoes que pegam elementos
            var r6 = products.First();
            Console.WriteLine("First test 1: " + r6);

            //var r7 = products.Where(p => p.Price > 3000.0).First(); // Erro, pois nao existe produto com preco 3000
            //Console.WriteLine("First test 2: " + r7);

            var r8 = products.FirstOrDefault();
            Console.WriteLine("First or default test 1: " + r8);

            var r9 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test 2: " + r9);

            var r10 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or defaut test1: " + r10);

            var r11 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or defaut test2: " + r11);
        }
    }
}
