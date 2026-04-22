namespace TiendaConsola;

public class PresentacionTienda
{
   private bool cerrarSesion;
   private bool cerrarTienda;

   public PresentacionTienda()
   {
      cerrarSesion = false;
      cerrarTienda = false;
   }
   public void setCerrarSesion(bool b) { cerrarSesion = b;}
   public bool getCerrarSesion() { return cerrarSesion;}
   public void setCerrarTienda(bool b) { cerrarTienda = b;}
   public bool getCerrarTienda() { return cerrarTienda;}
   public void MostrarProductosDisponibles(Inventario inventario)
   {     
      Console.WriteLine(" ");
      Console.WriteLine("LOS PRODUCTOS DISPONIBLES SON: ");
      for(int i=0;i<inventario.GetInventario().Count; i++)
      {
         if (inventario.GetInventario()[i].getCantidad() > 0)
         {
            Console.Write(inventario.GetInventario()[i].getProducto().ObtenerNombre());
            Console.Write(inventario.GetInventario()[i].getProducto().getDescripcion());
            Console.Write("        ");
            Console.Write("PRECIO:");
            Console.Write(inventario.GetInventario()[i].getProducto().ObtenerPrecio());
            Console.Write("        ");
            Console.Write("CANTIDAD:");
            Console.Write(inventario.GetInventario()[i].getCantidad());
            Console.WriteLine(" ");

         }
      }
      Console.WriteLine(" ");
   }
   public void ListarProductos(Inventario inventario)
   {
      for(int i=0;i<inventario.GetInventario().Count; i++)
      {
         Console.Write(inventario.GetInventario()[i].getProducto().ObtenerCodigo());
         Console.Write("        ");
            Console.Write(inventario.GetInventario()[i].getProducto().ObtenerNombre());
            Console.Write("        ");
            Console.Write("PRECIO:");
            Console.Write(inventario.GetInventario()[i].getProducto().ObtenerPrecio());
            Console.Write("        ");
            Console.Write("CANTIDAD:");
            Console.Write(inventario.GetInventario()[i].getCantidad());
            Console.WriteLine(" ");
      }
     
   }
   
