namespace Inf_Bez
{
    internal class DataPassword
    {
        public string FileName { get; set; }
        public string Password { get; set; }

        public DataPassword(string fileName, string password)
        {
            FileName = fileName;
            Password = password;
        }
    }
}