namespace Inf_Bez
{
    partial class FileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBoxFileName = new ComboBox();
            buttonReadFile = new Button();
            errorProviderFile = new ErrorProvider(components);
            labelPassword = new Label();
            checkBoxPasswordView = new CheckBox();
            textBoxPassword = new TextBox();
            labelFiles = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderFile).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFileName
            // 
            comboBoxFileName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFileName.FormattingEnabled = true;
            comboBoxFileName.Items.AddRange(new object[] { "Employees", "Subsidiaries", "Revenue" });
            comboBoxFileName.Location = new Point(12, 39);
            comboBoxFileName.Name = "comboBoxFileName";
            comboBoxFileName.Size = new Size(121, 29);
            comboBoxFileName.TabIndex = 0;
            comboBoxFileName.SelectedIndexChanged += comboBoxFileName_SelectedIndexChanged;
            // 
            // buttonReadFile
            // 
            buttonReadFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReadFile.Location = new Point(12, 160);
            buttonReadFile.Name = "buttonReadFile";
            buttonReadFile.Size = new Size(169, 74);
            buttonReadFile.TabIndex = 1;
            buttonReadFile.Text = "Прочитать";
            buttonReadFile.UseVisualStyleBackColor = true;
            buttonReadFile.Visible = false;
            buttonReadFile.Click += buttonPrintMassage_Click;
            // 
            // errorProviderFile
            // 
            errorProviderFile.ContainerControl = this;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(12, 88);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Password";
            labelPassword.Visible = false;
            // 
            // checkBoxPasswordView
            // 
            checkBoxPasswordView.AutoSize = true;
            checkBoxPasswordView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPasswordView.Location = new Point(178, 112);
            checkBoxPasswordView.Name = "checkBoxPasswordView";
            checkBoxPasswordView.Size = new Size(15, 14);
            checkBoxPasswordView.TabIndex = 13;
            checkBoxPasswordView.UseVisualStyleBackColor = true;
            checkBoxPasswordView.Visible = false;
            checkBoxPasswordView.CheckedChanged += checkBoxPasswordView_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 105);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(148, 29);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Visible = false;
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiles.Location = new Point(12, 22);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(30, 15);
            labelFiles.TabIndex = 15;
            labelFiles.Text = "Files";
            labelFiles.Visible = false;
            // 
            // FileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 254);
            Controls.Add(labelFiles);
            Controls.Add(labelPassword);
            Controls.Add(checkBoxPasswordView);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonReadFile);
            Controls.Add(comboBoxFileName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataViewer";
            ((System.ComponentModel.ISupportInitialize)errorProviderFile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFileName;
        private Button buttonReadFile;
        private ErrorProvider errorProviderFile;
        private Label labelPassword;
        private CheckBox checkBoxPasswordView;
        private TextBox textBoxPassword;
        private Label labelFiles;
    }
}