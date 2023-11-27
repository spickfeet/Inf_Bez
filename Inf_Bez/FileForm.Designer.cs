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
            comboBoxFileName = new ComboBox();
            buttonPrintMassage = new Button();
            labelMassage = new Label();
            SuspendLayout();
            // 
            // comboBoxFileName
            // 
            comboBoxFileName.FormattingEnabled = true;
            comboBoxFileName.Items.AddRange(new object[] { "Anime.json", "Films.json", "Games.json", "Books.json" });
            comboBoxFileName.Location = new Point(210, 161);
            comboBoxFileName.Name = "comboBoxFileName";
            comboBoxFileName.Size = new Size(121, 23);
            comboBoxFileName.TabIndex = 0;
            // 
            // buttonPrintMassage
            // 
            buttonPrintMassage.Location = new Point(483, 161);
            buttonPrintMassage.Name = "buttonPrintMassage";
            buttonPrintMassage.Size = new Size(75, 23);
            buttonPrintMassage.TabIndex = 1;
            buttonPrintMassage.Text = "button1";
            buttonPrintMassage.UseVisualStyleBackColor = true;
            buttonPrintMassage.Click += buttonPrintMassage_Click;
            // 
            // labelMassage
            // 
            labelMassage.AutoSize = true;
            labelMassage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelMassage.Location = new Point(95, 240);
            labelMassage.Name = "labelMassage";
            labelMassage.Size = new Size(63, 25);
            labelMassage.TabIndex = 2;
            labelMassage.Text = "label1";
            // 
            // FileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMassage);
            Controls.Add(buttonPrintMassage);
            Controls.Add(comboBoxFileName);
            Name = "FileForm";
            Text = "FileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFileName;
        private Button buttonPrintMassage;
        private Label labelMassage;
    }
}