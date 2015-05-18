using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate
{
    public partial class VerDiagnostico : Form
    {
        DiagnosticoCEN diagnosticoCEN = new DiagnosticoCEN();
        EpisodioCEN episodioCEN = new EpisodioCEN();
        EpisodioEN episodio;
        DiagnosticoEN diagnostico;

        public VerDiagnostico(EpisodioEN episodio)
        {
            this.episodio = episodio;
            InitializeComponent();
            diagnostico = diagnosticoCEN.ReadOID(Convert.ToInt32(episodio.Diagnostico.IdDiagnostico));           
            inicializarCampos();
        }


        public void inicializarCampos()
        {
            PacienteCEN paCEN = new PacienteCEN();
            PacienteEN paciente = paCEN.BuscarDeEpisodio(episodio.IdEpisodio);

            apellidos.Text = paciente.Apellidos;
            nombre.Text = paciente.Nombre;
            dni.Text = paciente.Dni.ToString();
            fnac.Text = paciente.FNac.ToString();
            sexo.Text = paciente.Sexo;
            nacionalidad.Text = paciente.Nacionalidad;
            ciudad.Text = paciente.Ciudad;
            municipio.Text = paciente.Municipio;
            tlf.Text = paciente.Tlf;
            direccion.Text = paciente.Direccion;
            grupoSang.Text = paciente.GrupoSang;
            codpos.Text = paciente.CodigoPostal;
            sip.Text = paciente.Sip.ToString();
            edad.Text = (((DateTime.Now - (DateTime)paciente.FNac).Days) / 365).ToString();

            motivo_general.Text = episodio.Observaciones;
            idEpisodio.Text = episodio.IdEpisodio.ToString();
            fecha.Text = episodio.FechaInicio.ToString();
            juicio.Text = diagnostico.Juicio;
            tratamiento.Text = diagnostico.Tratamiento;
            hospitalizacion.Checked = diagnostico.Hospitalizacion;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
