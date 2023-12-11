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
            ((System.ComponentModel.ISupportInitialize)errorProviderFile).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFileName
            // 
            comboBoxFileName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFileName.FormattingEnabled = true;
            comboBoxFileName.Items.AddRange(new object[] { "Employees", "Subsidiaries", "Revenue" });
            comboBoxFileName.Location = new Point(14, 52);
            comboBoxFileName.Margin = new Padding(3, 4, 3, 4);
            comboBoxFileName.Name = "comboBoxFileName";
            comboBoxFileName.Size = new Size(138, 28);
            comboBoxFileName.TabIndex = 0;
            // 
            // buttonReadFile
            // 
            buttonReadFile.Location = new Point(183, 52);
            buttonReadFile.Margin = new Padding(3, 4, 3, 4);
            buttonReadFile.Name = "buttonReadFile";
            buttonReadFile.Size = new Size(150, 99);
            buttonReadFile.TabIndex = 1;
            buttonReadFile.Text = "Прочитать";
            buttonReadFile.UseVisualStyleBackColor = true;
            buttonReadFile.Click += buttonPrintMassage_Click;
            // 
            // errorProviderFile
            // 
            errorProviderFile.ContainerControl = this;
            // 
            // FileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 308);
            Controls.Add(buttonReadFile);
            Controls.Add(comboBoxFileName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FileForm";
            Text = "FileForm";
            ((System.ComponentModel.ISupportInitialize)errorProviderFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxFileName;
        private Button buttonReadFile;
        private ErrorProvider errorProviderFile;
    }
}