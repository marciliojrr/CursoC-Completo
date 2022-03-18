using ExercicioFixacaoComposicao.Entities;
using ExercicioFixacaoComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioFixacaoComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client data
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            // Order data
            Console.WriteLine("\nEnter order data:");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine($"Enter de #{i + 1} item data:");

                Console.Write("Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(prodName, prodPrice);

                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                OrderItem ordemItem = new OrderItem(prodQuantity, prodPrice, product);

                order.AddItem(ordemItem);
                Console.WriteLine();
            }
            
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("--------------\n");
            Console.WriteLine(order);
        }
    }
}
