namespace eKino_UI.Projekcija
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
            this.dodajKorisnikaButton = new System.Windows.Forms.Button();
            this.popisKorisnikaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajKorisnikaButton
            // 
            this.dodajKorisnikaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajKorisnikaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajKorisnikaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajKorisnikaButton.Image = global::eKino_UI.Properties.Resources.add_icon;
            this.dodajKorisnikaButton.Location = new System.Drawing.Point(523, 163);
            this.dodajKorisnikaButton.Name = "dodajKorisnikaButton";
            this.dodajKorisnikaButton.Size = new System.Drawing.Size(300, 227);
            this.dodajKorisnikaButton.TabIndex = 3;
            this.dodajKorisnikaButton.Text = "   Dodaj projekciju";
            this.dodajKorisnikaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajKorisnikaButton.UseVisualStyleBackColor = true;
            this.dodajKorisnikaButton.Click += new System.EventHandler(this.dodajKorisnikaButton_Click);
            // 
            // popisKorisnikaButton
            // 
            this.popisKorisnikaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popisKorisnikaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popisKorisnikaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisKorisnikaButton.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.popisKorisnikaButton.Location = new System.Drawing.Point(159, 163);
            this.popisKorisnikaButton.Name = "popisKorisnikaButton";
            this.popisKorisnikaButton.Size = new System.Drawing.Size(300, 227);
            this.popisKorisnikaButton.TabIndex = 2;
            this.popisKorisnikaButton.Text = "   Popis projekcija";
            this.popisKorisnikaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.popisKorisnikaButton.UseVisualStyleBackColor = true;
            this.popisKorisnikaButton.Click += new System.EventHandler(this.popisKorisnikaButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dodajKorisnikaButton);
            this.Controls.Add(this.popisKorisnikaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projekcije";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajKorisnikaButton;
        private System.Windows.Forms.Button popisKorisnikaButton;
    }
}