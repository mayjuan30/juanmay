using TareaPizarron.core;

namespace TareaPizarron.application;

public class ArticuloService
{
    private List<Articulo> _articulos = new List<Articulo>();
    public void Agregar(Articulo nuevo) => _articulos.Add(nuevo);
    public List<Articulo> ObtenerTodos() => _articulos;
    public List<Articulo> ObtenerStockBajo() => _articulos.Where(a => a.Stock < 10).ToList();
}