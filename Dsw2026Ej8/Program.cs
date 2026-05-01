using Dsw2026Ej8;


// ProductHelper helper = new ProductHelper();

// string etiqueta = helper.ObtenerEtiquetaProducto(101, "Teclado Mecánico", 15500.50m);


// Console.WriteLine(etiqueta); punto 1

//Problema2 p2 = new Problema2();
//Console.WriteLine(p2.CrearResumenVenta(1, "Producto Prueba", 10, 100));
// Debería imprimir: 1-Producto Prueba-1000 esto es del problema 2

//Product miProducto = new Product { Description = "Original" };
//Problema3 p3 = new Problema3();

//Console.WriteLine(p3.CompararCopias(10, miProducto));
// Debería imprimir: 10-11-Producto Modificado esto es del problema 3

//Problema4 p4 = new Problema4();
//Console.WriteLine(p4.CalcularPromedio(10, null, 8)); // Debería dar 9 (18 / 2)
// Console.WriteLine(p4.CalcularPromedio(10, null, null)); // Debería dar 0 esto es del problema 4

//Problema5 p5 = new Problema5();

//RetailSale minorista = new RetailSale { Importe = 100 };
//WholesaleSale mayorista = new WholesaleSale { Importe = 100 };

// Console.WriteLine($"Minorista: {p5.ObtenerImporteFinal(minorista)}"); // Debería dar 100
//Console.WriteLine($"Mayorista: {p5.ObtenerImporteFinal(mayorista)}"); // Debería dar 90 esto es del problema 5

Console.WriteLine("\n--- Problema 6 ---");
 Problema6 p6 = new Problema6();
 Console.WriteLine(p6.NormalizarCodigoProducto("  ab 123 x  "));