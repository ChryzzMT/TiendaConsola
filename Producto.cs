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

    public void setCodigo(string c)
    {
        this.codigo=c;
    }

    public void setNombre(string n)
    {
        this.nombre=n;
    }

    public void setPrecio(double p)
    {
        this.precio = p;
    }
    public string ObtenerCodigo() { return this.codigo; }
    public string ObtenerNombre() { return this.nombre; }
    public double ObtenerPrecio() { return this.precio; }
    
    
    
}