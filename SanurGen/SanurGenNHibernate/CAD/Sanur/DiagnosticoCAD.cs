
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
public partial class DiagnosticoCAD : BasicCAD, IDiagnosticoCAD
{
public DiagnosticoCAD() : base ()
{
}

public DiagnosticoCAD(ISession sessionAux) : base (sessionAux)
{
}



public DiagnosticoEN ReadOIDDefault (string idDiagnostico)
{
        DiagnosticoEN diagnosticoEN = null;

        try
        {
                SessionInitializeTransaction ();
                diagnosticoEN = (DiagnosticoEN)session.Get (typeof(DiagnosticoEN), idDiagnostico);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in DiagnosticoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diagnosticoEN;
}


public string New_ (DiagnosticoEN diagnostico)
{
        try
        {
                SessionInitializeTransaction ();
                if (diagnostico.Medico != null) {
                        diagnostico.Medico = (SanurGenNHibernate.EN.Sanur.MedicoEN)session.Load (typeof(SanurGenNHibernate.EN.Sanur.MedicoEN), diagnostico.Medico.IdUsuario);
                }

                session.Save (diagnostico);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in DiagnosticoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diagnostico.IdDiagnostico;
}

public void Modify (DiagnosticoEN diagnostico)
{
        try
        {
                SessionInitializeTransaction ();
                DiagnosticoEN diagnosticoEN = (DiagnosticoEN)session.Load (typeof(DiagnosticoEN), diagnostico.IdDiagnostico);

                diagnosticoEN.Juicio = diagnostico.Juicio;


                diagnosticoEN.Tratamiento = diagnostico.Tratamiento;


                diagnosticoEN.Hospitalizacion = diagnostico.Hospitalizacion;

                session.Update (diagnosticoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in DiagnosticoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public DiagnosticoEN ReadOID (string idDiagnostico)
{
        DiagnosticoEN diagnosticoEN = null;

        try
        {
                SessionInitializeTransaction ();
                diagnosticoEN = (DiagnosticoEN)session.Get (typeof(DiagnosticoEN), idDiagnostico);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in DiagnosticoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diagnosticoEN;
}

public System.Collections.Generic.IList<DiagnosticoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DiagnosticoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DiagnosticoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DiagnosticoEN>();
                else
                        result = session.CreateCriteria (typeof(DiagnosticoEN)).List<DiagnosticoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in DiagnosticoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
