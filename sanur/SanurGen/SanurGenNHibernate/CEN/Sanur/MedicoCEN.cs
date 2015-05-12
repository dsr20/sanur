

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
public partial class MedicoCEN
{
private IMedicoCAD _IMedicoCAD;

public MedicoCEN()
{
        this._IMedicoCAD = new MedicoCAD ();
}

public MedicoCEN(IMedicoCAD _IMedicoCAD)
{
        this._IMedicoCAD = _IMedicoCAD;
}

public IMedicoCAD get_IMedicoCAD ()
{
        return this._IMedicoCAD;
}

public int New_ (string p_nombre, String p_contrasena, bool p_iniciado, string p_email, string p_apellidos, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum p_especialidad)
{
        MedicoEN medicoEN = null;
        int oid;

        //Initialized MedicoEN
        medicoEN = new MedicoEN ();
        medicoEN.Nombre = p_nombre;

        medicoEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        medicoEN.Iniciado = p_iniciado;

        medicoEN.Email = p_email;

        medicoEN.Apellidos = p_apellidos;

        medicoEN.Especialidad = p_especialidad;

        //Call to MedicoCAD

        oid = _IMedicoCAD.New_ (medicoEN);
        return oid;
}

public void Modify (int p_Medico_OID, string p_nombre, String p_contrasena, bool p_iniciado, string p_email, string p_apellidos, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum p_especialidad)
{
        MedicoEN medicoEN = null;

        //Initialized MedicoEN
        medicoEN = new MedicoEN ();
        medicoEN.IdUsuario = p_Medico_OID;
        medicoEN.Nombre = p_nombre;
        medicoEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);
        medicoEN.Iniciado = p_iniciado;
        medicoEN.Email = p_email;
        medicoEN.Apellidos = p_apellidos;
        medicoEN.Especialidad = p_especialidad;
        //Call to MedicoCAD

        _IMedicoCAD.Modify (medicoEN);
}

public void Destroy (int idUsuario)
{
        _IMedicoCAD.Destroy (idUsuario);
}

public MedicoEN ReadOID (int idUsuario)
{
        MedicoEN medicoEN = null;

        medicoEN = _IMedicoCAD.ReadOID (idUsuario);
        return medicoEN;
}

public System.Collections.Generic.IList<MedicoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MedicoEN> list = null;

        list = _IMedicoCAD.ReadAll (first, size);
        return list;
}
}
}
