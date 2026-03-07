namespace TiendaConsola;

public class Inventario
{
    public List<Producto> productos;
    public int tam;

    private Inventario()
    {
        productos = new List<Producto>();
        tam=0;
    }
    
    public void MostrarInventario()
    {
        foreach (Producto i in productos)
        {
            Console.WriteLine(i.nombre);
        }
    }

    public void AgregarProducto()
    {
        productos[tam].nombre=Console.ReadLine();
        productos[tam].codigo=Console.ReadLine();
        productos[tam].precio=double.Parse(Console.ReadLine());
    }
    
    List<Producto> getProductos()
    {
        return productos;
    }
}