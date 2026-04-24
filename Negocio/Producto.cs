namespace TiendaConsola;

public class Producto
{
    private string codigo;
    private string nombre;
    private double precio;
    private string descripcion;

    public Producto(string codigo, string nombre, double precio,string descripcion)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
        this.descripcion = descripcion;
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
        precio = p;
    }

    public string getDescripcion() { return descripcion;}
    public string ObtenerCodigo() { return this.codigo; }
    public string ObtenerNombre() { return this.nombre; }
    public double ObtenerPrecio() { return this.precio; }
}