namespace TextCorrector
{
    partial class CorrectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrectorForm));
            this.CorrectText = new System.Windows.Forms.RichTextBox();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CorrectText
            // 
            this.CorrectText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CorrectText.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CorrectText.Location = new System.Drawing.Point(41, 74);
            this.CorrectText.Name = "CorrectText";
            this.CorrectText.Size = new System.Drawing.Size(612, 313);
            this.CorrectText.TabIndex = 0;
            this.CorrectText.Text = "";
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CorrectLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectLabel.Location = new System.Drawing.Point(122, 33);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(371, 23);
            this.CorrectLabel.TabIndex = 1;
            this.CorrectLabel.Text = "Введите свой текст и нажмите кнопку";
            // 
            // CorrectButton
            // 
            this.CorrectButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CorrectButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectButton.Location = new System.Drawing.Point(521, 26);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(132, 37);
            this.CorrectButton.TabIndex = 2;
            this.CorrectButton.Text = "Проверить";
            this.CorrectButton.UseVisualStyleBackColor = false;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // CorrectorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 438);
            this.Controls.Add(this.CorrectButton);
            this.Controls.Add(this.CorrectLabel);
            this.Controls.Add(this.CorrectText);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "CorrectorForm";
            this.Text = "TextCorrector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CorrectText;
        private System.Windows.Forms.Label CorrectLabel;
        private System.Windows.Forms.Button CorrectButton;
    }
}

