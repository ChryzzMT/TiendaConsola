namespace TiendaConsola;

public class Inventario
{
    private List<Producto> productos;
    private List<Producto> productosVendidos;

    public Inventario()
    {
        productos=new List<Producto>();
        productosVendidos = new List<Producto>();
    }
    

    public List<Producto> getProductoVendidos()
    {
        return productosVendidos;
    }
    public void AgregarProducto(string codigo ,string nombre,double precio, int cantidad, string descripcion,string tipo,string licencia)
    {
        Producto p = new Producto();
        if (tipo == "Fisico")
        {
            p = new ProductoFisico(codigo,nombre,descripcion,tipo,precio,cantidad);
        }else if (tipo == "Digital")
        { 
            p = new ProductoDigital(codigo, nombre, descripcion, tipo, precio, licencia);
        }
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

    public void ActualizarProducto(string cod,string NuevoNomb,double NuevoPrecio )
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].ObtenerCodigo() == cod)
            {
                productos[i].setNombre(NuevoNomb);
                productos[i].setPrecio(NuevoPrecio);
            }
        }
    }

    public void quitarCantidadInventario(int i, int cantParaRestar)
    {
        int nuevoStck = productos[i].getStock()- cantParaRestar;
        productos[i].setStock(nuevoStck);
    }

    public void devolverCantidad(string cod, int cantRestaurar)
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (cod == productos[i].ObtenerCodigo())
            {
                productos[i].setStock(productos[i].getStock()+cantRestaurar);
            }
        }
    }

    public void guardarProductosVendidos(List<Producto> carrito, List<int> cantVendida)
    {
        for (int i = 0; i < carrito.Count; i++)
        {
            Producto productoVendido = carrito[i];
            productosVendidos.Add(productoVendido);
        }
    }
    public List<Producto> GetInventario()
    {
        return productos;
    }
    /* public void agregarCantidad(string codigo, int cantidadExtra)
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].ObtenerCodigo() == codigo)
            {
                productos[i].setCantidad(productos[i].getCantidad()+cantidadExtra);
            }
        }
    }*/

}