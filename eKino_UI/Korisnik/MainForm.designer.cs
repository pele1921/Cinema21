namespace eKino_UI.Korisnik
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
            this.popisKorisnikaButton = new System.Windows.Forms.Button();
            this.dodajKorisnikaButton = new System.Windows.Forms.Button();
            this.popisUlogaButton = new System.Windows.Forms.Button();
            this.dodajUloguButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisKorisnikaButton
            // 
            this.popisKorisnikaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popisKorisnikaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popisKorisnikaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisKorisnikaButton.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.popisKorisnikaButton.Location = new System.Drawing.Point(11, 11);
            this.popisKorisnikaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.popisKorisnikaButton.Name = "popisKorisnikaButton";
            this.popisKorisnikaButton.Size = new System.Drawing.Size(225, 132);
            this.popisKorisnikaButton.TabIndex = 0;
            this.popisKorisnikaButton.Text = "   Popis korisnika";
            this.popisKorisnikaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.popisKorisnikaButton.UseVisualStyleBackColor = true;
            this.popisKorisnikaButton.Click += new System.EventHandler(this.popisKorisnikaButton_Click);
            // 
            // dodajKorisnikaButton
            // 
            this.dodajKorisnikaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajKorisnikaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajKorisnikaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajKorisnikaButton.Image = global::eKino_UI.Properties.Resources.add_icon;
            this.dodajKorisnikaButton.Location = new System.Drawing.Point(514, 11);
            this.dodajKorisnikaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dodajKorisnikaButton.Name = "dodajKorisnikaButton";
            this.dodajKorisnikaButton.Size = new System.Drawing.Size(225, 132);
            this.dodajKorisnikaButton.TabIndex = 1;
            this.dodajKorisnikaButton.Text = "   Dodaj korisnika";
            this.dodajKorisnikaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajKorisnikaButton.UseVisualStyleBackColor = true;
            this.dodajKorisnikaButton.Click += new System.EventHandler(this.dodajKorisnikaButton_Click);
            // 
            // popisUlogaButton
            // 
            this.popisUlogaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popisUlogaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.popisUlogaButton.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.popisUlogaButton.Location = new System.Drawing.Point(11, 344);
            this.popisUlogaButton.Name = "popisUlogaButton";
            this.popisUlogaButton.Size = new System.Drawing.Size(225, 132);
            this.popisUlogaButton.TabIndex = 2;
            this.popisUlogaButton.Text = "   Popis uloga";
            this.popisUlogaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.popisUlogaButton.UseVisualStyleBackColor = true;
            this.popisUlogaButton.Click += new System.EventHandler(this.popisUlogaButton_Click);
            // 
            // dodajUloguButton
            // 
            this.dodajUloguButton.BackColor = System.Drawing.SystemColors.Window;
            this.dodajUloguButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajUloguButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dodajUloguButton.Image = global::eKino_UI.Properties.Resources.add_icon;
            this.dodajUloguButton.Location = new System.Drawing.Point(514, 344);
            this.dodajUloguButton.Name = "dodajUloguButton";
            this.dodajUloguButton.Size = new System.Drawing.Size(225, 132);
            this.dodajUloguButton.TabIndex = 3;
            this.dodajUloguButton.Text = "   Dodaj ulogu";
            this.dodajUloguButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajUloguButton.UseVisualStyleBackColor = false;
            this.dodajUloguButton.Click += new System.EventHandler(this.dodajUloguButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.dodajUloguButton);
            this.Controls.Add(this.popisUlogaButton);
            this.Controls.Add(this.dodajKorisnikaButton);
            this.Controls.Add(this.popisKorisnikaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korisnici";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button popisKorisnikaButton;
        private System.Windows.Forms.Button dodajKorisnikaButton;
        private System.Windows.Forms.Button popisUlogaButton;
        private System.Windows.Forms.Button dodajUloguButton;
    }
}