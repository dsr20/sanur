

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
public partial class PacienteCEN
{
private IPacienteCAD _IPacienteCAD;

public PacienteCEN()
{
        this._IPacienteCAD = new PacienteCAD ();
}

public PacienteCEN(IPacienteCAD _IPacienteCAD)
{
        this._IPacienteCAD = _IPacienteCAD;
}

public IPacienteCAD get_IPacienteCAD ()
{
        return this._IPacienteCAD;
}

public int New_ (string p_nombre, string p_apellidos, Nullable<DateTime> p_fNac, string p_tlf, string p_direccion, string p_nacionalidad, int p_sip, int p_dni, string p_sexo, string p_email, string p_municipio, string p_grupoSang, string p_codigoPostal, string p_ips)
{
        PacienteEN pacienteEN = null;
        int oid;

        //Initialized PacienteEN
        pacienteEN = new PacienteEN ();
        pacienteEN.Nombre = p_nombre;

        pacienteEN.Apellidos = p_apellidos;

        pacienteEN.FNac = p_fNac;

        pacienteEN.Tlf = p_tlf;

        pacienteEN.Direccion = p_direccion;

        pacienteEN.Nacionalidad = p_nacionalidad;

        pacienteEN.Sip = p_sip;

        pacienteEN.Dni = p_dni;

        pacienteEN.Sexo = p_sexo;

        pacienteEN.Email = p_email;

        pacienteEN.Municipio = p_municipio;

        pacienteEN.GrupoSang = p_grupoSang;

        pacienteEN.CodigoPostal = p_codigoPostal;

        pacienteEN.Ips = p_ips;

        //Call to PacienteCAD

        oid = _IPacienteCAD.New_ (pacienteEN);
        return oid;
}

public void Modify (int p_Paciente_OID, string p_nombre, string p_apellidos, Nullable<DateTime> p_fNac, string p_tlf, string p_direccion, string p_nacionalidad, int p_sip, int p_dni, string p_sexo, string p_email, string p_municipio, string p_grupoSang, string p_codigoPostal, string p_ips)
{
        PacienteEN pacienteEN = null;

        //Initialized PacienteEN
        pacienteEN = new PacienteEN ();
        pacienteEN.IdPaciente = p_Paciente_OID;
        pacienteEN.Nombre = p_nombre;
        pacienteEN.Apellidos = p_apellidos;
        pacienteEN.FNac = p_fNac;
        pacienteEN.Tlf = p_tlf;
        pacienteEN.Direccion = p_direccion;
        pacienteEN.Nacionalidad = p_nacionalidad;
        pacienteEN.Sip = p_sip;
        pacienteEN.Dni = p_dni;
        pacienteEN.Sexo = p_sexo;
        pacienteEN.Email = p_email;
        pacienteEN.Municipio = p_municipio;
        pacienteEN.GrupoSang = p_grupoSang;
        pacienteEN.CodigoPostal = p_codigoPostal;
        pacienteEN.Ips = p_ips;
        //Call to PacienteCAD

        _IPacienteCAD.Modify (pacienteEN);
}

public void Destroy (int idPaciente)
{
        _IPacienteCAD.Destroy (idPaciente);
}

public PacienteEN ReadOID (int idPaciente)
{
        PacienteEN pacienteEN = null;

        pacienteEN = _IPacienteCAD.ReadOID (idPaciente);
        return pacienteEN;
}

public System.Collections.Generic.IList<PacienteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PacienteEN> list = null;

        list = _IPacienteCAD.ReadAll (first, size);
        return list;
}
public SanurGenNHibernate.EN.Sanur.PacienteEN BuscarDNI (int dni)
{
        return _IPacienteCAD.BuscarDNI (dni);
}
public SanurGenNHibernate.EN.Sanur.PacienteEN BuscarSIP (int sip)
{
        return _IPacienteCAD.BuscarSIP (sip);
}
public SanurGenNHibernate.EN.Sanur.PacienteEN BuscarNombreApellidos (string nombre, string apellidos)
{
        return _IPacienteCAD.BuscarNombreApellidos (nombre, apellidos);
}
}
}
