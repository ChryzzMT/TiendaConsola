namespace TiendaConsola;

public class Inventario
{
    private List<ProductoInventario> productos;
    private List<ProductoInventario> productosVendidos;

    public Inventario()
    {
        productos=new List<ProductoInventario>();
        productosVendidos = new List<ProductoInventario>();
    }
//metodo agregar mas cantidad a un producto
    public void agregarCantidad(string codigo, int cantidadExtra)
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].getProducto().ObtenerCodigo() == codigo)
            {
                productos[i].setCantidad(productos[i].getCantidad()+cantidadExtra);
            }
        }
    }

    public List<ProductoInventario> getProductoVendidos()
    {
        return productosVendidos;
    }
    public void AgregarProducto(string codigo ,string nombre,double precio, int cantidad, string descripcion)
    {
        Producto p = new Producto(codigo, nombre, precio,descripcion);
        ProductoInventario pi = new ProductoInventario(p, cantidad);
        productos.Add(pi);
    }

    public void EliminarProducto(string codigo)
    {
        for(int i=0;i<productos.Count;i++)
        {
            if (productos[i].getProducto().ObtenerCodigo() == codigo)
            {
                productos.Remove(productos[i]);
            }
        }
        
    }

    public void ActualizarProducto(string cod,string NuevoNomb,double NuevoPrecio )
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].getProducto().ObtenerCodigo() == cod)
            {
                productos[i].getProducto().setNombre(NuevoNomb);
                productos[i].getProducto().setPrecio(NuevoPrecio);
            }
        }
    }

    public void actualizarStock(int i, int cantParaRestar)
    {
        int nuevoStck = productos[i].getCantidad()- cantParaRestar;
        productos[i].setCantidad(nuevoStck);
    }

    public void devolverCantidad(string cod, int cantRestaurar)
    {
        for (int i = 0; i < productos.Count; i++)
        {
            if (cod == productos[i].getProducto().ObtenerCodigo())
            {
                productos[i].setCantidad(productos[i].getCantidad()+cantRestaurar);
            }
        }
    }

    public void guardarProductosVendidos(List<Producto> carrito, List<int> cantVendida)
    {
        for (int i = 0; i < carrito.Count; i++)
        {
            ProductoInventario productoVendido = new ProductoInventario(carrito[i],cantVendida[i]);
            productosVendidos.Add(productoVendido);
        }
    }
    public List<ProductoInventario> GetInventario()
    {
        return productos;
    }

}