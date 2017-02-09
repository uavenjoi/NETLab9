namespace NoteBook
{
    partial class NoteBookForm
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
            this.NBookGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NBookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NBookGridView
            // 
            this.NBookGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.NBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NBookGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.NBookGridView.Location = new System.Drawing.Point(24, 31);
            this.NBookGridView.Name = "NBookGridView";
            this.NBookGridView.ReadOnly = true;
            this.NBookGridView.RowTemplate.Height = 24;
            this.NBookGridView.Size = new System.Drawing.Size(524, 385);
            this.NBookGridView.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Location = new System.Drawing.Point(570, 31);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 54);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DelButton.Location = new System.Drawing.Point(570, 136);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(108, 54);
            this.DelButton.TabIndex = 1;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditButton.Location = new System.Drawing.Point(570, 240);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(108, 54);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NoteBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(694, 446);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NBookGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NoteBookForm";
            this.Text = "NoteBook";
            ((System.ComponentModel.ISupportInitialize)(this.NBookGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NBookGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EditButton;
    }
}

