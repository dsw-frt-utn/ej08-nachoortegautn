namespace Dsw2026Ej8
{
    public class Problema6
    {
        public string NormalizarCodigoProducto(string? code)
        {
            // Llamamos al método de extensión que creamos en Extensions.cs
            return code.ToProductCode();
        }
    }
}
