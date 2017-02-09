namespace NoteBook
{
    partial class OperationForm
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
            this.OperationButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OperationButton
            // 
            this.OperationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OperationButton.Location = new System.Drawing.Point(327, 307);
            this.OperationButton.Name = "OperationButton";
            this.OperationButton.Size = new System.Drawing.Size(84, 45);
            this.OperationButton.TabIndex = 0;
            this.OperationButton.Text = "OK";
            this.OperationButton.UseVisualStyleBackColor = false;
            this.OperationButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 23);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NameTextBox.Location = new System.Drawing.Point(12, 35);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(390, 30);
            this.NameTextBox.TabIndex = 2;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 71);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(44, 23);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Age";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AgeTextBox.Location = new System.Drawing.Point(12, 97);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(390, 30);
            this.AgeTextBox.TabIndex = 2;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(12, 139);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(68, 23);
            this.AdressLabel.TabIndex = 1;
            this.AdressLabel.Text = "Adress";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AdressTextBox.Location = new System.Drawing.Point(12, 165);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(390, 30);
            this.AdressTextBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 207);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(62, 23);
            this.PhoneLabel.TabIndex = 1;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 233);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(390, 30);
            this.PhoneTextBox.TabIndex = 2;
            // 
            // OperationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 364);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.OperationButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperationForm";
            this.Text = "Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OperationButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
    }
}