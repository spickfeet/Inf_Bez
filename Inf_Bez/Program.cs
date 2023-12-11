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
                    MessageContainer text = new("Атака титанов, Истребитель демонов \nБиба и боба", 1);
                    File.WriteAllText("Anime.json", JsonConvert.SerializeObject(text,Formatting.Indented));

                    text = new("Valorant, DOTA 2, Minecraft", 2);
                    File.WriteAllText("Games.json", JsonConvert.SerializeObject(text, Formatting.Indented));

                    text = new("Титаник, Один дома", 3);
                    File.WriteAllText("Films.json", JsonConvert.SerializeObject(text, Formatting.Indented));

                    text = new("Война и мир", 4);
                    File.WriteAllText("Books.json", JsonConvert.SerializeObject(text, Formatting.Indented));
                           
                ApplicationConfiguration.Initialize();
                Application.Run(new LogInForm());
            }
        }
    
}

