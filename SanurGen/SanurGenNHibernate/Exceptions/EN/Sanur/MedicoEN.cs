
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class MedicoEN                   :                           SanurGenNHibernate.EN.Sanur.UsuarioEN


{
/**
 *
 */

private SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum especialidad;





public virtual SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum Especialidad {
        get { return especialidad; } set { especialidad = value;  }
}





public MedicoEN() : base ()
{
}



public MedicoEN(int idUsuario, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum especialidad, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.init (idUsuario, especialidad, nombre, contrasena, iniciado, email, apellidos);
}


public MedicoEN(MedicoEN medico)
{
        this.init (medico.IdUsuario, medico.Especialidad, medico.Nombre, medico.Contrasena, medico.Iniciado, medico.Email, medico.Apellidos);
}

private void init (int idUsuario, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum especialidad, string nombre, String contrasena, bool iniciado, string email, string apellidos)
{
        this.IdUsuario = idUsuario;


        this.Especialidad = especialidad;

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
        MedicoEN t = obj as MedicoEN;
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
