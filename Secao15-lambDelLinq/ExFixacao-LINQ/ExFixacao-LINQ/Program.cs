using System.Globalization;

namespace ExFixacao_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fullPath = @"C:\Dev\CsharpCompleto-ProgramacaoOrientadaObjetos\Secao15-lambDelLinq\Datas\EmployeesDatas.txt";
            Console.WriteLine("Full file path: " + fullPath);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine();
            Console.Write("Enter salary limit: ");
            double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emails = employees.Where(e => e.Salary > salaryLimit).OrderBy(e => e.Email).Select(e => e.Email);
            var sumM = employees.Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary);

            Console.WriteLine();
            Console.WriteLine($"Email of people whose salary is more than {salaryLimit.ToString("f2", CultureInfo.InvariantCulture)}:");
            foreach (var empEmail in emails)
            {
                Console.WriteLine(empEmail);
            }

            Console.WriteLine();
            Console.WriteLine($"Sum of salary of pople whose name starts wit 'M': {sumM.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}