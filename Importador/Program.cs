using System.Reflection;

namespace CS_Padron_Importador
{
    internal static class Program
    {
        internal static readonly CardonerSistemas.Framework.Base.Application.Info Info = new(Assembly.GetExecutingAssembly());

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Application.Run(new FormMain());
        }
    }
}