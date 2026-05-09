namespace TiendaConsola;

public class Compra
{
    private Descuento descuentoBase;
    private Descuento descuentoAdi;
    private string NombreCliente;
    private Pago pago;
    private double Total;
    private double subTotal;
    private Carrito carrito;
    
    public Compra(string n,Carrito c)
    {
        NombreCliente = n;
        carrito = c;
        descuentoAdi = new DescuentoAdicional();
        descuentoBase = new DescuentoBase();
        Total = 0;
    }
    public void sacarTotal(string nivelCliente)
    {
        Total = subTotal;
        if (nivelCliente == "VIP")
        {
            Total= Total-descuentoBase.AplicarDesc(Total);
        }
        Total = Total-descuentoAdi.AplicarDesc(Total);
    }
    public void sacarSubtotal()
    {
        subTotal = 0;
        for (int i = 0; i < carrito.getCarrito().Count; i++)
        {
            if (carrito.getCarrito()[i].getTipo() == "Digital")
            {
                subTotal = subTotal + carrito.getCarrito()[i].ObtenerPrecio();
            }
            else
            {
                subTotal = subTotal + (carrito.getListaCantidad()[i] * carrito.getCarrito()[i].ObtenerPrecio());
            }
        }
    }
    
    public string getNombreCompra() { return NombreCliente; }

    public void setMetodoPago(Pago p)
    {
        pago = p;
    }

    public string tipoPago()
    {
        return pago.getTipo();
    }
    public double getSubtotal() { return subTotal;}
    public double getTotal() { return Total;}
    public void setNombreCompra(string com) { NombreCliente = com; }


}