namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product();

            p1.ToName("Computador");
            p1.ToPrice(2500.50);

            p2.ToName("Iphone 17 Pro Max");
            p2.ToPrice(6000);

            Console.WriteLine("Products:");

            Console.WriteLine($"{p1.GetName()}, cujo preço é $ {p1.GetPrice().ToString("f2")}");
            Console.WriteLine($"{p2.GetName()}, cujo preço é $ {p2.GetPrice()}");
            Console.WriteLine();

        }
    }
}
