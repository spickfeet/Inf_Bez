namespace Inf_Bez
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            FileForm fileForm = new FileForm();
            fileForm.ShowDialog();
        }
    }
}