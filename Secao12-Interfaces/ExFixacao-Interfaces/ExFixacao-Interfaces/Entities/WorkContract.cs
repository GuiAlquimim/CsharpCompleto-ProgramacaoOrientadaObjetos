namespace ExFixacao_Interfaces.Entities
{
    internal class WorkContract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public WorkContract(int number, double totalValue)
        {
            Number = number;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}