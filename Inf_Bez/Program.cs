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
                MessageContainer employees = new("\tСергей Владимирович\nВозраст: 21 год\nID: 2342342\n\tДмитрий Иванович\nВозраст: 31 год\nID: 6776823", 1);
                File.WriteAllText("Employees.json", JsonConvert.SerializeObject(employees, Formatting.Indented));
              
                MessageContainer subsidiaries = new("\tДочерние компании\nGrinding Gear Games\nRiot Games\nTencent Pictures\nYager Development\nIflix", 2);
                File.WriteAllText("Subsidiaries.json", JsonConvert.SerializeObject(subsidiaries, Formatting.Indented));
              
                MessageContainer revenue = new("\t\tВыручка\n\t2019 год\n 1.000.000 рублей\n\t2020 год\n 1.500.000 рублей\n\t2021 год\n 2.000.000 рублей", 3);
                File.WriteAllText("Revenue.json", JsonConvert.SerializeObject(revenue, Formatting.Indented));
              
                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm());
            }
        }
    
}

