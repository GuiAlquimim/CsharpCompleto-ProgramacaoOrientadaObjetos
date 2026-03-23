namespace ExercicioFixacao1_ClassesAtributosMetodos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo:");
            double largura = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);

            Console.WriteLine();
            Console.WriteLine($"Área: {retangulo.Area().ToString("f2")}");
            Console.WriteLine($"Perímetro: {retangulo.Perimetro().ToString("f2")}");
            Console.WriteLine($"Diagonal: {retangulo.Diagonal().ToString("f2")}");
        }
    }
}