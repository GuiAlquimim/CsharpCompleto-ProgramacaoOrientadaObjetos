namespace ExFixacao_MemEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ValorCotacao(cotacao, quantidade).ToString("f2")}");
        }
    }
}
