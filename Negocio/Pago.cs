namespace TiendaConsola;

public class Pago
{
    private double monto;
    private string tipo;

    public Pago(double m,string t)
    {
        monto = m;
        tipo = t;
    }

    public Pago()
    {
        
    }

    public virtual void procesarPago()
    {
    }

    public string getTipo()
    {
        return tipo;
    }
}