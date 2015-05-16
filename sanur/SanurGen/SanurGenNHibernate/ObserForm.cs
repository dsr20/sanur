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


// CREAR PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;

namespace SanurGenNHibernate
{
    public partial class ObserForm : Form
    {
        private SanurGenNHibernate.EN.Sanur.EpisodioEN episodio;

        public ObserForm(SanurGenNHibernate.EN.Sanur.EpisodioEN episodioEN)
        {
            InitializeComponent();
            this.episodio = episodioEN; // COPIAMOS LOS DATOS DEL FORM ANTERIOR
        }

        private void ObserForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           this.episodio.Observaciones = textBox1.Text;
           EpisodioCEN episodioCEN = new EpisodioCEN();
           try
           {
               DialogResult res = MessageBox.Show("¿Está seguro de que desea crear un episodio?", "Crear episodio", MessageBoxButtons.YesNo);
               if (res == System.Windows.Forms.DialogResult.Yes)
               {
                   episodioCEN.New_(episodio.Paciente.IdPaciente, episodio.FechaInicio, episodio.Observaciones, episodio.Administrativo.IdUsuario, Enumerated.Sanur.EstadoEnum.triaje, false, false);
                   creaPDF(episodio);
                   this.Close();
               }
           }catch (NullReferenceException)
           {
                MessageBox.Show("Necesita especificar un paciente");
           }
        }

        public EpisodioEN getObservaciones() { return episodio; }


        // MÉTODO PARA CREAR EL PDF
        private void creaPDF(EpisodioEN episodioEN)
        {
            Document doc = new Document();

            iTextSharp.text.pdf.PdfWriter pdf;
            try
            {
                pdf = PdfWriter.GetInstance(doc,

                              new FileStream(@"paciente_N" + episodioEN.Paciente.Dni + ".pdf", FileMode.Create));
            }
            catch (IOException) 
            {
                File.Delete("paciente_N" + episodioEN.Paciente.Dni + ".pdf");
                
               
                pdf = PdfWriter.GetInstance(doc,

                              new FileStream(@"paciente_N" + episodioEN.Paciente.Dni + ".pdf", FileMode.Create)); // BORRAMOS
            }


            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 12, iTextSharp.text.Font.BOLD);

            doc.Open();

            // EMPEZAMOS A RELLENAR EL DOCUMENTO


            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../../../pdf/Logo_Hospital.JPG");
            doc.Add(jpg);


            PdfPTable table = new PdfPTable(3);

            table.WidthPercentage = 100f;

            table.AddCell("Fecha/Hora");


            PdfPCell cell = new PdfPCell(new Phrase("Dirección"));
            cell.Colspan = 2;
            table.AddCell(cell);

            table.AddCell(episodioEN.FechaInicio.ToString());

            PdfPCell movcell = new PdfPCell(new Phrase("Hospital de San Javier - Departamento de Urgencias"));

            movcell.Colspan = 2;
            table.AddCell(movcell);

            doc.Add(table);

            doc.Add(new Paragraph("Datos del Paciente"));

            PdfContentByte rectangulo = pdf.DirectContent;

            rectangulo.Rectangle(50, 450, 500, 150);


            PdfPTable tableDat = new PdfPTable(6);
            tableDat.WidthPercentage = 80f;
            tableDat.SpacingBefore = 50;


            PdfPCell ncell = new PdfPCell(new Phrase("Nombre", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            tableDat.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Nombre));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            tableDat.AddCell(ncell);

            ncell = new PdfPCell(new Phrase("Apellidos", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            tableDat.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Apellidos));
            ncell.Colspan = 3;
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            tableDat.AddCell(ncell);

            doc.Add(tableDat);
            // FILA NUEVA

            PdfPTable table2 = new PdfPTable(6);
            table2.WidthPercentage = 80f;
            table2.SpacingBefore = 10f;

            ncell = new PdfPCell(new Phrase("DNI", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table2.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Dni));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table2.AddCell(ncell);


            ncell = new PdfPCell(new Phrase("Nº SS", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table2.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Sip));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table2.AddCell(ncell);

            ncell = new PdfPCell(new Phrase("Sexo", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table2.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Sexo));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table2.AddCell(ncell);

            doc.Add(table2);
            // FILA NUEVA

            PdfPTable table3 = new PdfPTable(6);
            table3.WidthPercentage = 80f;
            table3.SpacingBefore = 10f;

            ncell = new PdfPCell(new Phrase("País", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table3.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Nacionalidad));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table3.AddCell(ncell);


            ncell = new PdfPCell(new Phrase("Grupo Sanguineo", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            ncell.Colspan = 2;
            table3.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.GrupoSang));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table3.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(""));
            ncell.BorderWidth = 0;
            table3.AddCell(ncell);

            doc.Add(table3);

            // FILA NUEVA
            PdfPTable table4 = new PdfPTable(4);
            table4.WidthPercentage = 80f;
            table4.SpacingBefore = 10f;


            ncell = new PdfPCell(new Phrase("Direccion", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table4.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Direccion));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table4.AddCell(ncell);

            ncell = new PdfPCell(new Phrase("Telefono", times));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table4.AddCell(ncell);

            ncell = new PdfPCell(new Phrase(episodioEN.Paciente.Tlf));
            ncell.BorderWidth = 0;
            ncell.BorderWidthBottom = 1f;
            table4.AddCell(ncell);

            table4.AddCell(ncell);
            table4.SpacingAfter = 30;

            doc.Add(table4);

            doc.Add(new Paragraph("Motivo de la asistencia"));

            PdfPTable table5 = new PdfPTable(1);
            table5.WidthPercentage = 80f;
            table5.SpacingBefore = 30f;

            String str = episodioEN.Observaciones;

            string[] palabras = str.Split(',', '-', '.', ' ');
            String str2 = "";

            int iter = 0;

            for (int i = 0; i < palabras.Length; i++)
            {

                if (iter == 11 || i == palabras.Length - 1)
                {
                    if (i == palabras.Length - 1)
                        str2 += palabras[i] + " ";

                    ncell = new PdfPCell(new Phrase(str2));

                    ncell.BorderWidth = 0;
                    ncell.BorderWidthBottom = 1f;
                    table5.AddCell(ncell);
                    iter = 0;
                    str2 = "";
                }
                iter++;
                str2 += palabras[i] + " ";

            }

            doc.Add(table5);

            rectangulo.Stroke();

            doc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
