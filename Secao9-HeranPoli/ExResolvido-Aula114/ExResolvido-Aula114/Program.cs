using ExResolvido_Aula114.Entities;

namespace ExResolvido_Aula114
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the numer of employees: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{1} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hourd: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == 'y' || outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                    employees.Add(new Employee(name, hours, valuePerHour));

                Console.WriteLine();
            }

            Console.WriteLine("Payments:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}