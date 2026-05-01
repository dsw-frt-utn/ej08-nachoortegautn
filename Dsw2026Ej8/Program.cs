using Dsw2026Ej8;

// Instanciamos la clase que creaste
ProductHelper helper = new ProductHelper();

// Probamos el método con datos de ejemplo
string etiqueta = helper.ObtenerEtiquetaProducto(101, "Teclado Mecánico", 15500.50m);

// Mostramos el resultado en consola
Console.WriteLine(etiqueta);
