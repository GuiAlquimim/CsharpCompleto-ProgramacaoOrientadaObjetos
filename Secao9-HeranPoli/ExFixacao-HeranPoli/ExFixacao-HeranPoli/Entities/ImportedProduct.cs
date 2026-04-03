namespace ExFixacao_HeranPoli.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return $"{Name}, $ {TotalPrice().ToString("f2")} (Customs fee: $ {CustomsFee.ToString("f2")})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}