using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace Inf_Bez
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            labelError.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;

            User userForRegistration = new User(textBoxLogin.Text, textBoxPassword.Text, GetId());
            var usersData = File.Exists("Users.json") 
                ? JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("Users.json")) 
                : throw new Exception("Users.json �� ������");

            if (usersData != null)
            {
                foreach (var user in usersData)
                {
                    if (userForRegistration.Login == user.Login)
                    {
                        labelError.Visible = true;
                        return;
                    }

                }
            }
            else
            {
                usersData = new List<User>();
            }

            usersData.Add(userForRegistration);
            File.WriteAllText("Users.json", JsonConvert.SerializeObject(usersData));
            Close();
            
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

        private HashSet<int> GetId()
        {
            char[] separators = { ' ', ',' };
            var text = textBoxId.Text.Split(separators);
            HashSet<int> ids = new HashSet<int>();
            foreach (var item in text)
            {
                if (int.TryParse(item, out int i)) ids.Add(i);
            }
            return ids;
        }
    }
}