using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;
using SanurGenNHibernate.Enumerated.Sanur;

namespace SanurGenNHibernate
{
    public partial class bCrearEpisodio : Form
    {
        public bCrearEpisodio()
        {
            InitializeComponent();
        }

        private void bCrearEpisodio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            DateTime myDate2 = DateTime.Now;
            
            EpisodioCEN episodio = new EpisodioCEN();
           /* String str = GetTimeStamp();
            TimeSpan toi =TypeDescriptor.GetConverter(horaActual).ConvertTo(horaActual, typeof(TimeSpan)); 
            
            episodio.New_(1, myDate2, "hola", 1, myDate2, EstadoEnum.espera, false, false);*/

           
        }
    }
}
