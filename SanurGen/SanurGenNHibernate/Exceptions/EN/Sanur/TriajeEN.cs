
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class TriajeEN
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

private string movilidad;

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

private int idTriaje;

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


public virtual string Movilidad {
        get { return movilidad; } set { movilidad = value;  }
}


public virtual string MotivoAsist {
        get { return motivoAsist; } set { motivoAsist = value;  }
}


public virtual SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum Destino {
        get { return destino; } set { destino = value;  }
}


public virtual int IdTriaje {
        get { return idTriaje; } set { idTriaje = value;  }
}


public virtual string Observaciones {
        get { return observaciones; } set { observaciones = value;  }
}





public TriajeEN()
{
}



public TriajeEN(int idTriaje, SanurGenNHibernate.EN.Sanur.MedicoEN medico, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum prioridad, string movilidad, string motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum destino, string observaciones)
{
        this.init (idTriaje, medico, prioridad, movilidad, motivoAsist, destino, observaciones);
}


public TriajeEN(TriajeEN triaje)
{
        this.init (triaje.IdTriaje, triaje.Medico, triaje.Prioridad, triaje.Movilidad, triaje.MotivoAsist, triaje.Destino, triaje.Observaciones);
}

private void init (int idTriaje, SanurGenNHibernate.EN.Sanur.MedicoEN medico, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum prioridad, string movilidad, string motivoAsist, SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum destino, string observaciones)
{
        this.IdTriaje = idTriaje;


        this.Medico = medico;

        this.Prioridad = prioridad;

        this.Movilidad = movilidad;

        this.MotivoAsist = motivoAsist;

        this.Destino = destino;

        this.Observaciones = observaciones;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TriajeEN t = obj as TriajeEN;
        if (t == null)
                return false;
        if (IdTriaje.Equals (t.IdTriaje))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdTriaje.GetHashCode ();
        return hash;
}
}
}
