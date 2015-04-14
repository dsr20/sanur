

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
public partial class DiagnosticoCEN
{
private IDiagnosticoCAD _IDiagnosticoCAD;

public DiagnosticoCEN()
{
        this._IDiagnosticoCAD = new DiagnosticoCAD ();
}

public DiagnosticoCEN(IDiagnosticoCAD _IDiagnosticoCAD)
{
        this._IDiagnosticoCAD = _IDiagnosticoCAD;
}

public IDiagnosticoCAD get_IDiagnosticoCAD ()
{
        return this._IDiagnosticoCAD;
}

public string New_ (int p_medico, string p_juicio, string p_tratamiento, string p_idDiagnostico, bool p_hospitalizacion)
{
        DiagnosticoEN diagnosticoEN = null;
        string oid;

        //Initialized DiagnosticoEN
        diagnosticoEN = new DiagnosticoEN ();

        if (p_medico != -1) {
                diagnosticoEN.Medico = new SanurGenNHibernate.EN.Sanur.MedicoEN ();
                diagnosticoEN.Medico.IdUsuario = p_medico;
        }

        diagnosticoEN.Juicio = p_juicio;

        diagnosticoEN.Tratamiento = p_tratamiento;

        diagnosticoEN.IdDiagnostico = p_idDiagnostico;

        diagnosticoEN.Hospitalizacion = p_hospitalizacion;

        //Call to DiagnosticoCAD

        oid = _IDiagnosticoCAD.New_ (diagnosticoEN);
        return oid;
}

public void Modify (string p_Diagnostico_OID, string p_juicio, string p_tratamiento, bool p_hospitalizacion)
{
        DiagnosticoEN diagnosticoEN = null;

        //Initialized DiagnosticoEN
        diagnosticoEN = new DiagnosticoEN ();
        diagnosticoEN.IdDiagnostico = p_Diagnostico_OID;
        diagnosticoEN.Juicio = p_juicio;
        diagnosticoEN.Tratamiento = p_tratamiento;
        diagnosticoEN.Hospitalizacion = p_hospitalizacion;
        //Call to DiagnosticoCAD

        _IDiagnosticoCAD.Modify (diagnosticoEN);
}

public DiagnosticoEN ReadOID (string idDiagnostico)
{
        DiagnosticoEN diagnosticoEN = null;

        diagnosticoEN = _IDiagnosticoCAD.ReadOID (idDiagnostico);
        return diagnosticoEN;
}

public System.Collections.Generic.IList<DiagnosticoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DiagnosticoEN> list = null;

        list = _IDiagnosticoCAD.ReadAll (first, size);
        return list;
}
}
}
