namespace TiendaConsola;

public class ProductoInventario
{
    private Producto producto;
    private int cantidad;

    public ProductoInventario(Producto p, int cant)
    {
        producto = p;
        cantidad = cant;
    }

    public Producto getProducto() { return producto; }
    public int getCantidad() { return cantidad; }

    public void setProducto(Producto p) { producto = p; }
    public void setCantidad(int c) { cantidad=c; }
}