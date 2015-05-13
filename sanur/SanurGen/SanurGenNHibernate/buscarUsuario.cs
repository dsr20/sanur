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
    public partial class buscarUsuario : Form
    {
        public SanurGenNHibernate.Principal VentanaPrincipal;

        public buscarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioCEN usuarioCEN = new UsuarioCEN();
            UsuarioEN usuarioEN = new UsuarioEN();

            if (Email.Text != "")
            {
                try
                {
                    usuarioEN = usuarioCEN.ReadMail(Email.Text.ToString());

                    dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email);
                }
                catch (Exception error)
                {
                    MessageBox.Show("El usuario no existe");
                }
            }
            else
            {
                IList<UsuarioEN> listaUsuarios= new List<UsuarioEN>();

                String[] listaDatos = new String[4];

                listaUsuarios = usuarioCEN.ReadNombre(Nombre.Text.ToString());

                if (listaUsuarios.Count != 0)
                {
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email);
                    }
                }
                else
                    MessageBox.Show("no existe ningun usuario con ese nombre");
            }
        }
    }
}
