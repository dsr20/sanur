
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IEpisodioCAD
{
EpisodioEN ReadOIDDefault (int idEpisodio);

int New_ (EpisodioEN episodio);

void Modify (EpisodioEN episodio);


EpisodioEN ReadOID (int idEpisodio);


System.Collections.Generic.IList<EpisodioEN> ReadAll (int first, int size);


System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> ObtenerHistorial (int idPaciente);


System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> BuscarParaTriage ();


System.Collections.Generic.IList<SanurGenNHibernate.EN.Sanur.EpisodioEN> BuscarParaMedico (SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum destino);
}
}
