namespace TiendaConsola;

public class Privilegios
{
    private bool ListarProductos;
    private bool CrearProducto;
    private bool ActualizarProducto;
    private bool EliminarProducto;
    private bool ListarUsuarios;
    private bool CrearUsuario;
    private bool ActualizarUsuario;
    private bool EliminarUsuario;
    private bool RealizarCompra;

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
        RealizarCompra = false;
    }
    
    public Privilegios(bool listarProductos, bool crearProducto, bool actualizarProducto, bool eliminarProducto,bool listarUsuarios, bool crearUsuario, bool actualizarUsuario, bool eliminarUsuario,bool realizarCompra)
    {
        ListarProductos = listarProductos;
        CrearProducto = crearProducto;
        ActualizarProducto = actualizarProducto;
        EliminarProducto = eliminarProducto;
        ListarUsuarios = listarUsuarios;
        CrearUsuario = crearUsuario;
        ActualizarUsuario = actualizarUsuario;
        EliminarUsuario = eliminarUsuario;
        RealizarCompra = realizarCompra;
    }
}   
