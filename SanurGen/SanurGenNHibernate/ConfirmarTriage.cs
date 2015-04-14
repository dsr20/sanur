using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SanurGenNHibernate
{
    public partial class ConfirmarTriage : Form
    {
        private bool confirmado;

        public bool Confirmado {get {return confirmado;} set{confirmado = value;}}

        public ConfirmarTriage()
        {
            InitializeComponent();
        }

        private void si_Click(object sender, EventArgs e)
        {
            confirmado = true;
            Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            confirmado = false;
            Close();
        }
    }
}
