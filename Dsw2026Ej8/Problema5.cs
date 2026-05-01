namespace Dsw2026Ej8
{
    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            // Polimorfismo: se ejecuta el método de la clase real
            return sale.CalculateTotal();
        }
    }
}
