using ExFixacao_MetAbst.Entites;

namespace ExFixacao_MetAbst
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Natural or legal (n/l)? ");
                char personType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (personType == 'n' || personType == 'N')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    persons.Add(new NaturalPerson(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employeesQuantity = int.Parse(Console.ReadLine());
                    persons.Add(new LegalPerson(name, anualIncome, employeesQuantity));
                }

                Console.WriteLine();
            }

            double totalTaxes = 0.0;
            Console.WriteLine("Taxes paid:");
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
                totalTaxes += person.TotalTax();
            }

            Console.WriteLine();
            Console.WriteLine($"Total Taxes: ${totalTaxes.ToString("f2")}");
        }
    }
}