using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf_Bez
{
    public partial class MessageForm : Form
    {
        public MessageForm(string title, string massage)
        {
            InitializeComponent();

            Text = title;
            richTextBox1.Text = massage;
        }
    }
}
