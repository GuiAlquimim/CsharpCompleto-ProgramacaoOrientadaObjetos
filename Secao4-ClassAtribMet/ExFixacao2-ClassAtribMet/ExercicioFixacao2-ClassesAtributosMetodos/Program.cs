namespace ExercicioFixacao2_ClassesAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {funcionario}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {funcionario}");
        }
    }
}
