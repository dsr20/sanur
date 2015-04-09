
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
public partial class PacienteCAD : BasicCAD, IPacienteCAD
{
public PacienteCAD() : base ()
{
}

public PacienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public PacienteEN ReadOIDDefault (int idPaciente)
{
        PacienteEN pacienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                pacienteEN = (PacienteEN)session.Get (typeof(PacienteEN), idPaciente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pacienteEN;
}


public int New_ (PacienteEN paciente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (paciente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return paciente.IdPaciente;
}

public void Modify (PacienteEN paciente)
{
        try
        {
                SessionInitializeTransaction ();
                PacienteEN pacienteEN = (PacienteEN)session.Load (typeof(PacienteEN), paciente.IdPaciente);

                pacienteEN.Nombre = paciente.Nombre;


                pacienteEN.Apellidos = paciente.Apellidos;


                pacienteEN.FNac = paciente.FNac;


                pacienteEN.Tlf = paciente.Tlf;


                pacienteEN.Direccion = paciente.Direccion;


                pacienteEN.Nacionalidad = paciente.Nacionalidad;


                pacienteEN.Sip = paciente.Sip;


                pacienteEN.Dni = paciente.Dni;


                pacienteEN.Sexo = paciente.Sexo;


                pacienteEN.Email = paciente.Email;


                pacienteEN.Municipio = paciente.Municipio;


                pacienteEN.GrupoSang = paciente.GrupoSang;


                pacienteEN.CodigoPostal = paciente.CodigoPostal;


                pacienteEN.Ips = paciente.Ips;

                session.Update (pacienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int idPaciente)
{
        try
        {
                SessionInitializeTransaction ();
                PacienteEN pacienteEN = (PacienteEN)session.Load (typeof(PacienteEN), idPaciente);
                session.Delete (pacienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public PacienteEN ReadOID (int idPaciente)
{
        PacienteEN pacienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                pacienteEN = (PacienteEN)session.Get (typeof(PacienteEN), idPaciente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pacienteEN;
}

public System.Collections.Generic.IList<PacienteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PacienteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PacienteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PacienteEN>();
                else
                        result = session.CreateCriteria (typeof(PacienteEN)).List<PacienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public SanurGenNHibernate.EN.Sanur.PacienteEN BuscarDNI (int dni)
{
        SanurGenNHibernate.EN.Sanur.PacienteEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PacienteEN self where from PacienteEN as pa where pa.Dni= :dni";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PacienteENbuscarDNIHQL");
                query.SetParameter ("dni", dni);


                result = query.UniqueResult<SanurGenNHibernate.EN.Sanur.PacienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public SanurGenNHibernate.EN.Sanur.PacienteEN BuscarSIP (int sip)
{
        SanurGenNHibernate.EN.Sanur.PacienteEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PacienteEN self where from PacienteEN where sip= :sip";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PacienteENbuscarSIPHQL");
                query.SetParameter ("sip", sip);


                result = query.UniqueResult<SanurGenNHibernate.EN.Sanur.PacienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public SanurGenNHibernate.EN.Sanur.PacienteEN BuscarNombreApellidos (string nombre, string apellidos)
{
        SanurGenNHibernate.EN.Sanur.PacienteEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PacienteEN self where from PacienteEN where nombre= :dni AND apellidos= :apellidos";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PacienteENbuscarNombreApellidosHQL");
                query.SetParameter ("nombre", nombre);
                query.SetParameter ("apellidos", apellidos);


                result = query.UniqueResult<SanurGenNHibernate.EN.Sanur.PacienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SanurGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SanurGenNHibernate.Exceptions.DataLayerException ("Error in PacienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
