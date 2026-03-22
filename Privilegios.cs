namespace TiendaConsola;

public class Privilegios
{
    private bool ListarProductos { get; set; }
    private bool CrearProducto { get; set; }
    private bool ActualizarProducto { get; set; }
    private bool EliminarProducto { get; set; }
    private bool ListarUsuarios { get; set; }
    private bool CrearUsuario { get; set; }
    private bool ActualizarUsuario { get; set; }
    private bool EliminarUsuario { get; set; }

    public Privilegios()
    {
        ListarProductos = false;
        CrearProducto = false;
        ActualizarProducto = false;
        EliminarProducto = false;
        ListarUsuarios = false;
        CrearUsuario = false;
        ActualizarUsuario = false;
        EliminarUsuario = false;
    }
    
    public Privilegios(bool listarProductos, bool crearProducto, bool actualizarProducto, bool eliminarProducto,bool listarUsuarios, bool crearUsuario, bool actualizarUsuario, bool eliminarUsuario )
    {
        ListarProductos = listarProductos;
        CrearProducto = crearProducto;
        ActualizarProducto = actualizarProducto;
        EliminarProducto = eliminarProducto;
        ListarUsuarios = listarUsuarios;
        CrearUsuario = crearUsuario;
        ActualizarUsuario = actualizarUsuario;
        EliminarUsuario = eliminarUsuario;
    }
}   