   public void MostrarTienda(Inventario inventario, Login Log,Usuario us,Carrito carrit)
   {
      int opcion=0;
      if (us.getNombreRol() == "Administrador")
      {  
         Console.WriteLine("======== PANTALLA DE INICIO ========");
         Console.WriteLine("1. Listar Productos");
         Console.WriteLine("2. Agregar Producto");
         Console.WriteLine("3. Actualizar Producto");
         Console.WriteLine("4. eliminar Producto");
         Console.WriteLine("5. Listar Usuarios");
         Console.WriteLine("6. Agregar usuario");
         Console.WriteLine("7. Actualizar Usuario");
         Console.WriteLine("8. Eliminar Usuario");
         Console.WriteLine("9. Cerrar Sesion");
         Console.WriteLine("10. Cerrar Tienda");
         Console.WriteLine("11. Ver Ventas");
         Console.WriteLine(" ");
         opcion=int.Parse(Console.ReadLine());
         switch (opcion)
         {
            case 1 :
               ListarProductos(inventario); break;
            case 2:
               Console.Write("Introduzca el codigo del producto: ");
               string codigo = Console.ReadLine();
               Console.Write("Introduzca el nombre del producto: ");
               string nombre = Console.ReadLine();
               Console.Write("Introduzca el precio del producto: ");
               double precio = double.Parse(Console.ReadLine());
               Console.Write("Introduzca la cantidad del producto: ");
               int stock = int.Parse(Console.ReadLine());
               Console.Write("Introduzca una descripcion del producto: ");
               string descripcion = Console.ReadLine();
               inventario.AgregarProducto(codigo, nombre, precio, stock,descripcion);
               break;
            case 3:
               Console.Write("Introduzca el codigo del producto: ");
               string Codigo = Console.ReadLine();
               Console.Write("Introduzca el nuevo nombre del producto: ");
               string nuvNombre = Console.ReadLine();
               Console.Write("Introduzca el nuevo precio del producto: ");
               double nuvPrecio = double.Parse(Console.ReadLine());
               inventario.ActualizarProducto(Codigo,nuvNombre,nuvPrecio);
               break;
            case 4:
               Console.Write("Introduzca el codigo del producto: ");
               string cod = Console.ReadLine();
               inventario.EliminarProducto(cod);
               Console.Write("Se elimino el producto con codigo ");
               Console.Write(cod);
               break;
            case 5 :
               ListarUsuarios(Log.GetListaUsuarios());
               break;
            case 6:
               Console.Write("Introduzca el nombre del nuevo usuario: ");
               string usr = Console.ReadLine();
               Console.Write("Introduzca el password del nuevo usuario: ");
               string pwd = Console.ReadLine();
               Console.Write("Introduzca el rol del nuevo usuario: ");
               string nombRol = Console.ReadLine();
               Log.agregarUsuario(usr,pwd,nombRol);
               break;
            case 7:
               Console.Write("Introduzca el usuario: ");
               string usrr = Console.ReadLine();
               Console.Write("Introduzca el password: ");
               string pawd = Console.ReadLine();
               Console.Write("Introduzca el nuevo usuario: ");
               string nuevoUsr = Console.ReadLine();
               Console.Write("Introduzca el nuevo password: ");
               string nuevoPwd = Console.ReadLine();
               Log.actualizarUsuario(usrr,pawd,nuevoUsr,nuevoPwd);
               break;
            case 8 :
               Console.Write("Introduzca el usuario para eliminar: ");
               string usuar = Console.ReadLine();
               Console.Write("Introduzca el password: ");
               string paswd = Console.ReadLine();
               Log.eliminarUsuario(usuar,paswd);
               break;
            case 9 :
               cerrarSesion = true;
               Console.WriteLine("Se cerro la sesion");
               break;
            case 10 :
               cerrarSesion = true;
               cerrarTienda = true;
               Console.WriteLine("Se cerro la tienda");
               break;
            case 11:
               verVentas(inventario);
               break;
         }
         Console.WriteLine(" ");
      }else if (us.getNombreRol() == "Cliente")
      {
         opcion = 0;
         Console.WriteLine("======== PANTALLA DE INICIO ========= ");
         Console.WriteLine("1. Ver productos");
         Console.WriteLine("2. Realizar compra");
         Console.WriteLine("3. Cerrar sesion");
         Console.WriteLine("4. Cerrar Tienda");
         
         opcion = int.Parse(Console.ReadLine());
         switch (opcion)
         {
            case 1:
               MostrarProductosDisponibles(inventario);
               break;
            case 2:
               RealizarCompra(inventario,carrit);
               break;
            case 3 :
               cerrarSesion = true;
               Console.WriteLine("Se cerro la sesion");
               break;
            case 4 :
               cerrarSesion = true;
               cerrarTienda = true;
               Console.WriteLine("La tienda cerro");
               break;
         }

      }
      return;
   }

   public void ListarUsuarios(List<Usuario> u)
   {
      for (int i = 0;i<u.Count ; i++)
      {
         Console.Write(u[i].obtnUsuario());
         Console.Write("        ");
         Console.Write(u[i].getNombreRol());
         Console.WriteLine(" ");
      }
   }
   public void MostrarCarrito(Carrito c)
   {
      Console.WriteLine("<-=-=-=-=-= LOS PRODUCTOS QUE VA A COMPRAR SON =-=-=-=-=-=->");
      for (int i = 0; i < c.getCarrito().Count; i++)
      {
         Console.Write(c.getCarrito()[i].ObtenerNombre());
         Console.Write("      EL PRECIO ES DE:");
         Console.Write(c.getCarrito()[i].ObtenerPrecio());
         Console.Write("      LA CANTIDAD ES DE:");
         Console.Write(c.getListaCantidad()[i]);
         Console.Write("      EL SUBTOTAL ES DE:");
         double subtotalIndividual = c.getListaCantidad()[i] * c.getCarrito()[i].ObtenerPrecio();
         Console.WriteLine(subtotalIndividual);// saca el subtotal de cada producto
      }
      Console.WriteLine("<-=-=-=-=-==================================== =-=-=-=-=-=->");
   }

