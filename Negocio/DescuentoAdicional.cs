namespace TiendaConsola;

public class DescuentoAdicional:Descuento
{
    private double MontoActivacion;

    public DescuentoAdicional()
    {
        setPorcentajeDesc(0.05);
        MontoActivacion = 500;
    }

    public override double AplicarDesc(double monto)
    {
        if (monto > MontoActivacion)
        {
            return monto * getPorcentajeDesc();
        }
        return monto;
    }

    public void setMontoActivacion(double m)
    {
        MontoActivacion = m;
    }
}