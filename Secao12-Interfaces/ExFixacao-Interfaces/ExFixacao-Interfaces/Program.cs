using ExFixacao_Interfaces.Entities;
using ExFixacao_Interfaces.Services;

namespace ExFixacao_Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());

            WorkContract contract = new WorkContract(number, totalValue);

            Console.Write("Enter the number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
                Console.WriteLine(installment);
        }
    }
}