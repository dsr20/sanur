using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;

namespace SanurGenNHibernate
{
    public partial class episodio : Form
    {
        public episodio()
        {
            InitializeComponent();
        }

        private void episodio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EpisodioCEN episodioCEN = null;

            DateTime time = DateTime.Now;
            
            episodioCEN.New_(1,time,null,1,time,SanurGenNHibernate.Enumerated.Sanur.EstadoEnum.espera,false,false);


        }
    }
}
