namespace ExFixacao_MetAbst.Entites
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TotalTax();

        public override string ToString()
        {
            return $"{Name}, ${TotalTax().ToString("f2")} (Anual income: ${AnualIncome.ToString("f2")})";
        }
    }
}