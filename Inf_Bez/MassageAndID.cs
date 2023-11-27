using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Bez
{
    internal class MassageAndID
    {
        private string _massage;
        private int _id;
        public string Massage
        {
            get { return _massage; }
            set { _massage = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public MassageAndID(string massage, int id)
        {
            Massage = massage;
            ID = id;
        }
    }
}
