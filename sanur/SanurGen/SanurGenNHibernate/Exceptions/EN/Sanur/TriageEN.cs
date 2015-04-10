
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class TriageEN
{
/**
 *
 */

private SanurGenNHibernate.EN.Sanur.MedicoEN medico;

/**
 *
 */

private SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum prioridad;

/**
 *
 */

private string motivoAsist;

/**
 *
 */

private SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum destino;

/**
 *
 */

private int idTriage;

/**
 *
 */

private string observaciones;





public virtual SanurGenNHibernate.EN.Sanur.MedicoEN Medico {
        get { return medico; } set { medico = value;  }
}


public virtual SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum Prioridad {
        get { return prioridad; } set { prioridad = value;  }
}


public virtual string MotivoAsist {
        get { return motivoAsist; } set { motivoAsist = value;  }
}


public virtual SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum Destino {
        get { return destino; } set { destino = value;  }
}


public virtual int IdTriage {
        get { return idTriage; } set { idTriage = value;  }
}


public virtual string Observaciones {
        get { return observaciones; } set { observaciones = value;  }
}





public TriageEN()
{
}



public TriageEN(int idTriage, SanurGenNHibernate.EN.Sanur.MedicoEN medico, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum prioridad, string motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum destino, string observaciones)
{
        this.init (idTriage, medico, prioridad, motivoAsist, destino, observaciones);
}


public TriageEN(TriageEN triage)
{
        this.init (triage.IdTriage, triage.Medico, triage.Prioridad, triage.MotivoAsist, triage.Destino, triage.Observaciones);
}

private void init (int idTriage, SanurGenNHibernate.EN.Sanur.MedicoEN medico, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum prioridad, string motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum destino, string observaciones)
{
        this.IdTriage = idTriage;


        this.Medico = medico;

        this.Prioridad = prioridad;

        this.MotivoAsist = motivoAsist;

        this.Destino = destino;

        this.Observaciones = observaciones;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TriageEN t = obj as TriageEN;
        if (t == null)
                return false;
        if (IdTriage.Equals (t.IdTriage))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdTriage.GetHashCode ();
        return hash;
}
}
}
