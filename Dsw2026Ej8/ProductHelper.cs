namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private const string FormatoMoneda = "C";

        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return $"[{code}] {description} - {price.ToString(FormatoMoneda)}";
        }
    }
}
