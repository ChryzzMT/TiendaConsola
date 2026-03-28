namespace TiendaConsola;

public class Producto
{
    private string codigo;
    private string nombre;
    private double precio;
    private int stock;

    public Producto(string codigo, string nombre, double precio,int stock)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
        this.stock = stock;
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

    public void setStock(int stock)
    {
        this.stock = stock;
    }
    public string ObtenerCodigo() { return this.codigo; }
    public string ObtenerNombre() { return this.nombre; }
    public double ObtenerPrecio() { return this.precio; }
    public int ObtnerStock() { return this.stock; }



}