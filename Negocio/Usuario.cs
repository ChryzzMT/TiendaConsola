namespace TiendaConsola;

public class Usuario
{
    private string usuario;
    private string password;
    private Rol rol;
    private string tipo;

    public string getNombreRol()
    {
        return rol.Nombre;
    }

    public Usuario(string usr, string pwd, string nombreRol, string t)
    {
        usuario = usr;
        password = pwd;
        rol = new Rol();
        rol.Nombre = nombreRol;
        tipo = t;
    }

    public string getTipo()
    {
        return tipo;
    }

public void setUsuario(string usr) { this.usuario = usr; }

    public void setPassword(string pwd) { this.password = pwd; }
    
    public void asignarRol(string nombreRol)
    {
        for(int i=0;i<rol.getRoles().Count;i++)
        {
            if (rol.getRoles()[i].Nombre == nombreRol)
            {
                rol.Nombre = nombreRol;
            }
        }
    }
    public string obtnUsuario() { return this.usuario; }
    
    public string obtnPassword() { return this.password; }
}