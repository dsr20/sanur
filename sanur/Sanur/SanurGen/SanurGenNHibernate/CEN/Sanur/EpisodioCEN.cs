

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
public partial class EpisodioCEN
{
private IEpisodioCAD _IEpisodioCAD;

public EpisodioCEN()
{
        this._IEpisodioCAD = new EpisodioCAD ();
}

public EpisodioCEN(IEpisodioCAD _IEpisodioCAD)
{
        this._IEpisodioCAD = _IEpisodioCAD;
}

public IEpisodioCAD get_IEpisodioCAD ()
{
        return this._IEpisodioCAD;
}

public int New_ (int p_paciente, TimeSpan p_fechaInicio, string p_observaciones, int p_administrativo, TimeSpan p_fechaFin, SanurGenNHibernate.Enumerated.Sanur.EstadoEnum p_estado, bool p_emergencia, bool p_imporante)
{
        EpisodioEN episodioEN = null;
        int oid;

        //Initialized EpisodioEN
        episodioEN = new EpisodioEN ();

        if (p_paciente != -1) {
                episodioEN.Paciente = new SanurGenNHibernate.EN.Sanur.PacienteEN ();
                episodioEN.Paciente.IdPaciente = p_paciente;
        }

        episodioEN.FechaInicio = p_fechaInicio;

        episodioEN.Observaciones = p_observaciones;


        if (p_administrativo != -1) {
                episodioEN.Administrativo = new SanurGenNHibernate.EN.Sanur.AdministrativoEN ();
                episodioEN.Administrativo.IdUsuario = p_administrativo;
        }

        episodioEN.FechaFin = p_fechaFin;

        episodioEN.Estado = p_estado;

        episodioEN.Emergencia = p_emergencia;

        episodioEN.Imporante = p_imporante;

        //Call to EpisodioCAD

        oid = _IEpisodioCAD.New_ (episodioEN);
        return oid;
}

public void Modify (int p_Episodio_OID, TimeSpan p_fechaInicio, string p_observaciones, TimeSpan p_fechaFin, SanurGenNHibernate.Enumerated.Sanur.EstadoEnum p_estado, bool p_emergencia, bool p_imporante)
{
        EpisodioEN episodioEN = null;

        //Initialized EpisodioEN
        episodioEN = new EpisodioEN ();
        episodioEN.IdEpisodio = p_Episodio_OID;
        episodioEN.FechaInicio = p_fechaInicio;
        episodioEN.Observaciones = p_observaciones;
        episodioEN.FechaFin = p_fechaFin;
        episodioEN.Estado = p_estado;
        episodioEN.Emergencia = p_emergencia;
        episodioEN.Imporante = p_imporante;
        //Call to EpisodioCAD

        _IEpisodioCAD.Modify (episodioEN);
}

public EpisodioEN ReadOID (int idEpisodio)
{
        EpisodioEN episodioEN = null;

        episodioEN = _IEpisodioCAD.ReadOID (idEpisodio);
        return episodioEN;
}

public System.Collections.Generic.IList<EpisodioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EpisodioEN> list = null;

        list = _IEpisodioCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> ObtenerHistorial (int idPaciente)
{
        return _IEpisodioCAD.ObtenerHistorial (idPaciente);
}
public System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> BuscarParaTriage ()
{
        return _IEpisodioCAD.BuscarParaTriage ();
}
public System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> BuscarParaMedico (SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum destino)
{
        return _IEpisodioCAD.BuscarParaMedico (destino);
}
}
}
