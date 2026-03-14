namespace TiendaConsola;

public class Producto
{
    private string codigo;
    private string nombre;
    private double precio;

    public Producto(string codigo, string nombre, double precio)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
    }
    public string ObtenerCodigo() { return this.codigo; }
    public string ObtenerNombre() { return this.nombre; }
    public double ObtenerPrecio() { return this.precio; }
    
    
    
}