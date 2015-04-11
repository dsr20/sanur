
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class EpisodioEN
{
/**
 *
 */

private SanurGenNHibernate.EN.Sanur.PacienteEN paciente;

/**
 *
 */

private SanurGenNHibernate.EN.Sanur.TriageEN triage;

/**
 *
 */

private int idEpisodio;

/**
 *
 */

private TimeSpan fechaInicio;

/**
 *
 */

private string observaciones;

/**
 *
 */

private SanurGenNHibernate.EN.Sanur.DiagnosticoEN diagnostico;

/**
 *
 */

private System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.PruebaEN> prueba;

/**
 *
 */

private SanurGenNHibernate.EN.Sanur.AdministrativoEN administrativo;

/**
 *
 */

private TimeSpan fechaFin;

/**
 *
 */

private SanurGenNHibernate.Enumerated.Sanur.EstadoEnum estado;

/**
 *
 */

private bool emergencia;

/**
 *
 */

private bool imporante;





public virtual SanurGenNHibernate.EN.Sanur.PacienteEN Paciente {
        get { return paciente; } set { paciente = value;  }
}


public virtual SanurGenNHibernate.EN.Sanur.TriageEN Triage {
        get { return triage; } set { triage = value;  }
}


public virtual int IdEpisodio {
        get { return idEpisodio; } set { idEpisodio = value;  }
}


public virtual TimeSpan FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}


public virtual string Observaciones {
        get { return observaciones; } set { observaciones = value;  }
}


public virtual SanurGenNHibernate.EN.Sanur.DiagnosticoEN Diagnostico {
        get { return diagnostico; } set { diagnostico = value;  }
}


public virtual System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.PruebaEN> Prueba {
        get { return prueba; } set { prueba = value;  }
}


public virtual SanurGenNHibernate.EN.Sanur.AdministrativoEN Administrativo {
        get { return administrativo; } set { administrativo = value;  }
}


public virtual TimeSpan FechaFin {
        get { return fechaFin; } set { fechaFin = value;  }
}


public virtual SanurGenNHibernate.Enumerated.Sanur.EstadoEnum Estado {
        get { return estado; } set { estado = value;  }
}


public virtual bool Emergencia {
        get { return emergencia; } set { emergencia = value;  }
}


public virtual bool Imporante {
        get { return imporante; } set { imporante = value;  }
}





public EpisodioEN()
{
        prueba = new System.Collections.Generic.List<SanurGenNHibernate.EN.Sanur.PruebaEN>();
}



public EpisodioEN(int idEpisodio, SanurGenNHibernate.EN.Sanur.PacienteEN paciente, SanurGenNHibernate.EN.Sanur.TriageEN triage, TimeSpan fechaInicio, string observaciones, SanurGenNHibernate.EN.Sanur.DiagnosticoEN diagnostico, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.PruebaEN> prueba, SanurGenNHibernate.EN.Sanur.AdministrativoEN administrativo, TimeSpan fechaFin, SanurGenNHibernate.Enumerated.Sanur.EstadoEnum estado, bool emergencia, bool imporante)
{
        this.init (idEpisodio, paciente, triage, fechaInicio, observaciones, diagnostico, prueba, administrativo, fechaFin, estado, emergencia, imporante);
}


public EpisodioEN(EpisodioEN episodio)
{
        this.init (episodio.IdEpisodio, episodio.Paciente, episodio.Triage, episodio.FechaInicio, episodio.Observaciones, episodio.Diagnostico, episodio.Prueba, episodio.Administrativo, episodio.FechaFin, episodio.Estado, episodio.Emergencia, episodio.Imporante);
}

private void init (int idEpisodio, SanurGenNHibernate.EN.Sanur.PacienteEN paciente, SanurGenNHibernate.EN.Sanur.TriageEN triage, TimeSpan fechaInicio, string observaciones, SanurGenNHibernate.EN.Sanur.DiagnosticoEN diagnostico, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.PruebaEN> prueba, SanurGenNHibernate.EN.Sanur.AdministrativoEN administrativo, TimeSpan fechaFin, SanurGenNHibernate.Enumerated.Sanur.EstadoEnum estado, bool emergencia, bool imporante)
{
        this.IdEpisodio = idEpisodio;


        this.Paciente = paciente;

        this.Triage = triage;

        this.FechaInicio = fechaInicio;

        this.Observaciones = observaciones;

        this.Diagnostico = diagnostico;

        this.Prueba = prueba;

        this.Administrativo = administrativo;

        this.FechaFin = fechaFin;

        this.Estado = estado;

        this.Emergencia = emergencia;

        this.Imporante = imporante;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EpisodioEN t = obj as EpisodioEN;
        if (t == null)
                return false;
        if (IdEpisodio.Equals (t.IdEpisodio))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdEpisodio.GetHashCode ();
        return hash;
}
}
}
