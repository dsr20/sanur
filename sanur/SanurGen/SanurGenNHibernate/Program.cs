using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SanurGenNHibernate.CEN.Sanur;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_crear_paciente());
            //Login login = new Login();
            //login.ShowDialog();
            //PacienteCEN pcen = new PacienteCEN();

            //pcen.New_("Gacel", "Ivorra", new DateTime(1991, 1, 9), "600255555", "Doctor Jimenez", "España", 1232345, 48672144, "H", "g@g.com", "Alicante", "B+", "03005", "San Juan", "Alicante");
            //MedicoCEN mcen= new MedicoCEN();
            //mcen.New_("Sergio", "sergio", false, "s@s.com", "apellido1 apellido2", Enumerated.Sanur.EspecialidadEnum.ginecologia);
           //AdministrativoCEN acen = new AdministrativoCEN();
           //acen.New_("Andrea", "andrea", false, "a@a.com", "Rodriguez");
            //EpisodioCEN epcen = new EpisodioCEN();
            //epcen.New_(1, new DateTime(2000, 10, 20), "Dolor en el torax", 2, Enumerated.Sanur.EstadoEnum.espera, false, false);
          
            //EpisodioEN ep = epcen.ReadOID(1);
            //PacienteEN pa = ep.Paciente;
            //string s = pa.Apellidos;
            //Application.Run(new HojaTriage(1, ep));
        }
    }
}
