namespace Primeiros_Exercicios_Ex01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());

            pessoa1.Nome = nome;
            pessoa1.Idade = idade;
            pessoa2.Nome = nome2;
            pessoa2.Idade = idade2;

            if (pessoa1.Idade > pessoa2.Idade)
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            else
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
        }
    }
}