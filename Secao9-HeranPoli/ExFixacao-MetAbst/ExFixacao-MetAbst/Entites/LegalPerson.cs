namespace ExFixacao_MetAbst.Entites
{
    internal class LegalPerson : Person
    {
        public int EmployeesQuantity { get; set; }

        public LegalPerson(string name, double anualIncome, int employeesQuantity) : base(name, anualIncome)
        {
            EmployeesQuantity = employeesQuantity;
        }

        public override double TotalTax()
        {
            double tax;
            if (EmployeesQuantity <= 10)
                tax = AnualIncome * 0.16;
            else
                tax = AnualIncome * 0.14;

            return tax;
        }
    }
}