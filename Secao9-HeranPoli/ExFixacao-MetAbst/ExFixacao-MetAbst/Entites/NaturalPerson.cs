namespace ExFixacao_MetAbst.Entites
{
    internal class NaturalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public NaturalPerson(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TotalTax()
        {
            double tax;
            if (AnualIncome < 20000)
                tax = AnualIncome * 0.15;
            else
                tax = AnualIncome * 0.25;

            if (HealthExpenditures >= 1)
                tax -= HealthExpenditures * 0.5;

            return tax;
        }
    }
}