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
    public partial class FileForm : Form
    {
        private Form _prevForm;
        public FileForm(Form prev)
        {
            _prevForm = prev;
            _prevForm.Hide();
            InitializeComponent();
            FormClosed += OnClosed;
        }
        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
        }
    }
}
