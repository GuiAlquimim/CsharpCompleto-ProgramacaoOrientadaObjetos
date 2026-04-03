using ExFixacao_HeranPoli.Entities;
using System.Globalization;

namespace ExFixacao_HeranPoli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (C/U/I): ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (productType == 'u' || productType == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("pt-BR"));
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (productType == 'i' || productType == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                    products.Add(new Product(name, price));

                Console.WriteLine();
            }

            Console.WriteLine("Price tags:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}