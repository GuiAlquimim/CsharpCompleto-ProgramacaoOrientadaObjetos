using ExFixacao_Interfaces2.Services;

namespace ExFixacao_Interfaces2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Qual a distância para entrega (Km)? ");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Tempo de entrega:");
            CalculadoraDeEntrega calculadoraDeEntrega1 = new CalculadoraDeEntrega(new Carro());
            CalculadoraDeEntrega calculadoraDeEntrega2 = new CalculadoraDeEntrega(new Aviao());

            Console.Write("De carro: ");
            Console.WriteLine(calculadoraDeEntrega1.ExibirPrevisao(distancia));
            Console.Write("De avião: ");
            Console.WriteLine(calculadoraDeEntrega2.ExibirPrevisao(distancia));
        }
    }
}