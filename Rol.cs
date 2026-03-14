namespace TiendaConsola;

public class Rol
{
    private string nombre;
    private string descripcion;

    public Rol(string nb, string dsc)
    {
        this.nombre = nb;
        this.descripcion = dsc;
    }
    
    public string obtnNombre(){ return this.nombre; }
    public string obtnDescripcion(){ return this.descripcion; }
    
}