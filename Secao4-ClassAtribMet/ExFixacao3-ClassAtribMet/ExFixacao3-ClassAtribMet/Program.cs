namespace ExFixacao3_ClassAtribMet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas:");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

            double notaFinal = aluno.CalcularNota();

            Console.WriteLine($"Nota final = {notaFinal.ToString("f2")}");

            if (notaFinal < 60)
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine($"Faltaram {(60 - notaFinal).ToString("f2")} pontos");
            }
            else
                Console.WriteLine("Aprovado!");
        }
    }
}