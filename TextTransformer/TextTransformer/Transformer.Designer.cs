namespace TextTransformer
{
    partial class TransformerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransformerForm));
            this.TransformerButton = new System.Windows.Forms.Button();
            this.UpperCheck = new System.Windows.Forms.CheckBox();
            this.ReversCheck = new System.Windows.Forms.CheckBox();
            this.InsertCheck = new System.Windows.Forms.CheckBox();
            this.OriginalText = new System.Windows.Forms.TextBox();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.TansformedText = new System.Windows.Forms.TextBox();
            this.TransformLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransformerButton
            // 
            this.TransformerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TransformerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransformerButton.ForeColor = System.Drawing.Color.White;
            this.TransformerButton.Location = new System.Drawing.Point(614, 455);
            this.TransformerButton.Name = "TransformerButton";
            this.TransformerButton.Size = new System.Drawing.Size(120, 52);
            this.TransformerButton.TabIndex = 5;
            this.TransformerButton.Text = "Transform";
            this.TransformerButton.UseVisualStyleBackColor = false;
            this.TransformerButton.Click += new System.EventHandler(this.Transbutton_Click);
            // 
            // UpperCheck
            // 
            this.UpperCheck.AutoSize = true;
            this.UpperCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpperCheck.ForeColor = System.Drawing.Color.White;
            this.UpperCheck.Location = new System.Drawing.Point(12, 22);
            this.UpperCheck.Name = "UpperCheck";
            this.UpperCheck.Size = new System.Drawing.Size(149, 84);
            this.UpperCheck.TabIndex = 2;
            this.UpperCheck.Text = "Transform all \r\nof caracter in\r\ntext to upper\r\ncase\r\n";
            this.UpperCheck.UseVisualStyleBackColor = true;
            // 
            // ReversCheck
            // 
            this.ReversCheck.AutoSize = true;
            this.ReversCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReversCheck.ForeColor = System.Drawing.Color.White;
            this.ReversCheck.Location = new System.Drawing.Point(14, 206);
            this.ReversCheck.Name = "ReversCheck";
            this.ReversCheck.Size = new System.Drawing.Size(145, 64);
            this.ReversCheck.TabIndex = 4;
            this.ReversCheck.Text = "\r\nRevers text   \r\n \r\n";
            this.ReversCheck.UseVisualStyleBackColor = true;
            // 
            // InsertCheck
            // 
            this.InsertCheck.AutoSize = true;
            this.InsertCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertCheck.ForeColor = System.Drawing.Color.White;
            this.InsertCheck.Location = new System.Drawing.Point(12, 113);
            this.InsertCheck.Name = "InsertCheck";
            this.InsertCheck.Size = new System.Drawing.Size(147, 84);
            this.InsertCheck.TabIndex = 3;
            this.InsertCheck.Text = "Insert space  \r\nbefore each \r\ncharacter of  \r\ntext\r\n";
            this.InsertCheck.UseVisualStyleBackColor = true;
            // 
            // OriginalText
            // 
            this.OriginalText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OriginalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OriginalText.Location = new System.Drawing.Point(190, 91);
            this.OriginalText.Multiline = true;
            this.OriginalText.Name = "OriginalText";
            this.OriginalText.Size = new System.Drawing.Size(525, 130);
            this.OriginalText.TabIndex = 1;
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginLabel.ForeColor = System.Drawing.Color.White;
            this.OriginLabel.Location = new System.Drawing.Point(360, 68);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(159, 20);
            this.OriginLabel.TabIndex = 5;
            this.OriginLabel.Text = "Enter original text";
            // 
            // TansformedText
            // 
            this.TansformedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TansformedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TansformedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TansformedText.Location = new System.Drawing.Point(190, 263);
            this.TansformedText.Multiline = true;
            this.TansformedText.Name = "TansformedText";
            this.TansformedText.ReadOnly = true;
            this.TansformedText.Size = new System.Drawing.Size(525, 130);
            this.TansformedText.TabIndex = 6;
            // 
            // TransformLabel
            // 
            this.TransformLabel.AutoSize = true;
            this.TransformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransformLabel.ForeColor = System.Drawing.Color.White;
            this.TransformLabel.Location = new System.Drawing.Point(360, 240);
            this.TransformLabel.Name = "TransformLabel";
            this.TransformLabel.Size = new System.Drawing.Size(152, 20);
            this.TransformLabel.TabIndex = 5;
            this.TransformLabel.Text = "Transformed text";
            // 
            // TransformerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 540);
            this.Controls.Add(this.TransformLabel);
            this.Controls.Add(this.OriginLabel);
            this.Controls.Add(this.TansformedText);
            this.Controls.Add(this.OriginalText);
            this.Controls.Add(this.InsertCheck);
            this.Controls.Add(this.ReversCheck);
            this.Controls.Add(this.UpperCheck);
            this.Controls.Add(this.TransformerButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TransformerForm";
            this.Text = "TextTransformer";
            this.Load += new System.EventHandler(this.TransForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TransformerButton;
        private System.Windows.Forms.CheckBox UpperCheck;
        private System.Windows.Forms.CheckBox ReversCheck;
        private System.Windows.Forms.CheckBox InsertCheck;
        private System.Windows.Forms.TextBox OriginalText;
        private System.Windows.Forms.Label OriginLabel;
        private System.Windows.Forms.TextBox TansformedText;
        private System.Windows.Forms.Label TransformLabel;
    }
}

