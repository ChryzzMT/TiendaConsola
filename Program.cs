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

invent.AgregarProducto("5756","Detergente Omo",34.56,30," 1kg              ");
invent.AgregarProducto("2389","Yogurt Sabor Frutilla",27.45,10," 1kg       ");
invent.AgregarProducto("8947","Pasta Dental Colgate",34.56,30," 100 gramos ");
invent.AgregarProducto("7283","Arroz",10.00,35," 1 kilogramo               ");
invent.AgregarProducto("9137","Coca Cola",4.5,45," 350 ml                ");
invent.AgregarProducto("2381", "Papas Fritas",15.67,24," 500 gramos        ");


while (Tienda.cerrarTienda==false)
{
    Tienda.cerrarSesion = false;
    Usuario us1 = Tienda.IniciarSesion(log);
    while (Tienda.cerrarSesion == false)
    {
        Tienda.MostrarTienda(invent,log,us1,carrito);
    }
}





