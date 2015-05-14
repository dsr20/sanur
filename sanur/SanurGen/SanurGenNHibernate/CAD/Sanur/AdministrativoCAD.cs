
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
public partial class AdministrativoCAD : BasicCAD, IAdministrativoCAD
{
public AdministrativoCAD() : base ()
{
}

public AdministrativoCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdministrativoEN ReadOIDDefault (int idUsuario)
{
        AdministrativoEN administrativoEN = null;

        try
        {
                SessionInitializeTransaction ();
                administrativoEN = (AdministrativoEN)session.Get (typeof(AdministrativoEN), idUsuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdministrativoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administrativoEN;
}


public int New_ (AdministrativoEN administrativo)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (administrativo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdministrativoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administrativo.IdUsuario;
}

public void Modify (AdministrativoEN administrativo)
{
        try
        {
                SessionInitializeTransaction ();
                AdministrativoEN administrativoEN = (AdministrativoEN)session.Load (typeof(AdministrativoEN), administrativo.IdUsuario);

                administrativoEN.Nombre = administrativo.Nombre;


                administrativoEN.Contrasena = administrativo.Contrasena;


                administrativoEN.Iniciado = administrativo.Iniciado;


                administrativoEN.Email = administrativo.Email;


                administrativoEN.Apellidos = administrativo.Apellidos;

                session.Update (administrativoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdministrativoCAD.", ex);
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
                AdministrativoEN administrativoEN = (AdministrativoEN)session.Load (typeof(AdministrativoEN), idUsuario);
                session.Delete (administrativoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdministrativoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public AdministrativoEN ReadOID (int idUsuario)
{
        AdministrativoEN administrativoEN = null;

        try
        {
                SessionInitializeTransaction ();
                administrativoEN = (AdministrativoEN)session.Get (typeof(AdministrativoEN), idUsuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdministrativoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administrativoEN;
}

public System.Collections.Generic.IList<AdministrativoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministrativoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdministrativoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdministrativoEN>();
                else
                        result = session.CreateCriteria (typeof(AdministrativoEN)).List<AdministrativoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in AdministrativoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
