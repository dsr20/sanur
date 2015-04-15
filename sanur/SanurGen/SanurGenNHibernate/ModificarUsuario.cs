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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioEN usuarioEN = new UsuarioEN();
            UsuarioCEN usuarioCEN = new UsuarioCEN();
            MedicoCEN medicoCEN = new MedicoCEN();
            //MedicoEN medicoEN = new MedicoEN();

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
                MessageBox.Show("El usuario no existe", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioEN usuarioEN = new UsuarioEN();
            UsuarioCEN usuarioCEN = new UsuarioCEN();

            MedicoCEN medicoCEN = new MedicoCEN();
            MedicoEN medicoEN = new MedicoEN();
            AdministradorCEN administradorCEN = new AdministradorCEN();
            AdministrativoCEN administrativoCEN = new AdministrativoCEN();

            usuarioEN = usuarioCEN.ReadMail(emailantiguo.Text.ToString());

            try
            {
                administradorCEN.Modify(usuarioEN.IdUsuario, nombre.Text.ToString(), contrasena.Text.ToString(), usuarioEN.Iniciado, emailnuevo.Text.ToString(), apellidos.Text.ToString());
                MessageBox.Show("El usuario ha sido modificado correctamente", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                try
                {
                    administrativoCEN.Modify(usuarioEN.IdUsuario, nombre.Text.ToString(), contrasena.Text.ToString(), usuarioEN.Iniciado, emailnuevo.Text.ToString(), apellidos.Text.ToString());
                    MessageBox.Show("El usuario ha sido modificado correctamente", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    try
                    {
                        medicoEN = medicoCEN.ReadOID(usuarioEN.IdUsuario);
                        medicoCEN.Modify(usuarioEN.IdUsuario, nombre.Text.ToString(), contrasena.Text.ToString(), usuarioEN.Iniciado, emailnuevo.Text.ToString(), apellidos.Text.ToString(), medicoEN.Especialidad);
                        MessageBox.Show("El usuario ha sido modificado correctamente", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Error al modificar el usuario","Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
