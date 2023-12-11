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
                MessageContainer employees = new("\t������� �����������\n�������: 21 ���\nID: 2342342\n\t������� ���������\n�������: 31 ���\nID: 6776823\n\tC����� ����������\n�������: 21 ���\nID: 79834387\n", 1);
                File.WriteAllText("Employees.json", JsonConvert.SerializeObject(employees, Formatting.Indented));
                MessageContainer subsidiaries = new("\t�������� ��������\nGrinding Gear Games\nRiot Games\nTencent Pictures\nYager Development\nIflix", 2);
                File.WriteAllText("Subsidiaries.json", JsonConvert.SerializeObject(subsidiaries, Formatting.Indented));
                MessageContainer revenue = new("\t\t�����\n\t2019 ���\n 1.000.000\n\t2020 ���\n 1.500.000\n\t2021 ���\n 2.000.000", 3);
                File.WriteAllText("Revenue.json", JsonConvert.SerializeObject(revenue, Formatting.Indented));          
                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm());
            }
        }
    
}