   public void RealizarCompra(Inventario i,Carrito c)
   {
      Compra compra = new Compra();

      bool acabarCarrito = false;
      while (acabarCarrito == false)
      {
         MostrarProductosDisponibles(i);
         Console.WriteLine("~~~~~~~ SELECCIONE PARA CONTINUAR CON SU COMPRA ~~~~~~~~~");
         Console.WriteLine("1.Agregar producto Al carrito");
         Console.WriteLine("2.Eliminar Producto Del carrito");
         Console.WriteLine("3.Mostrar Productos Disponibles");
         Console.WriteLine("4.Mostrar Carrito");
         Console.WriteLine("5.Acabar Carrito");
         int opc = int.Parse(Console.ReadLine());
         switch (opc)
         {
            case 1:
               Console.Write("Ingrese el nombre del producto para agregar al carrito: ");
               string prodAgregar = Console.ReadLine();
               Console.Write("Ingrese la cantidad del producto para agregar al carrito: ");
               int cant = int.Parse(Console.ReadLine());
               c.AgregarAlCarrito(i,prodAgregar,cant);
               break;
            case 2 :
               MostrarCarrito(c);
               Console.Write("Introduzca el nombre del producto para eliminar: ");
               string nomb = Console.ReadLine();
               c.EliminarDelCarrito(nomb,i);
               break;
            case 3:
               MostrarProductosDisponibles(i);
               break;
            case 4:
               MostrarCarrito(c);
               break;
            case 5:
               acabarCarrito = true;
               break;
         }
      }
         Console.WriteLine("<<<<<<< INGRESE DATOS PARA LA COMPRA >>>>>>> ");
         Console.Write("Nombre para la compra: ");
         string nombreCompra = Console.ReadLine();
         Console.Write("Metodo de pago: ");
         string metodoPago = Console.ReadLine();
         compra.setMetodoPago(metodoPago);
         compra.setNombreCompra(nombreCompra);
         MostrarCompra(c,compra);
         i.guardarProductosVendidos(c.getCarrito(),c.getListaCantidad());
   }

   public void MostrarCompra(Carrito c,Compra compra)
   {
      Console.WriteLine(" ");
      Console.WriteLine("******* LOS DATOS PARA LA COMPRA SON ******* ");
      Console.Write("Nombre:");
      Console.WriteLine(compra.getNombreCompra());
      Console.Write("El metodo de pago es: ");
      Console.WriteLine(compra.getMetodoPago());
      
      MostrarCarrito(c);
      compra.sacarSubtotal(c);
      compra.sacarTotal(c);
      Console.Write("El SUBTOTAL ES DE: ");
      Console.WriteLine(compra.getSubtotal());
      Console.Write("El TOTAL es de: ");
      Console.WriteLine(compra.getTotal());
      Console.WriteLine(" ");
   }
   public Usuario IniciarSesion(Login l)
   {
      bool valid = false;
      while (valid==false)
      {
         Console.WriteLine("=) []------[ INICIO DE SESION ]--------[] =)");
         Console.Write("Ingrese su usuario: ");
         string usr = Console.ReadLine();
         Console.Write("Ingrese su contrasena: ");
         string pwd = Console.ReadLine();
         
         for (int i = 0; i < l.usuarios.Count; i++)
         {
            if (l.GetListaUsuarios()[i].obtnUsuario() == usr && l.GetListaUsuarios()[i].obtnPassword() == pwd)
            {
               Console.Write("BIENVENIDO ");
               Console.WriteLine(l.GetListaUsuarios()[i].obtnUsuario());
               Console.WriteLine("        ");
               return l.GetListaUsuarios()[i];
            }
         }
      }
      return null;
   }

   public void verVentas(Inventario inv)
   {
      if (inv.getProductoVendidos() == null)
      {
         Console.Write("NO SE VENDEIRON PRODUCTOS TODAVIA");
         return;
      }
      Console.WriteLine("LOS PRODUCTOS QUE SE VENDIERON SON: ");
      double Total = 0;
      for (int i = 0; i < inv.getProductoVendidos().Count; i++)
      {
         Console.Write(inv.getProductoVendidos()[i].getProducto().ObtenerNombre());
         Console.Write("       ");
         Console.Write("CANTIDAD: ");
         Console.Write(inv.getProductoVendidos()[i].getCantidad());
         Console.Write("    PRECIO: ");
         Console.Write(inv.getProductoVendidos()[i].getProducto().ObtenerPrecio());
         Console.Write("    SUBTOTAL: "); 
         Total=Total+ inv.getProductoVendidos()[i].getProducto().ObtenerPrecio()*inv.getProductoVendidos()[i].getCantidad();
         Console.Write(Total);
         Console.WriteLine(" ");
      }
      Console.Write("TOTAL DE LAS VENTAS: ");
      Console.Write(Total);
   }
   
}