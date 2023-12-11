using Newtonsoft.Json;

namespace Inf_Bez
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DataManager.Initialize();
            Application.Run(new LogInForm());
        }
    }
    
}

