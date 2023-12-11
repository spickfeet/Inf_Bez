using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Bez
{
    public class DataPassword
    {
        public string FileName { get; set; }
        public string Password { get; set; }
        public DataPassword(string name, string password)
        {
            FileName = name;
            Password = password;
        }
    }
}
