

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
public partial class AdjuntoCEN
{
private IAdjuntoCAD _IAdjuntoCAD;

public AdjuntoCEN()
{
        this._IAdjuntoCAD = new AdjuntoCAD ();
}

public AdjuntoCEN(IAdjuntoCAD _IAdjuntoCAD)
{
        this._IAdjuntoCAD = _IAdjuntoCAD;
}

public IAdjuntoCAD get_IAdjuntoCAD ()
{
        return this._IAdjuntoCAD;
}

public int New_ (string p_url, string p_tipo)
{
        AdjuntoEN adjuntoEN = null;
        int oid;

        //Initialized AdjuntoEN
        adjuntoEN = new AdjuntoEN ();
        adjuntoEN.Url = p_url;

        adjuntoEN.Tipo = p_tipo;

        //Call to AdjuntoCAD

        oid = _IAdjuntoCAD.New_ (adjuntoEN);
        return oid;
}

public void Modify (int p_Adjunto_OID, string p_url, string p_tipo)
{
        AdjuntoEN adjuntoEN = null;

        //Initialized AdjuntoEN
        adjuntoEN = new AdjuntoEN ();
        adjuntoEN.IdAdjunto = p_Adjunto_OID;
        adjuntoEN.Url = p_url;
        adjuntoEN.Tipo = p_tipo;
        //Call to AdjuntoCAD

        _IAdjuntoCAD.Modify (adjuntoEN);
}

public void Destroy (int idAdjunto)
{
        _IAdjuntoCAD.Destroy (idAdjunto);
}

public AdjuntoEN ReadOID (int idAdjunto)
{
        AdjuntoEN adjuntoEN = null;

        adjuntoEN = _IAdjuntoCAD.ReadOID (idAdjunto);
        return adjuntoEN;
}

public System.Collections.Generic.IList<AdjuntoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdjuntoEN> list = null;

        list = _IAdjuntoCAD.ReadAll (first, size);
        return list;
}
}
}
