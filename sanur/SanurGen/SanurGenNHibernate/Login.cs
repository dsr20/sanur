using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;
using System.Net.Mail;

namespace SanurGenNHibernate
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioCEN user = new UsuarioCEN();

            if (user.ComprobarMail(nombre.Text, password.Text)) // COMPROBAMOS QUE EL USUARIO COINCIDE CN EL PASS
            {
                Principal htr = new Principal(nombre.Text);
                this.Hide(); // OCULTAMOS EL LOGIN
                htr.ShowDialog();// CREAMOS EL ID DE SESSION Y MOVEMOS A SIGUIENTE CAPA
            }

            nombre.Refresh(); // REFRESCAMOS LOS DATOS
            password.Refresh(); // REFRESCAMOS LOS DATOS
            labelError.Show(); // MOSTRAMOS MENSAJE DE ERROR

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private bool EnviarEmail() 
        {        
 
            MailMessage msg = new MailMessage();
 
            msg.To.Add("dani_hawkb@hotmail.com"); // CORREO ADMINISTRADOR

            msg.From = new MailAddress(nombre.Text.ToString(), nombre.Text.ToString(), System.Text.Encoding.UTF8); // USUARIO
 
            msg.Subject = "Cambio de contraseña";
 
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
 
            msg.Body = "Solicitud de cambio de contraseña para el usuario "+nombre.Text;
 
            msg.BodyEncoding = System.Text.Encoding.UTF8;
 
            msg.IsBodyHtml = false; //Si vas a enviar un correo con contenido html entonces cambia el valor a true
              //Aquí es donde se hace lo especial
 
            SmtpClient client = new SmtpClient();
 
            client.Credentials = new System.Net.NetworkCredential("sanurdss@gmail.com", "sanurDSS1"); // CORREO GENERICO

            client.Port = 587;

            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail
 
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail

            try
            {
                client.Send(msg);
                return true;

            }
            catch (SmtpException e)
            {
                MessageBox.Show("No se ha podido enviar el correo");
                return false;
            }
        }

        private void passForgot_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nombre.Text))
                MessageBox.Show("Debe de introducir el usuario en el campo correspondiente");
            else
                EnviarEmail(); // FALTA COMPROBAR SI EL USUARIO EXISTE
        }

    }
}
