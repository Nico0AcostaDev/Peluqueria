using peluqueria.Models;

namespace peluqueria
{
    internal static class Program
    { 
        [STAThread]
        static void Main()
        {
            PeluqueriaContext dbContext = peluqueria.Models.PeluqueriaContext.CreateDbContext(); 
   
             
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin(dbContext));
        }
    }
}