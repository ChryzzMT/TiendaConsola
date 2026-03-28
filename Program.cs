// See https://aka.ms/new-console-template for more information

using TiendaConsola;
//aqui se crean los nuevos roles, nuevos usuarios, anade nuevos productos
Rol rol = new Rol();
PresentacionTienda Tienda = new PresentacionTienda();
Login log = new Login();
Inventario invent = new Inventario();
Carrito carrito = new Carrito();
Compra comp = new Compra();
rol.crearRol("Administrador","Controla la tienda",true,true,true,true,true,true,true,true,false);
rol.crearRol("Cliente","Compra cosas en la tienda",false,false,false,false,false,false,false,false,true);

log.agregarUsuario("Enrique","enrique123","Administrador");
log.agregarUsuario("Luis","luis123","Cliente");

invent.AgregarProducto("5756","Detergente Omo 1kg       ",34.56,30);
invent.AgregarProducto("2389","Yogurt Sabor Frutilla 1kg",27.45,10);
invent.AgregarProducto("8947","Pasta Dental Colgate 100g",34.56,30);
invent.AgregarProducto("7283","Arroz 1kg                ",10.00,35);
invent.AgregarProducto("9137","Coca Cola 350ml          ",4.5,45);
invent.AgregarProducto("2381", "Papas Fritas 500g       ",15.67,24);


while (Tienda.cerrarTienda==false)
{
    Tienda.cerrarSesion = false;
    Usuario us1 = Tienda.IniciarSesion(log);
    while (Tienda.cerrarSesion == false)
    {
        Tienda.MostrarTienda(invent,log,us1,carrito);
    }
}





