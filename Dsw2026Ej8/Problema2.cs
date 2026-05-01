namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            // Calculamos el total con la condición de cantidad
            decimal totalCalculado = quantity > 0 ? quantity * unitPrice : 0;

            // Creamos la clase anónima con los nombres requeridos
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalculado
            };

            // Retornamos la cadena formateada
            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}
