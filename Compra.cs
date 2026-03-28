namespace TiendaConsola;

public class Compra
{
    private string NombreCompra;
    private string MetodoPago;
    private double Total;
    private double subTotal;

    public void sacarTotal(Carrito carrit)
    {
        for (int i = 0; i < carrit.getCarrito().Count; i++)
        {
            Total = Total + (carrit.getCarrito()[i].ObtenerPrecio() * carrit.getListaCantidad()[i]);
        }
    }
    public void sacarSubtotal(Carrito carr)
    {
        for (int i = 0; i < carr.getCarrito().Count; i++)
        {
            subTotal = subTotal + (carr.getListaCantidad()[i] * carr.getCarrito()[i].ObtenerPrecio());
        }
    }
    public string getNombreCompra() { return NombreCompra; }

    public string getMetodoPago() { return MetodoPago;}
    public double getSubtotal() { return subTotal;}
    public double getTotal() { return Total;}
    public void setNombreCompra(string com) { NombreCompra = com; }
    public void setMetodoPago(string met) { MetodoPago = met; }


}