namespace TiendaConsola;

public class Inventario
{
    public List<Producto> productos = new List<Producto>();
    public void AgregarProducto(Producto p)
    {
        productos.Add(p);
    }

    public void EliminarProducto(Producto p)
    {
        productos.Remove(p);
    }

    public void ActualizarProducto(string cod,string nomb,double pre )
    {
        foreach (Producto p in productos)
        {
            if (p.ObtenerCodigo() == cod)
            {
                p.setCodigo(cod);
                p.setNombre(nomb);
                p.setPrecio(pre);
            }   
        }
    }

    public List<Producto> ObtenerProductos()
    {
        return productos;
    }

}