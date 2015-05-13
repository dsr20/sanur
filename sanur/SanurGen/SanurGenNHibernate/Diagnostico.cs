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
    public partial class Diagnostico : Form
    {
        EpisodioEN episodio;
        MedicoEN medico;
        PacienteEN paciente;

        public Diagnostico(MedicoEN medico, EpisodioEN episodio)
        {
            InitializeComponent(); 
            //medico = (MedicoEN)VentanaPrincipal.UsuarioIniciado;
            this.medico = medico;
            this.episodio = episodio;
            InitializeComponent();
            inicializarCampos();
        }

        public void inicializarCampos()
        {
            PacienteCEN paCEN = new PacienteCEN();
            paciente = paCEN.BuscarDeEpisodio(episodio.IdEpisodio);

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
    }
}
