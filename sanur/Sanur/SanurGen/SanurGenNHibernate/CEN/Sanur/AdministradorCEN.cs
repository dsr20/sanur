

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
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public int New_ (string p_nombre, String p_contrasena, bool p_iniciado, string p_email, string p_apellidos)
{
        AdministradorEN administradorEN = null;
        int oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Nombre = p_nombre;

        administradorEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        administradorEN.Iniciado = p_iniciado;

        administradorEN.Email = p_email;

        administradorEN.Apellidos = p_apellidos;

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.New_ (administradorEN);
        return oid;
}

public void Modify (int p_Administrador_OID, string p_nombre, String p_contrasena, bool p_iniciado, string p_email, string p_apellidos)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.IdUsuario = p_Administrador_OID;
        administradorEN.Nombre = p_nombre;
        administradorEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);
        administradorEN.Iniciado = p_iniciado;
        administradorEN.Email = p_email;
        administradorEN.Apellidos = p_apellidos;
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Destroy (int idUsuario)
{
        _IAdministradorCAD.Destroy (idUsuario);
}

public AdministradorEN ReadOID (int idUsuario)
{
        AdministradorEN administradorEN = null;

        administradorEN = _IAdministradorCAD.ReadOID (idUsuario);
        return administradorEN;
}

public System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministradorEN> list = null;

        list = _IAdministradorCAD.ReadAll (first, size);
        return list;
}
}
}
