using ExResolvido_Aula102.Entities;
using ExResolvido_Aula102.Entities.Enums;
using System.Globalization;

namespace ExResolvido_Aula102
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department department = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            WorkerLevel wl = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level);

            Worker worker = new Worker(name, wl, baseSalary, department);

            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");
            int contratsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contratsQuantity; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(contractDate, valuePerHour, hours);

                worker.AddContract(hourContract);
                Console.WriteLine();
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            DateTime incomeDate = DateTime.ParseExact(monthYear, "MM/yyyy", CultureInfo.InvariantCulture);

            int month = incomeDate.Month;
            int year = incomeDate.Year;

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthYear}: {worker.Income(year, month).ToString("f2")}");
        }
    }
}