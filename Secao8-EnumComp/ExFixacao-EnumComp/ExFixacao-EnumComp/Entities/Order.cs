using ExFixacao_EnumComp.Entities.Enums;
using System.Globalization;
using System.Text;

namespace ExFixacao_EnumComp.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

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
            double total = 0.0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Order Momment {Moment.ToString("G", CultureInfo.GetCultureInfo("pt-BR"))}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("d", CultureInfo.GetCultureInfo("pt-BR"))}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Price}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("f2")}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("f2")}");

            return sb.ToString();
        }
    }
}