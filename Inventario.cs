namespace TiendaConsola;

public class Inventario
{
    public List<Producto> productos;

    public Inventario()
    {
        productos=new List<Producto>();
    }
    public void AgregarProducto(string codigo ,string nombre,double precio, int stock, string descripcion)
    {
        Producto p = new Producto(codigo, nombre, precio,stock,descripcion);
        productos.Add(p);
    }

    public void EliminarProducto(string codigo)
    {
        for(int i=0;i<productos.Count;i++)
        {
            if (productos[i].ObtenerCodigo() == codigo)
            {
                productos.Remove(productos[i]);
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

    public void restaurarStock(string cod, int cantRestaurar,Inventario inv)
    {
        for (int i = 0; i < inv.GetInventario().Count; i++)
        {
            if (cod == inv.GetInventario()[i].ObtenerCodigo())
            {
                inv.GetInventario()[i].setStock(inv.GetInventario()[i].ObtnerStock()+cantRestaurar);
            }
        }
    }

    public List<Producto> GetInventario()
    {
        return productos;
    }

}