namespace TiendaConsola;

public class Descuento
{
    private double porcentajeDesc;
    
    public Descuento(double porcentDesc)
    {
        porcentajeDesc = porcentDesc;
    }
    public virtual double AplicarDesc(double monto)
    {
        return monto;
    }

    public void setPorcentajeDesc(double p)
    {
        porcentajeDesc = p;
    }

    public double getPorcentajeDesc()
    {
        return porcentajeDesc;
    }
    public Descuento(){ }
}