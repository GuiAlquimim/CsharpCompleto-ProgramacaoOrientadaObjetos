namespace Exercicios4_EstruturaFor7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int Num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine($"{i}: {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }

        }
    }
}
