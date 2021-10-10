namespace eKino_UI.Dvorana
{
    partial class MainForm
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
            this.popisDvoranaButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisDvoranaButton
            // 
            this.popisDvoranaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popisDvoranaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popisDvoranaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisDvoranaButton.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.popisDvoranaButton.Location = new System.Drawing.Point(159, 164);
            this.popisDvoranaButton.Margin = new System.Windows.Forms.Padding(4);
            this.popisDvoranaButton.Name = "popisDvoranaButton";
            this.popisDvoranaButton.Size = new System.Drawing.Size(300, 225);
            this.popisDvoranaButton.TabIndex = 0;
            this.popisDvoranaButton.Text = "  Popis Dvorana";
            this.popisDvoranaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.popisDvoranaButton.UseVisualStyleBackColor = true;
            this.popisDvoranaButton.Click += new System.EventHandler(this.popisDvoranaButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajButton.Image = global::eKino_UI.Properties.Resources.add_icon;
            this.dodajButton.Location = new System.Drawing.Point(523, 164);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(4);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(300, 225);
            this.dodajButton.TabIndex = 1;
            this.dodajButton.Text = "   Dodaj Dvoranu";
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.popisDvoranaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dvorane";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button popisDvoranaButton;
        private System.Windows.Forms.Button dodajButton;
    }
}