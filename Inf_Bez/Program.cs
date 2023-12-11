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
                MessageContainer employees = new("\tÀëåêñåé Àíàòîëüåâè÷\nÂîçðàñò: 21 ãîä\nID: 2342342\n\tÄìèòðèé Âàäèìîâè÷\nÂîçðàñò: 31 ãîä\nID: 6776823\n\tCåðãåé Âèêòîðîâè÷\nÂîçðàñò: 21 ãîä\nID: 79834387\n", 1);
                File.WriteAllText("Employees.json", JsonConvert.SerializeObject(employees, Formatting.Indented));
              
                MessageContainer subsidiaries = new("\tÄî÷åðíèè êîìïàíèè\nGrinding Gear Games\nRiot Games\nTencent Pictures\nYager Development\nIflix", 2);
                File.WriteAllText("Subsidiaries.json", JsonConvert.SerializeObject(subsidiaries, Formatting.Indented));
              
                MessageContainer revenue = new("\t\tÄîõîä\n\t2019 ãîä\n 1.000.000\n\t2020 ãîä\n 1.500.000\n\t2021 ãîä\n 2.000.000", 3);
                File.WriteAllText("Revenue.json", JsonConvert.SerializeObject(revenue, Formatting.Indented));
              
                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm());
            }
        }
    
}

