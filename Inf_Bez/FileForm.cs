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
            if (comboBoxFileName.SelectedIndex <= -1)
            {
                errorProviderFile.SetError(comboBoxFileName, "Выберите файл");
                return;
            }
            string filePath = comboBoxFileName.Text + ".json";
            var message = JsonConvert.DeserializeObject<MessageContainer>(File.ReadAllText(filePath));

            if (_user.Id.Contains(message.ID))
            {
                errorProviderFile.Clear();
                string? title = comboBoxFileName.Text;
                MessageForm messageForm = new MessageForm(title, message.Message);
                messageForm.ShowDialog();
            }
            else
            {
                errorProviderFile.SetError(comboBoxFileName, "У вас нет доступа к этому файлу");
            }
        }
    }
}
