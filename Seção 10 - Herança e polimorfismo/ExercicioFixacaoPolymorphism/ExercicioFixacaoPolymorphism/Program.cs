using System;
using ExercicioFixacaoPolymorphism.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numProd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Product> productsList = new List<Product>();

            for (int i = 0; i < numProd; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                for (int i = 0; i < "Product #x data".Length; i++)
                {
                    Console.Write("-");
                }

                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProd = char.Parse(Console.ReadLine());

                if (typeProd == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new Product(name, price);
                    productsList.Add(product);
                    Console.WriteLine();
                }
                else if (typeProd == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuDate = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(name, price, manuDate);
                    productsList.Add(product);
                    Console.WriteLine();
                }
                else if (typeProd == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    Product product = new ImportedProduct(name, price, customsFee);
                    productsList.Add(product);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            Console.WriteLine("PRICE TAGS:");
            for (int i = 0; i < "PRICE TAGS".Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();

            foreach (Product product in productsList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
