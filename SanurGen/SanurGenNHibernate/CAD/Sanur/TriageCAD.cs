
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
public partial class TriageCAD : BasicCAD, ITriageCAD
{
public TriageCAD() : base ()
{
}

public TriageCAD(ISession sessionAux) : base (sessionAux)
{
}



public TriageEN ReadOIDDefault (int idTriage)
{
        TriageEN triageEN = null;

        try
        {
                SessionInitializeTransaction ();
                triageEN = (TriageEN)session.Get (typeof(TriageEN), idTriage);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return triageEN;
}


public int New_ (TriageEN triage)
{
        try
        {
                SessionInitializeTransaction ();
                if (triage.Medico != null) {
                        triage.Medico = (SanurGenNHibernate.EN.Sanur.MedicoEN)session.Load (typeof(SanurGenNHibernate.EN.Sanur.MedicoEN), triage.Medico.IdUsuario);
                }

                session.Save (triage);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return triage.IdTriage;
}

public void Modify (TriageEN triage)
{
        try
        {
                SessionInitializeTransaction ();
                TriageEN triageEN = (TriageEN)session.Load (typeof(TriageEN), triage.IdTriage);

                triageEN.Prioridad = triage.Prioridad;


                triageEN.MotivoAsist = triage.MotivoAsist;


                triageEN.Destino = triage.Destino;


                triageEN.Observaciones = triage.Observaciones;

                session.Update (triageEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public TriageEN ReadOID (int idTriage)
{
        TriageEN triageEN = null;

        try
        {
                SessionInitializeTransaction ();
                triageEN = (TriageEN)session.Get (typeof(TriageEN), idTriage);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return triageEN;
}

public System.Collections.Generic.IList<TriageEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TriageEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TriageEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TriageEN>();
                else
                        result = session.CreateCriteria (typeof(TriageEN)).List<TriageEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public int BuscarUltimo ()
{
        int result;

        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TriageEN self where SELECT max(tri.IdTriage) FROM TriageEN as tri";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TriageENbuscarUltimoHQL");


                result = query.UniqueResult<int>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public SanurGenNHibernate.EN.Sanur.TriageEN BuscarDeEpisodio (int idEpisodio)
{
        SanurGenNHibernate.EN.Sanur.TriageEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TriageEN self where SELECT tri FROM EpisodioEN as ep INNER JOIN ep.Triage as tri where ep.IdEpisodio = :idEpisodio";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TriageENbuscarDeEpisodioHQL");
                query.SetParameter ("idEpisodio", idEpisodio);


                result = query.UniqueResult<SanurGenNHibernate.EN.Sanur.TriageEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in TriageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
