using System.Data.SqlClient;

namespace Desafio1_GroupSoftware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                TelaLogin login = new TelaLogin();
                if (login.ShowDialog() == DialogResult.OK)
                    Application.Run(new frmPrincipal());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}