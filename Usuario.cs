namespace TiendaConsola;

public class Usuario
{
    private string usuario;
    private string password;
    private Rol rol;

    public Usuario(string usr, string pwd, string nombreRol)
    {
        usuario = usr;
        password = pwd;
        rol= new Rol();
        rol.asignarRol(nombreRol);
    }

    public void setUsuario(string usr)
    {
        this.usuario = usr;
    }

    public void setPassword(string pwd)
    {
        this.password = pwd;
    }

    public string obtnUsuario()
    {
        return this.usuario;
    }
    
    public string obtnPassword()
    {
        return this.password;
    }
}