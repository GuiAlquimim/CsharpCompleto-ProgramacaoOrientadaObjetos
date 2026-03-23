namespace Exercicio6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores A, B e C:\n");
            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            Console.WriteLine();
            Console.WriteLine($"Triângulo: {(A * C / 2).ToString("f3")}");
            Console.WriteLine($"Circulo: {(Math.PI * Math.Pow(C, 2)).ToString("f3")}");
            Console.WriteLine($"Trapézio: {((A + B) * C / 2).ToString("f3")}");
            Console.WriteLine($"Quadrado: {(Math.Pow(B, 2)).ToString("f3")}");
            Console.WriteLine($"Retângulo: {(A * B).ToString("f3")}");
        }
    }
}