namespace TiendaConsola;

public class ProductoDigital:Producto
{
    private string licencia;

    public ProductoDigital(string codigo,string nombre,string descripcion,string tipo,double precio,string lic)
    {
        licencia = lic;
        setCodigo(codigo);
        setNombre(nombre);
        setPrecio(precio);
        setTipo(tipo);
        setDescripcion(descripcion);
        
    }

    public override bool validacion(string l, int c)
    {
        if (l == licencia)
        {
            return true;
        }

        return false;
    }

    public override string getLicencia()
    {
        return licencia;
    }
}