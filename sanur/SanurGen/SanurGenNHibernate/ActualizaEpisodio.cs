using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.CEN.Sanur;
using System.Collections;

namespace SanurGenNHibernate
{
    public partial class ActualizaEpisodio : Form
    {
        // Añadir esta pagina a la pagina principal (ver principal)
        public SanurGenNHibernate.Principal VentanaPrincipal;
        private PacienteCEN pacienteCEN;
        private TriageCEN triageCEN;
        private EpisodioCEN episodioCEN;
        private MedicoEN medicoEN;
        private Diagnostico diagnostico;

        public ActualizaEpisodio()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            triageCEN = new TriageCEN();
            pacienteCEN = new PacienteCEN();
            episodioCEN = new EpisodioCEN();
        }

        //A medias cargado de datos.
        public void CargarDatosGrid()
        {

            medicoEN = (MedicoEN)VentanaPrincipal.UsuarioIniciado;

            // Obtiene episodios según la especialidad
            List<EpisodioEN> episodios = null;
            episodios = (List<EpisodioEN>)episodioCEN.BuscarParaMedico(medicoEN.Especialidad);
            episodios.Sort(comparaPrioridad);

            // Rellena datos del grid, comprobar..
            for (int i = 0; i < episodios.Count(); i++)
            {
                PacienteEN paciente = pacienteCEN.BuscarDeEpisodio(episodios[i].IdEpisodio);
                TriageEN triage = triageCEN.BuscarDeEpisodio(episodios[i].IdEpisodio);
                string[] fila = {episodios[i].IdEpisodio.ToString(), paciente.IdPaciente.ToString(), paciente.Nombre, triage.Prioridad.ToString(), triage.MotivoAsist, triage.Observaciones, episodios[i].FechaInicio.ToString()};
                dataGridView1.Rows.Add(fila);
            }
        }

        // Comparador para ordenar los episodios por prioridad, COMPROBAR FUNCIONAMIENTO....
        private static int comparaPrioridad(EpisodioEN ep1, EpisodioEN ep2)
        {
            TriageCEN triageCEN = new TriageCEN();
            TriageEN t1 = triageCEN.BuscarDeEpisodio(ep1.IdEpisodio);
            TriageEN t2 = triageCEN.BuscarDeEpisodio(ep2.IdEpisodio);
            return t1.Prioridad - t2.Prioridad; // Comprobar si ordena ascendente o descendente
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EpisodioEN episodio = new EpisodioEN();
            int idEpisodio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            if (idEpisodio != 0)
            {
                episodio = episodioCEN.ReadOID(idEpisodio);
                diagnostico = new Diagnostico(medicoEN, episodio);
                diagnostico.Show();
                //triage = triageCEN.BuscarDeEpisodio(idEpisodio);
            }
        }
    }
}
