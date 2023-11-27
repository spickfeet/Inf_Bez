namespace Inf_Bez
{
    partial class MassageForm
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
            labelMassage = new Label();
            SuspendLayout();
            // 
            // labelMassage
            // 
            labelMassage.AutoSize = true;
            labelMassage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelMassage.Location = new Point(28, 63);
            labelMassage.Name = "labelMassage";
            labelMassage.Size = new Size(63, 25);
            labelMassage.TabIndex = 0;
            labelMassage.Text = "label1";
            // 
            // MassageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 285);
            Controls.Add(labelMassage);
            Name = "MassageForm";
            Text = "MassageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMassage;
    }
}