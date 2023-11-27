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
            if (!File.Exists("Users.json"))
            {

                User spickfeet = new("Kuga", "123", 19871);
                User timZR = new("TimZR", "321", 19872);
                User blinchik = new("Blinchik", "111", 19873);

                List<User> users = new List<User>();
                users.Add(spickfeet);
                users.Add(timZR);

                File.WriteAllText("Users.json", JsonConvert.SerializeObject(users));
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
        }
    }
}