using System.Security.Cryptography.X509Certificates;

namespace Examen
{
    internal static class Program
    {
        public static List<Proyecto> ListaProyectos = new List<Proyecto>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}