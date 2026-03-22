// See https://aka.ms/new-console-template for more information

using TiendaConsola;
//aqui se crean los nuevos roles, nuevos usuarios, anade nuevos productos
Rol Rol = new Rol();
Rol.crearRol();

PresentacionTienda tienda = new PresentacionTienda();
tienda.iniciarSesion();
Usuario usuario=new Usuario()
