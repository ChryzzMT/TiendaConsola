namespace TiendaConsola;

public class Carrito
{
    private List<Producto> productos = new List<Producto>();
    
    public void MostrarCarrito()
    {
        foreach (Producto i in productos)
        {
            Console.WriteLine(i.nombre);
        }
    }
}