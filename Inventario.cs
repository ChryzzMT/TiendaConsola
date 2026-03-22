namespace TiendaConsola;

public class Inventario
{
    public List<Producto> productos;

    public Inventario()
    {
        productos=new List<Producto>();
    }
    public void AgregarProducto(string codigo ,string nombre,double precio, int stock)
    {
        Producto p = new Producto(codigo, nombre, precio,stock);
        productos.Add(p);
    }

    public void EliminarProducto(string codigo)
    {
        foreach (Producto i in productos)
        {
            if (i.ObtenerCodigo() == codigo)
            {
                productos.Remove(i);
            }
        }
        
    }

    public void ActualizarProducto(string cod,string nomb,double pre,int stck )
    {
        foreach (Producto p in productos)
        {
            if (p.ObtenerCodigo() == cod)
            {
                p.setCodigo(cod);
                p.setNombre(nomb);
                p.setPrecio(pre);
                p.setStock(stck);
            }   
        }
    }

    public List<Producto> GetInventario()
    {
        return productos;
    }

}