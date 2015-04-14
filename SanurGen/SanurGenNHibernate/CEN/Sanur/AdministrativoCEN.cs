

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
public partial class AdministrativoCEN
{
private IAdministrativoCAD _IAdministrativoCAD;

public AdministrativoCEN()
{
        this._IAdministrativoCAD = new AdministrativoCAD ();
}

public AdministrativoCEN(IAdministrativoCAD _IAdministrativoCAD)
{
        this._IAdministrativoCAD = _IAdministrativoCAD;
}

public IAdministrativoCAD get_IAdministrativoCAD ()
{
        return this._IAdministrativoCAD;
}

public int New_ (string p_nombre, String p_contrasena, bool p_iniciado, string p_email, string p_apellidos)
{
        AdministrativoEN administrativoEN = null;
        int oid;

        //Initialized AdministrativoEN
        administrativoEN = new AdministrativoEN ();
        administrativoEN.Nombre = p_nombre;

        administrativoEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        administrativoEN.Iniciado = p_iniciado;

        administrativoEN.Email = p_email;

        administrativoEN.Apellidos = p_apellidos;

        //Call to AdministrativoCAD

        oid = _IAdministrativoCAD.New_ (administrativoEN);
        return oid;
}

public void Modify (int p_Administrativo_OID, string p_nombre, String p_contrasena, bool p_iniciado, string p_email, string p_apellidos)
{
        AdministrativoEN administrativoEN = null;

        //Initialized AdministrativoEN
        administrativoEN = new AdministrativoEN ();
        administrativoEN.IdUsuario = p_Administrativo_OID;
        administrativoEN.Nombre = p_nombre;
        administrativoEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);
        administrativoEN.Iniciado = p_iniciado;
        administrativoEN.Email = p_email;
        administrativoEN.Apellidos = p_apellidos;
        //Call to AdministrativoCAD

        _IAdministrativoCAD.Modify (administrativoEN);
}

public void Destroy (int idUsuario)
{
        _IAdministrativoCAD.Destroy (idUsuario);
}

public AdministrativoEN ReadOID (int idUsuario)
{
        AdministrativoEN administrativoEN = null;

        administrativoEN = _IAdministrativoCAD.ReadOID (idUsuario);
        return administrativoEN;
}

public System.Collections.Generic.IList<AdministrativoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministrativoEN> list = null;

        list = _IAdministrativoCAD.ReadAll (first, size);
        return list;
}
}
}
