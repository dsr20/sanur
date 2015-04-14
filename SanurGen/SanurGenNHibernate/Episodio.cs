using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;

// CREAR PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using SanurGenNHibernate.EN.Sanur; 

namespace SanurGenNHibernate
{
    public partial class Episodio : Form
    {
        public Episodio()
        {
            InitializeComponent();
        }

        private void episodio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DateTime time = DateTime.Now;
            EpisodioEN episodioEN = new EpisodioEN();
            EpisodioCEN episodioCEN = new EpisodioCEN();

            episodioEN.Estado = SanurGenNHibernate.Enumerated.Sanur.EstadoEnum.espera;
            episodioEN.FechaInicio = time;
            episodioEN.Paciente = new PacienteEN();
            episodioEN.Emergencia = true;
            episodioEN.Administrativo = new AdministrativoEN();

            episodioCEN.New_();
            creaPDF(episodioEN);
        }

        private void creaPDF(EpisodioEN episodioEN) 
        {
            Document doc = new Document();
            
            PdfWriter.GetInstance(doc,

                          new FileStream(@"paciente_N"+episodioEN.Paciente.Dni+".pdf", FileMode.Create));


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
