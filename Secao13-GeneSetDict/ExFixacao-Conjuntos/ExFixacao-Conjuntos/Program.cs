namespace ExFixacao_Conjuntos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HashSet<int> alunos = new HashSet<int>();
            char[] cursos = { 'A', 'B', 'C' };

            foreach (char curso in cursos)
            {
                Console.Write($"Quantos aluos irão se matricular no curso {curso}? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"#{i}: ");
                    int aluno = int.Parse(Console.ReadLine());
                    alunos.Add(aluno);
                }
            }

            Console.WriteLine($"Total students: {alunos.Count}");
        }
    }
}