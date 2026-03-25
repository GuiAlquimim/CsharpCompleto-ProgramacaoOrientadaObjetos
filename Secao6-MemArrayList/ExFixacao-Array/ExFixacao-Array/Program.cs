namespace ExFixacao_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos estudantes vão alugar um quarto? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Email do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Quarto alugado: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                quartos[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("Quartos ocupados no pensionado:");

            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"[{i}] ocupado por {quartos[i].Nome}, contato: {quartos[i].Email}");
                }
            }
        }
    }
}
