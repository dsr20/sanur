
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
public partial class MedicoCAD : BasicCAD, IMedicoCAD
{
public MedicoCAD() : base ()
{
}

public MedicoCAD(ISession sessionAux) : base (sessionAux)
{
}



public MedicoEN ReadOIDDefault (int idUsuario)
{
        MedicoEN medicoEN = null;

        try
        {
                SessionInitializeTransaction ();
                medicoEN = (MedicoEN)session.Get (typeof(MedicoEN), idUsuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in MedicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medicoEN;
}


public int New_ (MedicoEN medico)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (medico);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in MedicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medico.IdUsuario;
}

public void Modify (MedicoEN medico)
{
        try
        {
                SessionInitializeTransaction ();
                MedicoEN medicoEN = (MedicoEN)session.Load (typeof(MedicoEN), medico.IdUsuario);

                medicoEN.Nombre = medico.Nombre;


                medicoEN.Contrasena = medico.Contrasena;


                medicoEN.Iniciado = medico.Iniciado;


                medicoEN.Email = medico.Email;


                medicoEN.Apellidos = medico.Apellidos;


                medicoEN.Especialidad = medico.Especialidad;

                session.Update (medicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in MedicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int idUsuario)
{
        try
        {
                SessionInitializeTransaction ();
                MedicoEN medicoEN = (MedicoEN)session.Load (typeof(MedicoEN), idUsuario);
                session.Delete (medicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in MedicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public MedicoEN ReadOID (int idUsuario)
{
        MedicoEN medicoEN = null;

        try
        {
                SessionInitializeTransaction ();
                medicoEN = (MedicoEN)session.Get (typeof(MedicoEN), idUsuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in MedicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medicoEN;
}

public System.Collections.Generic.IList<MedicoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MedicoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MedicoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MedicoEN>();
                else
                        result = session.CreateCriteria (typeof(MedicoEN)).List<MedicoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in MedicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
