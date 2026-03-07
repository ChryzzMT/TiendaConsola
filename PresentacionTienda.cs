namespace TiendaConsola;

public class PresentacionTienda
{
   private Inventario Inventario;

   public PresentacionTienda(Inventario Inventario)
   {
      this.Inventario = Inventario;
   }

   public void MostrarStock()
   {
      foreach (Producto p in Inventario.ObtenerProductos())
      {
         Console.WriteLine(p.ObtenerCodigo());
         Console.WriteLine(p.ObtenerNombre());
         Console.WriteLine(p.ObtenerPrecio());
      }
   }
}