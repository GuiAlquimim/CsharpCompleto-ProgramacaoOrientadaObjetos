using ExFixacao_EnumComp.Entities;
using ExFixacao_EnumComp.Entities.Enums;
using System.Globalization;

namespace ExFixacao_EnumComp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birh date (DD/MM/YYYYY): ");
            DateTime clientBirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();

            Order order = new Order(Enum.Parse<OrderStatus>(status), client);

            Console.Write("How many items to this order? ");
            int orderQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= orderQuantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}