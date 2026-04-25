namespace TiendaConsola;

public class PagoTarjeta:Pago
{
    private string numeroTarjeta;

    public PagoTarjeta(string numTar,double m,string t):base(m,t)
    {
        numeroTarjeta = numTar;
    }

    public override void procesarPago()
    {
        base.procesarPago();
    }
}