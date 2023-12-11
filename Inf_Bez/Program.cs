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
                MessageContainer employees = new("\tАлексей Анатольевич\nВозраст: 21 год\nID: 2342342\n\tДмитрий Вадимович\nВозраст: 31 год\nID: 6776823\n\tCергей Викторович\nВозраст: 21 год\nID: 79834387\n", 1);
                File.WriteAllText("Employees.json", JsonConvert.SerializeObject(employees, Formatting.Indented));
                MessageContainer subsidiaries = new("\tДочернии компании\nGrinding Gear Games\nRiot Games\nTencent Pictures\nYager Development\nIflix", 2);
                File.WriteAllText("Subsidiaries.json", JsonConvert.SerializeObject(subsidiaries, Formatting.Indented));
                MessageContainer revenue = new("\t\tДоход\n\t2019 год\n 1.000.000\n\t2020 год\n 1.500.000\n\t2021 год\n 2.000.000", 3);
                File.WriteAllText("Revenue.json", JsonConvert.SerializeObject(revenue, Formatting.Indented));          
                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm());
            }
        }
    
}

