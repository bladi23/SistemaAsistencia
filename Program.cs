using SistemaAsistencia.VIEWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_MenuPrincipal());
        }
    }

    public static class ConfiguracionProyecto
    {
        public static int IDusuario { get; set; }
        public static string usuario { get; set; }
        public static string rol { get; set; }
    }






}
