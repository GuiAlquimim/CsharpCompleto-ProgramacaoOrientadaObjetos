namespace Exercicios3_EstruturaWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digie a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida.");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}