namespace Primeiros_Exercicios_Ex02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Salário médio = {MediaSalarial(funcionario1.Salario, funcionario2.Salario).ToString("f2")}");
        }

        static double MediaSalarial(double salario1, double salario2)
        {
            return (salario1 + salario2) / 2;
        }
    }
}