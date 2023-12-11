namespace Inf_Bez
{
    public class User : IUser
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public HashSet<int> Id { get; set; }

        public User(string login, string password, HashSet<int> id)
        {
            Login = login;
            Password = password;
            Id = id;
        }
    }
}
