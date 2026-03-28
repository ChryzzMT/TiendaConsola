namespace TiendaConsola;

public class Carrito
{
    private List<Producto> carrito = new List<Producto>();
    private List<int> ListaCantidad = new List<int>();

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
            if (inventario.GetInventario()[i].ObtenerNombre()==nombre)
            {
                carrito.Add(inventario.GetInventario()[i]);
                ListaCantidad.Add(cantidad);
                inventario.actualizarStock(i,cantidad);
            }
        }
    }

    public void EliminarDelCarrito(string nombre,Inventario inv)
    {
        for (int i = 0; i < carrito.Count; i++)
        {
            if (carrito[i].ObtenerNombre() == nombre)
            {
                inv.restaurarStock(carrito[i].ObtenerCodigo(),ListaCantidad[i],inv);
                ListaCantidad.RemoveAt(i);
                carrito.RemoveAt(i);
                break;
            }
        }
    }

}