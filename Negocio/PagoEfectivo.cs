namespace TiendaConsola;

public class PagoEfectivo:Pago
{
    public PagoEfectivo(double m,string t):base(m,t)
    {
        
    }
    public override void procesarPago()
    {
        base.procesarPago();
    }
}