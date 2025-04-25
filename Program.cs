using System;
using System.Windows.Forms;
using formproyecto2;

namespace TuNombreDeProyecto
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Reemplaza Form1 por el nombre real de tu formulario
            Application.Run(new Form1());
        }
    }
}
