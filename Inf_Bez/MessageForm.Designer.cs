namespace Inf_Bez
{
    partial class MessageForm
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
            labelMessage = new Label();
            SuspendLayout();
            // 
            // labelMassage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.Location = new Point(28, 63);
            labelMessage.Name = "labelMassage";
            labelMessage.Size = new Size(63, 25);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "label1";
            // 
            // MassageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 285);
            Controls.Add(labelMessage);
            Name = "MassageForm";
            Text = "MassageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
    }
}