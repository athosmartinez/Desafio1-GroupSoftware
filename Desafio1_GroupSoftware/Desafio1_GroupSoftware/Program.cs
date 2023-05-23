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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new TelaLogin());
            TelaLogin login = new TelaLogin();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new frmPrincipal());
        }
    }
}