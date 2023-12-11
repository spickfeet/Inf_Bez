using Microsoft.VisualBasic.ApplicationServices;
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

        private MessageContainer _messageContainer;

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
            var dataPasswords = JsonConvert.DeserializeObject<List<DataPassword>>(File.ReadAllText("DataPasswords.json"));

            foreach (DataPassword dataPassword in dataPasswords)
            {
                if (dataPassword.FileName == comboBoxFileName.Text + ".json")
                {
                    if (dataPassword.Password == HashCodeConvertor.ConvertToHashCode(textBoxPassword.Text))
                    {
                        string? title = comboBoxFileName.Text;
                        MessageForm messageForm = new MessageForm(title, _messageContainer.Message);
                        messageForm.ShowDialog();
                    }
                    else
                    {
                        errorProviderFile.SetError(textBoxPassword, "Неверный пароль");
                    }
                }
            }
        }

        private void checkBoxPasswordView_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordView.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void ChangePasswordVisibleState(bool state)
        {
            textBoxPassword.Visible = state;
            labelPassword.Visible = state;
            checkBoxPasswordView.Visible = state;
            buttonReadFile.Visible = state;

            textBoxPassword.Text = string.Empty;
        }

        private void comboBoxFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePasswordVisibleState(false);

            if (comboBoxFileName.SelectedIndex <= -1)
            {
                errorProviderFile.SetError(comboBoxFileName, "Выберите файл");
                return;
            }

            _messageContainer = JsonConvert.DeserializeObject<MessageContainer>(File.ReadAllText(comboBoxFileName.Text + ".json"));

            if (_user.Id.Contains(_messageContainer.ID))
            {
                errorProviderFile.Clear();

                ChangePasswordVisibleState(true);
            }
            else
            {
                ChangePasswordVisibleState(false);

                errorProviderFile.SetError(comboBoxFileName, "У вас нет доступа к этому файлу");
            }
        }
    }
}
