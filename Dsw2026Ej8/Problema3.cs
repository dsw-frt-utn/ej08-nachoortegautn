namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            
            int valorCopia = originalValue;

            
            valorCopia++;

            
            Product productoCopiado = product;

            
            productoCopiado.ModificarDescripcion("Producto Modificado");

            // 5. Retornar: valorOriginal-valorCopia-descripcionProducto
            return $"{originalValue}-{valorCopia}-{product.Description}";
        }
    }
}
