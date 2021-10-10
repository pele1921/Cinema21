namespace eKino_UI.Film
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
            this.dodajFilmButton = new System.Windows.Forms.Button();
            this.popisFilmovaButton = new System.Windows.Forms.Button();
            this.dodajZanrButton = new System.Windows.Forms.Button();
            this.popisZanrovaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajFilmButton
            // 
            this.dodajFilmButton.AllowDrop = true;
            this.dodajFilmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajFilmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajFilmButton.Image = global::eKino_UI.Properties.Resources.add_icon;
            this.dodajFilmButton.Location = new System.Drawing.Point(694, 12);
            this.dodajFilmButton.Name = "dodajFilmButton";
            this.dodajFilmButton.Size = new System.Drawing.Size(300, 163);
            this.dodajFilmButton.TabIndex = 3;
            this.dodajFilmButton.Text = "   Dodaj film";
            this.dodajFilmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajFilmButton.UseVisualStyleBackColor = true;
            this.dodajFilmButton.Click += new System.EventHandler(this.dodajFilmButton_Click);
            // 
            // popisFilmovaButton
            // 
            this.popisFilmovaButton.AllowDrop = true;
            this.popisFilmovaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popisFilmovaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popisFilmovaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisFilmovaButton.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.popisFilmovaButton.Location = new System.Drawing.Point(7, 12);
            this.popisFilmovaButton.Name = "popisFilmovaButton";
            this.popisFilmovaButton.Size = new System.Drawing.Size(300, 163);
            this.popisFilmovaButton.TabIndex = 2;
            this.popisFilmovaButton.Text = "   Popis filmova";
            this.popisFilmovaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.popisFilmovaButton.UseVisualStyleBackColor = true;
            this.popisFilmovaButton.Click += new System.EventHandler(this.popisFilmovaButton_Click);
            // 
            // dodajZanrButton
            // 
            this.dodajZanrButton.AllowDrop = true;
            this.dodajZanrButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajZanrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajZanrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajZanrButton.Image = global::eKino_UI.Properties.Resources.add_icon;
            this.dodajZanrButton.Location = new System.Drawing.Point(683, 425);
            this.dodajZanrButton.Name = "dodajZanrButton";
            this.dodajZanrButton.Size = new System.Drawing.Size(300, 163);
            this.dodajZanrButton.TabIndex = 5;
            this.dodajZanrButton.Text = "   Dodaj žanr";
            this.dodajZanrButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajZanrButton.UseVisualStyleBackColor = true;
            this.dodajZanrButton.Click += new System.EventHandler(this.dodajZanrButton_Click);
            // 
            // popisZanrovaButton
            // 
            this.popisZanrovaButton.AllowDrop = true;
            this.popisZanrovaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popisZanrovaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popisZanrovaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisZanrovaButton.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.popisZanrovaButton.Location = new System.Drawing.Point(7, 425);
            this.popisZanrovaButton.Name = "popisZanrovaButton";
            this.popisZanrovaButton.Size = new System.Drawing.Size(300, 163);
            this.popisZanrovaButton.TabIndex = 4;
            this.popisZanrovaButton.Text = "   Popis žanrova";
            this.popisZanrovaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.popisZanrovaButton.UseVisualStyleBackColor = true;
            this.popisZanrovaButton.Click += new System.EventHandler(this.popisZanrovaButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dodajZanrButton);
            this.Controls.Add(this.popisZanrovaButton);
            this.Controls.Add(this.dodajFilmButton);
            this.Controls.Add(this.popisFilmovaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filmovi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajFilmButton;
        private System.Windows.Forms.Button popisFilmovaButton;
        private System.Windows.Forms.Button dodajZanrButton;
        private System.Windows.Forms.Button popisZanrovaButton;
    }
}