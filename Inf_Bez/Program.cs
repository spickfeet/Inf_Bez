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
                if (!File.Exists("Anime.json"))
                {
                    MassageAndID text = new("����� �������, ����������� �������", 1);
                    File.WriteAllText("Anime.json", JsonConvert.SerializeObject(text));
                }
                if (!File.Exists("Game.json"))
                {
                    MassageAndID text = new("Valorant, DOTA 2, Minecraft", 2);
                    File.WriteAllText("Games.json", JsonConvert.SerializeObject(text));
                }
                if (!File.Exists("Films.json")) // Blinchik
                {
                    MassageAndID text = new("�������, ���� ����", 3);
                    File.WriteAllText("Films.json", JsonConvert.SerializeObject(text));
                }
                if (!File.Exists("Books.json")) // Kuga � TimZR
                {
                    MassageAndID text = new("����� � ���", 4);
                    File.WriteAllText("Books.json", JsonConvert.SerializeObject(text));
                }             
                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm());
            }
        }
    
}

