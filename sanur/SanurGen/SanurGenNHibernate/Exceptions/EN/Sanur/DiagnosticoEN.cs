
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class DiagnosticoEN
{
/**
 *
 */

private SanurGenNHibernate.EN.Sanur.MedicoEN medico;

/**
 *
 */

private string juicio;

/**
 *
 */

private string tratamiento;

/**
 *
 */

private string idDiagnostico;

/**
 *
 */

private bool hospitalizacion;





public virtual SanurGenNHibernate.EN.Sanur.MedicoEN Medico {
        get { return medico; } set { medico = value;  }
}


public virtual string Juicio {
        get { return juicio; } set { juicio = value;  }
}


public virtual string Tratamiento {
        get { return tratamiento; } set { tratamiento = value;  }
}


public virtual string IdDiagnostico {
        get { return idDiagnostico; } set { idDiagnostico = value;  }
}


public virtual bool Hospitalizacion {
        get { return hospitalizacion; } set { hospitalizacion = value;  }
}





public DiagnosticoEN()
{
}



public DiagnosticoEN(string idDiagnostico, SanurGenNHibernate.EN.Sanur.MedicoEN medico, string juicio, string tratamiento, bool hospitalizacion)
{
        this.init (idDiagnostico, medico, juicio, tratamiento, hospitalizacion);
}


public DiagnosticoEN(DiagnosticoEN diagnostico)
{
        this.init (diagnostico.IdDiagnostico, diagnostico.Medico, diagnostico.Juicio, diagnostico.Tratamiento, diagnostico.Hospitalizacion);
}

private void init (string idDiagnostico, SanurGenNHibernate.EN.Sanur.MedicoEN medico, string juicio, string tratamiento, bool hospitalizacion)
{
        this.IdDiagnostico = idDiagnostico;


        this.Medico = medico;

        this.Juicio = juicio;

        this.Tratamiento = tratamiento;

        this.Hospitalizacion = hospitalizacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DiagnosticoEN t = obj as DiagnosticoEN;
        if (t == null)
                return false;
        if (IdDiagnostico.Equals (t.IdDiagnostico))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdDiagnostico.GetHashCode ();
        return hash;
}
}
}
