namespace Exercicios4_EstruturaFor6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Seus divisores:");
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                    Console.WriteLine($"{i} ({Num} / {i} = {Num / i})");
            }
        }
    }
}
