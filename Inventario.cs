namespace TiendaConsola;

public class Inventario
{
    public List<Producto> productos;

    public void AgregarProducto(Producto p)
    {
        productos.Add(p);
    }
    public void MostrarProductos()
    {
        foreach (Producto p in productos)
        {
            Console.WriteLine(p.ObtenerCodigo());
            Console.WriteLine(p.ObtenerNombre());
            Console.WriteLine(p.ObtenerPrecio());
        }
    }

    public List<Producto> ObtenerProductos()
    {
        return productos;
    }

}