using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Bez
{
    public class User : IUser
    {
        public string Login {  get; set; }
        public string Password { get; set; }

        public HashSet<int> Id { get; set; }

        public User(string login, string password, HashSet<int> id)
        {
            Login = login;
            Password = password;
            Id = id;
        }

        public bool IsCorrectData()
        {
            if (string.IsNullOrEmpty(Login)) return false;
            if (string.IsNullOrEmpty(Password)) return false;

            return true;
        }

        public static string ConvertToHashCode(string password)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashValue = SHA256.HashData(messageBytes);
            return Convert.ToHexString(hashValue);
        }
    }
}
