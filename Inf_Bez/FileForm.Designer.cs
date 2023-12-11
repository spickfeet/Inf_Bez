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
            this.components = new System.ComponentModel.Container();
            this.comboBoxFileName = new System.Windows.Forms.ComboBox();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.errorProviderFile = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFile)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFileName
            // 
            this.comboBoxFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileName.FormattingEnabled = true;
            this.comboBoxFileName.Items.AddRange(new object[] {
            "Anime",
            "Games",
            "Films",
            "Books"});
            this.comboBoxFileName.Location = new System.Drawing.Point(12, 39);
            this.comboBoxFileName.Name = "comboBoxFileName";
            this.comboBoxFileName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFileName.TabIndex = 0;
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(160, 39);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(131, 74);
            this.buttonReadFile.TabIndex = 1;
            this.buttonReadFile.Text = "Прочитать";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonPrintMassage_Click);
            // 
            // errorProviderFile
            // 
            this.errorProviderFile.ContainerControl = this;
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 231);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.comboBoxFileName);
            this.Name = "FileForm";
            this.Text = "FileForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxFileName;
        private Button buttonReadFile;
        private ErrorProvider errorProviderFile;
    }
}