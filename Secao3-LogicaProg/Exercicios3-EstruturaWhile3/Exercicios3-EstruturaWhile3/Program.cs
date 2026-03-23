namespace Exercicios3_EstruturaWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tipo de combustível?");
            int tipo = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (tipo != 4)
            {

                if (tipo == 1)
                    alcool++;
                else if (tipo == 2)
                    gasolina++;
                else if (tipo == 3)
                    diesel++;
                else
                    Console.WriteLine("Tipo inválido!");

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Muito obrigado!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
