
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class AdministradorEN                    :                           SanurGenNHibernate.EN.Sanur.UsuarioEN


{
public AdministradorEN() : base ()
{
}



public AdministradorEN(int idUsuario, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.init (idUsuario, nombre, contrasena, iniciado, email, apellidos);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (administrador.IdUsuario, administrador.Nombre, administrador.Contrasena, administrador.Iniciado, administrador.Email, administrador.Apellidos);
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
        AdministradorEN t = obj as AdministradorEN;
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
