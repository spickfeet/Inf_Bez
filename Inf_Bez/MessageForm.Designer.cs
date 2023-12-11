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
            richTextBoxMessage = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxMessage
            // 
            richTextBoxMessage.Location = new Point(12, 12);
            richTextBoxMessage.Name = "richTextBoxMessage";
            richTextBoxMessage.ReadOnly = true;
            richTextBoxMessage.Size = new Size(700, 408);
            richTextBoxMessage.TabIndex = 1;
            richTextBoxMessage.Text = "";
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 432);
            Controls.Add(richTextBoxMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MessageForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DataViewer";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBoxMessage;
    }
}