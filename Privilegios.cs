namespace TiendaConsola;

public class Privilegios
{
    private bool crearProducto;
    private bool EliminarProducto;
    private bool venderProducto;
    private bool crearUsuario;
    private bool EliminarUsuario;

    public bool obtnCrearProducto() { return crearProducto; }
    public bool obtnEliminarProducto() {return EliminarProducto; }
    public bool obtnVenderProducto() { return venderProducto; }
    public bool obtnCrearUsuario() { return crearUsuario; }
    public bool obtnEliminarUsuario() { return EliminarUsuario; }
}