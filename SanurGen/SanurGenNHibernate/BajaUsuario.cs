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
    public partial class BajaUsuario : Form
    {
        public SanurGenNHibernate.Principal VentanaPrincipal;

        public BajaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioEN usuarioEN = new UsuarioEN();
            UsuarioCEN usuarioCEN = new UsuarioCEN();

            try
            {
                usuarioEN = usuarioCEN.ReadMail(emailantiguo.Text.ToString());
                nombre.Text = usuarioEN.Nombre.ToString();
                apellidos.Text = usuarioEN.Apellidos.ToString();
                emailnuevo.Text = usuarioEN.Email.ToString();
                contrasena.Text = usuarioEN.Contrasena.ToString();
            }
            catch (Exception except)
            {
                MessageBox.Show("El usuario no existe", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioEN usuarioEN = new UsuarioEN();
            UsuarioCEN usuarioCEN = new UsuarioCEN();

            MedicoCEN medicoCEN = new MedicoCEN();
            AdministradorCEN administradorCEN = new AdministradorCEN();
            AdministrativoCEN administrativoCEN = new AdministrativoCEN();

            usuarioEN = usuarioCEN.ReadMail(emailantiguo.Text.ToString());

            if (usuarioEN.IdUsuario != VentanaPrincipal.UsuarioIniciado.IdUsuario)
            {
                try
                {
                    administradorCEN.Destroy(usuarioEN.IdUsuario);
                    MessageBox.Show("El usuario ha sido eliminado correctamente", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    try
                    {
                        administrativoCEN.Destroy(usuarioEN.IdUsuario);
                        MessageBox.Show("El usuario ha sido eliminado correctamente", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exc)
                    {
                        try
                        {
                            medicoCEN.Destroy(usuarioEN.IdUsuario);
                            MessageBox.Show("El usuario ha sido eliminado correctamente", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show("Error al eliminar el usuario", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
                MessageBox.Show("No puedes modificar el usuario que ha iniciado la sesión");
        }
    }
}
