using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Bez
{
    internal interface IUser
    {
        public string Login {  get; set; }
        public string Password { get; set; }
        public HashSet<int> Id { get; set; }
    }
}
