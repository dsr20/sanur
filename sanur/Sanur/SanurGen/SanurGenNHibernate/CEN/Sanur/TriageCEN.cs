

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
public partial class TriageCEN
{
private ITriageCAD _ITriageCAD;

public TriageCEN()
{
        this._ITriageCAD = new TriageCAD ();
}

public TriageCEN(ITriageCAD _ITriageCAD)
{
        this._ITriageCAD = _ITriageCAD;
}

public ITriageCAD get_ITriageCAD ()
{
        return this._ITriageCAD;
}

public int New_ (int p_medico, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum p_prioridad, string p_motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum p_destino, string p_observaciones)
{
        TriageEN triageEN = null;
        int oid;

        //Initialized TriageEN
        triageEN = new TriageEN ();

        if (p_medico != -1) {
                triageEN.Medico = new SanurGenNHibernate.EN.Sanur.MedicoEN ();
                triageEN.Medico.IdUsuario = p_medico;
        }

        triageEN.Prioridad = p_prioridad;

        triageEN.MotivoAsist = p_motivoAsist;

        triageEN.Destino = p_destino;

        triageEN.Observaciones = p_observaciones;

        //Call to TriageCAD

        oid = _ITriageCAD.New_ (triageEN);
        return oid;
}

public void Modify (int p_Triage_OID, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum p_prioridad, string p_motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum p_destino, string p_observaciones)
{
        TriageEN triageEN = null;

        //Initialized TriageEN
        triageEN = new TriageEN ();
        triageEN.IdTriage = p_Triage_OID;
        triageEN.Prioridad = p_prioridad;
        triageEN.MotivoAsist = p_motivoAsist;
        triageEN.Destino = p_destino;
        triageEN.Observaciones = p_observaciones;
        //Call to TriageCAD

        _ITriageCAD.Modify (triageEN);
}

public TriageEN ReadOID (int idTriage)
{
        TriageEN triageEN = null;

        triageEN = _ITriageCAD.ReadOID (idTriage);
        return triageEN;
}

public System.Collections.Generic.IList<TriageEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TriageEN> list = null;

        list = _ITriageCAD.ReadAll (first, size);
        return list;
}
}
}
