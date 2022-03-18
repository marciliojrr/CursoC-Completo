using Enum1.Entities;
using Enum1.Entities.Enums;
using System;

namespace Enum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Converte enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Converte string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
