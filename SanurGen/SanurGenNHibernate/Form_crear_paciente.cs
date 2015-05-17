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

namespace SanurGenNHibernate
{
    public partial class Form_crear_paciente : Form
    {
        public Form_crear_paciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacienteEN pacienteEn=new PacienteEN();
            
            // Validación de los datos (versión rápida enfocada a compatibilidad con la BD)
            if(TNombre.Text.Length < 1)
                MessageBox.Show("El nombre del paciente no puede ser vacío");
            else if (TApellido.Text.Length < 1)
                MessageBox.Show("El apellido del paciente no puede ser vacío");
            else if (TTelefono.Text.Length != 9)
                MessageBox.Show("El telefono del paciente no puede ser vacío o es incorrecto");
            else if (TDireccion.Text.Length < 1)
                MessageBox.Show("La direccion del paciente no puede ser vacío");
            else if (TNacionalidad.Text.Length < 1)
                MessageBox.Show("La nacionalidad del paciente no puede ser vacío");
            else if (TDNI.Text.Length != 8)
                MessageBox.Show("El DNI tiene un formato incorrecto");
            else if (TEmail.Text.Length < 1)
                MessageBox.Show("El email no puede estar vacío");
            else if (TMunicipio.Text.Length < 1)
                MessageBox.Show("El municipio no puede estar vacío");
            else if (TGS.Text.Length < 1)
                MessageBox.Show("El grupo sanguíneo no puede estar vacío");
            else if (TCP.Text.Length < 1)
                MessageBox.Show("El código postal no puede estar vacío");
            else if (TIPS.Text.Length < 1)
                MessageBox.Show("El campo IPS no puede ser vacío");
            else if (tciudad.Text.Length < 1)
                MessageBox.Show("El campo ciudad no puede ser vacío");
            else
            {
                try
                {

                    PacienteCEN pacienteCen = new PacienteCEN();
                    pacienteCen.New_(TNombre.Text, TApellido.Text, dateTimePicker1.Value, TTelefono.Text, TDireccion.Text, TNacionalidad.Text, Convert.ToInt32(TSip.Text), Convert.ToInt32(TDNI.Text), selector_sexo.Text, TEmail.Text, TMunicipio.Text, TGS.Text, TCP.Text, TIPS.Text, tciudad.Text);
                    TNombre.Clear();
                    TApellido.Clear();
                    TTelefono.Clear();
                    TDireccion.Clear();
                    TNacionalidad.Clear();
                    TSip.Clear();
                    TDNI.Clear();
                    TEmail.Clear();
                    TMunicipio.Clear();
                    TGS.Clear();
                    TCP.Clear();
                    TIPS.Clear();
                    tciudad.Clear();
                    MessageBox.Show("Paciente creado con Éxito");
                }
                catch (Exception)
                {
                    MessageBox.Show("Redundancia de datos - Usuario ya existente en la BD");
                }
             

            }


       }
       private void textBox9_TextChanged(object sender, EventArgs e)
       {

       }

       private void TNombre_TextChanged(object sender, EventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }
       private void label3_Click(object sender, EventArgs e)
       {

       }

       private void button2_Click(object sender, EventArgs e)
       {
           this.Close();
       }
 

    }
}
