namespace TiendaConsola;

public class Login
{
    private List<Usuario> usuarios;

    public Login()
    {
        usuarios = new List<Usuario>();
    }

    public void agregarUsuario(string usr, string pwd, string nR)
    {
        Usuario us = new Usuario(usr, pwd,nR);
        usuarios.Add(us);
    }
    public void eliminarUsuario(string usr, string pwd)
    {
        foreach (Usuario ui in usuarios)
        {
            if (verifUsuario(ui.obtnUsuario(), ui.obtnPassword()))
            {
                usuarios.Remove(ui);
            }
        }
    }

    public void actualizarUsuario(string usr, string pwd, string nuevoUsuario,string nuevoPassword)
    {
        foreach (Usuario ui in usuarios)
        {
            if (verifUsuario(ui.obtnUsuario(), ui.obtnPassword()))
            {
                ui.setUsuario(nuevoUsuario);
                ui.setPassword(nuevoPassword);
            }
        }
    }
    public bool verifUsuario(string usr, string pwd)
    {
        foreach(Usuario ui in usuarios)
            if (ui.obtnUsuario() == usr && ui.obtnPassword()==pwd)
            {
                return true;
            }
        return false;
    }
}