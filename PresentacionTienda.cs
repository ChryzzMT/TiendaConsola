namespace TiendaConsola;

public class PresentacionTienda
{
   private Inventario Inventario;
   private Login login;

   public PresentacionTienda()
   {
      Inventario = new Inventario();
      login=new Login()
      
   }

   public void MostrarStock()
   {
      foreach (Producto p in Inventario.GetInventario())
      {
         Console.WriteLine(p.ObtenerCodigo());
         Console.WriteLine(p.ObtenerNombre());
         Console.WriteLine(p.ObtenerPrecio());
      }
   }

   public void MostrarTienda()
   {
      int opcion=0;
      
      
      while (opcion != 2)
      {
         Console.WriteLine("Opciones: ");
         Console.WriteLine("1. Mostrar Productos");
         Console.WriteLine("2. Salir");
         opcion = int.Parse(Console.ReadLine());
         
         if (opcion == 1)
         {
            Console.WriteLine("MOSTRANDO PRODCUTOS");
            MostrarStock();
         }
         
      }

      Console.WriteLine("Saliste de la Tienda");
      return;
   }
   public bool iniciarSesion()
   {
      Console.Write("Ingrese sus datos para iniciar sesion: ");
      
   }
}