
using System;

namespace SanurGenNHibernate.EN.Sanur
{
public partial class AdjuntoEN
{
/**
 *
 */

private SanurGenNHibernate.EN.Sanur.PruebaEN prueba;

/**
 *
 */

private int idAdjunto;

/**
 *
 */

private string url;

/**
 *
 */

private string tipo;





public virtual SanurGenNHibernate.EN.Sanur.PruebaEN Prueba {
        get { return prueba; } set { prueba = value;  }
}


public virtual int IdAdjunto {
        get { return idAdjunto; } set { idAdjunto = value;  }
}


public virtual string Url {
        get { return url; } set { url = value;  }
}


public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}





public AdjuntoEN()
{
}



public AdjuntoEN(int idAdjunto, SanurGenNHibernate.EN.Sanur.PruebaEN prueba, string url, string tipo)
{
        this.init (idAdjunto, prueba, url, tipo);
}


public AdjuntoEN(AdjuntoEN adjunto)
{
        this.init (adjunto.IdAdjunto, adjunto.Prueba, adjunto.Url, adjunto.Tipo);
}

private void init (int idAdjunto, SanurGenNHibernate.EN.Sanur.PruebaEN prueba, string url, string tipo)
{
        this.IdAdjunto = idAdjunto;


        this.Prueba = prueba;

        this.Url = url;

        this.Tipo = tipo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdjuntoEN t = obj as AdjuntoEN;
        if (t == null)
                return false;
        if (IdAdjunto.Equals (t.IdAdjunto))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdAdjunto.GetHashCode ();
        return hash;
}
}
}
