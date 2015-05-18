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
    public partial class Diagnostico : Form
    {
        DiagnosticoCEN diagnosticoCEN = new DiagnosticoCEN();
        EpisodioCEN episodioCEN = new EpisodioCEN();
        TriageCEN triageCEN = new TriageCEN();
        EpisodioEN episodio;
        MedicoEN medico;

        public Diagnostico(MedicoEN medico, EpisodioEN episodio)
        {
            this.medico = medico;
            this.episodio = episodio;
            InitializeComponent();
            inicializarCampos();
        }

        private bool validaDatos()
        {
            if (juicio.Text.ToString().Equals("") || tratamiento.Text.ToString().Equals(""))
            {
                string msg = "Error: No puede haber campos vacíos";
                MessageBoxButtons opc = MessageBoxButtons.OK;
                string leyenda = "Error";
                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBox.Show(msg, leyenda, opc, icono);
                return false;
            }

            return true;
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
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            string msg = "Advertencia: ¿Seguro que desea cancelar?";
            MessageBoxButtons opc = MessageBoxButtons.YesNo;
            string leyenda = "Advertencia";
            MessageBoxIcon icono = MessageBoxIcon.Warning;

            if (MessageBox.Show(msg, leyenda, opc, icono) == DialogResult.Yes)
                Close();
        }

        private void ver_triage_Click(object sender, EventArgs e)
        {
            TriageEN triage = triageCEN.BuscarDeEpisodio(episodio.IdEpisodio);
            HojaTriage hojaTriage = new HojaTriage(medico, episodio);
            hojaTriage.cargarTriage(triage.Destino, triage.Prioridad, triage.Observaciones, triage.MotivoAsist);
            hojaTriage.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (validaDatos() && confirmarDiagnostico())
            {
                //episodio.Estado = EstadoEnum.triaje;

                //epCEN.Modify(episodio.IdEpisodio, episodio.FechaInicio, episodio.Observaciones, episodio.Estado, episodio.Emergencia, episodio.Imporante);
                //idTriage = triageCEN.BuscarUltimo();
                //epCEN.AsignarTriage(episodio.IdEpisodio, idTriage);

                //Crea diagnostico con los camposd el formulario
                DiagnosticoEN diagnostico = new DiagnosticoEN();
                diagnostico.Juicio = juicio.Text.ToString();
                diagnostico.Tratamiento = tratamiento.Text.ToString();
                diagnostico.Hospitalizacion = hospitalizacion.Checked;

                // Cambia estado del episodio para cerrarlo una vez ya se tiene un diagnostico
                episodio.Estado = Enumerated.Sanur.EstadoEnum.cerrado;
                episodioCEN.Modify(episodio.IdEpisodio, episodio.FechaInicio, episodio.Observaciones, episodio.Estado, episodio.Emergencia, episodio.Imporante);

                // Se guarda y se relaciona el diagnostico con el episodio
                diagnosticoCEN.New_(medico.IdUsuario, diagnostico.Juicio, diagnostico.Tratamiento, diagnostico.Hospitalizacion);
                diagnostico.IdDiagnostico = diagnosticoCEN.BuscarUltimo().IdDiagnostico;
                episodioCEN.AsignarDiagnostico(episodio.IdEpisodio, diagnostico.IdDiagnostico);

                /*Principal p = new Principal();

                p.ActualizarGrid();*/

                Close();
            }
        }

        private bool confirmarDiagnostico()
        {
            string msg = "¿Desea confirmar el diagnostico?";
            MessageBoxButtons opc = MessageBoxButtons.YesNo;
            string leyenda = "Confirmar diagnostico";
            MessageBoxIcon icono = MessageBoxIcon.Question;
            if (MessageBox.Show(msg, leyenda, opc, icono) == DialogResult.Yes)
                return true;
            return false;
        }
    }
}
