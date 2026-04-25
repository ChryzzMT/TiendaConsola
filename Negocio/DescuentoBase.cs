namespace TiendaConsola;

public class DescuentoBase:Descuento
{
    public DescuentoBase()
    {
        setPorcentajeDesc(0.1);
    }
    public override double AplicarDesc(double monto)
    {
        return getPorcentajeDesc() * monto;
    }
}