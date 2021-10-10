namespace eKino_UI.Usluga
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
            this.dodajUsluguButton = new System.Windows.Forms.Button();
            this.popisUsluguButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajUsluguButton
            // 
            this.dodajUsluguButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajUsluguButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajUsluguButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajUsluguButton.Image = global::eKino_UI.Properties.Resources.add_icon;
            this.dodajUsluguButton.Location = new System.Drawing.Point(392, 132);
            this.dodajUsluguButton.Margin = new System.Windows.Forms.Padding(2);
            this.dodajUsluguButton.Name = "dodajUsluguButton";
            this.dodajUsluguButton.Size = new System.Drawing.Size(225, 184);
            this.dodajUsluguButton.TabIndex = 3;
            this.dodajUsluguButton.Text = "   Dodaj uslugu";
            this.dodajUsluguButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajUsluguButton.UseVisualStyleBackColor = true;
            this.dodajUsluguButton.Click += new System.EventHandler(this.dodajUsluguButton_Click);
            // 
            // popisUsluguButton
            // 
            this.popisUsluguButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.popisUsluguButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popisUsluguButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisUsluguButton.Image = global::eKino_UI.Properties.Resources.read_icon;
            this.popisUsluguButton.Location = new System.Drawing.Point(119, 132);
            this.popisUsluguButton.Margin = new System.Windows.Forms.Padding(2);
            this.popisUsluguButton.Name = "popisUsluguButton";
            this.popisUsluguButton.Size = new System.Drawing.Size(225, 184);
            this.popisUsluguButton.TabIndex = 2;
            this.popisUsluguButton.Text = "   Popis usluga";
            this.popisUsluguButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.popisUsluguButton.UseVisualStyleBackColor = true;
            this.popisUsluguButton.Click += new System.EventHandler(this.popisUslugaButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.dodajUsluguButton);
            this.Controls.Add(this.popisUsluguButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projekcije";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajUsluguButton;
        private System.Windows.Forms.Button popisUsluguButton;
    }
}