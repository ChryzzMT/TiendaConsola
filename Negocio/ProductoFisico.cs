namespace TiendaConsola;

public class ProductoFisico:Producto
{
    private int stock;

    public ProductoFisico(string codigo,string nombre,string descripcion,string tipo,double precio,int cant)
    {
        stock = cant;
        setCodigo(codigo);
        setNombre(nombre);
        setPrecio(precio);
        setTipo(tipo);
        setDescripcion(descripcion);
    }

    public override bool validacion(string l, int c)
    {
        if (c > stock)
        {
            return false;
        }

        return true;
    }

    public override void setStock(int c)
    {
        stock = c;
    }

    public override int getStock()
    {
        return stock;
    }
}