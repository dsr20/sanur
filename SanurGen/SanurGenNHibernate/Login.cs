using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;
using SanurGenNHibernate.EN.Sanur;
using System.Net.Mail;
using System.Security.Cryptography;

namespace SanurGenNHibernate
{
    public partial class Login : Form
    {
        public SanurGenNHibernate.Principal VentanaPrincipal;


        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../../pdf/Logo_Hospital.png");
            this.AcceptButton = bEnter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioCEN user = new UsuarioCEN();
            UsuarioEN u = new UsuarioEN();

            MD5 md = MD5.Create() ;

            
            string hashs = GetMd5Hash(md,password.Text);

            if (user.ComprobarMail(nombre.Text, hashs)) // COMPROBAMOS QUE EL USUARIO COINCIDE CN EL PASS
            {
                u = user.ReadMail(nombre.Text);
                   
                VentanaPrincipal.UsuarioIniciado = u;
                VentanaPrincipal.TipoUsuario=VentanaPrincipal.CompruebaUsuario(u.IdUsuario);
                VentanaPrincipal.Sesion_ini = true;

                VentanaPrincipal.VisibleMenu();

                Close();
            }

            nombre.Refresh(); // REFRESCAMOS LOS DATOS
            password.Refresh(); // REFRESCAMOS LOS DATOS
            labelError.Show(); // MOSTRAMOS MENSAJE DE ERROR
                      

        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
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
