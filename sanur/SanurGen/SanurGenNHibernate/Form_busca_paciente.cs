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
    public partial class Form_busca_paciente : Form
    {
        public Form_busca_paciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacienteEN pacienteEn = new PacienteEN();
            PacienteCEN pacienteCen = new PacienteCEN();
            if(textBox1.Text!="")
                pacienteEn = pacienteCen.BuscarDNI( Convert.ToInt32( textBox1.Text));
            else if (textBox2.Text != "")
                pacienteEn = pacienteCen.BuscarSIP(Convert.ToInt32(textBox2.Text));
            else
                   MessageBox.Show("Introduce DNI o SIP");

            if (pacienteEn == null)
            {
                MessageBox.Show("No se encuentra el paciente.");
            }
            else
            {
                tnombre.Text = pacienteEn.Nombre;
                tapellidos.Text = pacienteEn.Apellidos;
                tdni.Text = Convert.ToString( pacienteEn.Dni);
                temail.Text = pacienteEn.Email; 
                tdireccion.Text = pacienteEn.Direccion;
                tsip.Text = Convert.ToString(pacienteEn.Sip);
                ttelefono.Text = pacienteEn.Tlf;
                tnacionalidad.Text = pacienteEn.Nacionalidad;
                tmunicipio.Text = pacienteEn.Municipio;
                tsexo.Text = pacienteEn.Sexo;
                tciudad.Text = pacienteEn.Ciudad;
                tgp.Text = pacienteEn.GrupoSang;
                tcp.Text = pacienteEn.CodigoPostal;
                tips.Text = pacienteEn.Ips;

                // Conversión fecha manual
                string aux = Convert.ToString(pacienteEn.FNac);
                string aux2= "";
                for (int i = 0; i < aux.Length; i++)
                {
                    if (aux[i] == ' ')
                        break;
                    aux2 += aux[i];
                }
                ////////////////////////////////

                tfechanac.Text = aux2;
            }

        }

        private void Form_busca_paciente_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
