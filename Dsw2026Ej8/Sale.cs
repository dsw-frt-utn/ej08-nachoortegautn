namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal Importe { get; set; }

        public virtual decimal CalculateTotal()
        {
            return Importe;
        }
    }

    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe;
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe * 0.9m;
        }
    }
}
