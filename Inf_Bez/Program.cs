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
                    MessageContainer text = new("����� �������, ����������� �������", 1);
                    File.WriteAllText("Anime.json", JsonConvert.SerializeObject(text));
                }
                if (!File.Exists("Game.json"))
                {
                    MessageContainer text = new("Valorant, DOTA 2, Minecraft", 2);
                    File.WriteAllText("Games.json", JsonConvert.SerializeObject(text));
                }
                if (!File.Exists("Films.json")) // Blinchik
                {
                    MessageContainer text = new("�������, ���� ����", 3);
                    File.WriteAllText("Films.json", JsonConvert.SerializeObject(text));
                }
                if (!File.Exists("Books.json")) // Kuga � TimZR
                {
                    MessageContainer text = new("����� � ���", 4);
                    File.WriteAllText("Books.json", JsonConvert.SerializeObject(text));
                }             
                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm());
            }
        }
    
}

