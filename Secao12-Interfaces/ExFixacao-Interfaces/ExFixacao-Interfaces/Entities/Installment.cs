using System.Globalization;

namespace ExFixacao_Interfaces.Entities
{
    internal class Installment
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Date.ToString("d", CultureInfo.GetCultureInfo("pt-BR"))} - {Amount.ToString("f2")}";
        }
    }
}