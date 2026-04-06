using ExFixacao_Excecoes.Entities;
using ExFixacao_Excecoes.Entities.Exceptions;

namespace ExFixacao_Excecoes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);

                Console.WriteLine($"New balance: {account.Balance.ToString("f2")}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error while attempting withdrawal: {e.Message}");
            }
        }
    }
}