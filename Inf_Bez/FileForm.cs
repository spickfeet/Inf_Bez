using Newtonsoft.Json;
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
        private User _user;
        public FileForm(Form prev, User user)
        {

            _prevForm = prev;
            _prevForm.Hide();
            _user = user;
            InitializeComponent();
            FormClosed += OnClosed;
        }
        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
        }

        private void buttonPrintMassage_Click(object sender, EventArgs e)
        {
            if (comboBoxFileName.SelectedIndex == -1)
            {
                errorProviderFile.SetError(comboBoxFileName, "Выбtрите файл");
                return;
            }
            var massage = JsonConvert.DeserializeObject<MassageAndID>(File.ReadAllText(comboBoxFileName.Text));
            if (_user.Id.Contains(massage.ID))
            {
                errorProviderFile.Clear();
                MassageForm massageForm = new MassageForm(massage.Massage);
                massageForm.ShowDialog();
            }
            else
            {
                errorProviderFile.SetError(comboBoxFileName, "Увас нет доступа к этому файлу");
            }
        }
    }
}
