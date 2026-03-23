namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos você tem na sua casa?");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string vetName = vet[0];
            int vetAge = int.Parse(vet[1]);
            double vetHeight = double.Parse(vet[2]);
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price);
            Console.WriteLine(vetName);
            Console.WriteLine(vetAge);
            Console.WriteLine(vetHeight);

        }
    }
}
