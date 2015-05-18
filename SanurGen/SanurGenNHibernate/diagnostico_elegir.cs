using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate
{
    public partial class diagnostico_elegir : Form
    {
        private EN.Sanur.PacienteEN pacienteEn;

        public diagnostico_elegir()
        {
            InitializeComponent();
        }

        public diagnostico_elegir(EN.Sanur.PacienteEN pacienteEn)
        {
            // TODO: Complete member initialization
            this.pacienteEn = pacienteEn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                EpisodioCEN episodiocen = new EpisodioCEN();
                EpisodioEN episodio = new EpisodioEN();
                episodio = episodiocen.ReadOID(Convert.ToInt32(textidepisodio.Text));
                VerDiagnostico diagnostico = new VerDiagnostico(episodio);
                diagnostico.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Episodio Erróneo o diagnóstico no especificado aún");
            }

        }

    }
}
