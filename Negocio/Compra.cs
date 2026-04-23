namespace TiendaConsola;

public class Compra
{
    private string NombreCliente;
    private string MetodoPago;
    private double Total;
    private double subTotal;
    private Carrito carrito;
    
    public Compra(string n,string mp,Carrito c)
    {
        NombreCliente = n;
        MetodoPago = mp;
        carrito = c;
    }
    public void sacarTotal()
    {
        for (int i = 0; i < carrito.getCarrito().Count; i++)
        {
            Total = Total + (carrito.getCarrito()[i].ObtenerPrecio() * carrito.getListaCantidad()[i]);
        }
    }
    public void sacarSubtotal()
    {
        for (int i = 0; i < carrito.getCarrito().Count; i++)
        {
            subTotal = subTotal + (carrito.getListaCantidad()[i] * carrito.getCarrito()[i].ObtenerPrecio());
        }
    }
    public string getNombreCompra() { return NombreCliente; }

    public string getMetodoPago() { return MetodoPago;}
    public double getSubtotal() { return subTotal;}
    public double getTotal() { return Total;}
    public void setNombreCompra(string com) { NombreCliente = com; }
    public void setMetodoPago(string met) { MetodoPago = met; }


}