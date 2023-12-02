using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Bez
{
    internal class MessageContainer
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public MessageContainer(string massage, int id)
        {
            Message = massage;
            ID = id;
        }
    }
}
