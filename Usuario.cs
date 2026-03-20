namespace TiendaConsola;

public class Usuario
{
    private string usuario;
    private string password;
    public Usuario(string usr, string pwd)
    {
        this.usuario = usr;
        this.password = pwd;
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