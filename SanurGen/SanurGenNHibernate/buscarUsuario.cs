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
            dataGridView1.Rows.Clear();

            UsuarioCEN usuarioCEN = new UsuarioCEN();
            UsuarioEN usuarioEN = new UsuarioEN();

            if (Email.Text != "")
            {
                try
                {
                    usuarioEN = usuarioCEN.ReadMail(Email.Text.ToString());

                    if (VentanaPrincipal.CompruebaUsuario(usuarioEN.IdUsuario) == "Medico")
                    {
                        MedicoCEN medicoCEN = new MedicoCEN();
                        MedicoEN medicoEN = new MedicoEN();

                        medicoEN = medicoCEN.ReadOID(usuarioEN.IdUsuario);

                        if (medicoEN.Especialidad == EspecialidadEnum.ginecologia)
                        {
                            dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email, true, false, false, "Ginecología");
                        }
                        else if (medicoEN.Especialidad == EspecialidadEnum.pediatria)
                        {
                            dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email, true, false, false, "Pediatría");
                        }
                        else if (medicoEN.Especialidad == EspecialidadEnum.psiquiatria)
                        {
                            dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email, true, false, false, "Psiquiatría");
                        }
                        else if (medicoEN.Especialidad == EspecialidadEnum.traumatologia)
                        {
                            dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email, true, false, false, "Traumatología");
                        }
                        else if (medicoEN.Especialidad == EspecialidadEnum.triage)
                        {
                            dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email, true, false, false, "Triaje");
                        }
                    }
                    else if (VentanaPrincipal.CompruebaUsuario(usuarioEN.IdUsuario) == "Administrador")
                    {
                        dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email, false, true, false);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(usuarioEN.IdUsuario, usuarioEN.Nombre, usuarioEN.Apellidos, usuarioEN.Email, false, false, true);
                    }
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
                        if (VentanaPrincipal.CompruebaUsuario(listaUsuarios[i].IdUsuario) == "Medico")
                        {
                            MedicoCEN medicoCEN = new MedicoCEN();
                            MedicoEN medicoEN = new MedicoEN();

                            medicoEN = medicoCEN.ReadOID(listaUsuarios[i].IdUsuario);

                            if (medicoEN.Especialidad == EspecialidadEnum.ginecologia)
                            {
                                dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email, true, false, false, "Ginecología");
                            }
                            else if (medicoEN.Especialidad == EspecialidadEnum.pediatria)
                            {
                                dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email, true, false, false, "Pediatría");
                            }
                            else if (medicoEN.Especialidad == EspecialidadEnum.psiquiatria)
                            {
                                dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email, true, false, false, "Psiquiatría");
                            }
                            else if (medicoEN.Especialidad == EspecialidadEnum.traumatologia)
                            {
                                dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email, true, false, false, "Traumatología");
                            }
                            else if (medicoEN.Especialidad == EspecialidadEnum.triage)
                            {
                                dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email, true, false, false, "Triaje");
                            }
                        }
                        else if (VentanaPrincipal.CompruebaUsuario(listaUsuarios[i].IdUsuario) == "Administrador")
                        {
                            dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email, false, true, false);
                        }
                        else
                        {
                            dataGridView1.Rows.Add(listaUsuarios[i].IdUsuario, listaUsuarios[i].Nombre, listaUsuarios[i].Apellidos, listaUsuarios[i].Email, false, false, true);
                        }
                    }
                }
                else
                    MessageBox.Show("no existe ningun usuario con ese nombre");
            }
        }
    }
}
