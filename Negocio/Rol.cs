namespace TiendaConsola;

public class Rol
{
    public string Nombre;
    private string Descripcion;
    private Privilegios Privilegios;

    private List<Rol> roles=new List<Rol>();
    
    public List<Rol> getRoles()
    {
        return roles;
    }

    public Rol()
    {
        return;
    }
    public Rol(string nb, string dsc,bool listarProductos, bool crearProducto, bool actualizarProducto, bool eliminarProducto,bool listarUsuarios, bool crearUsuario, bool actualizarUsuario, bool eliminarUsuario,bool realizarCompra )
    {
        Privilegios = new Privilegios(listarProductos,crearProducto, actualizarProducto, eliminarProducto, listarUsuarios, crearUsuario, actualizarUsuario, eliminarUsuario,realizarCompra);
        this.Nombre = nb;
        this.Descripcion = dsc;
    }

    public void crearRol(string nb, string dsc,bool listarProductos, bool crearProducto, bool actualizarProducto, bool eliminarProducto,bool listarUsuarios, bool crearUsuario, bool actualizarUsuario, bool eliminarUsuario,bool realizarCompra)
    {
        Rol r = new Rol(nb, dsc, listarProductos, crearProducto, actualizarProducto, eliminarProducto, listarUsuarios, crearUsuario, actualizarUsuario, eliminarUsuario,realizarCompra);
        roles.Add(r);
    }
    
}