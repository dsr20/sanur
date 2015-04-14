
using System;
using System.Text;
using SanurGenNHibernate.CEN.Sanur;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.Exceptions;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial class PruebaCAD : BasicCAD, IPruebaCAD
{
public PruebaCAD() : base ()
{
}

public PruebaCAD(ISession sessionAux) : base (sessionAux)
{
}



public PruebaEN ReadOIDDefault (string idPrueba)
{
        PruebaEN pruebaEN = null;

        try
        {
                SessionInitializeTransaction ();
                pruebaEN = (PruebaEN)session.Get (typeof(PruebaEN), idPrueba);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PruebaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pruebaEN;
}


public string New_ (PruebaEN prueba)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (prueba);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PruebaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return prueba.IdPrueba;
}

public void Modify (PruebaEN prueba)
{
        try
        {
                SessionInitializeTransaction ();
                PruebaEN pruebaEN = (PruebaEN)session.Load (typeof(PruebaEN), prueba.IdPrueba);

                pruebaEN.Nombre = prueba.Nombre;


                pruebaEN.Descripcion = prueba.Descripcion;


                pruebaEN.Resultado = prueba.Resultado;

                session.Update (pruebaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PruebaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public PruebaEN ReadOID (string idPrueba)
{
        PruebaEN pruebaEN = null;

        try
        {
                SessionInitializeTransaction ();
                pruebaEN = (PruebaEN)session.Get (typeof(PruebaEN), idPrueba);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PruebaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pruebaEN;
}

public System.Collections.Generic.IList<PruebaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PruebaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PruebaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PruebaEN>();
                else
                        result = session.CreateCriteria (typeof(PruebaEN)).List<PruebaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PruebaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
