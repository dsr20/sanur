

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.CAD.Sanur;

namespace SanurGenNHibernate.CEN.Sanur
{
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public UsuarioEN ReadOID (int idUsuario)
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (idUsuario);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
public int New_ (string p_nombre, String p_contrasena, bool p_iniciado, string p_email, string p_apellidos)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        usuarioEN.Iniciado = p_iniciado;

        usuarioEN.Email = p_email;

        usuarioEN.Apellidos = p_apellidos;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public SanurGenNHibernate.EN.Sanur.UsuarioEN ReadMail (string p_mail)
{
        return _IUsuarioCAD.ReadMail (p_mail);
}
public System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.UsuarioEN> ReadNombre (string p_nombre)
{
        return _IUsuarioCAD.ReadNombre (p_nombre);
}
}
}
