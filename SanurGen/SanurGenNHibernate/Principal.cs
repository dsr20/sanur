using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.CEN.Sanur;

namespace SanurGenNHibernate
{
    public partial class Principal : Form
    {
        MedicoCEN MedicoCen = new MedicoCEN();
        AdministrativoCEN AdministrativoCen = new AdministrativoCEN();
        AdministrativoEN AdministrativoEn = new AdministrativoEN();
        MedicoEN MedicoEn = new MedicoEN();

        //----- DECLARACION DE DATOS PUBLICOS --------
        public UsuarioEN UsuarioIniciado;
        
        public bool Sesion_ini = false;
        public String TipoUsuario = "";

        //------- DECLARACIÓN DE VENTANAS --------
        SanurGenNHibernate.Login login;
        SanurGenNHibernate.altaUsuario altausuario;
        SanurGenNHibernate.BajaUsuario bajausuario;
        SanurGenNHibernate.ModificarUsuario modusuario;
        SanurGenNHibernate.buscarUsuario buscarusuario;
        SanurGenNHibernate.Form_busca_paciente buscarpaciente;
        ActualizaEpisodio act_epi; 

        private int childFormNumber = 0;

        private UsuarioEN usuarioEN;

        public Principal()
        {
            InitializeComponent();
        }

        public void VisibleMenu()
        {
            if (Sesion_ini == true)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;

                if (TipoUsuario == "Medico")
                {
                    pacientesToolStripMenuItem.Visible = true;
                    nuevoPacienteToolStripMenuItem.Visible = false;

                    act_epi = new ActualizaEpisodio();
                    act_epi.MdiParent = this;
                    act_epi.VentanaPrincipal = this;
                    act_epi.CargarDatosGrid();
                    act_epi.Dock = DockStyle.Fill;
                    act_epi.Show();
                }
                else if (TipoUsuario == "Administrador")
                {
                    usuariosToolStripMenuItem.Visible = true;
                }
                else if (TipoUsuario == "Administrativo")
                {
                    nuevoPacienteToolStripMenuItem.Visible = true;
                    pacientesToolStripMenuItem.Visible = true;
                    //triageToolStripMenuItem.Visible = true;
                }
            }

            TipoUsuario = CompruebaUsuario(UsuarioIniciado.IdUsuario);
        }

        public String CompruebaUsuario(int user)
        {
            int id = 0;

            try
            {
                AdministrativoEn = AdministrativoCen.ReadOID(user);
                id = AdministrativoEn.IdUsuario;
                return "Administrativo";
            }
            catch (Exception p)
            {
                try
                {
                    MedicoEn = MedicoCen.ReadOID(user);
                    id = MedicoEn.IdUsuario;
                    return "Medico";
                }
                catch (Exception q)
                {
                    return "Administrador";
                }
            }
        }

        public Principal(String p_mail)
        {
            InitializeComponent();

            UsuarioCEN usuarioCEN = new UsuarioCEN();
            this.usuarioEN = usuarioCEN.ReadMail(p_mail); // CREAMOS EL OBJETO USUARIO
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //creo y muestro el formulario de usuarios
            login = new SanurGenNHibernate.Login();//creo la ventana
            login.VentanaPrincipal = this;//para que tenga acceso login a los datos de ventanaprincipal
            login.MdiParent = this;
            login.Show();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creo y muestro el formulario de usuarios
            altausuario = new SanurGenNHibernate.altaUsuario();//creo la ventana
            altausuario.VentanaPrincipal = this;//para que tenga acceso login a los datos de ventanaprincipal
            altausuario.MdiParent = this;
            altausuario.Show();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creo y muestro el formulario de usuarios
            modusuario = new SanurGenNHibernate.ModificarUsuario();//creo la ventana
            modusuario.VentanaPrincipal = this;//para que tenga acceso login a los datos de ventanaprincipal
            modusuario.MdiParent = this;
            modusuario.Show();
        }

        private void borrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creo y muestro el formulario de usuarios
            bajausuario = new SanurGenNHibernate.BajaUsuario();//creo la ventana
            bajausuario.VentanaPrincipal = this;//para que tenga acceso login a los datos de ventanaprincipal
            bajausuario.MdiParent = this;
            bajausuario.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_crear_paciente creaPaciente = new Form_crear_paciente();
            creaPaciente.Show();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarpaciente = new SanurGenNHibernate.Form_busca_paciente();//creo la ventana
            buscarpaciente.VentanaPrincipal = this;//para que tenga acceso login a los datos de ventanaprincipal
            buscarpaciente.MdiParent = this;
            buscarpaciente.Show();
            //Form_busca_paciente busPaciente = new Form_busca_paciente(usuarioEN);
            //busPaciente.Show();
            //this.episodioEN = busPaciente.GetEpisodio();
        }

        private void nuevoTriageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EpisodioCEN episodio = new EpisodioCEN();
            EpisodioEN epis =new EpisodioEN();
            epis = episodio.ReadOID(1);
            HojaTriage hojaTri = new HojaTriage((MedicoEN)UsuarioIniciado,epis);
            hojaTri.Show();
        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creo y muestro el formulario de usuarios
            buscarusuario = new SanurGenNHibernate.buscarUsuario();//creo la ventana
            buscarusuario.VentanaPrincipal = this;//para que tenga acceso login a los datos de ventanaprincipal
            buscarusuario.MdiParent = this;
            buscarusuario.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (confirmarCerrarSesión())
            {
                FormCollection ventanas = Application.OpenForms;

                for (int i = 0; i < ventanas.Count; i++)
                {
                    Form ventana = ventanas[i];
                    if (!ventana.IsMdiContainer)
                    {
                        ventana.Close();
                        ventanas = Application.OpenForms;
                        i--;
                    }
                }

                Sesion_ini = false;
                TipoUsuario = "";
                usuariosToolStripMenuItem.Visible = false;
                pacientesToolStripMenuItem.Visible = false;
                triageToolStripMenuItem.Visible = false;
                cerrarSesiónToolStripMenuItem.Visible = false;
                UsuarioIniciado = null;
                login = null;
                altausuario = null;
                bajausuario = null;
                modusuario = null;
                buscarusuario = null;
                buscarpaciente = null;
                act_epi = null;
                usuarioEN = null;
                childFormNumber = 0;

                //creo y muestro el formulario de usuarios
                login = new SanurGenNHibernate.Login();//creo la ventana
                login.VentanaPrincipal = this;//para que tenga acceso login a los datos de ventanaprincipal
                login.MdiParent = this;
                login.Show();
            }
        }

        private bool confirmarCerrarSesión()
        {
            string msg = "¿Seguro que quiere cerrar sesión?";
            MessageBoxButtons opc = MessageBoxButtons.YesNo;
            string leyenda = "Cerrar sesión";
            MessageBoxIcon icono = MessageBoxIcon.Question;
            if (MessageBox.Show(msg, leyenda, opc, icono) == DialogResult.Yes)
                return true;
            return false;
        }
    }
}
