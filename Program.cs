using TareaPizarron.core;
using TareaPizarron.application;

var service = new ArticuloService();

// Caso de Uso: Agregar
service.Agregar(new Articulo { Nombre = "Laptop", Sku = "L01", Stock = 5 });
service.Agregar(new Articulo { Nombre = "Mouse", Sku = "M05", Stock = 15 });

// Caso de Uso: Consultar todos
Console.WriteLine("--- TODOS LOS ARTICULOS ---");
foreach(var a in service.ObtenerTodos()) Console.WriteLine($"{a.Nombre} | Stock: {a.Stock}");

// Caso de Uso: Stock bajo
Console.WriteLine("\n--- STOCK BAJO ---");
foreach(var a in service.ObtenerStockBajo()) Console.WriteLine($"Alerta: {a.Nombre}");