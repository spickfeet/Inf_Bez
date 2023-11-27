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
            //User spickfeet = new("Kuga", "123", new HashSet<int> { 1, 2, 3 });
            //User timZR = new("TimZR", "321", new HashSet<int> { 2 });
            //User blinchik = new("Blinchik", "111", new HashSet<int> { 3 });

            //List<User> users = new List<User>
            //{
            //    spickfeet,
            //    timZR,
            //    blinchik
            //};

            //File.WriteAllText("Users.json", JsonConvert.SerializeObject(users));


            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
        }
    }
}