

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
public partial class PruebaCEN
{
private IPruebaCAD _IPruebaCAD;

public PruebaCEN()
{
        this._IPruebaCAD = new PruebaCAD ();
}

public PruebaCEN(IPruebaCAD _IPruebaCAD)
{
        this._IPruebaCAD = _IPruebaCAD;
}

public IPruebaCAD get_IPruebaCAD ()
{
        return this._IPruebaCAD;
}

public string New_ (string p_idPrueba, string p_nombre, string p_descripcion, string p_resultado)
{
        PruebaEN pruebaEN = null;
        string oid;

        //Initialized PruebaEN
        pruebaEN = new PruebaEN ();
        pruebaEN.IdPrueba = p_idPrueba;

        pruebaEN.Nombre = p_nombre;

        pruebaEN.Descripcion = p_descripcion;

        pruebaEN.Resultado = p_resultado;

        //Call to PruebaCAD

        oid = _IPruebaCAD.New_ (pruebaEN);
        return oid;
}

public void Modify (string p_Prueba_OID, string p_nombre, string p_descripcion, string p_resultado)
{
        PruebaEN pruebaEN = null;

        //Initialized PruebaEN
        pruebaEN = new PruebaEN ();
        pruebaEN.IdPrueba = p_Prueba_OID;
        pruebaEN.Nombre = p_nombre;
        pruebaEN.Descripcion = p_descripcion;
        pruebaEN.Resultado = p_resultado;
        //Call to PruebaCAD

        _IPruebaCAD.Modify (pruebaEN);
}

public PruebaEN ReadOID (string idPrueba)
{
        PruebaEN pruebaEN = null;

        pruebaEN = _IPruebaCAD.ReadOID (idPrueba);
        return pruebaEN;
}

public System.Collections.Generic.IList<PruebaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PruebaEN> list = null;

        list = _IPruebaCAD.ReadAll (first, size);
        return list;
}
}
}
