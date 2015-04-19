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

// CREAR PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
namespace SanurGenNHibernate
{
    public partial class Form_busca_paciente : Form
    {
        private PacienteEN pacienteEn;
        private UsuarioEN usuarioEN;

        public Form_busca_paciente()
        {
            InitializeComponent();
        }

        public Form_busca_paciente(UsuarioEN usuario)
        {
            InitializeComponent();
            this.usuarioEN = usuario;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            PacienteCEN pacienteCen = new PacienteCEN();
            if(textBox1.Text!="")
                this.pacienteEn = pacienteCen.BuscarDNI( Convert.ToInt32( textBox1.Text));
            else if (textBox2.Text != "")
                this.pacienteEn = pacienteCen.BuscarSIP(Convert.ToInt32(textBox2.Text));
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            EpisodioEN episodioEN = new EpisodioEN();
            EpisodioCEN episodioCEN = new EpisodioCEN();

          /*  episodioEN.Paciente = pacienteEn;
            episodioEN.FechaInicio = time;
            episodioEN.FechaFin = time;

            episodioEN.Administrativo = new AdministrativoEN(usuarioEN.IdUsuario,usuarioEN.Nombre,usuarioEN.Contrasena,usuarioEN.Iniciado,usuarioEN.Email,usuarioEN.Apellidos);
            episodioEN.Diagnostico = new DiagnosticoEN();
            episodioEN.Emergencia = false;
            episodioEN.Imporante = false;
            episodioEN.Estado = Enumerated.Sanur.EstadoEnum.espera;
            episodioEN.Triage = null;
            episodioEN.Observaciones = "";*/

            
            episodioCEN.New_(pacienteEn.IdPaciente, time, "",usuarioEN.IdUsuario, Enumerated.Sanur.EstadoEnum.espera, false, false);
           // episodioCEN.New_(1, new DateTime(2000, 10, 20), "Dolor en el torax", 2, Enumerated.Sanur.EstadoEnum.espera, false, false);
            this.Close();
            MessageBox.Show("Episodio creado existosamente");
           // creaPDF(episodioEN);
        }

        private void creaPDF(EpisodioEN episodioEN)
        {
            Document doc = new Document();

            PdfWriter.GetInstance(doc,

                          new FileStream(@"paciente_N" + episodioEN.Paciente.Dni + ".pdf", FileMode.Create));


            doc.Open();

            // EMPEZAMOS A RELLENAR EL DOCUMENTO


            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../../../pdf/Logo_Hospital.JPG");
            doc.Add(jpg);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre"));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido"));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("País"));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase(episodioEN.Paciente.Nombre));
            clNombre.BorderWidth = 0;

            clApellido = new PdfPCell(new Phrase(episodioEN.Paciente.Apellidos));
            clApellido.BorderWidth = 0;

            clPais = new PdfPCell(new Phrase(episodioEN.Paciente.Nacionalidad));
            clPais.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            PdfPCell clDni = new PdfPCell(new Phrase("DNI"));
            clDni.BorderWidth = 0;
            clDni.BorderWidthBottom = 0.75f;

            PdfPCell clSip = new PdfPCell(new Phrase("SIP"));
            clSip.BorderWidth = 0;
            clSip.BorderWidthBottom = 0.75f;

            PdfPCell clIps = new PdfPCell(new Phrase("IPS"));
            clIps.BorderWidth = 0;
            clIps.BorderWidthBottom = 0.75f;

            tblPrueba.AddCell(clDni);
            tblPrueba.AddCell(clSip);
            tblPrueba.AddCell(clIps);

            clDni = new PdfPCell(new Phrase(episodioEN.Paciente.Nombre));
            clDni.BorderWidth = 0;

            clSip = new PdfPCell(new Phrase(episodioEN.Paciente.Apellidos));
            clSip.BorderWidth = 0;

            clIps = new PdfPCell(new Phrase(episodioEN.Paciente.Nacionalidad));
            clIps.BorderWidth = 0;

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);
            doc.Close();
        }
    }
}
