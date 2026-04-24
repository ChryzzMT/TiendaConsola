namespace TiendaConsola;

public class Carrito
{
    private List<Producto> carrito = new List<Producto>();
    private List<int> ListaCantidad = new List<int>();

    public Carrito()
    {
        carrito = new List<Producto>();
        ListaCantidad = new List<int>();
    }
    public List<int> getListaCantidad()
    {
        return ListaCantidad;
    }
    public List<Producto> getCarrito()
    {
        return carrito;
    }

    public void AgregarAlCarrito(Inventario inventario, string nombre, int cantidad)
    {
        for (int  i = 0; i < inventario.GetInventario().Count; i++)
        {
            if (inventario.GetInventario()[i].getProducto().ObtenerNombre()==nombre)
            {
                carrito.Add(inventario.GetInventario()[i].getProducto());
                ListaCantidad.Add(cantidad);
                inventario.quitarCantidadInventario(i,cantidad);
            }
        }
    }

    public void EliminarDelCarrito(string nombre,Inventario inv)
    {
        for (int i = 0; i < carrito.Count; i++)
        {
            if (carrito[i].ObtenerNombre() == nombre)
            {
                inv.devolverCantidad(carrito[i].ObtenerCodigo(),ListaCantidad[i]);
                ListaCantidad.RemoveAt(i);
                carrito.RemoveAt(i);
                break;
            }
        }
    }

}