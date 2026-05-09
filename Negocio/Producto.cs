namespace TiendaConsola;

public class Producto
{
    private string codigo;
    private string nombre;
    private double precio;
    private string descripcion;
    private string tipo;

    
    public Producto(string codigo, string nombre, double precio,string descripcion,string tipo)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
        this.descripcion = descripcion;
        this.tipo = tipo;
    }

    public virtual bool validacion(string l,int c)
    {
        return false;
    }
    public string getTipo() { return tipo; }

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

    public void setTipo(string t)
    {
        tipo = t;
    }

    public void setDescripcion(string d)
    {
        descripcion = d;
    }
    public string getDescripcion() { return descripcion;}
    
    public string ObtenerCodigo() { return this.codigo; }
    public string ObtenerNombre() { return this.nombre; }
    public double ObtenerPrecio() { return this.precio; }

    public virtual void setStock(int c) { }

    public virtual int getStock() { return 0; }

    public virtual string getLicencia() { return "No"; }
    public Producto()
    {
        
    }
}