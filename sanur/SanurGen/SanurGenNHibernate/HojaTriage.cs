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
    public partial class HojaTriage : Form
    {
        public HojaTriage()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            TriageEN triage = new TriageEN();
            TriageCEN triageCEN = new TriageCEN();
            ConfirmarTriage confirmar = new ConfirmarTriage();
            confirmar.ShowDialog();

            if (confirmar.Confirmado)
            {
                triage.Destino = obtenerDestino();
                triage.Prioridad = obtenerPrioridad();
                triage.MotivoAsist = motivo.Text.ToString();
                triage.Observaciones = observaciones.Text.ToString();

                // HAY QUE MODIFICAR EL MEDICO (PRIMER PARAMETRO)
                triageCEN.New_(1, triage.Prioridad, triage.MotivoAsist, triage.Destino, triage.Observaciones);
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

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
