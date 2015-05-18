using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.Enumerated.Sanur;
using SanurGenNHibernate.CEN.Sanur;

namespace SanurGenNHibernate
{
    public partial class Historial_Clinico : Form
    {
        public SanurGenNHibernate.Principal VentanaPrincipal;
        private PacienteEN pacienteEn = null;

        public Historial_Clinico()
        {
            InitializeComponent();
        }

        public Historial_Clinico(PacienteEN pacienteEn)
        {
            // TODO: Complete member initialization
            this.pacienteEn = pacienteEn;
            InitializeComponent();
        }


        private void Historial_Clinico_Load(object sender, EventArgs e)
        {
            

            if (pacienteEn != null)
            {
                paciente_nombre.Text = pacienteEn.Nombre;
                EpisodioCEN Episodiocen = new EpisodioCEN();
                IList<EpisodioEN> episodios = new List<EpisodioEN>();
                episodios = Episodiocen.ObtenerHistorial(pacienteEn.IdPaciente);
                if (episodios.Count != 0)
                {
                    for (int i = 0; i < episodios.Count; i++)
                    {
                        dataGridView1.Rows.Add(episodios[i].IdEpisodio, episodios[i].FechaInicio, episodios[i].FechaFin,episodios[i].Observaciones, episodios[i].Emergencia, episodios[i].Imporante);
                    }
                }
                else
                    MessageBox.Show("No hay registrado historial clínico de este paciente.");
            }
            else
            {
                MessageBox.Show("Error al cargar el paciente");
            }

        }


    }
}
