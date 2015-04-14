

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
public partial class TriajeCEN
{
private ITriajeCAD _ITriajeCAD;

public TriajeCEN()
{
        this._ITriajeCAD = new TriajeCAD ();
}

public TriajeCEN(ITriajeCAD _ITriajeCAD)
{
        this._ITriajeCAD = _ITriajeCAD;
}

public ITriajeCAD get_ITriajeCAD ()
{
        return this._ITriajeCAD;
}

public int New_ (int p_medico, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum p_prioridad, string p_movilidad, string p_motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum p_destino, string p_observaciones)
{
        TriajeEN triajeEN = null;
        int oid;

        //Initialized TriajeEN
        triajeEN = new TriajeEN ();

        if (p_medico != -1) {
                triajeEN.Medico = new SanurGenNHibernate.EN.Sanur.MedicoEN ();
                triajeEN.Medico.IdUsuario = p_medico;
        }

        triajeEN.Prioridad = p_prioridad;

        triajeEN.Movilidad = p_movilidad;

        triajeEN.MotivoAsist = p_motivoAsist;

        triajeEN.Destino = p_destino;

        triajeEN.Observaciones = p_observaciones;

        //Call to TriajeCAD

        oid = _ITriajeCAD.New_ (triajeEN);
        return oid;
}

public void Modify (int p_Triaje_OID, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum p_prioridad, string p_movilidad, string p_motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum p_destino, string p_observaciones)
{
        TriajeEN triajeEN = null;

        //Initialized TriajeEN
        triajeEN = new TriajeEN ();
        triajeEN.IdTriaje = p_Triaje_OID;
        triajeEN.Prioridad = p_prioridad;
        triajeEN.Movilidad = p_movilidad;
        triajeEN.MotivoAsist = p_motivoAsist;
        triajeEN.Destino = p_destino;
        triajeEN.Observaciones = p_observaciones;
        //Call to TriajeCAD

        _ITriajeCAD.Modify (triajeEN);
}

public TriajeEN ReadOID (int idTriaje)
{
        TriajeEN triajeEN = null;

        triajeEN = _ITriajeCAD.ReadOID (idTriaje);
        return triajeEN;
}

public System.Collections.Generic.IList<TriajeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TriajeEN> list = null;

        list = _ITriajeCAD.ReadAll (first, size);
        return list;
}
}
}
