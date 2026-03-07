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

   public void MostrarTienda()
   {
      int opcion;
      do
      {
         Console.WriteLine("Opciones: ");
         Console.WriteLine("1. Mostrar Productos");
         Console.WriteLine("2. Salir");
         opcion = Console.Read();
         if (opcion == 1)
         {
            MostrarStock();
         }

      } while (opcion != 2);
   }
}