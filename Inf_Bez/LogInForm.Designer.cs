namespace Inf_Bez
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelLogIn = new Label();
            buttonLogIn = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(299, 131);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(249, 52);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(299, 218);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(249, 52);
            textBoxPassword.TabIndex = 1;
            // 
            // labelLogIn
            // 
            labelLogIn.AutoSize = true;
            labelLogIn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogIn.Location = new Point(361, 39);
            labelLogIn.Name = "labelLogIn";
            labelLogIn.Size = new Size(113, 46);
            labelLogIn.TabIndex = 2;
            labelLogIn.Text = "Войти";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(299, 309);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(249, 64);
            buttonLogIn.TabIndex = 3;
            buttonLogIn.Text = "Войти";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogIn);
            Controls.Add(labelLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "LogInForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelLogIn;
        private Button buttonLogIn;
    }
}