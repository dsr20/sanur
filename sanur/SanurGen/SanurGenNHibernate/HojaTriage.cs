﻿using System;
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
    public partial class HojaTriage : Form
    {
        private int idMedico;
        private EpisodioEN episodio;

        // El médico que actúa de usuario actual se recibe por parametro
        public HojaTriage(int idMedico, EpisodioEN episodio)
        {
            this.idMedico = idMedico;
            this.episodio = episodio;
            InitializeComponent();
            inicializarCampos();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            TriageEN triage = new TriageEN();
            TriageCEN triageCEN = new TriageCEN();

            if (validaDatos() && confirmarTriage())
            {
                triage.Destino = obtenerDestino();
                triage.Prioridad = obtenerPrioridad();
                triage.MotivoAsist = motivo.Text.ToString();
                triage.Observaciones = observaciones.Text.ToString();

                triageCEN.New_(idMedico, triage.Prioridad, triage.MotivoAsist, triage.Destino, triage.Observaciones);
                Close();
            }
        }

        private EspecialidadEnum obtenerDestino()
        {
            if (destino.Text.ToString() == "Ginecología")
                return EspecialidadEnum.ginecologia;
            else if (destino.Text.ToString() == "Traumatología")
                return EspecialidadEnum.traumatologia;
            else if (destino.Text.ToString() == "Pediatría")
                return EspecialidadEnum.pediatria;
            else if (destino.Text.ToString() == "Psiquiatría")
                return EspecialidadEnum.psiquiatria;
            else
                return EspecialidadEnum.interna;
        }

        private PrioridadEnum obtenerPrioridad()
        {
            if (prioridad.Text.ToString() == "Inmediata")
                return PrioridadEnum.inmediata;
            else if (prioridad.Text.ToString() == "Preferente")
                return PrioridadEnum.preferente;
            else if (prioridad.Text.ToString() == "Urgente")
                return PrioridadEnum.urgente;
            else if (prioridad.Text.ToString() == "Normal")
                return PrioridadEnum.normal;
            else
                return PrioridadEnum.no_urgente;
        }

        private bool validaDatos()
        {
            if (destino.Text.ToString().Equals("") || prioridad.Text.ToString().Equals("") || motivo.Text.ToString().Equals("") || observaciones.Text.ToString().Equals(""))
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

        private void cancelar_Click(object sender, EventArgs e)
        {
            string msg = "Advertencia: ¿Seguro que desea cancelar?";
            MessageBoxButtons opc = MessageBoxButtons.YesNo;
            string leyenda = "Advertencia";
            MessageBoxIcon icono = MessageBoxIcon.Warning;

            if (MessageBox.Show(msg, leyenda, opc, icono) == DialogResult.Yes)
                Close();
        }

        private bool confirmarTriage()
        {
            string msg = "¿Desea confirmar la hoja de triage?";
            MessageBoxButtons opc = MessageBoxButtons.YesNo;
            string leyenda = "Confirmar hoja";
            MessageBoxIcon icono = MessageBoxIcon.Question;
            if (MessageBox.Show(msg, leyenda, opc, icono) == DialogResult.Yes)
                return true;
            return false;
        }

        private void inicializarCampos()
        {
            apellidos.Text = episodio.Paciente.Apellidos;
            nombre.Text = episodio.Paciente.Nombre;
            dni.Text = episodio.Paciente.Dni.ToString();
            fnac.Text = episodio.Paciente.FNac.ToString();
            sexo.Text = episodio.Paciente.Sexo;
            nacionalidad.Text = episodio.Paciente.Nacionalidad;
            ciudad.Text = episodio.Paciente.Ciudad;
            municipio.Text = episodio.Paciente.Municipio;
            tlf.Text = episodio.Paciente.Tlf;
            direccion.Text = episodio.Paciente.Direccion;
            grupoSang.Text = episodio.Paciente.GrupoSang;
            codpos.Text = episodio.Paciente.CodigoPostal;
            sip.Text = episodio.Paciente.Sip.ToString();
            edad.Text = ((((DateTime)episodio.Paciente.FNac - DateTime.Now).Days) / 365).ToString();
        }
    }
}
