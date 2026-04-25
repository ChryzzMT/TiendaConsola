namespace TiendaConsola;

public class Login
{
    public List<Usuario> usuarios;

    public Login()
    {
        usuarios = new List<Usuario>();
    }
    
    public void agregarUsuario(string usr, string pwd, string nR,string t)
    {
        Usuario us = new Usuario(usr, pwd,nR,t);
        usuarios.Add(us);
    }

    public List<Usuario> GetListaUsuarios()
    {
        return usuarios;
    }
    public void eliminarUsuario(string usr, string pwd)
    {
        for (int i = 0; i < usuarios.Count; i++)
        {
            if (usuarios[i].obtnUsuario() == usr && usuarios[i].obtnPassword() == pwd)
            {
                usuarios.RemoveAt(i);
            }
        }
    }

    public void actualizarUsuario(string usr, string pwd, string nuevoUsuario,string nuevoPassword)
    {
        for (int i = 0; i < usuarios.Count; i++)
        {
            if (usuarios[i].obtnUsuario() == usr && usuarios[i].obtnPassword() == pwd)
            {
                usuarios[i].setUsuario(nuevoUsuario);
                usuarios[i].setPassword(nuevoPassword);
            }
        }
    }
    public bool verifUsuario(string usr, string pwd)
    {
        for (int i = 0; i < usuarios.Count; i++)
        {
            if (usuarios[i].obtnUsuario() == usr && usuarios[i].obtnPassword() == pwd)
            {
                return true;
            }
        }
        return false;
    }
}