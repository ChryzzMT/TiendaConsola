namespace TiendaConsola;

public class Inventario
{
    public List<Producto> productos;

    public Inventario()
    {
        productos=new List<Producto>();
    }
    public void AgregarProducto(string codigo ,string nombre,double precio, int stock)
    {
        Producto p = new Producto(codigo, nombre, precio,stock);
        productos.Add(p);
    }

    public void EliminarProducto(string codigo)
    {
        foreach (Producto i in productos)
        {
            if (i.ObtenerCodigo() == codigo)
            {
                productos.Remove(i);
            }
        }
        
    }

    public void ActualizarProducto(string cod,string NuevoNomb,double NuevoPrecio,int NuevoStck )
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].ObtenerCodigo() == cod)
            {
                productos[i].setNombre(NuevoNomb);
                productos[i].setPrecio(NuevoPrecio);
                productos[i].setStock(NuevoStck);
            }
        }
    }

    public void actualizarStock(int i, int cantParaRestar)
    {
        int nuevoStck = productos[i].ObtnerStock() - cantParaRestar;
        productos[i].setStock(nuevoStck);
    }

    public List<Producto> GetInventario()
    {
        return productos;
    }

}