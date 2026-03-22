namespace TiendaConsola;

public class Rol
{
    private string Nombre { get; set; }
    private string Descripcion { get; set; }
    private Privilegios Privilegios;

    private List<Rol> roles { get; set; }

    public string getNombreRol()
    {
        return Nombre;
    }

    public Rol()
    {
        return;
    }
    public Rol(string nb, string dsc,bool listarProductos, bool crearProducto, bool actualizarProducto, bool eliminarProducto,bool listarUsuarios, bool crearUsuario, bool actualizarUsuario, bool eliminarUsuario )
    {
        Privilegios = new Privilegios(listarProductos,crearProducto, actualizarProducto, eliminarProducto, listarUsuarios, crearUsuario, actualizarUsuario, eliminarUsuario);
        this.Nombre = nb;
        this.Descripcion = dsc;
    }

    public void crearRol(string nb, string dsc,bool listarProductos, bool crearProducto, bool actualizarProducto, bool eliminarProducto,bool listarUsuarios, bool crearUsuario, bool actualizarUsuario, bool eliminarUsuario)
    {
        Rol r = new Rol(nb, dsc, listarProductos, crearProducto, actualizarProducto, eliminarProducto, listarUsuarios,
            crearUsuario, actualizarUsuario, eliminarUsuario);
        roles.Add(r);
    }

    public Rol asignarRol(string nombreRol)
    {
        foreach (Rol r in roles)
        {
            if (r.Nombre == nombreRol)
            {
                return r;
            }
            
        }

        return null;
    }
    
}