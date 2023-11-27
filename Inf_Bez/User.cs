using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Bez
{
    public class User
    {
        private int _id;
        private string _login;
        private string _password;
        public Rank _rank;
        public string Login 
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public User(string login, string password, int id)
        {
            Login = login;
            Password = password;
            ID = id;
        }
        
    }
}
