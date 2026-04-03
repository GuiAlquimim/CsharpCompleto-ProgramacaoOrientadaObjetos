using System.Globalization;

namespace ExFixacao_HeranPoli.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"{Name} (used), $ {Price.ToString("f2")} (Manufacture date: {ManufactureDate.ToString("d", CultureInfo.GetCultureInfo("pt-BR"))})";
        }
    }
}