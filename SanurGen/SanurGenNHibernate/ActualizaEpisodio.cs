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

            if (medicoEN.Especialidad == Enumerated.Sanur.EspecialidadEnum.triage) 
            {
                this.dataGridView1.Columns["Observaciones"].Visible = false;
                this.dataGridView1.Columns["Prioridad"].Visible = false;
            }
            

            // Obtiene episodios según la especialidad
            List<EpisodioEN> episodios = null;

            // Obtener episodios pendientes de triage o de diagnostico
            if (medicoEN.Especialidad == Enumerated.Sanur.EspecialidadEnum.triage)
                episodios = (List<EpisodioEN>)episodioCEN.BuscarParaTriage();
            else
                episodios = (List<EpisodioEN>)episodioCEN.BuscarParaMedico(medicoEN.Especialidad);
            //episodios.Sort(comparaPrioridad);
            

            // ------ TRIAGE ------
            if (medicoEN.Especialidad == Enumerated.Sanur.EspecialidadEnum.triage)
                // Rellena datos del grid, comprobar..
                for (int i = 0; i < episodios.Count(); i++)
                {
                    PacienteEN paciente = pacienteCEN.BuscarDeEpisodio(episodios[i].IdEpisodio);
                    TriageEN triage = triageCEN.BuscarDeEpisodio(episodios[i].IdEpisodio);

                    //string[] fila = {episodios[i].IdEpisodio.ToString(), paciente.IdPaciente.ToString(), paciente.Nombre, triage.Prioridad.ToString(), triage.MotivoAsist, triage.Observaciones, episodios[i].FechaInicio.ToString()};
                    string[] fila = { episodios[i].IdEpisodio.ToString(), paciente.IdPaciente.ToString(), paciente.Nombre, episodios[i].Observaciones, episodios[i].FechaInicio.ToString() };
                    dataGridView1.Rows.Add(fila);
                }
            else 
            {
                // ------ MEDICOS ------
                for (int i = 0; i < episodios.Count(); i++)
                {
                    PacienteEN paciente = pacienteCEN.BuscarDeEpisodio(episodios[i].IdEpisodio);
                    TriageEN triage = triageCEN.BuscarDeEpisodio(episodios[i].IdEpisodio);

                    string[] fila = { episodios[i].IdEpisodio.ToString(), paciente.IdPaciente.ToString(), paciente.Nombre, triage.Observaciones, episodios[i].FechaInicio.ToString(), triage.Prioridad.ToString(), triage.MotivoAsist};
                    
                    dataGridView1.Rows.Add(fila);
                }
            }
        }

        // Comparador para ordenar los episodios por prioridad, COMPROBAR FUNCIONAMIENTO....
        /*private static int comparaPrioridad(EpisodioEN ep1, EpisodioEN ep2)
        {
            TriageCEN triageCEN = new TriageCEN();
            TriageEN t1 = triageCEN.BuscarDeEpisodio(ep1.IdEpisodio);
            TriageEN t2 = triageCEN.BuscarDeEpisodio(ep2.IdEpisodio);
            return t1.Prioridad - t2.Prioridad; // Comprobar si ordena ascendente o descendente
        }*/ //No es necesario...

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EpisodioEN episodio = new EpisodioEN();
            int idEpisodio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            
            // Si la fila seleccionada contiene datos...
            if (idEpisodio != 0)
            {
                episodio = episodioCEN.ReadOID(idEpisodio);

                // Se debe abrir la ventana correspondiente a segun si esta pendiente de triage o de diagnostico
                if (medicoEN.Especialidad == Enumerated.Sanur.EspecialidadEnum.triage)
                {
                    HojaTriage triage = new HojaTriage(medicoEN, episodio);
                    triage.Show();
                    triage.Refresh();
                }
                else
                {
                    Diagnostico diagnostico = new Diagnostico(medicoEN, episodio);
                    diagnostico.Show();
                    diagnostico.Refresh();
                }
                
            }
        }
    }
}
