
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class PruebaEN
{
/**
 *
 */

private string idPrueba;

/**
 *
 */

private string nombre;

/**
 *
 */

private string descripcion;

/**
 *
 */

private string resultado;

/**
 *
 */

private System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.AdjuntoEN> adjunto;





public virtual string IdPrueba {
        get { return idPrueba; } set { idPrueba = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual string Resultado {
        get { return resultado; } set { resultado = value;  }
}


public virtual System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.AdjuntoEN> Adjunto {
        get { return adjunto; } set { adjunto = value;  }
}





public PruebaEN()
{
        adjunto = new System.Collections.Generic.List<SanurGenNHibernate.EN.Sanur.AdjuntoEN>();
}



public PruebaEN(string idPrueba, string nombre, string descripcion, string resultado, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.AdjuntoEN> adjunto)
{
        this.init (idPrueba, nombre, descripcion, resultado, adjunto);
}


public PruebaEN(PruebaEN prueba)
{
        this.init (prueba.IdPrueba, prueba.Nombre, prueba.Descripcion, prueba.Resultado, prueba.Adjunto);
}

private void init (string idPrueba, string nombre, string descripcion, string resultado, System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.AdjuntoEN> adjunto)
{
        this.IdPrueba = idPrueba;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Resultado = resultado;

        this.Adjunto = adjunto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PruebaEN t = obj as PruebaEN;
        if (t == null)
                return false;
        if (IdPrueba.Equals (t.IdPrueba))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdPrueba.GetHashCode ();
        return hash;
}
}
}
