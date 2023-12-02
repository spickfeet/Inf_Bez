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
            comboBoxFileName.Items.AddRange(new object[] { "Anime.json", "Games.json", "Films.json", "Books.json" });
            comboBoxFileName.Location = new Point(12, 39);
            comboBoxFileName.Name = "comboBoxFileName";
            comboBoxFileName.Size = new Size(121, 23);
            comboBoxFileName.TabIndex = 0;
            // 
            // buttonReadFile
            // 
            buttonReadFile.Location = new Point(160, 39);
            buttonReadFile.Name = "buttonReadFile";
            buttonReadFile.Size = new Size(131, 74);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 231);
            Controls.Add(buttonReadFile);
            Controls.Add(comboBoxFileName);
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