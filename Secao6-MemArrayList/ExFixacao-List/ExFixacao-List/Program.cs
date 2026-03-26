namespace ExFixacao_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id to increase salary: ");
            int idToIncrease = int.Parse(Console.ReadLine());

            Employee employeeAux = employees.Find(x => x.Id == idToIncrease);

            if (employeeAux != null)
            {
                Console.Write("Percentage salary increase: ");
                int percentage = int.Parse(Console.ReadLine());
                employeeAux.increaseSalary(percentage);
            }
            else
                Console.WriteLine("Id not found");

            Console.WriteLine();
            Console.WriteLine("Updated list of employess:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}