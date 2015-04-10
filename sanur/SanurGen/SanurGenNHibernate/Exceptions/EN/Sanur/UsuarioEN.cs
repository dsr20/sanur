
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class UsuarioEN
{
/**
 *
 */

private int idUsuario;

/**
 *
 */

private string nombre;

/**
 *
 */

private String contrasena;

/**
 *
 */

private bool iniciado;

/**
 *
 */

private string email;

/**
 *
 */

private string apellidos;





public virtual int IdUsuario {
        get { return idUsuario; } set { idUsuario = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual String Contrasena {
        get { return contrasena; } set { contrasena = value;  }
}


public virtual bool Iniciado {
        get { return iniciado; } set { iniciado = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}





public UsuarioEN()
{
}



public UsuarioEN(int idUsuario, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.init (idUsuario, nombre, contrasena, iniciado, email, apellidos);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.IdUsuario, usuario.Nombre, usuario.Contrasena, usuario.Iniciado, usuario.Email, usuario.Apellidos);
}

private void init (int idUsuario, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.IdUsuario = idUsuario;


        this.Nombre = nombre;

        this.Contrasena = contrasena;

        this.Iniciado = iniciado;

        this.Email = email;

        this.Apellidos = apellidos;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (IdUsuario.Equals (t.IdUsuario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdUsuario.GetHashCode ();
        return hash;
}
}
}
