namespace Inf_Bez
{
    partial class SignUpForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.checkBoxPasswordView = new System.Windows.Forms.CheckBox();
            this.labelTitleSignUp = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.Location = new System.Drawing.Point(125, 138);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(218, 43);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(125, 208);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(218, 43);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(125, 354);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(218, 48);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Зарегистрировать";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.Control;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Location = new System.Drawing.Point(125, 404);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(207, 15);
            this.labelError.TabIndex = 4;
            this.labelError.Text = "Такой пользователь уже существует";
            // 
            // checkBoxPasswordView
            // 
            this.checkBoxPasswordView.AutoSize = true;
            this.checkBoxPasswordView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPasswordView.Location = new System.Drawing.Point(349, 223);
            this.checkBoxPasswordView.Name = "checkBoxPasswordView";
            this.checkBoxPasswordView.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPasswordView.TabIndex = 5;
            this.checkBoxPasswordView.UseVisualStyleBackColor = true;
            // 
            // labelTitleSignUp
            // 
            this.labelTitleSignUp.AutoSize = true;
            this.labelTitleSignUp.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleSignUp.Location = new System.Drawing.Point(140, 27);
            this.labelTitleSignUp.Name = "labelTitleSignUp";
            this.labelTitleSignUp.Size = new System.Drawing.Size(176, 38);
            this.labelTitleSignUp.TabIndex = 2;
            this.labelTitleSignUp.Text = "Регистрация";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(125, 278);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(218, 43);
            this.textBoxId.TabIndex = 6;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(125, 121);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 15);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(125, 191);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(125, 261);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(17, 15);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 501);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.checkBoxPasswordView);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelTitleSignUp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUpForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonSignUp;
        private Label labelError;
        private CheckBox checkBoxPasswordView;
        private Label labelTitleSignUp;
        private TextBox textBoxId;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelId;
    }
}