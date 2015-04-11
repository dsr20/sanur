using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.CEN.Sanur;
using System.Windows.Forms;

namespace SanurGenNHibernate
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HojaTriage());
            /*
            PacienteCEN pcen = new PacienteCEN();
            PacienteEN paciente = pcen.BuscarDNI(48672144);
            EpisodioCEN epcen = new EpisodioCEN();
            IList<EpisodioEN> historial = new List<EpisodioEN>();
            int id = paciente.IdPaciente;
            historial = epcen.ObtenerHistorial(id);
            Console.WriteLine("Hola");*/

        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
    }
}
