using peluqueria.Models;

namespace peluqueria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PeluqueriaContext dbContext = peluqueria.Models.PeluqueriaContext.CreateDbContext(); // Llama al método para crear el contexto
   
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin(dbContext));
        }
    }
}