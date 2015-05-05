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
    public partial class altaUsuario : Form
    {
        public SanurGenNHibernate.Principal VentanaPrincipal;

        public altaUsuario()
        {
            InitializeComponent();
        }

        private void crear_Click(object sender, EventArgs e)
        {
            UsuarioCEN usuarioCEN = new UsuarioCEN();
            UsuarioEN usuarioEN = new UsuarioEN();
            MedicoCEN medicoCEN = new MedicoCEN();
            AdministradorCEN administradorCEN = new AdministradorCEN();
            AdministrativoCEN administrativoCEN = new AdministrativoCEN();

            string mensaje = "¿Seguro de que desea crear un nuevo usuario con estos datos?";
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            string leyenda = "Crear usuario";
            DialogResult resultado;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            resultado = MessageBox.Show(mensaje, leyenda, opciones, icono);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    //usuarioCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString());
                    if (tipo.Text.ToString() == "Medico")
                        medicoCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString(), obtenerEspecialidad());
                    else if (tipo.Text.ToString() == "Administrativo")
                        administrativoCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString());
                    else if (tipo.Text.ToString() == "Administrador")
                        administradorCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString());

                    usuarioEN = usuarioCEN.ReadMail(email.Text.ToString());
                    MessageBox.Show("Usuario creado correctamente con el Id:" + usuarioEN.IdUsuario.ToString(), "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }                
            }
            else
                Close();
        }

        private EspecialidadEnum obtenerEspecialidad()
        {
            if (especialidad.Text.ToString() == "Ginecología")
                return EspecialidadEnum.ginecologia;
            else if (especialidad.Text.ToString() == "Traumatología")
                return EspecialidadEnum.traumatologia;
            else if (especialidad.Text.ToString() == "Pediatría")
                return EspecialidadEnum.pediatria;
            else if (especialidad.Text.ToString() == "Psiquiatría")
                return EspecialidadEnum.psiquiatria;
            else
                return EspecialidadEnum.interna;
        }

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipo.Text.ToString() == "Medico")
            {
                especialidad.Visible = true;
                label6.Visible = true;
            }
            else
            {
                especialidad.Visible = false;
                label6.Visible = false;
            }
        }

        private void altaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
