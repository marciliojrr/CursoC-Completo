using ExercicioFixacaoComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoComposicao.Entities
{
    internal class Order
    {
        // AutoProps
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        // Constructors
        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        // Methods
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine($"{Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"- {item.Product.Name}, ${item.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: {item.SubTotal()}");
            }

            sb.Append($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
