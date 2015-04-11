
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
public partial class AdjuntoCAD : BasicCAD, IAdjuntoCAD
{
public AdjuntoCAD() : base ()
{
}

public AdjuntoCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdjuntoEN ReadOIDDefault (int idAdjunto)
{
        AdjuntoEN adjuntoEN = null;

        try
        {
                SessionInitializeTransaction ();
                adjuntoEN = (AdjuntoEN)session.Get (typeof(AdjuntoEN), idAdjunto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdjuntoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adjuntoEN;
}


public int New_ (AdjuntoEN adjunto)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (adjunto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdjuntoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adjunto.IdAdjunto;
}

public void Modify (AdjuntoEN adjunto)
{
        try
        {
                SessionInitializeTransaction ();
                AdjuntoEN adjuntoEN = (AdjuntoEN)session.Load (typeof(AdjuntoEN), adjunto.IdAdjunto);

                adjuntoEN.Url = adjunto.Url;


                adjuntoEN.Tipo = adjunto.Tipo;

                session.Update (adjuntoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdjuntoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int idAdjunto)
{
        try
        {
                SessionInitializeTransaction ();
                AdjuntoEN adjuntoEN = (AdjuntoEN)session.Load (typeof(AdjuntoEN), idAdjunto);
                session.Delete (adjuntoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdjuntoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public AdjuntoEN ReadOID (int idAdjunto)
{
        AdjuntoEN adjuntoEN = null;

        try
        {
                SessionInitializeTransaction ();
                adjuntoEN = (AdjuntoEN)session.Get (typeof(AdjuntoEN), idAdjunto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdjuntoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adjuntoEN;
}

public System.Collections.Generic.IList<AdjuntoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdjuntoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdjuntoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdjuntoEN>();
                else
                        result = session.CreateCriteria (typeof(AdjuntoEN)).List<AdjuntoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdjuntoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
